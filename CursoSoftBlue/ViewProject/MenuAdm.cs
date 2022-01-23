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
        private FornecedorController fornecedorController = new FornecedorController();
        private ProdutoController produtoController = new ProdutoController();
        public MenuAdm()
        {
            InitializeComponent();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewFornecedor(fornecedorController).ShowDialog();
            this.Visible = true;
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewProduto(produtoController).ShowDialog();
            this.Visible = true;
        }
    }
}
