using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSystemErk.Objetos;
using System.Data.OleDb;

namespace StockSystemErk.DAL
{
    class AcessoBanco
    {
        private static string StringConexao = StockSystemErk.Properties.Settings.Default.ConexaoBD.ToString();
        OleDbConnection Conn = new OleDbConnection(StringConexao);
       
        string Comand;



        public void InserirNovoProduto()
        {
            DataSet ds = new DataSet();
            SqlParameter[] param = new SqlParameter[4];
            
           

            Comand = "INSERT INTO TB_PRODUTOS "+
           "(PRD_PRODUTO,PRD_VLRCOMPRA,PRD_VLRVENDA,PRD_DESCRICAO,PRD_QUANTIDADE,PRD_DATACOMPRA,PRD_CATEGORIA)"+
    "VALUES ('"+prd.produto+"',"+prd.valorComprado+","+prd.valorVenda+",'"+prd.descricao+"',"+prd.quantidade+",'"+prd.dataCompra+"','"+prd.categoria+"'";

            try
            {
                Conn.Open();
                OleDbCommand cmd = new OleDbCommand(Comand, Conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
            //string con = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Erick Barbosa - NT\source\repos\StockSystemErk\StockSystemErk\Base\StockSystemErk.mdb";
            // string comando = "insert into TB_PRODUTOs(PRD_CODIGO,PRD_PRODUTO,PRD_VLRCOMPRA,PRD_VLRVENDA,PRD_DESCRICAO,PRD_QUANTIDADE,PRD_DATACOMPRA) values(2,'Cerveja',1000,500,'primeiro',10,'2021-05-04')";
            // OleDbConnection conexao = new OleDbConnection(con);
            // conexao.Open();
            // OleDbCommand cmd = new OleDbCommand(comando, conexao);

            //cmd.ExecuteNonQuery();
        }



    }
}
