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
    public partial class FormEditarCadastroProdutoHigienico : Form
    {
        public FormEditarCadastroProdutoHigienico()
        {
            InitializeComponent();
        }
        public FormEditarCadastroProdutoHigienico (ProdutoHigienico ProdutoHigienico)
        {
            InitializeComponent();
            txtId.Text = ProdutoHigienico.Id.ToString();
            txtNome.Text = ProdutoHigienico.Nome;
            cmbCategoria.SelectedItem = ProdutoHigienico.Categoria;
            txtPreco.Text = Convert.ToString(ProdutoHigienico.Preco);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoHigienico produtoHigienico = new ProdutoHigienico();
            produtoHigienico.Id = Convert.ToInt32(txtId.Text);
            produtoHigienico.Nome = txtNome.Text;
            produtoHigienico.Categoria = cmbCategoria.SelectedIndex.ToString();
            produtoHigienico.Preco = Convert.ToDecimal(txtPreco.Text);

            RepositorioProdutoHigienico repositorio = new RepositorioProdutoHigienico();
            repositorio.Atualizar(produtoHigienico);

            MessageBox.Show("Editado com sucesso");
            Close();
        }
    }
}
