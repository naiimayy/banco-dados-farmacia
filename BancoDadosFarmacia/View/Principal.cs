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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCadastroProdutoHigienico_Click(object sender, EventArgs e)
        {
            FormListaProdutoHigienico form = new FormListaProdutoHigienico();
            form.Visible = true;
        }

        private void btnCadastroComestivel_Click(object sender, EventArgs e)
        {
            FormListaComestivel form = new FormListaComestivel();
            form.Visible = true;
        }
    }
}
