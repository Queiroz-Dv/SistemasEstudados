using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Treinojunior.ProjectModel;

namespace ADO_Base
{
    public class DAL_InputNota
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        private void Insert(InputNota inputNota)
        {
            var command = new SqlCommand("insert into " +
                "NOTASDEENTRADA(IdFornecedor, Numero, " +
                "DataEmissao, DataEntrada) values(" +
                "@IdFornecedor, @Numero, @DataEmissao, " +
                "@DataEntrada)", connection);
            command.Parameters.AddWithValue("@IdFornecedor", inputNota.FornecedorNota.ID);
            command.Parameters.AddWithValue("@Numero", inputNota.Numero);
            command.Parameters.AddWithValue("@DataEmissao", inputNota.DataEmissao);
            command.Parameters.AddWithValue("@DataEntrada", inputNota.DataEntrada);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IList<InputNota> GetAllAsDataTable()
        {
            IList<InputNota> inputNotas = new List<InputNota>();
            var adapter = new SqlDataAdapter("select id, numero, fornecedornota, cnpj, dataemissao, dataentrada, produtos from NOTASDEENTRADA", connection);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);
            connection.Close();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                inputNotas.Add(
                    new InputNota()
                    {
                        ID = Convert.ToInt64(row["id"]),
                        Numero = (string)row["numero"],
                        FornecedorNota = (Fornecedor)row["fornecedornota"],
                        CNPJ = (string)row["cnpj"],
                        DataEmissao = (DateTime)row["dataemissao"],
                        DataEntrada = (DateTime)row["dataentrada"],
                        Produtos = ((IList<InputProdutoNota>)row["produtos"])
                    });
            }
            return inputNotas;
        }

        private void Update(InputNota inputNota)
        {
            var command = new SqlCommand("update NOTASDEENTRADA " +
                "set IdFornecedor=@IdFornecedor, Numero=@Numero, " +
                "DataEmissao=@DataEmissao, DataEntrada=" +
                "@DataEntrada where (Id=@Id)", connection);
            command.Parameters.AddWithValue("@IdFornecedor", inputNota.FornecedorNota.ID);
            command.Parameters.AddWithValue("@Numero", inputNota.Numero);
            command.Parameters.AddWithValue("@DataEmissao", inputNota.DataEmissao);
            command.Parameters.AddWithValue("@DataEntrada", inputNota.DataEntrada);
            command.Parameters.AddWithValue("@Id", inputNota.ID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            DeleteAllProdutosFromNotaEntrada(inputNota.ID);
            InsertProdutosNotaDeEntrada(inputNota.ID,
                inputNota.Produtos);
        }

        public void RemoveById(long? ID)
        {
            var command = new SqlCommand("delete from " +
                "NOTASDEENTRADA where (Id=@Id)", connection);
            command.Parameters.AddWithValue("@Id", ID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void InsertProdutosNotaDeEntrada(long? ID, IList<InputProdutoNota> produtos)
        {
            var command = new SqlCommand("insert into " +
                "PRODUTOSNOTASDEENTRADA(IdNotaDeEntrada, " +
                "IdProduto, PrecoCustoCompra, QuantidadeCompra) " +
                "values(@IdNotaDeEntrada, @IdProduto, " +
                "@PrecoCustoCompra, @QuantidadeCompra",
                connection);
            connection.Open();
            foreach (var produto in produtos)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@IdNotaDeEntrada", ID);
                command.Parameters.AddWithValue("@IdProduto", produto.ID);
                command.Parameters.AddWithValue("@PrecoCustoCompra", produto.PrecoCustoCompra);
                command.Parameters.AddWithValue("@QuantidadeCompra", produto.QuantidadeComprada);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void DeleteAllProdutosFromNotaEntrada(long? ID)
        {
            var command = new SqlCommand("delete from " +
                "NOTASDEENTRADA where (Id=@Id)", connection);
            command.Parameters.AddWithValue("@Id", ID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Save(InputNota inputNota)
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
