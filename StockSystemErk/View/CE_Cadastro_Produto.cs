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
      
        ObjNovoProduto NewProdutoObj = new ObjNovoProduto();

        public CE_Cadastro_Produto()
        {
            InitializeComponent();
        }


        public void SetProdutoNovo()
        {
            NewProdutoObj.produto = textProduto.Text;
            NewProdutoObj.valorComprado = textVlrCompra.Text;
            NewProdutoObj.valorVenda = texVlrVenda.Text;
            NewProdutoObj.quantidade = txtQuantidade.Text;
            NewProdutoObj.descricao = textDescricao.Text;
            NewProdutoObj.dataCompra = dateCompra.Text;
            NewProdutoObj.categoria = dllCategoria.SelectedItem.ToString();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            InserirNovoProduto();
        }

        public void InserirNovoProduto()
        {
            AcessoBanco dal = new AcessoBanco();

            SetProdutoNovo();
            dal.InserirNovoProduto(NewProdutoObj);
            MessageBox.Show( "Produto Cadastrado Com Sucesso !","Sucesso");
            Limpacomponente();
            this.Close();

        }

        public void Limpacomponente()
        {
            textProduto.Text = "";
            textVlrCompra.Text = "";
            texVlrVenda.Text = "";
            txtQuantidade.Text = "";
            textDescricao.Text = "";
            dateCompra.Text = DateTime.Today.ToString();
            dllCategoria.SelectedIndex = 0;
        }

        private void texVlrVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
