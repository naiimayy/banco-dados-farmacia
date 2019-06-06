using Model;
using Repositório;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormListaComestivel : Form
    {
        public FormListaComestivel()
        {
            InitializeComponent();
        }

        private void AtualizarTabela()
        {
            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            List <Comestivel> comestiveis = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < comestiveis.Count; i++)
            {
                Comestivel comestivel = comestiveis[i];
                dataGridView1.Rows.Add(new object[] { comestivel.Id, comestivel.Nome, comestivel.Preco, comestivel.DataVencimento, comestivel.Quantidade, comestivel.Marca});
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ComestivelRepositorio repositorio = new ComestivelRepositorio ();
            repositorio.Apagar(id);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroComestivel cadastro = new FormCadastroComestivel();
            cadastro.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            Comestivel comestivel = repositorio.ObterPeloId(id);

            FormEditarCadastroComestivel formEditarCadastroComestivel = new FormEditarCadastroComestivel(comestivel);
            formEditarCadastroComestivel.ShowDialog();
        }

        private void FormListaComestivel_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
