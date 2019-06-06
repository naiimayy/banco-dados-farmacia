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
        string Cadeiaconexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65979\Documents\ExercicioFarmacia.mdf;Integrated Security=True;Connect Timeout=30";
    }

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

    public Comestivel ObterPeloId (int id)
    {

    }
}
