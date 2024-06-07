using System;

namespace pimVI
{
    partial class Estoque
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dtvvenda = new System.Windows.Forms.DataGridView();
            this.lblestoque = new System.Windows.Forms.Label();
            this.lblqtde = new System.Windows.Forms.Label();
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
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblprod = new System.Windows.Forms.Label();
            this.lblcodbarras = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvvenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFinalizar.Location = new System.Drawing.Point(707, 539);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(121, 39);
            this.btnFinalizar.TabIndex = 156;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dtvvenda
            // 
            this.dtvvenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvvenda.Location = new System.Drawing.Point(68, 310);
            this.dtvvenda.MultiSelect = false;
            this.dtvvenda.Name = "dtvvenda";
            this.dtvvenda.Size = new System.Drawing.Size(684, 212);
            this.dtvvenda.TabIndex = 155;
            // 
            // lblestoque
            // 
            this.lblestoque.AutoSize = true;
            this.lblestoque.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblestoque.Location = new System.Drawing.Point(439, 21);
            this.lblestoque.Name = "lblestoque";
            this.lblestoque.Size = new System.Drawing.Size(140, 43);
            this.lblestoque.TabIndex = 153;
            this.lblestoque.Text = "Estoque";
            // 
            // lblqtde
            // 
            this.lblqtde.AutoSize = true;
            this.lblqtde.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblqtde.Location = new System.Drawing.Point(203, 21);
            this.lblqtde.Name = "lblqtde";
            this.lblqtde.Size = new System.Drawing.Size(240, 43);
            this.lblqtde.TabIndex = 157;
            this.lblqtde.Text = "Quantidade de ";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cbCategoria.Location = new System.Drawing.Point(222, 137);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(235, 28);
            this.cbCategoria.TabIndex = 172;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // txtfab
            // 
            this.txtfab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfab.Location = new System.Drawing.Point(212, 233);
            this.txtfab.MaxLength = 20;
            this.txtfab.Name = "txtfab";
            this.txtfab.Size = new System.Drawing.Size(235, 26);
            this.txtfab.TabIndex = 171;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricante.Location = new System.Drawing.Point(90, 237);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(116, 22);
            this.lblFabricante.TabIndex = 170;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(186, 201);
            this.txtValor.MaxLength = 20;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(235, 26);
            this.txtValor.TabIndex = 169;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(90, 205);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(65, 22);
            this.lblValor.TabIndex = 168;
            this.lblValor.Text = "Valor:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(222, 171);
            this.txtQuantidade.MaxLength = 60;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(235, 26);
            this.txtQuantidade.TabIndex = 167;
            // 
            // txtGarantia
            // 
            this.txtGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia.Location = new System.Drawing.Point(222, 265);
            this.txtGarantia.MaxLength = 5;
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(199, 26);
            this.txtGarantia.TabIndex = 166;
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarantia.Location = new System.Drawing.Point(98, 269);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(96, 22);
            this.lblGarantia.TabIndex = 165;
            this.lblGarantia.Text = "Garantia:";
            // 
            // lblquant
            // 
            this.lblquant.AutoSize = true;
            this.lblquant.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquant.Location = new System.Drawing.Point(90, 173);
            this.lblquant.Name = "lblquant";
            this.lblquant.Size = new System.Drawing.Size(124, 22);
            this.lblquant.TabIndex = 164;
            this.lblquant.Text = "Quantidade:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(90, 143);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(107, 22);
            this.lblcategoria.TabIndex = 163;
            this.lblcategoria.Text = "Categoria:";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.Location = new System.Drawing.Point(252, 105);
            this.txtCodBarras.MaxLength = 60;
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(273, 26);
            this.txtCodBarras.TabIndex = 161;
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(188, 73);
            this.txtProduto.MaxLength = 60;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(442, 26);
            this.txtProduto.TabIndex = 160;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // lblprod
            // 
            this.lblprod.AutoSize = true;
            this.lblprod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprod.Location = new System.Drawing.Point(90, 73);
            this.lblprod.Name = "lblprod";
            this.lblprod.Size = new System.Drawing.Size(92, 22);
            this.lblprod.TabIndex = 159;
            this.lblprod.Text = "Produto:";
            // 
            // lblcodbarras
            // 
            this.lblcodbarras.AutoSize = true;
            this.lblcodbarras.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodbarras.Location = new System.Drawing.Point(90, 106);
            this.lblcodbarras.Name = "lblcodbarras";
            this.lblcodbarras.Size = new System.Drawing.Size(152, 22);
            this.lblcodbarras.TabIndex = 158;
            this.lblcodbarras.Text = "Código Barras:";
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRemover.Location = new System.Drawing.Point(707, 226);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(102, 45);
            this.btnRemover.TabIndex = 176;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(707, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 45);
            this.btnAdd.TabIndex = 175;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnatualizar
            // 
            this.btnatualizar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnatualizar.Location = new System.Drawing.Point(707, 77);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(102, 45);
            this.btnatualizar.TabIndex = 174;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click_1);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnatualizar);
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
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblprod);
            this.Controls.Add(this.lblcodbarras);
            this.Controls.Add(this.lblqtde);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dtvvenda);
            this.Controls.Add(this.lblestoque);
            this.Name = "Estoque";
            this.Size = new System.Drawing.Size(848, 595);
            ((System.ComponentModel.ISupportInitialize)(this.dtvvenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dtvvenda;
        private System.Windows.Forms.Label lblestoque;
        private System.Windows.Forms.Label lblqtde;
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
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblprod;
        private System.Windows.Forms.Label lblcodbarras;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnatualizar;
    }
}
