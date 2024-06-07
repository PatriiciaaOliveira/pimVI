using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pimVI
{
    public partial class Cliente : UserControl
    {
        public Cliente()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private object nome;
        private object email;
        private object cpf;
        private object cnpj;
        private object status;
        private object pessoa;

        private void desabilitaCampos()
        {

            lblCodiClie.Visible = false;
            lblCodigoCliente.Visible = false;
            btnNovo.Enabled = true;
            txtnomeCli.Enabled = false;
            txtemail.Enabled = false;
            mtbTel.Enabled = false;
            cbpessoa.Enabled = false;
            mtbcep.Enabled = false;
            txtlograd.Enabled = false;
            txtnumero.Enabled = false;
            txtcomp.Enabled = false;
            txtbairro.Enabled = false;
            txtcid.Enabled = false;
            mtbcpf.Enabled = false;
            cbUF.Enabled = false;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = false;
            btnRemover.Enabled = false;
            btnCancelar.Enabled = false;
            lblCnpj.Visible = false;
            mtbcnpj.Visible = false;

        }

        private void habilitaCampos()
        {
            lblCodiClie.Visible = false;
            lblCodigoCliente.Visible = false;
            btnNovo.Enabled = false;
            txtnomeCli.Enabled = true;
            txtemail.Enabled = true;
            mtbTel.Enabled = true;
            cbpessoa.Enabled = true;
            mtbcep.Enabled = false;
            txtlograd.Enabled = true;
            txtnumero.Enabled = true;
            txtcomp.Enabled = true;
            txtbairro.Enabled = true;
            txtcid.Enabled = true;
            mtbcpf.Enabled = true;
            mtbcnpj.Enabled = true;
            cbUF.Enabled = true;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAlterar.Enabled = false;
            btnRemover.Enabled = false;
            btnCancelar.Enabled = true;
            lblCnpj.Visible = false;
            mtbcnpj.Visible = false;


        }

        private void limparCampos()
        {
            txtnomeCli.Clear();
            txtemail.Clear();
            mtbTel.Clear();
            txtlograd.Clear();
            txtnumero.Clear();
            txtcomp.Clear();
            txtbairro.Clear();
            txtcid.Clear();
            mtbcpf.Clear();
            cbpessoa.SelectedIndex = -1;
            cbUF.SelectedIndex = -1;
            txtpesquisaClie.Clear();
            dtvCliente.DataSource = null;
            rbativo.Checked = true;
            lblCodigoCliente.Visible = false;
            lblCodiClie.Visible = false;


        }
        private void manipularDados()
        {
            lblCodigoCliente.Visible = true;
            lblCodiClie.Visible = true;
            txtnomeCli.Enabled = true;
            txtemail.Enabled = true;
            mtbTel.Enabled = true;
            cbpessoa.Enabled = true;
            mtbcpf.Enabled = true;
            mtbcnpj.Enabled = true;
            txtlograd.Enabled = true;
            txtnumero.Enabled = true;
            txtcomp.Enabled = true;
            txtbairro.Enabled = true;
            txtcid.Enabled = true;
            mtbcep.Enabled = true;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnGravar.Enabled = false;
            btnRemover.Enabled = true;
            
        }

        private void cbpessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbpessoa.SelectedIndex == -1) //se não houver nada selecionado
            {
                lblCnpj.Visible = false;
                mtbcnpj.Visible = false;
            }
            else if (cbpessoa.SelectedIndex == 0) //se estiver selecionado Físico
            {
                lblCnpj.Visible = false;
                mtbcnpj.Visible = false;
            }
            else
            {
                lblCnpj.Visible = true;
                mtbcnpj.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitaCampos();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (rbinativo.Checked)
            {
                MessageBox.Show("Para inserir um cliente precisa marcar o botão ativo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rbativo.Checked = true;
            }
            else if (txtnomeCli.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnomeCli.Focus();
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo E-mail", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.Focus();
            }
            else if (mtbTel.Text.Length < 11)
            {
                MessageBox.Show("Obrigatório preencher o campo telefone válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbTel.Focus();
            }
            else if (cbpessoa.SelectedIndex == -1)
            {
                MessageBox.Show("Obrigatório informar o tipo de pessoa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (cbpessoa.SelectedIndex == 0 && mtbcpf.Text.Length < 11)
            {

                MessageBox.Show("Obrigatório informar o cpf válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbcpf.Focus();
            }
            else if (cbpessoa.SelectedIndex == 1 && mtbcnpj.Text.Length < 14)
            {
                MessageBox.Show("Obrigatório informar o cnpj válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbcnpj.Focus();
            }

            else if (txtlograd.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Logradouro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlograd.Focus();
            }
            else if (txtnumero.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo número", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnumero.Focus();
            }
            else if (txtbairro.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo bairro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbairro.Focus();
            }
            else if (txtcid.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcid.Focus();
            }
            else if (mtbcep.Text.Length < 8)
            {
                MessageBox.Show("Obrigatório informar o campo cep", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbcep.Focus();
            }
            else if (cbUF.SelectedIndex == -1)
            {
                MessageBox.Show("Obrigatório informar o campo Estado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
            string nome = txtnomeCli.Text;
            string email = txtemail.Text;
            string telefone = mtbTel.Text;
            string cpf;
            string cnpj;
            string pessoa;
                if (cbpessoa.SelectedIndex == 0)
                {
                    pessoa = "F";
                    cpf = mtbcnpj.Text;
                    cnpj = "";

                }
                else
                {
                    pessoa = "J";
                    cnpj = mtbcnpj.Text;
                    cpf = "";

                }



            }
            string logradouro = txtlograd.Text;
            string numero = txtnumero.Text;
            string complemento = txtcomp.Text;
            string bairro = txtbairro.Text;
            string cidade = txtcid.Text;
            string cep = mtbcep.Text;
            string uf = cbUF.Text;

            try
            {
                string strSql = "insert into tbl_CLIENTESS(nm_Cliente,Email,no_CPF,no_CNPJ,nm_Logradouro,no_Logradouro,Compremento,nm_Bairro,nm_Cidade,sg_UF,no_Cep,ds_status,ds_pessoa)values(@nm_Cliente,@Email,@no_CPF,@no_CNPJ,@nm_Logradouro,@no_Logradouro,@Compremento,@nm_Bairro,@nm_Cidade,@sg_UF,@no_Cep,@ds_status,@ds_pessoa) set @cd = SCOPE_IDENTITY()";
                cm.CommandText = strSql;
                cm.Connection = cn;


                cm.Parameters.Add("@nm_Cliente", SqlDbType.VarChar).Value = nome;
                cm.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                cm.Parameters.Add("@no_CPF", SqlDbType.VarChar).Value = cpf;
                cm.Parameters.Add("@no_CNPJ", SqlDbType.VarChar).Value = cnpj;
                cm.Parameters.Add("@nm_Logradouro", SqlDbType.VarChar).Value = logradouro;
                cm.Parameters.Add("@no_Logradouro", SqlDbType.VarChar).Value = numero;
                cm.Parameters.Add("@Compremento", SqlDbType.VarChar).Value = complemento;
                cm.Parameters.Add("@nm_Bairro", SqlDbType.VarChar).Value = bairro;
                cm.Parameters.Add("@nm_Cidade", SqlDbType.VarChar).Value = cidade;
                cm.Parameters.Add("@sg_UF", SqlDbType.VarChar).Value = uf;
                cm.Parameters.Add("@no_Cep", SqlDbType.VarChar).Value = cep;
                cm.Parameters.Add("@ds_status", SqlDbType.VarChar).Value = status;
                cm.Parameters.Add("@ds_pessoa", SqlDbType.VarChar).Value = pessoa;

                cm.Parameters.AddWithValue("@cd", 0).Direction = ParameterDirection.Output;
                cn.Open();
                cm.ExecuteNonQuery();
                

                int cd = Convert.ToInt32(cm.Parameters["@cd"].Value);
                string celular = mtbTel.Text;

                cm.CommandText = "insert into tbl_telefone(cd_cliente, no_Telefone)values('" + cd + "', '" + celular + "')";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cm.Parameters.Clear();

                MessageBox.Show("Os dados do cliente foram inseridos com sucesso!!", "Inserção de dados");
                limparCampos();
                cn.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                cn.Close();
            }


        }

        private void txtpesquisaClie_TextChanged(object sender, EventArgs e)
        {
            if(txtpesquisaClie.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from vwConsCli where nm_Cliente like('" + txtpesquisaClie.Text + "%')";
                    cm.Connection = cn;

                    //Receber Dados de uma tabela
                    SqlDataAdapter da = new SqlDataAdapter();

                    //objeto DataTable pode representar uma ou mais tabelas de dados
                    DataTable dt = new DataTable();

                    //recebndo os dados
                    da.SelectCommand = cm;
                    da.Fill(dt);
                    dtvCliente.DataSource = dt;
                    cn.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);

                }
            }
            else
            {
                dtvCliente.DataSource = null;

            }
            
        }
        private void carregaDados()
        {
            manipularDados();//metodo para manipular o objeto

            lblCodiClie.Text = dtvCliente.SelectedRows[0].Cells[0].Value.ToString();
            txtnomeCli.Text = dtvCliente.SelectedRows[0].Cells[1].Value.ToString();
            txtemail.Text = dtvCliente.SelectedRows[0].Cells[2].Value.ToString();
            mtbTel.Text = dtvCliente.SelectedRows[0].Cells[14].Value.ToString();
            string pessoa = dtvCliente.SelectedRows[0].Cells[13].Value.ToString();

            if (pessoa == "F")
            {
                cbpessoa.SelectedIndex = 0;
            }

            else
            {
                cbpessoa.SelectedIndex = 1;
            }
            mtbcpf.Text = dtvCliente.SelectedRows[0].Cells[3].Value.ToString();
            mtbcnpj.Text = dtvCliente.SelectedRows[0].Cells[4].Value.ToString();
            txtlograd.Text = dtvCliente.SelectedRows[0].Cells[5].Value.ToString();
            txtnumero.Text = dtvCliente.SelectedRows[0].Cells[6].Value.ToString();
            txtcomp.Text = dtvCliente.SelectedRows[0].Cells[7].Value.ToString();
            txtbairro.Text = dtvCliente.SelectedRows[0].Cells[8].Value.ToString();
            txtcid.Text = dtvCliente.SelectedRows[0].Cells[9].Value.ToString();
            string uf = dtvCliente.SelectedRows[0].Cells[10].Value.ToString();
            if (uf == "SP")
            {
                cbUF.SelectedIndex = 0;
            }
            else if (uf == "RJ")
            {
                cbUF.SelectedIndex = 1;
            }
            else if (uf == "PR")
            {
                cbUF.SelectedIndex = 2;
            }
            else if (uf == "MG")
            {
                cbUF.SelectedIndex = 3;
            }
            else
            {
                cbUF.SelectedIndex = 4;
            }
            mtbcep.Text = dtvCliente.SelectedRows[0].Cells[11].Value.ToString();
        }

            private void dtvCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaDados();
        }
    }
}   



