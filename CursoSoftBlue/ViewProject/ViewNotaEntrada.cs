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
    }
}
