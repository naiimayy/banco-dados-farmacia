namespace View
{
    partial class FormEditarCadastroProdutoHigienico
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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(370, 203);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Sabonete",
            "Perfume",
            "Shampoo",
            "Cotonete"});
            this.cmbCategoria.Location = new System.Drawing.Point(7, 125);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(438, 21);
            this.cmbCategoria.TabIndex = 18;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(7, 177);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(438, 20);
            this.txtPreco.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(438, 20);
            this.txtNome.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(7, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(438, 20);
            this.txtId.TabIndex = 15;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(7, 161);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 14;
            this.lblPreco.Text = "Preço";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(7, 109);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(4, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 7);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 13);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Código";
            // 
            // FormEditarCadastroProdutoHigienico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 243);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Name = "FormEditarCadastroProdutoHigienico";
            this.Text = "FormEditarCadastroProdutoHigienico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
    }
}