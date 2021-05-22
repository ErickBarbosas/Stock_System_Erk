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
            try
            {
                string con = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Erick Barbosa - NT\source\repos\StockSystemErk\StockSystemErk\Base\StockSystemErk.mdb";
                string comando = "insert into TB_PRODUTOs(PRD_CODIGO,PRD_PRODUTO,PRD_VLRCOMPRA,PRD_VLRVENDA,PRD_DESCRICAO,PRD_QUANTIDADE,PRD_DATACOMPRA) values(2,'Cerveja',1000,500,'primeiro',10,'2021-05-04')";
                OleDbConnection conexao = new OleDbConnection(con);
                conexao.Open();
                OleDbCommand cmd = new OleDbCommand(comando, conexao);

                cmd.ExecuteNonQuery();
            }
            catch( Exception ex )
            {
              
            }
           
        }
    }
}
