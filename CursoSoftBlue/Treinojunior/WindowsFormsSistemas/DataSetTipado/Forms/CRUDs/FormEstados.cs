using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treinojunior.WindowsFormsSistemas.DataSetTipado.Forms.CRUDs
{
    public partial class FormEstados : Form
    {
        public FormEstados()
        {
            InitializeComponent();
        }

        private void estadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void FormEstados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSEstadosECidades.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.dSEstadosECidades.Estados);

        }
    }
}
