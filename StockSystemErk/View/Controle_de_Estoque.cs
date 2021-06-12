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
using StockSystemErk.Objetos;

namespace StockSystemErk.View
{
    public partial class Controle_de_Estoque : Form
    {
        AcessoBanco BDacesso = new AcessoBanco();
        ObjNovoProduto objProduto = new ObjNovoProduto();

        public Controle_de_Estoque()
        {
            InitializeComponent();
            CarregarConteudo();
        }

        public void CarregarConteudo()
        {
            CarregaGridProdutos();
            CarregarContadores();
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

            ds = BDacesso.GetDadosProdutos(codigo);

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
            dt = BDacesso.CarregaGridEstoque();

            gridEstoque.DataSource = dt;
        }

        public void CarregarContadores()
        {
            DataSet ds = new DataSet();

            ds=BDacesso.ContadorEstoque();

            txtTotalProduto.Text = ds.Tables[0].Rows[0][0].ToString();
            txtQtdTotal.Text = ds.Tables[0].Rows[0][1].ToString();
            txtMenor5.Text = ds.Tables[0].Rows[0][2].ToString();

        }


        public void PesquisarProduto()
        {
            string pesquisa;
            DataTable dt;
            pesquisa = txtPesquisar.Text;

            dt = BDacesso.PesquisarProduto(pesquisa);

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
            int row, colum;
            String value;

            colum = e.ColumnIndex;
            row = e.RowIndex;
            value = gridEstoque.Rows[row].Cells[2].Value.ToString();
           

            switch (colum)
            {
                case 0:
                    painelAlterar.Visible = true;

                    CarregarPainelAlterar(value);
                      
                    break;

                case 1:

                    DialogResult res;
                    res=MessageBoxConfirmacao("Deseja Realmente Apagar Esse Produto do Estoque ?", "Confimação");

                    if (res.ToString().ToUpper() == "YES")
                    { }

                    break;

            }
           
        }


        public DialogResult MessageBoxConfirmacao(string msg,string titulo)
        {
            DialogResult resposta;

            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);


            return resposta;
        }

        public void Message(string msg, string titulo)
        {
            MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }

        public void SetValorAlterar()
        {
            objProduto.codigo = txtCodigo.Text;
            objProduto.produto = txtproduto.Text;
            objProduto.valorComprado = txtvalorProduto.Text;
            objProduto.valorVenda = txtvalorVenda.Text;
            objProduto.quantidade = txtQuantidade.Text;
            objProduto.descricao = txtDescricao.Text;
            objProduto.dataCompra = txtdatacompra.Text;
        }

        public void AlterarDadosProduto()
        {
            try
            {
                SetValorAlterar();
                BDacesso.AlterarProdutoEstoque(objProduto);
                Message("Produto Alterado Com Sucesso!", "Exito");
                painelAlterar.Visible = false;
                CarregaGridProdutos();
            }
            catch(Exception ex)
            {
            }
        }


        private void btnAlterarPRD_Click(object sender, EventArgs e)
        {

            DialogResult res;
            res = MessageBoxConfirmacao("Deseja Realmente Alterar Esse Produto do Estoque ?", "Confimação");

            if (res.ToString().ToUpper() == "YES")
            {
                AlterarDadosProduto();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            painelAlterar.Visible = false;
        }
    }
}
