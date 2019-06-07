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
    public partial class FormCadastroRemedio : Form
    {
        public FormCadastroRemedio()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Remedio remedio = new Remedio();
            remedio.Generico = rbSimGenerico.Checked;
            remedio.Nome = txtNome.Text;
            remedio.Categoria = cmbCategoria.SelectedIndex.ToString();
            remedio.Solido = rbSimSolido.Checked;
            remedio.Bula = txtBula.Text;
            remedio.Faixa = cmbFaixa.SelectedIndex.ToString();
            remedio.Receita = rbSimReceita.Checked; 

            RemedioRepositorio repositorio = new RemedioRepositorio();
            repositorio.Inserir(remedio);
            MessageBox.Show("Seu produto foi salvo com sucesso");
            Close();
        }
    }
}

