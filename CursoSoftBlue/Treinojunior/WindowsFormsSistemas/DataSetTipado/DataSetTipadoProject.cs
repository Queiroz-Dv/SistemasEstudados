using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Treinojunior.WindowsFormsSistemas.DataSetTipado.Forms.CRUDs;

namespace Treinojunior.WindowsFormsSistemas.DataSetTipado
{
    public partial class DataSetTipadoProject : Form
    {
        public DataSetTipadoProject()
        {
            InitializeComponent();
        }

        private void btnEstados_Click(object sender, EventArgs e)
        {
            new FormEstados().ShowDialog();
            
        }

        private void btnCidades_Click(object sender, EventArgs e)
        {
            new FormCidades().ShowDialog();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            new FormFornecedores().ShowDialog();
        }
    }
}
