using ADO_Base;
using ProjectController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            new ViewNotaEntrada(entradaController,
                                fornecedorController, 
                                produtoController).ShowDialog();
        }
    }
}
