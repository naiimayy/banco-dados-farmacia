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
    public partial class FormEditarCadastroComestivel : Form
    {
        public FormEditarCadastroComestivel()
        {
            InitializeComponent();
        }

        public FormEditarCadastroComestivel(Comestivel comestivel)
        {
            InitializeComponent();
            txtId.Text = comestivel.Id.ToString();
            txtNome.Text = comestivel.Nome;
            txtPreco.Text = Convert.ToString(comestivel.Preco);
            dtpDataVencimento.Value= Convert.ToDateTime(comestivel.DataVencimento);
            txtQuantidade.Text = comestivel.Quantidade.ToString();
            txtMarca.Text = comestivel.Marca;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Comestivel comestivel = new Comestivel();

            comestivel.Id = Convert.ToInt32(txtId.Text);
            if (txtNome.Text.Length < 1)
            {
                MessageBox.Show("Registre o nome corretamente");
                txtNome.Focus();
                return;
            }
            comestivel.Nome = txtNome.Text;

            try
            {
                comestivel.Preco = Convert.ToDecimal(txtPreco.Text);
                if (comestivel.Preco < 0)
                {
                    MessageBox.Show("Números devem ser maior do que zero");
                }
            }
            catch
            {
                MessageBox.Show("Campo deve conter apenas números");
                txtPreco.Focus();
                return;
            }
            comestivel.DataVencimento = Convert.ToDateTime(dtpDataVencimento.Text);
            try
            {
                comestivel.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                if (comestivel.Quantidade < 0)
                {
                    MessageBox.Show("Test");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Campo deve conter apenas números");
                txtQuantidade.Focus();
                return;
            }
            comestivel.Marca = txtMarca.Text;
            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            repositorio.Atualizar(comestivel);
            MessageBox.Show("Editado com sucesso");
            Close();
        }

    }
}
