namespace View
{
    partial class FormCadastroRemedio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtBula = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblGenerico = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gpbGenerico = new System.Windows.Forms.GroupBox();
            this.rbSimGenerico = new System.Windows.Forms.RadioButton();
            this.rbNaoGenerico = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblSolido = new System.Windows.Forms.Label();
            this.gpbSolido = new System.Windows.Forms.GroupBox();
            this.rbNaoSolido = new System.Windows.Forms.RadioButton();
            this.rbSimSolido = new System.Windows.Forms.RadioButton();
            this.lblBula = new System.Windows.Forms.Label();
            this.lblFaixa = new System.Windows.Forms.Label();
            this.cmbFaixa = new System.Windows.Forms.ComboBox();
            this.lblReceita = new System.Windows.Forms.Label();
            this.gpbReceita = new System.Windows.Forms.GroupBox();
            this.rbNaoReceita = new System.Windows.Forms.RadioButton();
            this.rbSimReceita = new System.Windows.Forms.RadioButton();
            this.gpbGenerico.SuspendLayout();
            this.gpbSolido.SuspendLayout();
            this.gpbReceita.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(312, 440);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(133, 63);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtBula
            // 
            this.txtBula.Location = new System.Drawing.Point(7, 329);
            this.txtBula.Name = "txtBula";
            this.txtBula.Size = new System.Drawing.Size(438, 20);
            this.txtBula.TabIndex = 17;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(7, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(438, 20);
            this.txtId.TabIndex = 15;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 124);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            // 
            // lblGenerico
            // 
            this.lblGenerico.AutoSize = true;
            this.lblGenerico.Location = new System.Drawing.Point(4, 82);
            this.lblGenerico.Name = "lblGenerico";
            this.lblGenerico.Size = new System.Drawing.Size(56, 13);
            this.lblGenerico.TabIndex = 12;
            this.lblGenerico.Text = "Genérico?";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 13);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Código";
            // 
            // gpbGenerico
            // 
            this.gpbGenerico.Controls.Add(this.rbNaoGenerico);
            this.gpbGenerico.Controls.Add(this.rbSimGenerico);
            this.gpbGenerico.Location = new System.Drawing.Point(71, 61);
            this.gpbGenerico.Name = "gpbGenerico";
            this.gpbGenerico.Size = new System.Drawing.Size(153, 57);
            this.gpbGenerico.TabIndex = 20;
            this.gpbGenerico.TabStop = false;
            // 
            // rbSimGenerico
            // 
            this.rbSimGenerico.AutoSize = true;
            this.rbSimGenerico.Location = new System.Drawing.Point(6, 19);
            this.rbSimGenerico.Name = "rbSimGenerico";
            this.rbSimGenerico.Size = new System.Drawing.Size(42, 17);
            this.rbSimGenerico.TabIndex = 21;
            this.rbSimGenerico.TabStop = true;
            this.rbSimGenerico.Text = "Sim";
            this.rbSimGenerico.UseVisualStyleBackColor = true;
            // 
            // rbNaoGenerico
            // 
            this.rbNaoGenerico.AutoSize = true;
            this.rbNaoGenerico.Location = new System.Drawing.Point(97, 19);
            this.rbNaoGenerico.Name = "rbNaoGenerico";
            this.rbNaoGenerico.Size = new System.Drawing.Size(45, 17);
            this.rbNaoGenerico.TabIndex = 22;
            this.rbNaoGenerico.TabStop = true;
            this.rbNaoGenerico.Text = "Não";
            this.rbNaoGenerico.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 140);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(438, 20);
            this.txtNome.TabIndex = 21;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(9, 179);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 22;
            this.lblCategoria.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Medicamento Fitoterápico",
            "Medicamento Alopático",
            "Medicamento Homeopático",
            "Medicamento Similar",
            "Medicamento Genérico",
            "Medicamento de Referência",
            "Medicamento Manipulado"});
            this.cmbCategoria.Location = new System.Drawing.Point(7, 195);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(438, 21);
            this.cmbCategoria.TabIndex = 23;
            // 
            // lblSolido
            // 
            this.lblSolido.AutoSize = true;
            this.lblSolido.Location = new System.Drawing.Point(9, 260);
            this.lblSolido.Name = "lblSolido";
            this.lblSolido.Size = new System.Drawing.Size(42, 13);
            this.lblSolido.TabIndex = 24;
            this.lblSolido.Text = "Sólido?";
            // 
            // gpbSolido
            // 
            this.gpbSolido.Controls.Add(this.rbNaoSolido);
            this.gpbSolido.Controls.Add(this.rbSimSolido);
            this.gpbSolido.Location = new System.Drawing.Point(71, 237);
            this.gpbSolido.Name = "gpbSolido";
            this.gpbSolido.Size = new System.Drawing.Size(153, 57);
            this.gpbSolido.TabIndex = 25;
            this.gpbSolido.TabStop = false;
            // 
            // rbNaoSolido
            // 
            this.rbNaoSolido.AutoSize = true;
            this.rbNaoSolido.Location = new System.Drawing.Point(97, 19);
            this.rbNaoSolido.Name = "rbNaoSolido";
            this.rbNaoSolido.Size = new System.Drawing.Size(45, 17);
            this.rbNaoSolido.TabIndex = 22;
            this.rbNaoSolido.TabStop = true;
            this.rbNaoSolido.Text = "Não";
            this.rbNaoSolido.UseVisualStyleBackColor = true;
            // 
            // rbSimSolido
            // 
            this.rbSimSolido.AutoSize = true;
            this.rbSimSolido.Location = new System.Drawing.Point(6, 19);
            this.rbSimSolido.Name = "rbSimSolido";
            this.rbSimSolido.Size = new System.Drawing.Size(42, 17);
            this.rbSimSolido.TabIndex = 21;
            this.rbSimSolido.TabStop = true;
            this.rbSimSolido.Text = "Sim";
            this.rbSimSolido.UseVisualStyleBackColor = true;
            // 
            // lblBula
            // 
            this.lblBula.AutoSize = true;
            this.lblBula.Location = new System.Drawing.Point(9, 313);
            this.lblBula.Name = "lblBula";
            this.lblBula.Size = new System.Drawing.Size(28, 13);
            this.lblBula.TabIndex = 26;
            this.lblBula.Text = "Bula";
            // 
            // lblFaixa
            // 
            this.lblFaixa.AutoSize = true;
            this.lblFaixa.Location = new System.Drawing.Point(11, 367);
            this.lblFaixa.Name = "lblFaixa";
            this.lblFaixa.Size = new System.Drawing.Size(32, 13);
            this.lblFaixa.TabIndex = 27;
            this.lblFaixa.Text = "Faixa";
            // 
            // cmbFaixa
            // 
            this.cmbFaixa.FormattingEnabled = true;
            this.cmbFaixa.Items.AddRange(new object[] {
            "Tarja vermelha",
            "Tarja preta",
            "Tarja amarela",
            "Não tarjados"});
            this.cmbFaixa.Location = new System.Drawing.Point(7, 383);
            this.cmbFaixa.Name = "cmbFaixa";
            this.cmbFaixa.Size = new System.Drawing.Size(438, 21);
            this.cmbFaixa.TabIndex = 28;
            // 
            // lblReceita
            // 
            this.lblReceita.AutoSize = true;
            this.lblReceita.Location = new System.Drawing.Point(5, 440);
            this.lblReceita.Name = "lblReceita";
            this.lblReceita.Size = new System.Drawing.Size(44, 13);
            this.lblReceita.TabIndex = 29;
            this.lblReceita.Text = "Receita";
            // 
            // gpbReceita
            // 
            this.gpbReceita.Controls.Add(this.rbNaoReceita);
            this.gpbReceita.Controls.Add(this.rbSimReceita);
            this.gpbReceita.Location = new System.Drawing.Point(71, 421);
            this.gpbReceita.Name = "gpbReceita";
            this.gpbReceita.Size = new System.Drawing.Size(153, 57);
            this.gpbReceita.TabIndex = 30;
            this.gpbReceita.TabStop = false;
            // 
            // rbNaoReceita
            // 
            this.rbNaoReceita.AutoSize = true;
            this.rbNaoReceita.Location = new System.Drawing.Point(97, 19);
            this.rbNaoReceita.Name = "rbNaoReceita";
            this.rbNaoReceita.Size = new System.Drawing.Size(45, 17);
            this.rbNaoReceita.TabIndex = 22;
            this.rbNaoReceita.TabStop = true;
            this.rbNaoReceita.Text = "Não";
            this.rbNaoReceita.UseVisualStyleBackColor = true;
            // 
            // rbSimReceita
            // 
            this.rbSimReceita.AutoSize = true;
            this.rbSimReceita.Location = new System.Drawing.Point(6, 19);
            this.rbSimReceita.Name = "rbSimReceita";
            this.rbSimReceita.Size = new System.Drawing.Size(42, 17);
            this.rbSimReceita.TabIndex = 21;
            this.rbSimReceita.TabStop = true;
            this.rbSimReceita.Text = "Sim";
            this.rbSimReceita.UseVisualStyleBackColor = true;
            // 
            // FormCadastroRemedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 520);
            this.Controls.Add(this.gpbReceita);
            this.Controls.Add(this.lblReceita);
            this.Controls.Add(this.cmbFaixa);
            this.Controls.Add(this.lblFaixa);
            this.Controls.Add(this.lblBula);
            this.Controls.Add(this.gpbSolido);
            this.Controls.Add(this.lblSolido);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.gpbGenerico);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtBula);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblGenerico);
            this.Controls.Add(this.lblId);
            this.Name = "FormCadastroRemedio";
            this.Text = "FormCadastroRemedio";
            this.gpbGenerico.ResumeLayout(false);
            this.gpbGenerico.PerformLayout();
            this.gpbSolido.ResumeLayout(false);
            this.gpbSolido.PerformLayout();
            this.gpbReceita.ResumeLayout(false);
            this.gpbReceita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtBula;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblGenerico;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gpbGenerico;
        private System.Windows.Forms.RadioButton rbNaoGenerico;
        private System.Windows.Forms.RadioButton rbSimGenerico;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblSolido;
        private System.Windows.Forms.GroupBox gpbSolido;
        private System.Windows.Forms.RadioButton rbNaoSolido;
        private System.Windows.Forms.RadioButton rbSimSolido;
        private System.Windows.Forms.Label lblBula;
        private System.Windows.Forms.Label lblFaixa;
        private System.Windows.Forms.ComboBox cmbFaixa;
        private System.Windows.Forms.Label lblReceita;
        private System.Windows.Forms.GroupBox gpbReceita;
        private System.Windows.Forms.RadioButton rbNaoReceita;
        private System.Windows.Forms.RadioButton rbSimReceita;
    }
}