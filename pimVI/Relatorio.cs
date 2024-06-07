using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pimVI
{
    public partial class Relatorio : UserControl
    {
        private SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True");
        private SqlCommand cm = new SqlCommand();

        public Relatorio()
        {
            InitializeComponent();
            carregarVendas();
            // Adicionando a configuração dos eventos
            dtvvenda.CellContentClick += new DataGridViewCellEventHandler(dtvvenda_CellContentClick);
            btnFinalizar.Click += new EventHandler(btnFinalizar_Click);
        }

        private void carregarVendas()
        {
            try
            {
                cn.Open();
                cm.CommandText = "SELECT * FROM tbl_Vendas";
                cm.Connection = cn;
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtvvenda.DataSource = dt;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar vendas: " + erro.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relatório gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtvvenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtvvenda.Rows[e.RowIndex];
                string detalhes = $"ID Venda: {row.Cells["id_Venda"].Value}\n" +
                                  $"Cliente: {row.Cells["id_Cliente"].Value}\n" +
                                  $"Data: {row.Cells["data_venda"].Value}\n" +
                                  $"Total: {row.Cells["total_venda"].Value}";

                MessageBox.Show(detalhes, "Detalhes da Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblVendas_Click(object sender, EventArgs e)
        {
            // Método vazio - implementações futuras
        }

        private void lblvend_Click(object sender, EventArgs e)
        {
            // Método vazio - implementações futuras
        }

        private void lblrelat_Click(object sender, EventArgs e)
        {
            // Método vazio - implementações futuras
        }
    }
}