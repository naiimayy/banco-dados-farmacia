using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositório
{
    public class RemedioRepositorio
    {
        string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65979\Documents\ExercicioFarmacia.mdf;Integrated Security=True;Connect Timeout=30";

        public List<Remedio> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM remedios";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<Remedio> remedios = new List<Remedio>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Remedio remedio = new Remedio();
                remedio.Id = Convert.ToInt32(linha["id"]);
                remedio.Generico = Convert.ToBoolean(linha["generico"]);
                remedio.Nome = linha["nome"].ToString();
                remedio.Categoria = linha["categoria"].ToString();
                remedio.Solido = Convert.ToBoolean(linha["solido"]);
                remedio.Bula = linha["bula"].ToString();
                remedio.Faixa = linha["faixa"].ToString();
                remedio.Receita = Convert.ToBoolean(linha["receita"]);
                remedios.Add(remedio);
            }
            conexao.Close();
            return remedios;
        }

        public Remedio ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM remedios WHERE id = @ID";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();
            if (tabela.Rows.Count == 1)
            {
                DataRow linha = tabela.Rows[0];
                Remedio remedio = new Remedio();
                remedio.Id = Convert.ToInt32(linha["id"]);
                remedio.Generico = Convert.ToBoolean(linha["generico"]);
                remedio.Nome = linha["nome"].ToString();
                remedio.Categoria = linha["categoria"].ToString();
                remedio.Solido = Convert.ToBoolean(linha["solido"]);
                remedio.Bula = linha["bula"].ToString();
                remedio.Faixa = linha["faixa"].ToString();
                remedio.Receita = Convert.ToBoolean(linha["receita"]);
                return remedio;
            }
            return null;
        }

        public void Inserir(Remedio remedio)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO remedios (generico, nome, categoria, solido, bula, faixa, receita) VALUES (@GENERICO, @NOME, @CATEGORIA, @SOLIDO, @BULA, @FAIXA, @RECEITA)";
            comando.Parameters.AddWithValue("@GENERICO", remedio.Generico);
            comando.Parameters.AddWithValue("@NOME", remedio.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", remedio.Categoria);
            comando.Parameters.AddWithValue("@SOLIDO", remedio.Solido);
            comando.Parameters.AddWithValue("@BULA", remedio.Bula);
            comando.Parameters.AddWithValue("@FAIXA", remedio.Faixa);
            comando.Parameters.AddWithValue("@RECEITA", remedio.Receita);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "DELETE FROM remedios WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Atualizar(Remedio remedio)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "UPDATE remedios SET @GENERICO = generico, @NOME = nome, @CATEGORIA = categoria, @SOLIDO = solido, @BULA = bula, @FAIXA = faixa, @RECEITA = receita WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", remedio.Id);
            comando.Parameters.AddWithValue("@GENERICO", remedio.Generico);
            comando.Parameters.AddWithValue("@NOME", remedio.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", remedio.Categoria);
            comando.Parameters.AddWithValue("@SOLIDO", remedio.Solido);
            comando.Parameters.AddWithValue("@BULA", remedio.Bula);
            comando.Parameters.AddWithValue("@FAIXA", remedio.Faixa);
            comando.Parameters.AddWithValue("@RECEITA", remedio.Receita);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}