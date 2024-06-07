using System;
using System.Windows.Forms;

namespace pimVI
{
    partial class Pedido
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
            this.cliente1 = new pimVI.Cliente();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.mtbcnpj = new System.Windows.Forms.MaskedTextBox();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtvpedido = new System.Windows.Forms.DataGridView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCodiClie = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.txtqtde = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btninserir = new System.Windows.Forms.Button();
            this.txttot = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvpedido)).BeginInit();
            this.SuspendLayout();
            // 
            // cliente1
            // 
            this.cliente1.Location = new System.Drawing.Point(51, 17);
            this.cliente1.Name = "cliente1";
            this.cliente1.Size = new System.Drawing.Size(37, 132);
            this.cliente1.TabIndex = 0;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(99, 169);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(68, 22);
            this.lblCnpj.TabIndex = 102;
            this.lblCnpj.Text = "CNPJ:";
            this.lblCnpj.Visible = false;
            // 
            // mtbcnpj
            // 
            this.mtbcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbcnpj.Location = new System.Drawing.Point(174, 169);
            this.mtbcnpj.Mask = "00.000.000/0000-00";
            this.mtbcnpj.Name = "mtbcnpj";
            this.mtbcnpj.Size = new System.Drawing.Size(199, 26);
            this.mtbcnpj.TabIndex = 101;
            this.mtbcnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbcnpj.Visible = false;
            // 
            // mtbcpf
            // 
            this.mtbcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbcpf.Location = new System.Drawing.Point(173, 168);
            this.mtbcpf.Mask = "000.000.000-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(199, 26);
            this.mtbcpf.TabIndex = 99;
            this.mtbcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(128, 322);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(65, 22);
            this.lblvalor.TabIndex = 97;
            this.lblvalor.Text = "Valor:";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.Location = new System.Drawing.Point(434, 278);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(61, 22);
            this.lblQtde.TabIndex = 95;
            this.lblQtde.Text = "Qtde:";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(90, 244);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(85, 22);
            this.lblProd.TabIndex = 94;
            this.lblProd.Text = "Produto";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(176, 278);
            this.txtcodigo.MaxLength = 20;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(199, 26);
            this.txtcodigo.TabIndex = 92;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(81, 278);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(83, 22);
            this.lblCodigo.TabIndex = 91;
            this.lblCodigo.Text = "Códico:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(109, 169);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(56, 22);
            this.lblCPF.TabIndex = 85;
            this.lblCPF.Text = "CPF:";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblnum.Location = new System.Drawing.Point(187, 62);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(0, 22);
            this.lblnum.TabIndex = 80;
            this.lblnum.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancelar.Location = new System.Drawing.Point(722, 310);
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
            this.btnRemover.Location = new System.Drawing.Point(722, 255);
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
            this.btnAlterar.Location = new System.Drawing.Point(722, 191);
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
            this.btnGravar.Location = new System.Drawing.Point(722, 128);
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
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtvpedido
            // 
            this.dtvpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvpedido.Location = new System.Drawing.Point(63, 431);
            this.dtvpedido.MultiSelect = false;
            this.dtvpedido.Name = "dtvpedido";
            this.dtvpedido.Size = new System.Drawing.Size(453, 151);
            this.dtvpedido.TabIndex = 74;
            this.dtvpedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtvpedido_MouseDoubleClick);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(174, 117);
            this.txtCliente.MaxLength = 60;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(523, 26);
            this.txtCliente.TabIndex = 71;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(90, 117);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(74, 22);
            this.lblCliente.TabIndex = 70;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCodiClie
            // 
            this.lblCodiClie.AutoSize = true;
            this.lblCodiClie.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodiClie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodiClie.Location = new System.Drawing.Point(197, 62);
            this.lblCodiClie.Name = "lblCodiClie";
            this.lblCodiClie.Size = new System.Drawing.Size(0, 22);
            this.lblCodiClie.TabIndex = 67;
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigoCliente.Location = new System.Drawing.Point(86, 62);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(84, 22);
            this.lblCodigoCliente.TabIndex = 66;
            this.lblCodigoCliente.Text = "Código:";
            this.lblCodigoCliente.Visible = false;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPedido.Location = new System.Drawing.Point(338, 12);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(121, 43);
            this.lblPedido.TabIndex = 65;
            this.lblPedido.Text = "Pedido";
            // 
            // txtqtde
            // 
            this.txtqtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtde.Location = new System.Drawing.Point(501, 274);
            this.txtqtde.MaxLength = 20;
            this.txtqtde.Name = "txtqtde";
            this.txtqtde.Size = new System.Drawing.Size(84, 26);
            this.txtqtde.TabIndex = 103;
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(191, 322);
            this.txtvalor.MaxLength = 20;
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(113, 26);
            this.txtvalor.TabIndex = 104;
            // 
            // btninserir
            // 
            this.btninserir.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btninserir.Location = new System.Drawing.Point(95, 377);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(170, 33);
            this.btninserir.TabIndex = 105;
            this.btninserir.Text = "Inserir Pedido";
            this.btninserir.UseVisualStyleBackColor = true;
            // 
            // txttot
            // 
            this.txttot.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttot.Location = new System.Drawing.Point(607, 445);
            this.txttot.MaxLength = 20;
            this.txttot.Name = "txttot";
            this.txttot.Size = new System.Drawing.Size(163, 40);
            this.txttot.TabIndex = 107;
            this.txttot.TextChanged += new System.EventHandler(this.txttot_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(603, 406);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(163, 22);
            this.lblTotal.TabIndex = 106;
            this.lblTotal.Text = "Total da Compra";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFinalizar.Location = new System.Drawing.Point(627, 512);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(124, 50);
            this.btnFinalizar.TabIndex = 108;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txttot);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtqtde);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.mtbcnpj);
            this.Controls.Add(this.mtbcpf);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtvpedido);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCodiClie);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.cliente1);
            this.Name = "Pedido";
            this.Size = new System.Drawing.Size(848, 595);
            ((System.ComponentModel.ISupportInitialize)(this.dtvpedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dtvpedido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txttot_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private Cliente cliente1;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.MaskedTextBox mtbcnpj;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtvpedido;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCodiClie;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.TextBox txtqtde;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.TextBox txttot;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFinalizar;
    }
}
