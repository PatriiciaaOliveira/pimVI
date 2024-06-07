using System;

namespace pimVI
{
    partial class Funcion
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
            this.lblFuncionar = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodi = new System.Windows.Forms.Label();
            this.lblNomefun = new System.Windows.Forms.Label();
            this.lblSenhaa = new System.Windows.Forms.Label();
            this.lblNomef = new System.Windows.Forms.Label();
            this.txtnomef = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.gbpesquisa = new System.Windows.Forms.GroupBox();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.dtvFun = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.gbpesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvFun)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncionar
            // 
            this.lblFuncionar.AutoSize = true;
            this.lblFuncionar.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFuncionar.Location = new System.Drawing.Point(291, 42);
            this.lblFuncionar.Name = "lblFuncionar";
            this.lblFuncionar.Size = new System.Drawing.Size(195, 43);
            this.lblFuncionar.TabIndex = 0;
            this.lblFuncionar.Text = "Funcionário";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigo.Location = new System.Drawing.Point(61, 97);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(84, 22);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Visible = false;
            this.lblCodigo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCodi
            // 
            this.lblCodi.AutoSize = true;
            this.lblCodi.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodi.Location = new System.Drawing.Point(151, 97);
            this.lblCodi.Name = "lblCodi";
            this.lblCodi.Size = new System.Drawing.Size(0, 22);
            this.lblCodi.TabIndex = 2;
            // 
            // lblNomefun
            // 
            this.lblNomefun.AutoSize = true;
            this.lblNomefun.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomefun.Location = new System.Drawing.Point(81, 166);
            this.lblNomefun.Name = "lblNomefun";
            this.lblNomefun.Size = new System.Drawing.Size(70, 22);
            this.lblNomefun.TabIndex = 3;
            this.lblNomefun.Text = "Login:";
            // 
            // lblSenhaa
            // 
            this.lblSenhaa.AutoSize = true;
            this.lblSenhaa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaa.Location = new System.Drawing.Point(436, 171);
            this.lblSenhaa.Name = "lblSenhaa";
            this.lblSenhaa.Size = new System.Drawing.Size(76, 22);
            this.lblSenhaa.TabIndex = 4;
            this.lblSenhaa.Text = "Senha:";
            // 
            // lblNomef
            // 
            this.lblNomef.AutoSize = true;
            this.lblNomef.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomef.Location = new System.Drawing.Point(81, 133);
            this.lblNomef.Name = "lblNomef";
            this.lblNomef.Size = new System.Drawing.Size(70, 22);
            this.lblNomef.TabIndex = 5;
            this.lblNomef.Text = "Nome:";
            // 
            // txtnomef
            // 
            this.txtnomef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomef.Location = new System.Drawing.Point(174, 129);
            this.txtnomef.MaxLength = 60;
            this.txtnomef.Name = "txtnomef";
            this.txtnomef.Size = new System.Drawing.Size(438, 26);
            this.txtnomef.TabIndex = 6;
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(509, 170);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(169, 26);
            this.txtsenha.TabIndex = 7;
            // 
            // txtlogin
            // 
            this.txtlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.Location = new System.Drawing.Point(174, 170);
            this.txtlogin.MaxLength = 20;
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(256, 26);
            this.txtlogin.TabIndex = 8;
            // 
            // gbpesquisa
            // 
            this.gbpesquisa.Controls.Add(this.txtpesquisa);
            this.gbpesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpesquisa.Location = new System.Drawing.Point(44, 256);
            this.gbpesquisa.Name = "gbpesquisa";
            this.gbpesquisa.Size = new System.Drawing.Size(622, 67);
            this.gbpesquisa.TabIndex = 9;
            this.gbpesquisa.TabStop = false;
            this.gbpesquisa.Text = "Pesquisa por Funcionário";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.Location = new System.Drawing.Point(139, 28);
            this.txtpesquisa.MaxLength = 60;
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(438, 26);
            this.txtpesquisa.TabIndex = 7;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // dtvFun
            // 
            this.dtvFun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvFun.Location = new System.Drawing.Point(44, 373);
            this.dtvFun.MultiSelect = false;
            this.dtvFun.Name = "dtvFun";
            this.dtvFun.Size = new System.Drawing.Size(622, 203);
            this.dtvFun.TabIndex = 10;
            this.dtvFun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvFun_CellContentClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNovo.Location = new System.Drawing.Point(703, 74);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 45);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGravar.Location = new System.Drawing.Point(703, 170);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(102, 45);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAlterar.Location = new System.Drawing.Point(703, 256);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(102, 45);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRemover.Location = new System.Drawing.Point(703, 334);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(102, 45);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancelar.Location = new System.Drawing.Point(703, 407);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 45);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblnum.Location = new System.Drawing.Point(141, 97);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(0, 22);
            this.lblnum.TabIndex = 16;
            this.lblnum.Visible = false;
            this.lblnum.Click += new System.EventHandler(this.lblnum_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(75, 216);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(76, 22);
            this.lblstatus.TabIndex = 17;
            this.lblstatus.Text = "Status:";
            // 
            // rbativo
            // 
            this.rbativo.AutoSize = true;
            this.rbativo.Checked = true;
            this.rbativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbativo.Location = new System.Drawing.Point(183, 219);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(60, 20);
            this.rbativo.TabIndex = 18;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbinativo.Location = new System.Drawing.Point(249, 219);
            this.rbinativo.Name = "rbinativo";
            this.rbinativo.Size = new System.Drawing.Size(71, 20);
            this.rbinativo.TabIndex = 19;
            this.rbinativo.Text = "Inativo";
            this.rbinativo.UseVisualStyleBackColor = true;
            // 
            // Funcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbinativo);
            this.Controls.Add(this.rbativo);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtvFun);
            this.Controls.Add(this.gbpesquisa);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtnomef);
            this.Controls.Add(this.lblNomef);
            this.Controls.Add(this.lblSenhaa);
            this.Controls.Add(this.lblNomefun);
            this.Controls.Add(this.lblCodi);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblFuncionar);
            this.Name = "Funcion";
            this.Size = new System.Drawing.Size(848, 595);
            this.Load += new System.EventHandler(this.Funcion_Load);
            this.gbpesquisa.ResumeLayout(false);
            this.gbpesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvFun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblnum_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NewMethod() => this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblFuncionar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodi;
        private System.Windows.Forms.Label lblNomefun;
        private System.Windows.Forms.Label lblSenhaa;
        private System.Windows.Forms.Label lblNomef;
        private System.Windows.Forms.TextBox txtnomef;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.GroupBox gbpesquisa;
        private System.Windows.Forms.DataGridView dtvFun;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.RadioButton rbativo;
        private System.Windows.Forms.RadioButton rbinativo;
    }
}
