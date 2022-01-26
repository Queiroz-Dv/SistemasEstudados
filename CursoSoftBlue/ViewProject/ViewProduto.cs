using ADO_Base;
using System;
using System.Windows.Forms;
using Treinojunior.ProjectModel;

namespace ViewProject
{
    public partial class ViewProduto : Form
    {
        private DAL_Produto dal = new DAL_Produto();
        private DAL_Fornecedor DAL_Fornecedor = new DAL_Fornecedor();
        private Produto produtoAtual;

        public ViewProduto()
        {
            InitializeComponent();
            InicilizarComboBoxs();

        }

        private void InicilizarComboBoxs()
        {
            cmbProduto.Items.Clear();
            foreach (Produto produto in this.dal.GetAllProdutos())
            {
                cmbProduto.Items.Add(produto);
            }
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            ClearControlsProduto();
        }

        private void ChangeStatusOfControls(bool newStatus)
        {
            cmbProduto.Enabled = newStatus;
            txtCusto.Enabled = newStatus;
            txtEstoque.Enabled = newStatus;
            btnNovo.Enabled = !newStatus;
            btnSalvar.Enabled = newStatus;
            btnCancelar.Enabled = newStatus;
            btnRemover.Enabled = newStatus;
        }

        private void ClearControlsProduto()
        {
            dgvProduto.ClearSelection();
            txtID.Text = string.Empty;
            cmbProduto.SelectedIndex = -1;
            txtCusto.Text = string.Empty;
            txtEstoque.Text = string.Empty;
            cmbProduto.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dal.Save(new Produto()
            {
                ID = string.IsNullOrEmpty(txtID.Text)?
                (long?)null:Convert.ToInt64(txtID.Text),
                Descricao = txtDescricao.Text,
                PrecoCusto = Convert.ToDouble(txtCusto.Text),
                PrecoVenda = Convert.ToDouble(txtPrecoVenda),
                Estoque = Convert.ToDouble(txtEstoque.Text)
            });
            MessageBox.Show("Manutenção realizada com sucesso");
            ClearControlsProduto();
        }

        private void UpdateProdutosGrid()
        {
            dgvProduto.DataSource = null;
            if (this.dal.GetAllProdutos().Count > 0)
            {
                dgvProduto.DataSource = this.dal.GetAllProdutos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControlsProduto();
            ChangeStatusOfControls(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Selecione o produto a ser removido no grid");
            }
            else
            {
                this.dal.RemoveById(this.produtoAtual.ID);
                ClearControlsProduto();
                MessageBox.Show("Produto removido com sucesso");
            }
        }
    }
}
