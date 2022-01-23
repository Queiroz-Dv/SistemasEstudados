using ProjectController;
using System;
using System.Windows.Forms;
using Treinojunior.ProjectModel;

namespace ViewProject
{
    public partial class ViewNotaEntrada : Form
    {
        private NotaEntradaController controller;
        private FornecedorController fornecedorController;
        private ProdutoController produtoController;

        private InputNota notaAtual;
        public ViewNotaEntrada(
            NotaEntradaController controller,
            FornecedorController fornecedorController,
            ProdutoController produtoController)
        {
            InitializeComponent();
            this.controller = controller;
            this.fornecedorController = fornecedorController;
            this.produtoController = produtoController;
            InicilizarComboBoxs();
        }

        private void InicilizarComboBoxs()
        {
            cmbFornecedor.Items.Clear();
            foreach (Fornecedor fornecedor in this.fornecedorController.GetAll())
            {
                cmbFornecedor.Items.Add(fornecedor);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuAdm menuAdm = new MenuAdm();
            this.Hide();
            menuAdm.ShowDialog();
            this.Visible = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        private void ClearControlsNota()
        {
            dgvNota.ClearSelection();
            txtID.Text = string.Empty;
            cmbFornecedor.SelectedIndex = -1;
            txtNumero.Text = string.Empty;
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            cmbFornecedor.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var notaEntrada = new InputNota()
            {
                ID = (txtID.Text == string.Empty ? Guid.NewGuid() :
                new Guid(txtID.Text)),
                DataEmissao = dtpEmissao.Value,
                DataEntrada = dtpEntrada.Value,
                FornecedorNota = (Fornecedor)cmbFornecedor.SelectedItem,
                Numero = txtNumero.Text
            };

            notaEntrada = (txtID.Text == string.Empty ? this.controller.Insert
                (notaEntrada) : this.controller.Update(notaEntrada));
            dgvNota.DataSource = null;
            dgvNota.DataSource = this.controller.GetAll();
            ClearControlsNota();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Selecione a nota a ser removida no grid");
            }
            else
            {
                this.controller.Remove(new InputNota()
                {
                    ID = new Guid(txtID.Text)
                });
                dgvNota.DataSource = null;
                dgvNota.DataSource = this.controller.GetAll();
                ClearControlsNota();
            }
        }

        private void dgvNota_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.notaAtual = this.controller.
                GetNotaByID((Guid)dgvNota.CurrentRow.Cells[0].Value);
                txtID.Text = notaAtual.ID.ToString();
                txtNumero.Text = notaAtual.Numero;
                cmbFornecedor.SelectedItem = notaAtual.FornecedorNota;
                dtpEmissao.Value = notaAtual.DataEmissao;
                dtpEntrada.Value = notaAtual.DataEntrada;
                UpdateGrid();
            }
            catch (Exception ex)
            {
                this.notaAtual = new InputNota();
            }
        }

        private void UpdateGrid()
        {
            dgvNota.DataSource = null;
            if (this.notaAtual.Produtos.Count > 0)
            {
                dgvNota.DataSource = this.notaAtual.Produtos;
            }
        }
    }
}
