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
    public class ComestivelRepositorio
    {
        string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65979\Documents\ExercicioFarmacia.mdf;Integrated Security=True;Connect Timeout=30";


        public List<Comestivel> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM produtos_comestiveis";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<Comestivel> comestiveis = new List<Comestivel>();

            for (int i = 0, i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Comestivel comestivel = new Comestivel();
                comestivel.Id = Convert.ToInt32(linha["id"]);
                comestivel.Nome = linha["nome"].ToString();
                comestivel.Preco = Convert.ToDecimal(linha["preco"]);
                comestivel.DataVencimento = Convert.ToDateTime(linha["data_vencimento"]);
                comestivel.Quantidade = Convert.ToInt32(linha["quantidade"]);
                comestivel.Marca = linha["marca"].ToString();
                comestiveis.Add(comestivel);
            }
            conexao.Close();
            return comestiveis;
        }

        public Comestivel ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM produtos_comestiveis WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            conexao.Close();
            if (dataTable.Rows.Count == 1)
            {
                DataRow linha = dataTable.Rows[0];
                Comestivel comestivel = new Comestivel();
                comestivel.Id = Convert.ToInt32(linha["id"]);
                comestivel.Nome = linha["nome"].ToString();
                comestivel.Preco = Convert.ToDecimal(linha["preco"]);
                comestivel.DataVencimento = Convert.ToDateTime(linha["data_vencimento"]);
                comestivel.Quantidade = Convert.ToInt32(linha["quantidade"]);
                comestivel.Marca = linha["marca"].ToString();
                return comestivel;
            }
            return null;
        }

        public void Inserir(Comestivel comestivel)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT INTO produtos_comestiveis (nome, preco, data_vencimento, quantidade, marca) VALUES (@NOME, @PRECO, @DATA_VENCIMENTO, @QUANTIDADE, @MARCA)";
            comando.Parameters.AddWithValue("@NOME", comestivel.Nome);
            comando.Parameters.AddWithValue("@PRECO", comestivel.Preco);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", comestivel.DataVencimento);
            comando.Parameters.AddWithValue("@QUANTIDADE", comestivel.Quantidade);
            comando.Parameters.AddWithValue("@MARCA", comestivel.Marca);

            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
