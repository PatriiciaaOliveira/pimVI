using System;
using System.Windows.Forms;

namespace pimVI
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.Show();
        }

        private void btnFuncio_Click(object sender, EventArgs e)
        {
            Funcion funcionario = new Funcion();
            funcionario.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedido pedidos = new Pedido();
            pedidos.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.Show();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            frm_Menu login = new frm_Menu();
            login.Show();
            this.Hide();
        }

        private void btnprodutos_Click(object sender, EventArgs e)
        {
            Produto produtos = new Produto();
            produtos.Show();
        }

        private void btnestoque_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Este método pode ser deixado vazio ou removido se não for necessário
        }
    }
}