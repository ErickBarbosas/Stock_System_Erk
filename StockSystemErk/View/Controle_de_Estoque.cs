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
            painelAlterar.Visible = false;
        }

        private void btnCadastraProduto_Click(object sender, EventArgs e)
        {
            CE_Cadastro_Produto cadastrarProduto = new CE_Cadastro_Produto();

                cadastrarProduto.Show();
        }

        public void CarregarPainelAlterar(string codigo)
        {
            DataSet ds;

            ds = BD.GetDadosProdutos(codigo);

            txtCodigo.Text = ds.Tables[0].Rows[0][0].ToString(); 
            txtproduto.Text = ds.Tables[0].Rows[0][1].ToString();
            txtvalorProduto.Text = ds.Tables[0].Rows[0][2].ToString();
            txtvalorVenda.Text  = ds.Tables[0].Rows[0][3].ToString();
            txtDescricao.Text= ds.Tables[0].Rows[0][4].ToString();
            txtQuantidade.Text= ds.Tables[0].Rows[0][5].ToString();
            txtdatacompra.Text = ds.Tables[0].Rows[0][6].ToString();
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

        private void gridEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row;
            row = e.RowIndex;

          String value=  gridEstoque.Rows[row].Cells[1].Value.ToString();

            CarregarPainelAlterar(value);
            painelAlterar.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            painelAlterar.Visible = false;
        }
    }
}
