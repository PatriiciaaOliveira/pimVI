using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pimVI
{
    public partial class Pedido : UserControl
    {
        public Pedido()
        {
            InitializeComponent();
            CarregarPedidos();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;
        private void desabilitaCampos()
        {

            lblCodiClie.Visible = false;
            lblCodigoCliente.Visible = false;
            btnNovo.Enabled = true;
            txtcodigo.Enabled = false;
            txtCliente.Enabled = false;
            txtqtde.Enabled = false;
            txtvalor.Enabled = false;
            btninserir.Enabled = false;
            txttot.Enabled = false;
            btnFinalizar.Enabled = false;
            mtbcpf.Enabled = false;
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
            txtcodigo.Enabled = true;
            txtCliente.Enabled = true;
            txtqtde.Enabled = true;
            txtvalor.Enabled = true;
            btninserir.Enabled = false;
            txttot.Enabled = true;
            btnFinalizar.Enabled = true;
            mtbcpf.Enabled = true;
            mtbcnpj.Enabled = true;
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
            txtcodigo.Clear();
            txtCliente.Clear();
            txtqtde.Clear();
            txtvalor.Clear();
            txttot.Clear();
            mtbcpf.Clear();            
            dtvpedido.DataSource = null;
            lblCodigoCliente.Visible = false;
            lblCodiClie.Visible = false;


        }
        private void manipularDados()
        {
            lblCodigoCliente.Visible = true;
            lblCodiClie.Visible = true;
            txtcodigo.Enabled = true;
            txtCliente.Enabled = true;
            txtqtde.Enabled = true;
            txtvalor.Enabled = true;
            mtbcpf.Enabled = true;
            mtbcnpj.Enabled = true;
            txttot.Enabled = true;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnGravar.Enabled = false;
            btnRemover.Enabled = true;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            
            LimparCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "INSERT INTO Pedidos (NomeCliente, CPF, CNPJ, Produto, Qtde, Valor) VALUES (@NomeCliente, @CPF, @CNPJ, @Produto, @Qtde, @Valor)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NomeCliente", txtCliente.Text);
                        cmd.Parameters.AddWithValue("@CPF", mtbcpf.Text);
                        cmd.Parameters.AddWithValue("@CNPJ", mtbcnpj.Text);
                        cmd.Parameters.AddWithValue("@Produto", txtcodigo.Text);
                        cmd.Parameters.AddWithValue("@Qtde", txtqtde.Text);
                        cmd.Parameters.AddWithValue("@Valor", txtvalor.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Pedido gravado com sucesso!");
                CarregarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar o pedido: " + ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "UPDATE Pedidos SET NomeCliente = @NomeCliente, CPF = @CPF, CNPJ = @CNPJ, Produto = @Produto, Qtde = @Qtde, Valor = @Valor WHERE Codigo = @Codigo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", lblnum.Text);
                        cmd.Parameters.AddWithValue("@NomeCliente", txtCliente.Text);
                        cmd.Parameters.AddWithValue("@CPF", mtbcpf.Text);
                        cmd.Parameters.AddWithValue("@CNPJ", mtbcnpj.Text);
                        cmd.Parameters.AddWithValue("@Produto", txtcodigo.Text);
                        cmd.Parameters.AddWithValue("@Qtde", txtqtde.Text);
                        cmd.Parameters.AddWithValue("@Valor", txtvalor.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Pedido alterado com sucesso!");
                CarregarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o pedido: " + ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "DELETE FROM Pedidos WHERE Codigo = @Codigo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", lblnum.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Pedido removido com sucesso!");
                CarregarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover o pedido: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "INSERT INTO ItensPedido (PedidoID, ProdutoID, Qtde, Valor) VALUES (@PedidoID, @ProdutoID, @Qtde, @Valor)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PedidoID", lblnum.Text);
                        cmd.Parameters.AddWithValue("@ProdutoID", txtcodigo.Text);
                        cmd.Parameters.AddWithValue("@Qtde", txtqtde.Text);
                        cmd.Parameters.AddWithValue("@Valor", txtvalor.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Item inserido com sucesso!");
                CarregarItensPedido();

                // Calculando o valor total do pedido
                CalcularTotalPedido();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o item: " + ex.Message);
            }
        }

        private void CarregarPedidos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "SELECT * FROM Pedidos";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dtvpedido.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os pedidos: " + ex.Message);
            }
        }

        private void CarregarItensPedido()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "SELECT * FROM ItensPedido WHERE PedidoID = @PedidoID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PedidoID", lblnum.Text);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os itens do pedido: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            // Código para limpar os campos do formulário
            txtCliente.Text = "";
            mtbcpf.Text = "";
            mtbcnpj.Text = "";
            txtcodigo.Text = "";
            txtqtde.Text = "";
            txtvalor.Text = "";
        }

        private void CalcularTotalPedido()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "SELECT SUM(Valor) FROM ItensPedido WHERE PedidoID = @PedidoID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PedidoID", lblnum.Text);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            txttot.Text = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular o valor total do pedido: " + ex.Message);
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

        