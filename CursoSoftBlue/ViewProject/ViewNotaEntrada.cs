using ADO_Base;
using ProjectController;
using System;
using System.Windows.Forms;
using Treinojunior.ProjectModel;

namespace ViewProject
{
    public partial class ViewNotaEntrada : Form
    {
        private NotaEntradaController controller;
        private DAL_InputNota dal = new DAL_InputNota();
        private DAL_Fornecedor DAL_Fornecedor = new DAL_Fornecedor();
        private InputNota notaAtual;

        public ViewNotaEntrada()
        {
            InitializeComponent();
            InicilizarComboBoxs();
            GetAllNotas();
        }

        private void GetAllNotas()
        {
            dgvNota.DataSource = dal.GetAllAsDataTable();
        }

        private void InicilizarComboBoxs()
        {
            cmbFornecedor.Items.Clear();
            foreach (Fornecedor fornecedor in this.DAL_Fornecedor.GetAllAsList())
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
            dal.Save(new InputNota()
            {
                ID = string.IsNullOrEmpty(txtID.Text)?(long?)null:Convert.ToInt64(txtID.Text),
                Numero = txtNumero.Text,
                DataEmissao = dtpEmissao.Value,
                DataEntrada = dtpEntrada.Value,
                FornecedorNota = (Fornecedor)cmbFornecedor.SelectedItem
            });
            MessageBox.Show("Manutenção realizada com sucesso");
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
                this.dal.RemoveById(this.notaAtual.ID);
                ClearControlsNota();
                MessageBox.Show("Nota removida com sucesso");
            }
        }

        private void dgvNota_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.notaAtual = this.controller.GetNotaByID
                ((long?)dgvNota.CurrentRow.Cells[0].Value);
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
