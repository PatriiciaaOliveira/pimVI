using System;

namespace pimVI
{
    partial class Caixa
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
            this.txttot = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtvcompra = new System.Windows.Forms.DataGridView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.lblforma = new System.Windows.Forms.Label();
            this.rbdinheiro = new System.Windows.Forms.RadioButton();
            this.rbcartao = new System.Windows.Forms.RadioButton();
            this.txtvalorreceb = new System.Windows.Forms.TextBox();
            this.lblValorrecebido = new System.Windows.Forms.Label();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.lbltroco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvcompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFinalizar.Location = new System.Drawing.Point(677, 487);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(124, 50);
            this.btnFinalizar.TabIndex = 135;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txttot
            // 
            this.txttot.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttot.Location = new System.Drawing.Point(240, 355);
            this.txttot.MaxLength = 20;
            this.txttot.Name = "txttot";
            this.txttot.Size = new System.Drawing.Size(142, 40);
            this.txttot.TabIndex = 134;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(58, 367);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(163, 22);
            this.lblTotal.TabIndex = 133;
            this.lblTotal.Text = "Total da Compra";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancelar.Location = new System.Drawing.Point(677, 427);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 50);
            this.btnCancelar.TabIndex = 119;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtvcompra
            // 
            this.dtvcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvcompra.Location = new System.Drawing.Point(75, 128);
            this.dtvcompra.MultiSelect = false;
            this.dtvcompra.Name = "dtvcompra";
            this.dtvcompra.Size = new System.Drawing.Size(659, 207);
            this.dtvcompra.TabIndex = 114;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(164, 77);
            this.txtCliente.MaxLength = 60;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(523, 26);
            this.txtCliente.TabIndex = 113;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(80, 77);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(74, 22);
            this.lblCliente.TabIndex = 112;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCaixa.Location = new System.Drawing.Point(319, 12);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(100, 43);
            this.lblCaixa.TabIndex = 109;
            this.lblCaixa.Text = "Caixa";
            // 
            // lblforma
            // 
            this.lblforma.AutoSize = true;
            this.lblforma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforma.ForeColor = System.Drawing.Color.Black;
            this.lblforma.Location = new System.Drawing.Point(412, 355);
            this.lblforma.Name = "lblforma";
            this.lblforma.Size = new System.Drawing.Size(208, 22);
            this.lblforma.TabIndex = 136;
            this.lblforma.Text = "Forma de Pagamento";
            // 
            // rbdinheiro
            // 
            this.rbdinheiro.AutoSize = true;
            this.rbdinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdinheiro.Location = new System.Drawing.Point(658, 390);
            this.rbdinheiro.Name = "rbdinheiro";
            this.rbdinheiro.Size = new System.Drawing.Size(83, 20);
            this.rbdinheiro.TabIndex = 139;
            this.rbdinheiro.Text = "Dinheiro";
            this.rbdinheiro.UseVisualStyleBackColor = true;
            // 
            // rbcartao
            // 
            this.rbcartao.AutoSize = true;
            this.rbcartao.Checked = true;
            this.rbcartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcartao.Location = new System.Drawing.Point(658, 355);
            this.rbcartao.Name = "rbcartao";
            this.rbcartao.Size = new System.Drawing.Size(71, 20);
            this.rbcartao.TabIndex = 138;
            this.rbcartao.TabStop = true;
            this.rbcartao.Text = "Cartão";
            this.rbcartao.UseVisualStyleBackColor = true;
            // 
            // txtvalorreceb
            // 
            this.txtvalorreceb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorreceb.Location = new System.Drawing.Point(240, 432);
            this.txtvalorreceb.MaxLength = 20;
            this.txtvalorreceb.Name = "txtvalorreceb";
            this.txtvalorreceb.Size = new System.Drawing.Size(163, 40);
            this.txtvalorreceb.TabIndex = 141;
            this.txtvalorreceb.TextChanged += new System.EventHandler(this.txtvalorreceb_TextChanged);
            // 
            // lblValorrecebido
            // 
            this.lblValorrecebido.AutoSize = true;
            this.lblValorrecebido.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorrecebido.ForeColor = System.Drawing.Color.Black;
            this.lblValorrecebido.Location = new System.Drawing.Point(71, 444);
            this.lblValorrecebido.Name = "lblValorrecebido";
            this.lblValorrecebido.Size = new System.Drawing.Size(150, 22);
            this.lblValorrecebido.TabIndex = 140;
            this.lblValorrecebido.Text = "Valor Recebido";
            // 
            // txttroco
            // 
            this.txttroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroco.Location = new System.Drawing.Point(240, 503);
            this.txttroco.MaxLength = 20;
            this.txttroco.Name = "txttroco";
            this.txttroco.Size = new System.Drawing.Size(163, 40);
            this.txttroco.TabIndex = 143;
            // 
            // lbltroco
            // 
            this.lbltroco.AutoSize = true;
            this.lbltroco.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltroco.ForeColor = System.Drawing.Color.Black;
            this.lbltroco.Location = new System.Drawing.Point(145, 515);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(65, 22);
            this.lbltroco.TabIndex = 142;
            this.lbltroco.Text = "Troco";
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txttroco);
            this.Controls.Add(this.lbltroco);
            this.Controls.Add(this.txtvalorreceb);
            this.Controls.Add(this.lblValorrecebido);
            this.Controls.Add(this.rbdinheiro);
            this.Controls.Add(this.rbcartao);
            this.Controls.Add(this.lblforma);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txttot);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtvcompra);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCaixa);
            this.Name = "Caixa";
            this.Size = new System.Drawing.Size(848, 595);
            ((System.ComponentModel.ISupportInitialize)(this.dtvcompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtvalorreceb_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txttot;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dtvcompra;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.Label lblforma;
        private System.Windows.Forms.RadioButton rbdinheiro;
        private System.Windows.Forms.RadioButton rbcartao;
        private System.Windows.Forms.TextBox txtvalorreceb;
        private System.Windows.Forms.Label lblValorrecebido;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.Label lbltroco;
    }
}
