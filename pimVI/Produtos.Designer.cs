namespace pimVI
{
    partial class Produto
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtfab = new System.Windows.Forms.TextBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.lblquant = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtvProduto = new System.Windows.Forms.DataGridView();
            this.gbpesquisaprod = new System.Windows.Forms.GroupBox();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblprod = new System.Windows.Forms.Label();
            this.lblcodbarras = new System.Windows.Forms.Label();
            this.lblCodi1 = new System.Windows.Forms.Label();
            this.lblproduto = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProduto)).BeginInit();
            this.gbpesquisaprod.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cbCategoria.Location = new System.Drawing.Point(210, 180);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(235, 28);
            this.cbCategoria.TabIndex = 103;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // txtfab
            // 
            this.txtfab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfab.Location = new System.Drawing.Point(200, 276);
            this.txtfab.MaxLength = 20;
            this.txtfab.Name = "txtfab";
            this.txtfab.Size = new System.Drawing.Size(235, 26);
            this.txtfab.TabIndex = 96;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricante.Location = new System.Drawing.Point(78, 280);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(116, 22);
            this.lblFabricante.TabIndex = 94;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(174, 244);
            this.txtValor.MaxLength = 20;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(235, 26);
            this.txtValor.TabIndex = 93;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(78, 248);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(65, 22);
            this.lblValor.TabIndex = 90;
            this.lblValor.Text = "Valor:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(210, 214);
            this.txtQuantidade.MaxLength = 60;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(235, 26);
            this.txtQuantidade.TabIndex = 89;
            // 
            // txtGarantia
            // 
            this.txtGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia.Location = new System.Drawing.Point(210, 308);
            this.txtGarantia.MaxLength = 5;
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(199, 26);
            this.txtGarantia.TabIndex = 88;
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarantia.Location = new System.Drawing.Point(86, 312);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(96, 22);
            this.lblGarantia.TabIndex = 87;
            this.lblGarantia.Text = "Garantia:";
            // 
            // lblquant
            // 
            this.lblquant.AutoSize = true;
            this.lblquant.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquant.Location = new System.Drawing.Point(78, 216);
            this.lblquant.Name = "lblquant";
            this.lblquant.Size = new System.Drawing.Size(124, 22);
            this.lblquant.TabIndex = 86;
            this.lblquant.Text = "Quantidade:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(78, 186);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(107, 22);
            this.lblcategoria.TabIndex = 84;
            this.lblcategoria.Text = "Categoria:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancelar.Location = new System.Drawing.Point(722, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 45);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRemover.Location = new System.Drawing.Point(722, 322);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(102, 45);
            this.btnRemover.TabIndex = 78;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAlterar.Location = new System.Drawing.Point(722, 244);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(102, 45);
            this.btnAlterar.TabIndex = 77;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGravar.Location = new System.Drawing.Point(722, 158);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(102, 45);
            this.btnGravar.TabIndex = 76;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNovo.Location = new System.Drawing.Point(722, 62);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 45);
            this.btnNovo.TabIndex = 75;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dtvProduto
            // 
            this.dtvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvProduto.Location = new System.Drawing.Point(24, 409);
            this.dtvProduto.MultiSelect = false;
            this.dtvProduto.Name = "dtvProduto";
            this.dtvProduto.Size = new System.Drawing.Size(692, 173);
            this.dtvProduto.TabIndex = 74;
            // 
            // gbpesquisaprod
            // 
            this.gbpesquisaprod.Controls.Add(this.txtpesquisa);
            this.gbpesquisaprod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpesquisaprod.Location = new System.Drawing.Point(82, 358);
            this.gbpesquisaprod.Name = "gbpesquisaprod";
            this.gbpesquisaprod.Size = new System.Drawing.Size(603, 45);
            this.gbpesquisaprod.TabIndex = 73;
            this.gbpesquisaprod.TabStop = false;
            this.gbpesquisaprod.Text = "Pesquisa por Produtos";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.Location = new System.Drawing.Point(92, 19);
            this.txtpesquisa.MaxLength = 60;
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(505, 26);
            this.txtpesquisa.TabIndex = 7;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.Location = new System.Drawing.Point(240, 148);
            this.txtCodBarras.MaxLength = 60;
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(273, 26);
            this.txtCodBarras.TabIndex = 72;
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(176, 116);
            this.txtProduto.MaxLength = 60;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(523, 26);
            this.txtProduto.TabIndex = 71;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // lblprod
            // 
            this.lblprod.AutoSize = true;
            this.lblprod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprod.Location = new System.Drawing.Point(78, 116);
            this.lblprod.Name = "lblprod";
            this.lblprod.Size = new System.Drawing.Size(92, 22);
            this.lblprod.TabIndex = 70;
            this.lblprod.Text = "Produto:";
            // 
            // lblcodbarras
            // 
            this.lblcodbarras.AutoSize = true;
            this.lblcodbarras.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodbarras.Location = new System.Drawing.Point(78, 149);
            this.lblcodbarras.Name = "lblcodbarras";
            this.lblcodbarras.Size = new System.Drawing.Size(152, 22);
            this.lblcodbarras.TabIndex = 68;
            this.lblcodbarras.Text = "Código Barras:";
            // 
            // lblCodi1
            // 
            this.lblCodi1.AutoSize = true;
            this.lblCodi1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodi1.Location = new System.Drawing.Point(86, 62);
            this.lblCodi1.Name = "lblCodi1";
            this.lblCodi1.Size = new System.Drawing.Size(84, 22);
            this.lblCodi1.TabIndex = 66;
            this.lblCodi1.Text = "Código:";
            this.lblCodi1.Visible = false;
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblproduto.Location = new System.Drawing.Point(338, 12);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(137, 43);
            this.lblproduto.TabIndex = 65;
            this.lblproduto.Text = "Produto";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblcod.Location = new System.Drawing.Point(176, 62);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(0, 22);
            this.lblcod.TabIndex = 104;
            this.lblcod.Visible = false;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtfab);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.lblGarantia);
            this.Controls.Add(this.lblquant);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtvProduto);
            this.Controls.Add(this.gbpesquisaprod);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblprod);
            this.Controls.Add(this.lblcodbarras);
            this.Controls.Add(this.lblCodi1);
            this.Controls.Add(this.lblproduto);
            this.Name = "Produto";
            this.Size = new System.Drawing.Size(848, 595);
            this.Load += new System.EventHandler(this.Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvProduto)).EndInit();
            this.gbpesquisaprod.ResumeLayout(false);
            this.gbpesquisaprod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtfab;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.Label lblquant;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtvProduto;
        private System.Windows.Forms.GroupBox gbpesquisaprod;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblprod;
        private System.Windows.Forms.Label lblcodbarras;
        private System.Windows.Forms.Label lblCodi1;
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.Label lblcod;
    }
}
