namespace BakerCommerce
{
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbCategoriaCadastro = new System.Windows.Forms.ComboBox();
            this.lblCategoriaCadastro = new System.Windows.Forms.Label();
            this.txbPrecoCadastro = new System.Windows.Forms.TextBox();
            this.lblPrecoCadastro = new System.Windows.Forms.Label();
            this.txbNomeCadastro = new System.Windows.Forms.TextBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.grbEditarCadastro = new System.Windows.Forms.GroupBox();
            this.btnEditarCadastro = new System.Windows.Forms.Button();
            this.cmbCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.txbPrecoEditar = new System.Windows.Forms.TextBox();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbApagarCadastro = new System.Windows.Forms.GroupBox();
            this.btnDescricaoProdutoApagar = new System.Windows.Forms.Button();
            this.lblDescricaoCadastroApagar = new System.Windows.Forms.Label();
            this.lblTituloProdutos = new System.Windows.Forms.Label();
            this.pibProdutos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditarCadastro.SuspendLayout();
            this.grbApagarCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(22, 63);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(489, 249);
            this.dgvProdutos.TabIndex = 0;
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.BackColor = System.Drawing.Color.White;
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.cmbCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.lblCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.txbPrecoCadastro);
            this.grbCadastrar.Controls.Add(this.lblPrecoCadastro);
            this.grbCadastrar.Controls.Add(this.txbNomeCadastro);
            this.grbCadastrar.Controls.Add(this.lblNomeCadastro);
            this.grbCadastrar.Location = new System.Drawing.Point(22, 332);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(239, 169);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(48, 121);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(135, 38);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // cmbCategoriaCadastro
            // 
            this.cmbCategoriaCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaCadastro.FormattingEnabled = true;
            this.cmbCategoriaCadastro.Location = new System.Drawing.Point(77, 85);
            this.cmbCategoriaCadastro.Name = "cmbCategoriaCadastro";
            this.cmbCategoriaCadastro.Size = new System.Drawing.Size(142, 21);
            this.cmbCategoriaCadastro.TabIndex = 5;
            // 
            // lblCategoriaCadastro
            // 
            this.lblCategoriaCadastro.AutoSize = true;
            this.lblCategoriaCadastro.Location = new System.Drawing.Point(16, 88);
            this.lblCategoriaCadastro.Name = "lblCategoriaCadastro";
            this.lblCategoriaCadastro.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaCadastro.TabIndex = 4;
            this.lblCategoriaCadastro.Text = "Categoria:";
            // 
            // txbPrecoCadastro
            // 
            this.txbPrecoCadastro.Location = new System.Drawing.Point(77, 55);
            this.txbPrecoCadastro.Name = "txbPrecoCadastro";
            this.txbPrecoCadastro.Size = new System.Drawing.Size(143, 20);
            this.txbPrecoCadastro.TabIndex = 3;
            // 
            // lblPrecoCadastro
            // 
            this.lblPrecoCadastro.AutoSize = true;
            this.lblPrecoCadastro.Location = new System.Drawing.Point(33, 58);
            this.lblPrecoCadastro.Name = "lblPrecoCadastro";
            this.lblPrecoCadastro.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoCadastro.TabIndex = 2;
            this.lblPrecoCadastro.Text = "Preço:";
            // 
            // txbNomeCadastro
            // 
            this.txbNomeCadastro.Location = new System.Drawing.Point(77, 20);
            this.txbNomeCadastro.Name = "txbNomeCadastro";
            this.txbNomeCadastro.Size = new System.Drawing.Size(143, 20);
            this.txbNomeCadastro.TabIndex = 1;
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(33, 23);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCadastro.TabIndex = 0;
            this.lblNomeCadastro.Text = "Nome:";
            // 
            // grbEditarCadastro
            // 
            this.grbEditarCadastro.BackColor = System.Drawing.Color.White;
            this.grbEditarCadastro.Controls.Add(this.btnEditarCadastro);
            this.grbEditarCadastro.Controls.Add(this.cmbCategoriaEditar);
            this.grbEditarCadastro.Controls.Add(this.lblCategoriaEditar);
            this.grbEditarCadastro.Controls.Add(this.txbPrecoEditar);
            this.grbEditarCadastro.Controls.Add(this.lblPrecoEditar);
            this.grbEditarCadastro.Controls.Add(this.txbNomeEditar);
            this.grbEditarCadastro.Controls.Add(this.lblNomeEditar);
            this.grbEditarCadastro.Location = new System.Drawing.Point(278, 332);
            this.grbEditarCadastro.Name = "grbEditarCadastro";
            this.grbEditarCadastro.Size = new System.Drawing.Size(239, 169);
            this.grbEditarCadastro.TabIndex = 7;
            this.grbEditarCadastro.TabStop = false;
            this.grbEditarCadastro.Text = "Editar";
            // 
            // btnEditarCadastro
            // 
            this.btnEditarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCadastro.Location = new System.Drawing.Point(52, 121);
            this.btnEditarCadastro.Name = "btnEditarCadastro";
            this.btnEditarCadastro.Size = new System.Drawing.Size(135, 38);
            this.btnEditarCadastro.TabIndex = 6;
            this.btnEditarCadastro.Text = "Editar";
            this.btnEditarCadastro.UseVisualStyleBackColor = true;
            // 
            // cmbCategoriaEditar
            // 
            this.cmbCategoriaEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEditar.FormattingEnabled = true;
            this.cmbCategoriaEditar.Location = new System.Drawing.Point(77, 85);
            this.cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            this.cmbCategoriaEditar.Size = new System.Drawing.Size(142, 21);
            this.cmbCategoriaEditar.TabIndex = 5;
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(16, 88);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaEditar.TabIndex = 4;
            this.lblCategoriaEditar.Text = "Categoria:";
            // 
            // txbPrecoEditar
            // 
            this.txbPrecoEditar.Location = new System.Drawing.Point(77, 55);
            this.txbPrecoEditar.Name = "txbPrecoEditar";
            this.txbPrecoEditar.Size = new System.Drawing.Size(143, 20);
            this.txbPrecoEditar.TabIndex = 3;
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(33, 58);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoEditar.TabIndex = 2;
            this.lblPrecoEditar.Text = "Preço:";
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(77, 20);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(143, 20);
            this.txbNomeEditar.TabIndex = 1;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(33, 23);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(38, 13);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome:";
            // 
            // grbApagarCadastro
            // 
            this.grbApagarCadastro.BackColor = System.Drawing.Color.White;
            this.grbApagarCadastro.Controls.Add(this.btnDescricaoProdutoApagar);
            this.grbApagarCadastro.Controls.Add(this.lblDescricaoCadastroApagar);
            this.grbApagarCadastro.Location = new System.Drawing.Point(22, 507);
            this.grbApagarCadastro.Name = "grbApagarCadastro";
            this.grbApagarCadastro.Size = new System.Drawing.Size(495, 55);
            this.grbApagarCadastro.TabIndex = 8;
            this.grbApagarCadastro.TabStop = false;
            this.grbApagarCadastro.Text = "Apagar";
            // 
            // btnDescricaoProdutoApagar
            // 
            this.btnDescricaoProdutoApagar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnDescricaoProdutoApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescricaoProdutoApagar.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDescricaoProdutoApagar.Location = new System.Drawing.Point(354, 11);
            this.btnDescricaoProdutoApagar.Name = "btnDescricaoProdutoApagar";
            this.btnDescricaoProdutoApagar.Size = new System.Drawing.Size(135, 38);
            this.btnDescricaoProdutoApagar.TabIndex = 1;
            this.btnDescricaoProdutoApagar.Text = "Apagar";
            this.btnDescricaoProdutoApagar.UseVisualStyleBackColor = true;
            // 
            // lblDescricaoCadastroApagar
            // 
            this.lblDescricaoCadastroApagar.AutoSize = true;
            this.lblDescricaoCadastroApagar.Location = new System.Drawing.Point(33, 26);
            this.lblDescricaoCadastroApagar.Name = "lblDescricaoCadastroApagar";
            this.lblDescricaoCadastroApagar.Size = new System.Drawing.Size(173, 13);
            this.lblDescricaoCadastroApagar.TabIndex = 0;
            this.lblDescricaoCadastroApagar.Text = "Selecione um produto para apagar.";
            // 
            // lblTituloProdutos
            // 
            this.lblTituloProdutos.AutoSize = true;
            this.lblTituloProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloProdutos.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic);
            this.lblTituloProdutos.ForeColor = System.Drawing.Color.White;
            this.lblTituloProdutos.Location = new System.Drawing.Point(93, 24);
            this.lblTituloProdutos.Name = "lblTituloProdutos";
            this.lblTituloProdutos.Size = new System.Drawing.Size(292, 36);
            this.lblTituloProdutos.TabIndex = 9;
            this.lblTituloProdutos.Text = "Gerenciamento de Produtos";
            // 
            // pibProdutos
            // 
            this.pibProdutos.BackColor = System.Drawing.Color.Transparent;
            this.pibProdutos.Image = global::BakerCommerce.Properties.Resources.shopping_cart;
            this.pibProdutos.Location = new System.Drawing.Point(365, 12);
            this.pibProdutos.Name = "pibProdutos";
            this.pibProdutos.Size = new System.Drawing.Size(100, 50);
            this.pibProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibProdutos.TabIndex = 10;
            this.pibProdutos.TabStop = false;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BakerCommerce.Properties.Resources.TemaPadaria;
            this.ClientSize = new System.Drawing.Size(538, 574);
            this.Controls.Add(this.lblTituloProdutos);
            this.Controls.Add(this.grbApagarCadastro);
            this.Controls.Add(this.grbEditarCadastro);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.pibProdutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProdutos";
            this.Text = "Gerenciamento de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditarCadastro.ResumeLayout(false);
            this.grbEditarCadastro.PerformLayout();
            this.grbApagarCadastro.ResumeLayout(false);
            this.grbApagarCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.TextBox txbPrecoCadastro;
        private System.Windows.Forms.Label lblPrecoCadastro;
        private System.Windows.Forms.TextBox txbNomeCadastro;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbCategoriaCadastro;
        private System.Windows.Forms.Label lblCategoriaCadastro;
        private System.Windows.Forms.GroupBox grbEditarCadastro;
        private System.Windows.Forms.Button btnEditarCadastro;
        private System.Windows.Forms.ComboBox cmbCategoriaEditar;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.TextBox txbPrecoEditar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox grbApagarCadastro;
        private System.Windows.Forms.Button btnDescricaoProdutoApagar;
        private System.Windows.Forms.Label lblDescricaoCadastroApagar;
        private System.Windows.Forms.Label lblTituloProdutos;
        private System.Windows.Forms.PictureBox pibProdutos;
    }
}