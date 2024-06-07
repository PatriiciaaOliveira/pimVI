namespace pimVI
{
    partial class Cliente
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
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtvCliente = new System.Windows.Forms.DataGridView();
            this.gbpesquisaCliente = new System.Windows.Forms.GroupBox();
            this.txtpesquisaClie = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnomeCli = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblCodiClie = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblpessoa = new System.Windows.Forms.Label();
            this.txtlograd = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.lblComple = new System.Windows.Forms.Label();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbcep = new System.Windows.Forms.MaskedTextBox();
            this.mtbcnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.cbpessoa = new System.Windows.Forms.ComboBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCliente)).BeginInit();
            this.gbpesquisaCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbinativo.Location = new System.Drawing.Point(595, 62);
            this.rbinativo.Name = "rbinativo";
            this.rbinativo.Size = new System.Drawing.Size(71, 20);
            this.rbinativo.TabIndex = 39;
            this.rbinativo.Text = "Inativo";
            this.rbinativo.UseVisualStyleBackColor = true;
            // 
            // rbativo
            // 
            this.rbativo.AutoSize = true;
            this.rbativo.Checked = true;
            this.rbativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbativo.Location = new System.Drawing.Point(529, 62);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(60, 20);
            this.rbativo.TabIndex = 38;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(421, 59);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(76, 22);
            this.lblstatus.TabIndex = 37;
            this.lblstatus.Text = "Status:";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblnum.Location = new System.Drawing.Point(168, 62);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(0, 22);
            this.lblnum.TabIndex = 36;
            this.lblnum.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancelar.Location = new System.Drawing.Point(703, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 45);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRemover.Location = new System.Drawing.Point(703, 322);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(102, 45);
            this.btnRemover.TabIndex = 34;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAlterar.Location = new System.Drawing.Point(703, 244);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(102, 45);
            this.btnAlterar.TabIndex = 33;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGravar.Location = new System.Drawing.Point(703, 158);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(102, 45);
            this.btnGravar.TabIndex = 32;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNovo.Location = new System.Drawing.Point(703, 62);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 45);
            this.btnNovo.TabIndex = 31;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dtvCliente
            // 
            this.dtvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCliente.Location = new System.Drawing.Point(44, 431);
            this.dtvCliente.MultiSelect = false;
            this.dtvCliente.Name = "dtvCliente";
            this.dtvCliente.Size = new System.Drawing.Size(622, 151);
            this.dtvCliente.TabIndex = 30;
            this.dtvCliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtvCliente_MouseDoubleClick);
            // 
            // gbpesquisaCliente
            // 
            this.gbpesquisaCliente.Controls.Add(this.txtpesquisaClie);
            this.gbpesquisaCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpesquisaCliente.Location = new System.Drawing.Point(63, 380);
            this.gbpesquisaCliente.Name = "gbpesquisaCliente";
            this.gbpesquisaCliente.Size = new System.Drawing.Size(603, 45);
            this.gbpesquisaCliente.TabIndex = 29;
            this.gbpesquisaCliente.TabStop = false;
            this.gbpesquisaCliente.Text = "Pesquisa por Cliente";
            // 
            // txtpesquisaClie
            // 
            this.txtpesquisaClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisaClie.Location = new System.Drawing.Point(92, 19);
            this.txtpesquisaClie.MaxLength = 60;
            this.txtpesquisaClie.Name = "txtpesquisaClie";
            this.txtpesquisaClie.Size = new System.Drawing.Size(505, 26);
            this.txtpesquisaClie.TabIndex = 7;
            this.txtpesquisaClie.TextChanged += new System.EventHandler(this.txtpesquisaClie_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(155, 149);
            this.txtemail.MaxLength = 60;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(235, 26);
            this.txtemail.TabIndex = 28;
            // 
            // txtnomeCli
            // 
            this.txtnomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeCli.Location = new System.Drawing.Point(155, 117);
            this.txtnomeCli.MaxLength = 60;
            this.txtnomeCli.Name = "txtnomeCli";
            this.txtnomeCli.Size = new System.Drawing.Size(523, 26);
            this.txtnomeCli.TabIndex = 26;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(71, 117);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(70, 22);
            this.lblNomeCliente.TabIndex = 25;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(426, 150);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(45, 22);
            this.lblTel.TabIndex = 24;
            this.lblTel.Text = "Tel:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(71, 153);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(74, 22);
            this.lblemail.TabIndex = 23;
            this.lblemail.Text = "E-mail:";
            // 
            // lblCodiClie
            // 
            this.lblCodiClie.AutoSize = true;
            this.lblCodiClie.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodiClie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodiClie.Location = new System.Drawing.Point(178, 62);
            this.lblCodiClie.Name = "lblCodiClie";
            this.lblCodiClie.Size = new System.Drawing.Size(0, 22);
            this.lblCodiClie.TabIndex = 22;
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigoCliente.Location = new System.Drawing.Point(67, 62);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(84, 22);
            this.lblCodigoCliente.TabIndex = 21;
            this.lblCodigoCliente.Text = "Código:";
            this.lblCodigoCliente.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCliente.Location = new System.Drawing.Point(319, 12);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(120, 43);
            this.lblCliente.TabIndex = 20;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(415, 185);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(56, 22);
            this.lblCPF.TabIndex = 41;
            this.lblCPF.Text = "CPF:";
            // 
            // lblpessoa
            // 
            this.lblpessoa.AutoSize = true;
            this.lblpessoa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpessoa.Location = new System.Drawing.Point(63, 184);
            this.lblpessoa.Name = "lblpessoa";
            this.lblpessoa.Size = new System.Drawing.Size(86, 22);
            this.lblpessoa.TabIndex = 40;
            this.lblpessoa.Text = "Pessoa:";
            // 
            // txtlograd
            // 
            this.txtlograd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlograd.Location = new System.Drawing.Point(155, 214);
            this.txtlograd.MaxLength = 60;
            this.txtlograd.Name = "txtlograd";
            this.txtlograd.Size = new System.Drawing.Size(235, 26);
            this.txtlograd.TabIndex = 47;
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(479, 213);
            this.txtnumero.MaxLength = 5;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(199, 26);
            this.txtnumero.TabIndex = 46;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(434, 214);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(37, 22);
            this.lblnumero.TabIndex = 45;
            this.lblnumero.Text = "Nº:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(21, 215);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(128, 22);
            this.lblLogradouro.TabIndex = 44;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // txtcomp
            // 
            this.txtcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomp.Location = new System.Drawing.Point(155, 244);
            this.txtcomp.MaxLength = 20;
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(235, 26);
            this.txtcomp.TabIndex = 51;
            // 
            // txtbairro
            // 
            this.txtbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbairro.Location = new System.Drawing.Point(479, 245);
            this.txtbairro.MaxLength = 20;
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(199, 26);
            this.txtbairro.TabIndex = 50;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbairro.Location = new System.Drawing.Point(398, 246);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(75, 22);
            this.lblbairro.TabIndex = 49;
            this.lblbairro.Text = "Bairro:";
            // 
            // lblComple
            // 
            this.lblComple.AutoSize = true;
            this.lblComple.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComple.Location = new System.Drawing.Point(5, 249);
            this.lblComple.Name = "lblComple";
            this.lblComple.Size = new System.Drawing.Size(146, 22);
            this.lblComple.TabIndex = 48;
            this.lblComple.Text = "Complemento:";
            // 
            // txtcid
            // 
            this.txtcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.Location = new System.Drawing.Point(155, 276);
            this.txtcid.MaxLength = 20;
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(235, 26);
            this.txtcid.TabIndex = 55;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(415, 278);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(57, 22);
            this.lblCEP.TabIndex = 53;
            this.lblCEP.Text = "CEP:";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCid.Location = new System.Drawing.Point(71, 278);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(82, 22);
            this.lblCid.TabIndex = 52;
            this.lblCid.Text = "Cidade:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(109, 322);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(42, 22);
            this.lblUF.TabIndex = 56;
            this.lblUF.Text = "UF:";
            // 
            // mtbTel
            // 
            this.mtbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTel.Location = new System.Drawing.Point(478, 153);
            this.mtbTel.Mask = "(00)00000-0000";
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(201, 26);
            this.mtbTel.TabIndex = 58;
            this.mtbTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbcpf
            // 
            this.mtbcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbcpf.Location = new System.Drawing.Point(479, 184);
            this.mtbcpf.Mask = "000.000.000-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(199, 26);
            this.mtbcpf.TabIndex = 59;
            this.mtbcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbcep
            // 
            this.mtbcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbcep.Location = new System.Drawing.Point(479, 282);
            this.mtbcep.Mask = "00000-000";
            this.mtbcep.Name = "mtbcep";
            this.mtbcep.Size = new System.Drawing.Size(199, 26);
            this.mtbcep.TabIndex = 60;
            this.mtbcep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbcnpj
            // 
            this.mtbcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbcnpj.Location = new System.Drawing.Point(480, 185);
            this.mtbcnpj.Mask = "00.000.000/0000-00";
            this.mtbcnpj.Name = "mtbcnpj";
            this.mtbcnpj.Size = new System.Drawing.Size(199, 26);
            this.mtbcnpj.TabIndex = 61;
            this.mtbcnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbcnpj.Visible = false;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(405, 185);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(68, 22);
            this.lblCnpj.TabIndex = 62;
            this.lblCnpj.Text = "CNPJ:";
            this.lblCnpj.Visible = false;
            // 
            // cbpessoa
            // 
            this.cbpessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpessoa.FormattingEnabled = true;
            this.cbpessoa.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cbpessoa.Location = new System.Drawing.Point(155, 181);
            this.cbpessoa.Name = "cbpessoa";
            this.cbpessoa.Size = new System.Drawing.Size(235, 28);
            this.cbpessoa.TabIndex = 63;
            this.cbpessoa.SelectedIndexChanged += new System.EventHandler(this.cbpessoa_SelectedIndexChanged);
            // 
            // cbUF
            // 
            this.cbUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "PR",
            "MG"});
            this.cbUF.Location = new System.Drawing.Point(157, 316);
            this.cbUF.MaxLength = 2;
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(85, 28);
            this.cbUF.TabIndex = 64;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.cbpessoa);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.mtbcnpj);
            this.Controls.Add(this.mtbcep);
            this.Controls.Add(this.mtbcpf);
            this.Controls.Add(this.mtbTel);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblCid);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.lblComple);
            this.Controls.Add(this.txtlograd);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblpessoa);
            this.Controls.Add(this.rbinativo);
            this.Controls.Add(this.rbativo);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtvCliente);
            this.Controls.Add(this.gbpesquisaCliente);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnomeCli);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblCodiClie);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.lblCliente);
            this.Name = "Cliente";
            this.Size = new System.Drawing.Size(848, 595);
            ((System.ComponentModel.ISupportInitialize)(this.dtvCliente)).EndInit();
            this.gbpesquisaCliente.ResumeLayout(false);
            this.gbpesquisaCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbinativo;
        private System.Windows.Forms.RadioButton rbativo;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtvCliente;
        private System.Windows.Forms.GroupBox gbpesquisaCliente;
        private System.Windows.Forms.TextBox txtpesquisaClie;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnomeCli;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblCodiClie;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblpessoa;
        private System.Windows.Forms.TextBox txtlograd;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblComple;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.MaskedTextBox mtbcep;
        private System.Windows.Forms.MaskedTextBox mtbcnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.ComboBox cbpessoa;
        private System.Windows.Forms.ComboBox cbUF;
    }
}
