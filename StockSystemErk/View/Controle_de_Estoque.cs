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
using StockSystemErk.DAL;

namespace StockSystemErk.View
{
    public partial class Controle_de_Estoque : Form
    {
        AcessoBanco BD = new AcessoBanco();

        public Controle_de_Estoque()
        {
            InitializeComponent();
            CarregaGridProdutos();
        }

        private void btnCadastraProduto_Click(object sender, EventArgs e)
        {
            CE_Cadastro_Produto cadastrarProduto = new CE_Cadastro_Produto();

                cadastrarProduto.Show();
            this.Refresh();
        }

        public void CarregaGridProdutos()
        {
            DataTable dt;
            dt = BD.CarregaGridEstoque();

            gridEstoque.DataSource = dt;
        }


        public void PesquisarProduto()
        {
            string pesquisa;
            DataTable dt;
            pesquisa = textBox2.Text;

            dt = BD.PesquisarProduto(pesquisa);

            gridEstoque.DataSource = dt;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarProduto();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaGridProdutos();
        }
    }
}
