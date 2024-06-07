namespace pimVI
{
    partial class frm_Principal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnestoque = new System.Windows.Forms.Button();
            this.btnprodutos = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnFuncio = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.estoque1 = new pimVI.Estoque();
            this.relatorio1 = new pimVI.Relatorio();
            this.caixa1 = new pimVI.Caixa();
            this.pedido1 = new pimVI.Pedido();
            this.produto1 = new pimVI.Produto();
            this.cliente1 = new pimVI.Cliente();
            this.funcion1 = new pimVI.Funcion();
            this.principal1 = new pimVI.Principal();
            this.principal2 = new pimVI.Principal();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnestoque);
            this.panel2.Controls.Add(this.btnprodutos);
            this.panel2.Controls.Add(this.btnSaida);
            this.panel2.Controls.Add(this.btnRelatorio);
            this.panel2.Controls.Add(this.btnPedidos);
            this.panel2.Controls.Add(this.btnFuncio);
            this.panel2.Controls.Add(this.btnCaixa);
            this.panel2.Controls.Add(this.btnCliente);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(128)))), ((int)(((byte)(136)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 600);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnestoque
            // 
            this.btnestoque.BackColor = System.Drawing.Color.White;
            this.btnestoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestoque.ForeColor = System.Drawing.Color.Black;
            this.btnestoque.Location = new System.Drawing.Point(25, 460);
            this.btnestoque.Name = "btnestoque";
            this.btnestoque.Size = new System.Drawing.Size(151, 48);
            this.btnestoque.TabIndex = 8;
            this.btnestoque.Text = "ESTOQUE";
            this.btnestoque.UseVisualStyleBackColor = false;
            this.btnestoque.Click += new System.EventHandler(this.btnestoque_Click);
            // 
            // btnprodutos
            // 
            this.btnprodutos.BackColor = System.Drawing.Color.White;
            this.btnprodutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprodutos.ForeColor = System.Drawing.Color.Black;
            this.btnprodutos.Location = new System.Drawing.Point(25, 173);
            this.btnprodutos.Name = "btnprodutos";
            this.btnprodutos.Size = new System.Drawing.Size(151, 48);
            this.btnprodutos.TabIndex = 7;
            this.btnprodutos.Text = "PRODUTOS";
            this.btnprodutos.UseVisualStyleBackColor = false;
            this.btnprodutos.Click += new System.EventHandler(this.btnprodutos_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.BackColor = System.Drawing.Color.White;
            this.btnSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.ForeColor = System.Drawing.Color.Black;
            this.btnSaida.Location = new System.Drawing.Point(25, 525);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(151, 48);
            this.btnSaida.TabIndex = 6;
            this.btnSaida.Text = "SAIDA";
            this.btnSaida.UseVisualStyleBackColor = false;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.White;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.Black;
            this.btnRelatorio.Location = new System.Drawing.Point(25, 395);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(151, 48);
            this.btnRelatorio.TabIndex = 5;
            this.btnRelatorio.Text = "RELATORIO";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.White;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.Black;
            this.btnPedidos.Location = new System.Drawing.Point(25, 247);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(151, 48);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Text = "PEDIDO";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnFuncio
            // 
            this.btnFuncio.BackColor = System.Drawing.Color.White;
            this.btnFuncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncio.ForeColor = System.Drawing.Color.Black;
            this.btnFuncio.Location = new System.Drawing.Point(25, 30);
            this.btnFuncio.Name = "btnFuncio";
            this.btnFuncio.Size = new System.Drawing.Size(151, 48);
            this.btnFuncio.TabIndex = 3;
            this.btnFuncio.Text = "FUNCIONARIO";
            this.btnFuncio.UseVisualStyleBackColor = false;
            this.btnFuncio.Click += new System.EventHandler(this.btnFuncio_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.White;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.Black;
            this.btnCaixa.Location = new System.Drawing.Point(25, 320);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(151, 48);
            this.btnCaixa.TabIndex = 2;
            this.btnCaixa.Text = "CAIXA";
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.White;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCliente.Location = new System.Drawing.Point(25, 98);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(151, 48);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // estoque1
            // 
            this.estoque1.Location = new System.Drawing.Point(217, 0);
            this.estoque1.Name = "estoque1";
            this.estoque1.Size = new System.Drawing.Size(848, 595);
            this.estoque1.TabIndex = 10;
            // 
            // relatorio1
            // 
            this.relatorio1.Location = new System.Drawing.Point(217, 1);
            this.relatorio1.Name = "relatorio1";
            this.relatorio1.Size = new System.Drawing.Size(848, 595);
            this.relatorio1.TabIndex = 9;
            // 
            // caixa1
            // 
            this.caixa1.Location = new System.Drawing.Point(217, 0);
            this.caixa1.Name = "caixa1";
            this.caixa1.Size = new System.Drawing.Size(848, 595);
            this.caixa1.TabIndex = 8;
            // 
            // pedido1
            // 
            this.pedido1.Location = new System.Drawing.Point(217, 0);
            this.pedido1.Name = "pedido1";
            this.pedido1.Size = new System.Drawing.Size(848, 595);
            this.pedido1.TabIndex = 7;
            // 
            // produto1
            // 
            this.produto1.Location = new System.Drawing.Point(217, 0);
            this.produto1.Name = "produto1";
            this.produto1.Size = new System.Drawing.Size(848, 595);
            this.produto1.TabIndex = 6;
            // 
            // cliente1
            // 
            this.cliente1.Location = new System.Drawing.Point(217, 1);
            this.cliente1.Name = "cliente1";
            this.cliente1.Size = new System.Drawing.Size(848, 595);
            this.cliente1.TabIndex = 5;
            // 
            // funcion1
            // 
            this.funcion1.Location = new System.Drawing.Point(217, 1);
            this.funcion1.Name = "funcion1";
            this.funcion1.Size = new System.Drawing.Size(848, 595);
            this.funcion1.TabIndex = 4;
            // 
            // principal1
            // 
            this.principal1.Location = new System.Drawing.Point(217, 0);
            this.principal1.Name = "principal1";
            this.principal1.Size = new System.Drawing.Size(848, 595);
            this.principal1.TabIndex = 3;
            // 
            // principal2
            // 
            this.principal2.Location = new System.Drawing.Point(217, 0);
            this.principal2.Name = "principal2";
            this.principal2.Size = new System.Drawing.Size(848, 595);
            this.principal2.TabIndex = 11;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 595);
            this.Controls.Add(this.principal2);
            this.Controls.Add(this.estoque1);
            this.Controls.Add(this.relatorio1);
            this.Controls.Add(this.caixa1);
            this.Controls.Add(this.pedido1);
            this.Controls.Add(this.produto1);
            this.Controls.Add(this.cliente1);
            this.Controls.Add(this.funcion1);
            this.Controls.Add(this.principal1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnFuncio;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnprodutos;
        private System.Windows.Forms.Button btnestoque;
        private Principal principal1;
        private Funcion funcion1;
        private Cliente cliente1;
        private Produto produto1;
        private Pedido pedido1;
        private Caixa caixa1;
        private Relatorio relatorio1;
        private Estoque estoque1;
        private Principal principal2;
    }
}