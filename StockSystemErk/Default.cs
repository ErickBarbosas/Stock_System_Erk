using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockSystemErk.View;


namespace StockSystemErk
{


    public partial class Default : Form
    {
        
        public Default()
        {
            InitializeComponent();
        }

        private void btnControleEstoque_Click(object sender, EventArgs e)
        {
            Controle_de_Estoque ControleEstoque = new Controle_de_Estoque();

            ControleEstoque.Show();
        }

        private void Default_Load(object sender, EventArgs e)
        {

        }

        private void btnTelaVenda_Click(object sender, EventArgs e)
        {
            Tela_de_Vendas Vendas = new Tela_de_Vendas();

                Vendas.Show();
        }

        private void btnFaturamento_Click(object sender, EventArgs e)
        {
            Faturamento faturamento = new Faturamento();

            faturamento.Show();

        }

        private void btnCaderneta_Click(object sender, EventArgs e)
        {
            Caderneta caderneta = new Caderneta();

            caderneta.Show();
        }
    }
    
}
