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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSEstadosECidades.Grupos' table. You can move, or remove it, as needed.
            this.gruposTableAdapter.FillByNome(this.dSEstadosECidades.Grupos);
            // TODO: This line of code loads data into the 'dSEstadosECidades.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.dSEstadosECidades.Produtos);

        }
    }
}
