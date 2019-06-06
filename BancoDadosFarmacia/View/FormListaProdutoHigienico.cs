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
    public partial class FormListaProdutoHigienico : Form
    {
        public FormListaProdutoHigienico()
        {
            InitializeComponent();
        }

        private void AtualizarTabela()
        {
            ProdutoHigienicoRepositorio repositorio = new ProdutoHigienicoRepositorio();
            List<ProdutoHigienico> produtosHigienicos = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < produtosHigienicos.Count; i++)
            {
                ProdutoHigienico produtoHigienico = produtosHigienicos[i];
                dataGridView1.Rows.Add(new object[] { produtoHigienico.Id, produtoHigienico.Nome, produtoHigienico.Categoria, produtoHigienico.Preco });
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ProdutoHigienicoRepositorio repositorio = new ProdutoHigienicoRepositorio();
            repositorio.Apagar(id);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroProdutoHigienico cadastro = new FormCadastroProdutoHigienico();
            cadastro.ShowDialog();
        }

        private void FormListaProdutoHigienico_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ProdutoHigienicoRepositorio repositorio = new ProdutoHigienicoRepositorio();
            ProdutoHigienico produtoHigienico = repositorio.ObterPeloId(id);

            FormEditarCadastroProdutoHigienico formEditarCadastroProdutoHigienico = new FormEditarCadastroProdutoHigienico(produtoHigienico);
            formEditarCadastroProdutoHigienico.ShowDialog();

        }
    }
}
