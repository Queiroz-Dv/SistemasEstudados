using System;
using System.Windows.Forms;

namespace Treinojunior.WindowsFormsSistemas.DataSetTipado.Forms.CRUDs
{
    public partial class FormCidades : Form
    {
        public FormCidades()
        {
            InitializeComponent();
        }

        private void cidadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cidadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);
        }

        private void FormCidades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSEstadosECidades.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.FillByNome(this.dSEstadosECidades.Estados);
            // TODO: This line of code loads data into the 'dSEstadosECidades.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.dSEstadosECidades.Cidades);
        }
    }
}
