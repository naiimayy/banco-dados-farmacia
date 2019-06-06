namespace View
{
    partial class Principal
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
            this.btnCadastroComestivel = new System.Windows.Forms.Button();
            this.btnCadastroRemedio = new System.Windows.Forms.Button();
            this.btnCadastroProdutoHigienico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroComestivel
            // 
            this.btnCadastroComestivel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroComestivel.Location = new System.Drawing.Point(12, 12);
            this.btnCadastroComestivel.Name = "btnCadastroComestivel";
            this.btnCadastroComestivel.Size = new System.Drawing.Size(274, 169);
            this.btnCadastroComestivel.TabIndex = 0;
            this.btnCadastroComestivel.Text = "Cadastro de Comestíveis ";
            this.btnCadastroComestivel.UseVisualStyleBackColor = true;
            this.btnCadastroComestivel.Click += new System.EventHandler(this.btnCadastroComestivel_Click);
            // 
            // btnCadastroRemedio
            // 
            this.btnCadastroRemedio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroRemedio.Location = new System.Drawing.Point(12, 187);
            this.btnCadastroRemedio.Name = "btnCadastroRemedio";
            this.btnCadastroRemedio.Size = new System.Drawing.Size(274, 164);
            this.btnCadastroRemedio.TabIndex = 1;
            this.btnCadastroRemedio.Text = "Cadastro de Remedios";
            this.btnCadastroRemedio.UseVisualStyleBackColor = true;
            // 
            // btnCadastroProdutoHigienico
            // 
            this.btnCadastroProdutoHigienico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProdutoHigienico.Location = new System.Drawing.Point(12, 357);
            this.btnCadastroProdutoHigienico.Name = "btnCadastroProdutoHigienico";
            this.btnCadastroProdutoHigienico.Size = new System.Drawing.Size(274, 178);
            this.btnCadastroProdutoHigienico.TabIndex = 2;
            this.btnCadastroProdutoHigienico.Text = "Cadastro de Produtos Higienicos ";
            this.btnCadastroProdutoHigienico.UseVisualStyleBackColor = true;
            this.btnCadastroProdutoHigienico.Click += new System.EventHandler(this.btnCadastroProdutoHigienico_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 545);
            this.Controls.Add(this.btnCadastroProdutoHigienico);
            this.Controls.Add(this.btnCadastroRemedio);
            this.Controls.Add(this.btnCadastroComestivel);
            this.Name = "Principal";
            this.Text = "Cadastros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroComestivel;
        private System.Windows.Forms.Button btnCadastroRemedio;
        private System.Windows.Forms.Button btnCadastroProdutoHigienico;
    }
}