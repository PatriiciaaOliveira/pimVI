using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pimVI
{
    public partial class Produto : UserControl
    {
        private SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True");
        private SqlCommand cm = new SqlCommand();
        private SqlDataReader dr;
        private object lblCodi;
        private object txtFabricante;

        public Produto()
        {
            InitializeComponent();
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
            carregarCategorias();
        }

        private void desabilitaCampos()
        {
            lblCodi1.Visible = false;
            lblcod.Visible = false;
            btnNovo.Enabled = true;
            txtCodBarras.Enabled = false;
            txtProduto.Enabled = false;
            cbCategoria.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;
            txtfab.Enabled = false;
            txtGarantia.Enabled = false;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnRemover.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void habilitaCampos()
        {
            txtCodBarras.Enabled = true;
            txtProduto.Enabled = true;
            cbCategoria.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;
            txtfab.Enabled = true;
            txtGarantia.Enabled = true;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            txtCodBarras.Focus();
            txtpesquisa.Text = "";
            dtvProduto.DataSource = null;
        }

        private void limparCampos()
        {
            txtCodBarras.Clear();
            txtProduto.Clear();
            cbCategoria.SelectedIndex = -1;
            txtQuantidade.Clear();
            txtValor.Clear();
            txtfab.Clear();
            txtGarantia.Clear();
            txtCodBarras.Focus();
            txtpesquisa.Clear();
            dtvProduto.DataSource = null;
            lblCodi1.Visible = false;
            lblcod.Visible = false;
        }

        private void manipularDados()
        {
            lblcod.Visible = true;
            lblCodi1.Visible = true;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnGravar.Enabled = false;
            btnRemover.Enabled = true;
            txtCodBarras.Enabled = true;
            txtProduto.Enabled = true;
            cbCategoria.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;
            txtfab.Enabled = true;
            txtGarantia.Enabled = true;
        }

        private void carregarCategorias()
        {
            try
            {
                cn.Open();
                cm.CommandText = "SELECT * FROM tblCategoria";
                cm.Connection = cn;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    cbCategoria.Items.Add(dr["CategoriaID"].ToString());
                }

                dr.Close();
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodBarras.Text == "" || txtProduto.Text == "" || cbCategoria.SelectedIndex == -1 || txtQuantidade.Text == "" || txtValor.Text == "" || txtfab.Text == "" || txtGarantia.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string codBarras = txtCodBarras.Text;
                    string produto = txtProduto.Text;
                    int categoria = cbCategoria.SelectedIndex + 1;
                    int quantidade = Convert.ToInt32(txtQuantidade.Text);
                    decimal valor = Convert.ToDecimal(txtValor.Text);
                    string fabricante = txtfab.Text;
                    string garantia = txtGarantia.Text;

                    string strSql = "INSERT INTO tbl_Produtos (CodBarras, ds_produto, id_Categoria, quantidade, valor, fabricante, garantia) VALUES (@codBarras, @produto, @categoria, @quantidade, @valor, @fabricante, @garantia)";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.AddWithValue("@codBarras", codBarras);
                    cm.Parameters.AddWithValue("@produto", produto);
                    cm.Parameters.AddWithValue("@categoria", categoria);
                    cm.Parameters.AddWithValue("@quantidade", quantidade);
                    cm.Parameters.AddWithValue("@valor", valor);
                    cm.Parameters.AddWithValue("@fabricante", fabricante);
                    cm.Parameters.AddWithValue("@garantia", garantia);

                    cn.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Produto inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtpesquisa.Text))
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "SELECT * FROM tbl_Produtos WHERE ds_produto LIKE @search OR CodBarras LIKE @search";
                    cm.Parameters.Clear();
                    cm.Parameters.AddWithValue("@search", "%" + txtpesquisa.Text + "%");
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvProduto.DataSource = dt;
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
            else
            {
                dtvProduto.DataSource = null;
            }
        }

        private void CarregaProduto()
        {
            if (dtvProduto.SelectedRows.Count > 0)
            {
                lblCodi1.Text = dtvProduto.SelectedRows[0].Cells[0].Value.ToString();
                txtCodBarras.Text = dtvProduto.SelectedRows[0].Cells[0].Value.ToString();
                txtProduto.Text = dtvProduto.SelectedRows[0].Cells[0].Value.ToString();
                cbCategoria.SelectedIndex = Convert.ToInt32(dtvProduto.SelectedRows[0].Cells[0].Value.ToString()) - 1;
                txtQuantidade.Text = dtvProduto.SelectedRows[0].Cells[0].Value.ToString();
                txtValor.Text = dtvProduto.SelectedRows[0].Cells[0].Value.ToString();
                txtfab.Text = dtvProduto.SelectedRows[0].Cells[0].Value.ToString();
                txtGarantia.Text = dtvProduto.SelectedRows[0].Cells[0].Value.ToString();
                manipularDados();
            }
        }

        private void dtvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaProduto();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodBarras.Text == "" || txtProduto.Text == "" || cbCategoria.SelectedIndex == -1 || txtQuantidade.Text == "" || txtValor.Text == "" || txtfab.Text == "" || txtGarantia.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string codBarras = txtCodBarras.Text;
                    string produto = txtProduto.Text;
                    int categoria = cbCategoria.SelectedIndex + 1;
                    int quantidade = Convert.ToInt32(txtQuantidade.Text);
                    decimal valor = Convert.ToDecimal(txtValor.Text);
                    string fabricante = txtfab.Text;
                    string garantia = txtGarantia.Text;
                    int cd = Convert.ToInt32(lblCodi1.Text);

                    string strSql = "UPDATE tbl_Produtos SET CodBarras = @codBarras, ds_produto = @produto, id_Categoria = @categoria, quantidade = @quantidade, valor = @valor, fabricante = @fabricante, garantia = @garantia WHERE id_Produto = @cd";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.AddWithValue("@codBarras", codBarras);
                    cm.Parameters.AddWithValue("@produto", produto);
                    cm.Parameters.AddWithValue("@categoria", categoria);
                    cm.Parameters.AddWithValue("@quantidade", quantidade);
                    cm.Parameters.AddWithValue("@valor", valor);
                    cm.Parameters.AddWithValue("@fabricante", fabricante);
                    cm.Parameters.AddWithValue("@garantia", garantia);
                    cm.Parameters.AddWithValue("@cd", cd);

                    cn.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Produto atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lblcod.Text != "")
            {
                try
                {
                    int cd = Convert.ToInt32(lblcod.Text);

                    string strSql = "DELETE FROM tbl_Produtos WHERE id_Produto = @cd";

                    cm.CommandText = strSql;
                    cm.Connection = cn;
                    cm.Parameters.AddWithValue("@cd", cd);

                    cn.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Produto removido com sucesso!", "Remoção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitaCampos();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}