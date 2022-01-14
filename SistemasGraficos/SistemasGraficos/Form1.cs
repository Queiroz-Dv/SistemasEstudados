using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasGraficos
{
    public partial class frmGastoRestaurante : Form
    {
        public frmGastoRestaurante()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtTotalDaConta.Text = (Convert.ToDouble(
                txtDespesa.Text) * 1.10).ToString("N");
        }
    }
}
