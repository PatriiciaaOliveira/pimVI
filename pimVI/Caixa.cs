using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pimVI
{
    public partial class Caixa : UserControl
    {
        private decimal valorTotalCompra;
        private decimal valorRecebido;
        private decimal troco;

        public Caixa()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QC4BN33\SQLEXPRESS;Initial Catalog=BD_LOJAVer;Integrated Security=True");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;
        private void limparCampos()
        {
            txtCliente.Clear();
            txtvalorreceb.Clear();
            txttroco.Clear();
            txttot.Clear();
            dtvcompra.DataSource = null;
            rbcartao.Checked = true;
            rbdinheiro.Checked = true;
        }
        private void habilitaCampos()
        {

            txtCliente.Enabled = false;
            txtvalorreceb.Enabled = true;
            txttroco.Enabled = true;
            txttot.Enabled = true;
            dtvcompra.Enabled = true;

            rbcartao.Enabled = false;
            rbdinheiro.Enabled = false;
            btnFinalizar.Enabled = false;
            btnCancelar.Enabled = false;

        }
        private void desabilitaCampos()
        {


            txtCliente.Enabled = false;
            txtvalorreceb.Enabled = false;
            txttroco.Enabled = false;
            txttot.Enabled = false;
            dtvcompra.Enabled = false;
            rbcartao.Enabled = false;
            rbdinheiro.Enabled = false;
            btnFinalizar.Enabled = false;
            btnCancelar.Enabled = false;


        }
        private void manipularDados()
        {

            txtCliente.Enabled = true;
            txtvalorreceb.Enabled = true;
            txttroco.Enabled = true;
            txttot.Enabled = true;
            dtvcompra.Enabled = true;
            rbcartao.Enabled = true;
            rbdinheiro.Enabled = true;
            btnFinalizar.Enabled = true;
            btnCancelar.Enabled = true;
        }





        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //  finalizar a compra
            MessageBox.Show("Compra finalizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CalcularTroco()
        {
            if (valorRecebido >= valorTotalCompra)
            {
                troco = valorRecebido - valorTotalCompra;
            }
            else
            {
                MessageBox.Show("O valor recebido é insuficiente.", "Troco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Lógica adicional, se necessário, caso o valor recebido seja insuficiente
            }
        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtvalorreceb.Text, out valorRecebido))
            {
                CalcularTroco();
                txttroco.Text = troco.ToString();
            }
            else
            {
                txttroco.Text = "";
            }
        }

        private void dtvcompra_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            // Verifica se foi selecionada uma linha no DataGridView
            if (dtvcompra.SelectedRows.Count > 0)
            {
                // Obtém os detalhes da compra da linha selecionada
                string nomeCliente = txtCliente.Text;
                string itensComprados = "";
                decimal totalCompra = 0;

                foreach (DataGridViewRow row in dtvcompra.SelectedRows)
                {
                    itensComprados += row.Cells["NomeItem"].Value.ToString() + " - " + row.Cells["PrecoItem"].Value.ToString() + "\n";
                    totalCompra += Convert.ToDecimal(row.Cells["PrecoItem"].Value);
                }

                // Exibe os detalhes da compra em uma MessageBox
                string mensagem = $"Detalhes da compra:\n\n" +
                                  $"Cliente: {nomeCliente}\n" +
                                  $"Itens comprados:\n{itensComprados}\n" +
                                  $"Total da compra: {totalCompra.ToString("C")}";
                MessageBox.Show(mensagem, "Detalhes da Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma compra para ver os detalhes.", "Seleção Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitaCampos();
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
    
