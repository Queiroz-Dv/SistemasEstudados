using ADO_Base;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Treinojunior.ProjectModel;

namespace ViewProject
{
    public partial class ViewProduto : Form
    {
        private DAL_Produto dal = new DAL_Produto();
        private Produto produtoAtual;

        public ViewProduto()
        {
            InitializeComponent();
            InicilizarComboBoxs();
            dal.GetAllProdutos();

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
            txtID.Text = string.Empty;
            cmbProduto.SelectedIndex = -1;
            txtCusto.Text = string.Empty;
            txtEstoque.Text = string.Empty;
            dgvProduto.ClearSelection();
            this.produtoAtual = null;
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

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            this.produtoAtual = GetProdutoById(Convert.
               ToInt64(dgvProduto.Rows[e.RowIndex].Cells[0].
               Value));
            txtID.Text = this.produtoAtual.ID.ToString();
            txtCusto.Text = this.produtoAtual.PrecoCusto.ToString();
            txtPrecoVenda.Text = this.produtoAtual.PrecoVenda.ToString();
            txtEstoque.Text = this.produtoAtual.Estoque.ToString();
        }

        private Produto GetProdutoById(long id)
        {
            Produto produto = new Produto();
            var connection = DBConnection.DB_Connection;
            var command = new SqlCommand("select ID," +
                                         "Descricao," +
                                         "PrecoCusto," +
                                         "PrecoVenda," +
                                         "Estoque from PRODUTO where ID=@ID", connection);
            command.Parameters.AddWithValue("@ID", id);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    produto.ID = reader.GetInt32(0);
                    produto.Descricao = reader.GetString(1);
                    produto.PrecoCusto = reader.GetDouble(2);
                    produto.PrecoVenda = reader.GetDouble(3);
                    produto.Estoque = reader.GetDouble(4);
                }
            }
            connection.Close();
            return produto;
        }
    }
}
