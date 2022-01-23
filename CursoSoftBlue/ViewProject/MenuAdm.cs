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
        public MenuAdm()
        {
            InitializeComponent();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewFornecedor().ShowDialog();
            this.Hide();
        }
    }
}
