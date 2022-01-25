﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Treinojunior.ProjectModel;

namespace ADO_Base
{
    public class DAL_Fornecedor
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        public void RemoveById(long? id)
        {
            var command = new SqlCommand("delete from FORNECEDORES where id=@id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Save(Fornecedor fornecedorORM)
        {
            if (fornecedorORM.ID != null)
            {
                this.Update(fornecedorORM);
            }
            else
            {
                this.Insert(fornecedorORM);
            }
        }

        private void Insert(Fornecedor fornecedorORM)
        {
            throw new NotImplementedException();
        }

        private void Update(Fornecedor fornecedorORM)
        {
            var command = new SqlCommand("update FORNECEDORES set cnpj=@cnpj, nome=@nome where id=@id", this.connection);
            command.Parameters.AddWithValue("@cnpj", fornecedorORM.CNPJ);
            command.Parameters.AddWithValue("@nome", fornecedorORM.Nome);
            command.Parameters.AddWithValue("@id", fornecedorORM.ID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IList<Fornecedor> GetAllAsList()
        {
            IList<Fornecedor> fornecedores = new List<Fornecedor>();

            var adapter = new SqlDataAdapter("select id, cnpj, nome, from FORNECEDORES", connection);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);
            connection.Close();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                fornecedores.Add(
                new Fornecedor()
                {
                    ID = Convert.ToInt64(row["id"]),
                    CNPJ = (string)row["cnpj"],
                    Nome = (string)row["nome"]

                });
            }
            return fornecedores;
        }
    }
}
