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
    public class RepositorioProdutoHigienico
    {
        string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65979\Documents\ExercicioFarmacia.mdf;Integrated Security=True;Connect Timeout=30";

        public List<ProdutoHigienico> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM produtos_higienicos";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<ProdutoHigienico> produtosHigienicos = new List<ProdutoHigienico>();

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                ProdutoHigienico produtoHigienico = new ProdutoHigienico();
                produtoHigienico.Id = Convert.ToInt32(linha["id"]);
                produtoHigienico.Nome = linha["nome"].ToString();
                produtoHigienico.Preco = Convert.ToDecimal(linha["preco"]);
                produtoHigienico.Categoria = linha["categoria"].ToString();
                produtosHigienicos.Add(produtoHigienico);
            }
            conexao.Close();
            return produtosHigienicos;
        }

        public ProdutoHigienico ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM produtos_higienicos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            conexao.Close();
            if (dataTable.Rows.Count == 1)
            {
                DataRow linha = dataTable.Rows[0];
                ProdutoHigienico produtoHigienico = new ProdutoHigienico();
                produtoHigienico.Id = Convert.ToInt32(linha["id"]);
                produtoHigienico.Nome = linha["nome"].ToString();
                produtoHigienico.Preco = Convert.ToDecimal(linha["preco"]);
                produtoHigienico.Categoria = linha["categoria"].ToString();
                return produtoHigienico;
            }
            return null;
        }

        public void Inserir (ProdutoHigienico produtoHigienico)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO produtos_higienicos (nome, preco, categoria) VALUES (@NOME, @PRECO, @CATEGORIA)";
            comando.Parameters.AddWithValue("@NOME", produtoHigienico.Nome);
            comando.Parameters.AddWithValue("@PRECO", produtoHigienico.Preco);
            comando.Parameters.AddWithValue("@CATEGORIA", produtoHigienico.Categoria);

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
            comando.CommandText = "DELETE FROM produtos_higienicos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Atualizar(ProdutoHigienico produtoHigienico)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE  produtos_higienicos SET
                                   nome = @NOME,
                                   preco = @PRECO,
                                   categoria = @CATEGORIA
                                   WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", produtoHigienico.Id);
            comando.Parameters.AddWithValue("@NOME", produtoHigienico.Nome);
            comando.Parameters.AddWithValue("@PRECO", produtoHigienico.Preco);
            comando.Parameters.AddWithValue("@CATEGORIA", produtoHigienico.Categoria);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
