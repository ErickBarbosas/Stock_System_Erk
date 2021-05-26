using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using StockSystemErk.DAL;
using StockSystemErk.Objetos;

namespace StockSystemErk.View
{
    public partial class CE_Cadastro_Produto : Form
    {
        public CE_Cadastro_Produto()
        {
            InitializeComponent();
        }

        private void Cadastro_Produto_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            ObjNovoProduto obj = new ObjNovoProduto();
            AcessoBanco dal = new AcessoBanco();

            obj.produto = textProduto.Text;
            obj.valorComprado = textVlrCompra.Text;
            obj.valorVenda = texVlrVenda.Text;
            obj.quantidade = txtQuantidade.Text;
            obj.descricao = "testando";
            obj.dataCompra = "2021-05-01";
            obj.categoria = "teste";

            dal.InserirNovoProduto(obj);
           
        }
    }
}
