using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Treinojunior.ProjectModel;

namespace ADO_Base
{
    public class DAL_NotaEntrada
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        private void Insert(NotaEntrada inputNota)
        {
            var command = new SqlCommand("insert into " +
                "NOTAENTRADA(IDFornecedor, Numero, " +
                "DataEmissao, DataEntrada) values(" +
                "@IDFornecedor, @Numero, @DataEmissao, " +
                "@DataEntrada)", connection);
            command.Parameters.AddWithValue("@IDFornecedor", inputNota.FornecedorNota.ID);
            command.Parameters.AddWithValue("@Numero", inputNota.Numero);
            command.Parameters.AddWithValue("@DataEmissao", inputNota.DataEmissao);
            command.Parameters.AddWithValue("@DataEntrada", inputNota.DataEntrada);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void InsertProduto(NotaEntrada notaEntrada, ProdutoNotaEntrada produto)
        {
            notaEntrada.Produtos.Add(produto);
            var command = new SqlCommand("insert into PRODUTONOTAENTRADA(" +
                "idnotaentrada, idproduto, precocompra, quantidadecompra)" +
                "values(@idnotaentrada, @idproduto, @precocompra, @quantidadecompra", this.connection);
            command.Parameters.AddWithValue("@idnotaentrada", notaEntrada.ID);
            command.Parameters.AddWithValue("@idproduto", produto.ID);
            command.Parameters.AddWithValue("@precocompra", produto.PrecoCustoCompra);
            command.Parameters.AddWithValue("@quantidadecompra", produto.QuantidadeComprada);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void UpdateProduto(ProdutoNotaEntrada produto)
        {
            var command = new SqlCommand("update PRODUTONOTAENTRADA set" +
                "(idproduto=@idproduto, precocompra=@precocompra, quantidadecompra=@quantidadecompra)" +
                "where (ID=@ID)", this.connection);
            command.Parameters.AddWithValue("@idproduto", produto.ID);
            command.Parameters.AddWithValue("@precocompra", produto.PrecoCustoCompra);
            command.Parameters.AddWithValue("@quantidadecompra", produto.QuantidadeComprada);
            command.Parameters.AddWithValue("@ID", produto.ID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public IList<NotaEntrada> GetAllAsDataTable()
        {
            IList<NotaEntrada> inputNotas = new List<NotaEntrada>();
            var adapter = new SqlDataAdapter("select id, numero, fornecedornota, cnpj, dataemissao, dataentrada, produtos from NOTAENTRADA", connection);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);
            connection.Close();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                inputNotas.Add(
                    new NotaEntrada()
                    {
                        ID = Convert.ToInt64(row["id"]),
                        Numero = (string)row["numero"],
                        FornecedorNota = (Fornecedor)row["fornecedornota"],
                        CNPJ = (string)row["cnpj"],
                        DataEmissao = (DateTime)row["dataemissao"],
                        DataEntrada = (DateTime)row["dataentrada"],
                        Produtos = ((IList<ProdutoNotaEntrada>)row["produtos"])
                    });
            }
            return inputNotas;
        }

        private void Update(NotaEntrada inputNota)
        {
            var command = new SqlCommand("update NOTAENTRADA " +
                "set IDFornecedor=@IDFornecedor, Numero=@Numero, " +
                "DataEmissao=@DataEmissao, DataEntrada=" +
                "@DataEntrada where (Id=@Id)", connection);
            command.Parameters.AddWithValue("@IDFornecedor", inputNota.FornecedorNota.ID);
            command.Parameters.AddWithValue("@Numero", inputNota.Numero);
            command.Parameters.AddWithValue("@DataEmissao", inputNota.DataEmissao);
            command.Parameters.AddWithValue("@DataEntrada", inputNota.DataEntrada);
            command.Parameters.AddWithValue("@ID", inputNota.ID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            DeleteAllProdutosFromNotaEntrada(inputNota.ID);
            InsertProdutosNotaDeEntrada(inputNota.ID,
                inputNota.Produtos);
        }

        public NotaEntrada GetById(long? ID)
        {
            NotaEntrada notaEntrada = new NotaEntrada();
            DAL_Fornecedor dalFornecedor = new DAL_Fornecedor();
            long idFornecedorNota = -1;
            var command = new SqlCommand("select id, idfornecedor, numero, dataemissao, dataentrada from NOTAENTRADA where ID=@ID", connection);
            command.Parameters.AddWithValue("@ID", ID);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    notaEntrada.ID = reader.GetInt64(0);
                    idFornecedorNota = reader.GetInt32(1);
                    notaEntrada.Numero = reader.GetString(2);
                    notaEntrada.DataEmissao = reader.GetDateTime(3);
                    notaEntrada.DataEntrada = reader.GetDateTime(4);
                }
            }
            connection.Close();
            if (idFornecedorNota > 0)
            {
                notaEntrada.FornecedorNota = dalFornecedor.GetById(idFornecedorNota);
            }
            return notaEntrada;
        }

        public void RemoveById(long? ID)
        {
            var command = new SqlCommand("delete from " +
                "NOTAENTRADA where (ID=@ID)", connection);
            command.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void InsertProdutosNotaDeEntrada(long? ID, IList<ProdutoNotaEntrada> produtos)
        {
            var command = new SqlCommand("insert into " +
                "PRODUTONOTAENTRADA(IDNotaEntrada, " +
                "IDProduto, PrecoCompra, QuantidadeCompra) " +
                "values(@IDNotaEntrada, @IDProduto, " +
                "@PrecoCompra, @QuantidadeCompra",
                connection);
            connection.Open();
            foreach (var produto in produtos)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@IDNotaEntrada", ID);
                command.Parameters.AddWithValue("@IDProduto", produto.ID);
                command.Parameters.AddWithValue("@PrecoCompra", produto.PrecoCustoCompra);
                command.Parameters.AddWithValue("@QuantidadeCompra", produto.QuantidadeComprada);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void DeleteAllProdutosFromNotaEntrada(long? ID)
        {
            var command = new SqlCommand("delete from " +
                "NOTAENTRADA where (ID=@ID)", connection);
            command.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Save(NotaEntrada inputNota)
        {
            if (inputNota.ID == null)
            {
                this.Insert(inputNota);
            }
            else
            {
                this.Update(inputNota);
            }
        }
    }
}
