using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;

namespace pimVI
{
    public partial class Funcion : UserControl
    {
        public Funcion()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void desabilitaCampos()
        {
            lblCodi.Visible = false;
            lblCodigo.Visible = false;
            btnNovo.Enabled = true;
            txtnomef.Enabled = false;
            txtlogin.Enabled = false;
            txtsenha.Enabled = false;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnRemover.Enabled = false;
            btnCancelar.Enabled = false;

        }
        private void habilitaCampos()
        {
            
            txtnomef.Enabled = true;
            txtlogin.Enabled = true;
            txtsenha.Enabled = true;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            txtnomef.Focus();
            txtpesquisa.Text = "";
            dtvFun.DataSource = null;
        }
        private void limparCampos()
        {
            txtnomef.Text = "";
            txtlogin.Clear();
            txtsenha.Clear();
            txtnomef.Focus();
            txtpesquisa.Clear();
            dtvFun.DataSource = null;
            rbativo.Checked = true;
            lblCodigo.Visible = false;
            lblCodi.Visible = false;


        }
        
        private void manipularDados()
        {
            lblCodi.Visible = true;
            lblCodigo.Visible = true;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnGravar.Enabled = false;
            btnRemover.Enabled = true;
            txtnomef.Enabled = true;
            txtlogin.Enabled = true;
            txtsenha.Enabled = true;

        }
       
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void Funcion_Load(object sender, EventArgs e)
        {
            desabilitaCampos();

        }


        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (txtnomef.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo mome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnomef.Focus();
            }
            else if (txtlogin.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogin.Focus();

            }
            else if (txtsenha.Text.Length < 8)
            {
                MessageBox.Show("O campo Senha deve conter no mínimo 8 digitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsenha.Focus();
            }
            else if (rbinativo.Checked)
            {
                MessageBox.Show("Impossível cadastrar um funcionário se o STATUS estiver INATIVO.", "Erro ao Gravar o Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                try
                {
                    string nome = txtnomef.Text;
                    string login = txtlogin.Text;
                    string senha = txtsenha.Text;

                    string strSql = "insert into tbl_Atendente(Login,Senha,nm_atendente,ds_status)values(@login,@senha,@atendente,1)";

                    cm.CommandText = strSql;
                    cm.Connection = cn;
                    

                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@atendente", SqlDbType.VarChar).Value = nome;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Os dados foram gravados com sucessso!!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnomef.Focus();
                    limparCampos();

                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            if(txtpesquisa.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tblAtendente where id_Usuario like('%" + txtpesquisa.Text + "%')";
                    cm.Connection = cn;

                    //Receber Dados de uma tabela
                    SqlDataAdapter da = new SqlDataAdapter();

                    //objeto DataTable pode representar uma ou mais tabelas de dados
                    DataTable dt = new DataTable();

                    //recebndo os dados
                    da.SelectCommand = cm;
                    da.Fill(dt);
                    dtvFun.DataSource = dt;
                    cn.Close();

                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);

                }
            }
            else
            {
                dtvFun.DataSource = null;

            }
        }

        private void CarregaFunc()
        {
            lblCodi.Text = dtvFun.SelectedRows[0].Cells[0].Value.ToString();
            txtlogin.Text = dtvFun.SelectedRows[0].Cells[0].Value.ToString();
            txtsenha.Text = dtvFun.SelectedRows[0].Cells[0].Value.ToString();
            txtnomef.Text = dtvFun.SelectedRows[0].Cells[0].Value.ToString();
            string valor = dtvFun.SelectedRows[0].Cells[0].Value.ToString();

            if(valor == "True")
            {
                rbativo.Checked = true;
            }
            else
            {
                rbinativo.Checked = true;
            }
            
            manipularDados();
        }



        private void dtvFun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaFunc();
            if (rbativo.Checked)
            {
                btnRemover.Enabled = true;
            }
            else
            {
                btnRemover.Enabled = false;
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtnomef.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo mome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnomef.Focus();
            }
            else if (txtlogin.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogin.Focus();

            }
            else if (txtsenha.Text.Length < 8)
            {
                MessageBox.Show("O campo Senha deve conter no mínimo 8 digitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsenha.Focus();
            }
            else if (rbinativo.Checked)
            {
                MessageBox.Show("Para Inativar um funcionário é preciso clicar no botão REMOVER.", "Erro na operação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    string nome = txtnomef.Text;
                    string login = txtlogin.Text;
                    string senha = txtsenha.Text;
                    int cd = Convert.ToInt32 (lblCodi.Text);

                    string strSql = "update tbl_Atendente set login = @login,senha=@senha,nm_atendente=@atendente,ds_status=1 where  id_Usuario=@cd";

                    cm.CommandText = strSql;
                    cm.Connection = cn;


                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@atendente", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Os dados foram alterados com sucessso!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnomef.Focus();
                    limparCampos();

                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtnomef.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo mome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnomef.Focus();
            }
            else if (txtlogin.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogin.Focus();

            }
            else if (txtsenha.Text.Length < 8)
            {
                MessageBox.Show("O campo Senha deve conter no mínimo 8 digitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsenha.Focus();
            }
            else if (rbativo.Checked)
            {
                MessageBox.Show("Para remover o registro deverá alterar o status para INATIVO.", "Erro ao tentar excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult exclusao = MessageBox.Show("Você tem certeza que deseja remover esse registro?", "Exclusão de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (exclusao == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        int cd = Convert.ToInt32(lblCodi.Text);
                        cn.Open();
                        string strSql = "update tblAtendente set ds_status = 0 where id_Usuario= @cd";
                        cm.Connection = cn;
                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show("Os dados foram alterados com sucessso!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtnomef.Focus();
                        limparCampos();

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cn.Close();

                    }
                    finally
                    {
                        cn.Close();
                    }
                }
                        
            }

        }

        
    }
}     

