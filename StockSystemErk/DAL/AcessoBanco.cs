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

        public DataTable CarregaGridEstoque()
        {
            Comand = "Select * From TB_PRODUTOS";
            OleDbCommand cmd = new OleDbCommand(Comand, Conn);
      

            
            Conn.Open();
            cmd.CommandType = CommandType.Text;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable tbProdutos = new DataTable();

            da.Fill(tbProdutos);

            return tbProdutos;
        }



        public void InserirNovoProduto(ObjNovoProduto prd)
        {

            try
            {
                OleDbParameter param = new OleDbParameter();
                    // OleDbCommand cmd = new OleDbCommand();
                
                Conn.Open();
                //cmd.CommandType = CommandType.Text;
                //cmd.Connection = Conn;

                //Comand ="INSERT INTO TB_PRODUTOS" +
                //    "(PRD_PRODUTO,PRD_VLRCOMPRA,PRD_VLRVENDA,PRD_DESCRICAO,PRD_QUANTIDADE,PRD_DATACOMPRA,PRD_CATEGORIA) "+
                //    "VALUES('" + prd.produto + "', " + prd.valorComprado + ", " + prd.valorVenda + ", '" + prd.descricao + "', " + prd.quantidade + ", '" + prd.dataCompra + "', '" + prd.categoria + "')";

                Comand = "INSERT INTO TB_PRODUTOS" +
                   "(PRD_PRODUTO,PRD_VLRCOMPRA,PRD_VLRVENDA,PRD_DESCRICAO,PRD_QUANTIDADE,PRD_DATACOMPRA,PRD_CATEGORIA) " +
               "VALUES (@PRODUTO, @VALORCOMPRA,@VALORVENDA,@DESCRICAO, @QUANTIDADE, @DATACOMPRA,@CATEGORIA)";

                OleDbCommand cmd = new OleDbCommand(Comand,Conn);

                
                cmd.Parameters.Add("@PRODUTO", OleDbType.VarChar).Value = prd.produto;
                cmd.Parameters.Add("@VALORCOMPRA",OleDbType.Decimal).Value= prd.valorComprado;
                cmd.Parameters.Add("@VALORVENDA", OleDbType.Decimal).Value= prd.valorVenda;
                cmd.Parameters.Add("@DESCRICAO", OleDbType.VarChar).Value = prd.descricao;
                cmd.Parameters.Add("@QUANTIDADE",OleDbType.Integer).Value = prd.quantidade;
                cmd.Parameters.Add("@DATACOMPRA", OleDbType.Date).Value = prd.dataCompra;
                cmd.Parameters.Add("@CATEGORIA", OleDbType.VarChar).Value = prd.categoria;
                
                cmd.ExecuteNonQuery();

                Conn.Close();               
            }
            catch (Exception ex)
            {  }
       
        }



    }
}
