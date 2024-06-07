namespace pimVI
{
    partial class Relatorio
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
            this.lblvend = new System.Windows.Forms.Label();
            this.lblrelat = new System.Windows.Forms.Label();
            this.lblVendas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvvenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFinalizar.Location = new System.Drawing.Point(672, 507);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(124, 50);
            this.btnFinalizar.TabIndex = 151;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dtvvenda
            // 
            this.dtvvenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvvenda.Location = new System.Drawing.Point(70, 148);
            this.dtvvenda.MultiSelect = false;
            this.dtvvenda.Name = "dtvvenda";
            this.dtvvenda.Size = new System.Drawing.Size(706, 337);
            this.dtvvenda.TabIndex = 147;
            this.dtvvenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvvenda_CellContentClick);
            // 
            // lblvend
            // 
            this.lblvend.AutoSize = true;
            this.lblvend.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvend.Location = new System.Drawing.Point(75, 97);
            this.lblvend.Name = "lblvend";
            this.lblvend.Size = new System.Drawing.Size(152, 22);
            this.lblvend.TabIndex = 145;
            this.lblvend.Text = "Vendas do mês";
            this.lblvend.Click += new System.EventHandler(this.lblvend_Click);
            // 
            // lblrelat
            // 
            this.lblrelat.AutoSize = true;
            this.lblrelat.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrelat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblrelat.Location = new System.Drawing.Point(253, 32);
            this.lblrelat.Name = "lblrelat";
            this.lblrelat.Size = new System.Drawing.Size(151, 43);
            this.lblrelat.TabIndex = 144;
            this.lblrelat.Text = "Relatório";
            this.lblrelat.Click += new System.EventHandler(this.lblrelat_Click);
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblVendas.Location = new System.Drawing.Point(421, 32);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(128, 43);
            this.lblVendas.TabIndex = 152;
            this.lblVendas.Text = "Vendas";
            this.lblVendas.Click += new System.EventHandler(this.lblVendas_Click);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblVendas);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dtvvenda);
            this.Controls.Add(this.lblvend);
            this.Controls.Add(this.lblrelat);
            this.Name = "Relatorio";
            this.Size = new System.Drawing.Size(848, 595);
            ((System.ComponentModel.ISupportInitialize)(this.dtvvenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dtvvenda;
        private System.Windows.Forms.Label lblvend;
        private System.Windows.Forms.Label lblrelat;
        private System.Windows.Forms.Label lblVendas;
    }
}
