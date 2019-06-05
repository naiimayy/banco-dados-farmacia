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
    public partial class FormCadastroProdutoHigienico : Form
    {
        public FormCadastroProdutoHigienico()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoHigienico produtoHigienico = new ProdutoHigienico();
            produtoHigienico.Nome = txtNome.Text;
            produtoHigienico.Categoria = cmbCategoria.SelectedIndex.ToString();

            try
            {
                produtoHigienico.Preco = Convert.ToDecimal(txtPreco.Text);
            }
            catch
            {
                MessageBox.Show("O campo PREÇO deve conter apenas números");
                txtPreco.Focus();
                return;
            }

            RepositorioProdutoHigienico repositorio = new RepositorioProdutoHigienico();
            repositorio.Inserir(produtoHigienico);
            MessageBox.Show("Seu produto foi salvo com sucesso");
            Close();
        }
    }
}
