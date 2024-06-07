using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pimVI
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        // Estabelecendo conexão com o banco de dados SQL Server
        public static string usuario;
        public static string codUsuario;

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True");
        SqlCommand cm = new SqlCommand();

        private void BtnSair_Click(object sender, EventArgs e)
        {
            // Fecha o aplicativo
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbLogin.Text) || string.IsNullOrEmpty(txbSenha.Text))
            {
                MessageBox.Show("Obrigatório preencher os campos login e senha", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "SELECT * FROM tblAtendente WHERE Login = @Login AND Senha = @Senha AND ds_status = 1";
                    cm.Connection = cn;
                    cm.Parameters.Clear();
                    cm.Parameters.AddWithValue("@Login", txbLogin.Text);
                    cm.Parameters.AddWithValue("@Senha", txbSenha.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        usuario = dt.Rows[0]["Login"].ToString();
                        codUsuario = dt.Rows[0]["nm_atendente"].ToString();
                        frm_Principal menu = new frm_Principal();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha inválido!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbLogin.Clear();
                        txbSenha.Clear();
                        txbLogin.Focus();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}