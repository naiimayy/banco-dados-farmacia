﻿using Model;
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
            txtNome.Text = comestivel.Nome;
            comestivel.Preco = Convert.ToDecimal(txtPreco.Text);
            comestivel.DataVencimento = Convert.ToDateTime(dtpDataVencimento.Text);
            comestivel.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            comestivel.Marca = txtMarca.Text;

            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            repositorio.Atualizar(comestivel);

            MessageBox.Show("Editado com sucesso");
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Comestivel comestivel = new Comestivel();
            comestivel.Id = Convert.ToInt32(txtId.Text);
            comestivel.Nome = txtNome.Text;
            comestivel.Preco = Convert.ToDecimal(txtPreco.Text);
            comestivel.DataVencimento = Convert.ToDateTime(dtpDataVencimento.Text);
            comestivel.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            comestivel.Marca = txtMarca.Text;

            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            repositorio.Atualizar(comestivel);
            MessageBox.Show("Editado com sucesso");
            Close();
        }

    }
}
