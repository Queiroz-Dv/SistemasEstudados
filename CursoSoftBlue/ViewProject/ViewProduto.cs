using ProjectController;
using System.Windows.Forms;
using Treinojunior.ProjectModel;

namespace ViewProject
{
    public partial class ViewProduto : Form
    {
        private NotaEntradaController controller;
        private FornecedorController fornecedorController;
        private ProdutoController produtoController;

        public ViewProduto(NotaEntradaController controller,
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
            cmbProduto.Items.Clear();
            foreach (Produto produto in this.produtoController.GetAll())
            {
                cmbProduto.Items.Add(produto);
            }
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            MenuAdm menuAdm = new MenuAdm();
            this.Hide();
            menuAdm.ShowDialog();
            this.Visible = true;
        }
    }
}
