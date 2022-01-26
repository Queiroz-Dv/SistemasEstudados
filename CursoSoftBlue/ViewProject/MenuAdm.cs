using ADO_Base;
using System;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class MenuAdm : Form
    {
        private DAL_Fornecedor DAL_fornecedor = new DAL_Fornecedor();
        public MenuAdm()
        {
            InitializeComponent();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewFornecedor(DAL_fornecedor).ShowDialog();   
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new ViewProduto().ShowDialog();
            
        }

        private void entradaDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewNotaEntrada().ShowDialog();
        }
    }
}
