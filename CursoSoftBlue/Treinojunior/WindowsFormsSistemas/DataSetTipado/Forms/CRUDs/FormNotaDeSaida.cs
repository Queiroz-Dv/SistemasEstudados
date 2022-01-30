using System;
using System.Windows.Forms;
using System.Data;
using Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets;

namespace Treinojunior.WindowsFormsSistemas.DataSetTipado.Forms.CRUDs
{
    public partial class FormNotaDeSaida : Form
    {
        private bool adding, editing;
        public FormNotaDeSaida()
        {
            InitializeComponent();
            adding = false;
            editing = false;
        }

        private void notasDeVendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notasDeVendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);
            adding = false;
            editing = false;
            SetBindingNavigatorButtonState();
        }

        private void FormNotaDeSaida_Load(object sender, EventArgs e)
        {
            this.produtosNotaDeSaidaTableAdapter.Fill(this.dSEstadosECidades.ProdutosNotaDeSaida);
            this.clientesTableAdapter.Fill(this.dSEstadosECidades.Clientes);
            this.notasDeVendaTableAdapter.Fill(this.dSEstadosECidades.NotasDeVenda);
            this.produtosTableAdapter.FillByDescricao(this.dSEstadosECidades.Produtos);
            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).DataSource = this.dSEstadosECidades.Produtos;
            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).DisplayMember = this.dSEstadosECidades.Produtos.descricaoColumn.ColumnName;
            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).ValueMember = this.dSEstadosECidades.Produtos.idprodutoColumn.ColumnName;

            if (notasDeVendaBindingSource.Current == null)
            {
                SetBindingNavigatorButtonState();
            }
        }

        private void SetBindingNavigatorButtonState()
        {
            bool fecharNota = false;
            if (notasDeVendaBindingSource.Current != null)
            {
                DataRowView drv = (DataRowView)
                    notasDeVendaBindingSource.Current;
                DSEstadosECidades.NotasDeVendaRow nvRow =
                    (DSEstadosECidades.NotasDeVendaRow)drv.Row;
                fecharNota = nvRow.notafechada.Equals("N");
            }
            bnbFirst.Enabled = !adding && !editing;
            bnbPrior.Enabled = bnbFirst.Enabled;
            bindingNavigatorCountItem.Enabled = bnbFirst.Enabled;
            bnbNext.Enabled = bnbFirst.Enabled;
            bnbLast.Enabled = bnbFirst.Enabled;

            bnbAdd.Enabled = bnbFirst.Enabled;
            bnbEdit.Enabled = bnbFirst.Enabled && fecharNota;
            bnbRemove.Enabled = !editing && fecharNota;
            bnbSave.Enabled = adding || editing;
            bnbFecharNota.Enabled = fecharNota && (!adding && !editing);

            gbxDadosDaNota.Enabled = adding || editing;
            gbxProdutosDaNota.Enabled = editing;
        }

        private void bnbAdd_Click(object sender, EventArgs e)
        {
            adding = true;
            SetBindingNavigatorButtonState();
        }

        private void bnbEdit_Click(object sender, EventArgs e)
        {
            editing = true;
            SetBindingNavigatorButtonState();
        }

        private void bnbRemove_Click(object sender, EventArgs e)
        {
            adding = false;
            editing = true;
            SetBindingNavigatorButtonState();
        }

        private void notasDeVendaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)
            notasDeVendaBindingSource.Current;
            if (drv != null)
            {
                DataRow dr = drv.Row;
                if (drv != null && !(dr.RowState == DataRowState.Detached))
                {
                    SetBindingNavigatorButtonState();
                }
            }
        }
    }
}
