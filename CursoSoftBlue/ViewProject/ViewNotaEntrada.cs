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
    }
}
