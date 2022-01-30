using System;
using System.Windows.Forms;

namespace Treinojunior.WindowsFormsSistemas.DataSetTipado.Forms.CRUDs
{
    public partial class FormNotaDeEntrada : Form
    {
        public FormNotaDeEntrada()
        {
            InitializeComponent();
        }

        private void notadeEntradaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notadeEntradaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void FormNotaDeEntrada_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSEstadosECidades.Fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.dSEstadosECidades.Fornecedores);
            // TODO: This line of code loads data into the 'dSEstadosECidades.ProdutosNotaDeEntrada' table. You can move, or remove it, as needed.
            this.produtosNotaDeEntradaTableAdapter.Fill(this.dSEstadosECidades.ProdutosNotaDeEntrada);
            // TODO: This line of code loads data into the 'dSEstadosECidades.NotadeEntrada' table. You can move, or remove it, as needed.
            this.notadeEntradaTableAdapter.Fill(this.dSEstadosECidades.NotadeEntrada);
            this.produtosTableAdapter.FillByDescricao(this.dSEstadosECidades.Produtos);
            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).DataSource = this.dSEstadosECidades.Produtos;
            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).DisplayMember = this.dSEstadosECidades.Produtos.descricaoColumn.ColumnName;
            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).ValueMember = this.dSEstadosECidades.Produtos.idprodutoColumn.ColumnName;
        }
    }
}
