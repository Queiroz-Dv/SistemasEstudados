using System;
using System.Windows.Forms;
using System.Data;
using Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets;

namespace Treinojunior.WindowsFormsSistemas.DataSetTipado.Forms.CRUDs
{
    public partial class FormNotaDeSaida: Form
    {
        public FormNotaDeSaida()
        {
            InitializeComponent();
        }

        private void notasDeVendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notasDeVendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void FormNotaDeSaida_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSEstadosECidades.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dSEstadosECidades.Clientes);
            // TODO: This line of code loads data into the 'dSEstadosECidades.ProdutosNotaDeSaida' table. You can move, or remove it, as needed.
            this.produtosNotaDeSaidaTableAdapter.Fill(this.dSEstadosECidades.ProdutosNotaDeSaida);
            // TODO: This line of code loads data into the 'dSEstadosECidades.NotasDeVenda' table. You can move, or remove it, as needed.
            this.notasDeVendaTableAdapter.Fill(this.dSEstadosECidades.NotasDeVenda);

        }

        private void SetBindingNavigatorButtonState()
        {
            bool fecharNota = false;
            if(notasDeVendaBindingSource.Current != null)
            {
                DataRowView drv = (DataRowView)
                    notasDeVendaBindingSource.Current;
                DSEstadosECidades.NotasDeVendaRow nvRow =
                    (DSEstadosECidades.NotasDeVendaRow)drv.Row;
                fecharNota = nvRow.notafechada.Equals("N");
            }
            
        }
    }
}
