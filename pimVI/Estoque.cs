using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace pimVI
{
    public partial class Estoque : UserControl
    {
        private SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True");
        private SqlCommand cm = new SqlCommand();
        private SqlDataReader dr;

        public Estoque()
        {
            InitializeComponent();
            CarregarProdutos();
            CarregarCategorias();
        }

        private void CarregarProdutos()
        {
            try
            {
                cn.Open();
                cm.CommandText = "SELECT id_Produto, CodBarras, ds_produto, id_Categoria, quantidade, valor, fabricante, garantia FROM tbl_Produtos";
                cm.Connection = cn;
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtvvenda.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        

        private void CarregarCategorias()
        {
            try
            {
                cn.Open();
                cm.CommandText = "SELECT CategoriaID FROM tblCategoria";
                cm.Connection = cn;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    cbCategoria.Items.Add(new { Text = dr["CategoriaID "].ToString() });
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm.CommandText = "INSERT INTO tbl_Produtos (CodBarras, ds_produto, id_Categoria, quantidade, valor, fabricante, garantia) VALUES (@CodBarras, @ds_produto, @id_Categoria, @quantidade, @valor, @fabricante, @garantia)";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@CodBarras", txtCodBarras.Text);
                cm.Parameters.AddWithValue("@ds_produto", txtProduto.Text);
                cm.Parameters.AddWithValue("@id_Categoria", ((dynamic)cbCategoria.SelectedItem).Value);
                cm.Parameters.AddWithValue("@quantidade", int.Parse(txtQuantidade.Text));
                cm.Parameters.AddWithValue("@valor", decimal.Parse(txtValor.Text));
                cm.Parameters.AddWithValue("@fabricante", txtfab.Text);
                cm.Parameters.AddWithValue("@garantia", txtGarantia.Text);
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                MessageBox.Show("Produto adicionado com sucesso!");
                CarregarProdutos();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produto: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm.CommandText = "UPDATE tbl_Produtos SET CodBarras=@CodBarras, ds_produto=@ds_produto, id_Categoria=@id_Categoria, quantidade=@quantidade, valor=@valor, fabricante=@fabricante, garantia=@garantia WHERE id_Produto=@id_Produto";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@CodBarras", txtCodBarras.Text);
                cm.Parameters.AddWithValue("@ds_produto", txtProduto.Text);
                cm.Parameters.AddWithValue("@id_Categoria", ((dynamic)cbCategoria.SelectedItem).Value);
                cm.Parameters.AddWithValue("@quantidade", int.Parse(txtQuantidade.Text));
                cm.Parameters.AddWithValue("@valor", decimal.Parse(txtValor.Text));
                cm.Parameters.AddWithValue("@fabricante", txtfab.Text);
                cm.Parameters.AddWithValue("@garantia", txtGarantia.Text);
                cm.Parameters.AddWithValue("@id_Produto", int.Parse(txtProduto.Text));
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                MessageBox.Show("Produto atualizado com sucesso!");
                CarregarProdutos();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm.CommandText = "DELETE FROM tbl_Produtos WHERE id_Produto=@id_Produto";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@id_Produto", int.Parse(txtProduto.Text));
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                MessageBox.Show("Produto removido com sucesso!");
                CarregarProdutos();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover produto: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void LimparCampos()
        {
            txtProduto.Clear();
            txtCodBarras.Clear();
            txtProduto.Clear();
            cbCategoria.SelectedIndex = -1;
            txtQuantidade.Clear();
            txtValor.Clear();
            txtfab.Clear();
            txtGarantia.Clear();
        }

        private void dgvEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtvvenda.Rows[e.RowIndex];
                txtProduto.Text = row.Cells["id_Produto"].Value.ToString();
                txtCodBarras.Text = row.Cells["CodBarras"].Value.ToString();
                txtProduto.Text = row.Cells["ds_produto"].Value.ToString();
                cbCategoria.SelectedIndex = cbCategoria.Items.IndexOf(cbCategoria.Items.Cast<dynamic>().First(item => item.Value.ToString() == row.Cells["id_Categoria"].Value.ToString()));
                txtQuantidade.Text = row.Cells["quantidade"].Value.ToString();
                txtValor.Text = row.Cells["valor"].Value.ToString();
                txtfab.Text = row.Cells["fabricante"].Value.ToString();
                txtGarantia.Text = row.Cells["garantia"].Value.ToString();
            }
        }

        private void btnatualizar_Click_1(object sender, EventArgs e)
        {

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}