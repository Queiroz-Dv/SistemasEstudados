using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinojunior.ProjectModel;

namespace ADO_Base
{
    public class DAL_Produto
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        private void Insert(Produto produto)
        {
            var command = new SqlCommand("insert into PRODUTO(ID, " +
                                         "Descricao, " +
                                         "PrecoCusto, " +
                                         "PrecoVenda, " +
                                         "Estoque)" +
            "values(@ID, @Descricao, @PrecoCusto, @PrecoVenda, @Estoque)", connection);

            command.Parameters.AddWithValue("@ID", produto.ID);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.Parameters.AddWithValue("@PrecoCusto", produto.PrecoCusto);
            command.Parameters.AddWithValue("@PrecoVenda", produto.PrecoVenda);
            command.Parameters.AddWithValue("@Estoque", produto.Estoque);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IList<Produto> GetAllProdutos()
        {
            IList<Produto> produtos = new List<Produto>();
            var adapter = new SqlDataAdapter("select ID, " +
                                             "Descricao, " +
                                             "PrecoCusto," +
                                             "PrecoVenda, " +
                                             "Estoque from PRODUTO", connection);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);
            connection.Close();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                produtos.Add(
                    new Produto()
                    {
                        ID = Convert.ToInt64(row["ID"]),
                        Descricao = (string)row["Descricao"],
                        PrecoCusto = (double)row["PrecoCusto"],
                        PrecoVenda = (double)row["PrecoVenda"],
                        Estoque = (double)row["Estoque"]
                    });
            }
            return produtos;
        }

        private void Update(Produto produto)
        {
            var command = new SqlCommand("update PRODUTO set ID=@ID, " +
                                         "Descricao=@Descricao, " +
                                         "PrecoCusto=@PrecoCusto," +
                                         "PrecoVenda=@PrecoVenda," +
                                         "Estoque=@Estoque where (ID=@ID)", connection);
            command.Parameters.AddWithValue("@ID", produto.ID);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.Parameters.AddWithValue("@PrecoCusto", produto.PrecoCusto);
            command.Parameters.AddWithValue("@PrecoVenda", produto.PrecoVenda);
            command.Parameters.AddWithValue("@Estoque", produto.Estoque);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            DeleteAllProdutos(produto.ID);
            Insert(produto);
        }

        public void RemoveById(long? ID)
        {
            var command = new SqlCommand("delete from " +
                "PRODUTO where (ID=@ID)", connection);
            command.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void DeleteAllProdutos(long? ID)
        {
            var command = new SqlCommand("delete from PRODUTO where (ID=@ID", connection);
            command.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Save(Produto produto)
        {
            if (produto.ID == null)
            {
                this.Insert(produto);
            }
            else
            {
                this.Update(produto);
            }
        }
    }
}
