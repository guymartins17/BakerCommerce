namespace BakerCommerce
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.pibOlhoAberto = new System.Windows.Forms.PictureBox();
            this.pibLogin = new System.Windows.Forms.PictureBox();
            this.grbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibOlhoAberto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(13, 88);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(61, 59);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(186, 20);
            this.txbEmail.TabIndex = 2;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(61, 85);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(186, 20);
            this.txbSenha.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(115, 184);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(253, 53);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic);
            this.lblTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Location = new System.Drawing.Point(108, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(266, 36);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "BakerCommerce :: Login";
            // 
            // grbLogin
            // 
            this.grbLogin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grbLogin.Controls.Add(this.pibOlhoAberto);
            this.grbLogin.Controls.Add(this.pibLogin);
            this.grbLogin.Controls.Add(this.txbSenha);
            this.grbLogin.Controls.Add(this.lblSenha);
            this.grbLogin.Controls.Add(this.lblEmail);
            this.grbLogin.Controls.Add(this.txbEmail);
            this.grbLogin.Location = new System.Drawing.Point(98, 58);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(286, 120);
            this.grbLogin.TabIndex = 6;
            this.grbLogin.TabStop = false;
            this.grbLogin.Text = "Login";
            // 
            // pibOlhoAberto
            // 
            this.pibOlhoAberto.Image = global::BakerCommerce.Properties.Resources.Olho;
            this.pibOlhoAberto.Location = new System.Drawing.Point(253, 84);
            this.pibOlhoAberto.Name = "pibOlhoAberto";
            this.pibOlhoAberto.Size = new System.Drawing.Size(26, 17);
            this.pibOlhoAberto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibOlhoAberto.TabIndex = 5;
            this.pibOlhoAberto.TabStop = false;
            // 
            // pibLogin
            // 
            this.pibLogin.Image = global::BakerCommerce.Properties.Resources.login_avatar;
            this.pibLogin.Location = new System.Drawing.Point(110, 20);
            this.pibLogin.Name = "pibLogin";
            this.pibLogin.Size = new System.Drawing.Size(72, 33);
            this.pibLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogin.TabIndex = 4;
            this.pibLogin.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BakerCommerce.Properties.Resources.TemaPadaria;
            this.ClientSize = new System.Drawing.Size(478, 296);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.grbLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibOlhoAberto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbLogin;
        private System.Windows.Forms.PictureBox pibLogin;
        private System.Windows.Forms.PictureBox pibOlhoAberto;
    }
}

