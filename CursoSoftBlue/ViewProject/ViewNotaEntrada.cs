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
    public partial class ViewNotaEntrada : Form
    {
        public ViewNotaEntrada()
        {
            InitializeComponent();
        }

        private void ViewNotaEntrada_Load(object sender, EventArgs e)
        {

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
