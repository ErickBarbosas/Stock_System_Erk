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



        public void InserirNovoProduto(ObjNovoProduto prd)
        {

            try
            {
                    // OleDbCommand cmd = new OleDbCommand();
                OleDbParameter param = new OleDbParameter();
                Conn.Open();
                SqlTransaction transacao = Conn.BeginTransaction();
                //cmd.CommandType = CommandType.Text;
                //cmd.Connection = Conn;

                //Comand ="INSERT INTO TB_PRODUTOS" +
                //    "(PRD_PRODUTO,PRD_VLRCOMPRA,PRD_VLRVENDA,PRD_DESCRICAO,PRD_QUANTIDADE,PRD_DATACOMPRA,PRD_CATEGORIA) "+
                //    "VALUES('" + prd.produto + "', " + prd.valorComprado + ", " + prd.valorVenda + ", '" + prd.descricao + "', " + prd.quantidade + ", '" + prd.dataCompra + "', '" + prd.categoria + "')";

                Comand = "INSERT INTO TB_PRODUTOS" +
                   "(PRD_PRODUTO,PRD_VLRCOMPRA,PRD_VLRVENDA,PRD_DESCRICAO,PRD_QUANTIDADE,PRD_DATACOMPRA,PRD_CATEGORIA) " +
            "VALUES ('@PRODUTO', @VALORCOMPRA,@VALORVENDA,'@DESCRICAO', @QUANTIDADE, '@DATACOMPRA','@CATEGORIA')";

                OleDbCommand cmd = new OleDbCommand(Comand,Conn, transacao);

                cmd.Parameters.AddWithValue("@PRODUTO", prd.produto);
                cmd.Parameters.AddWithValue("@VALORCOMPRA", prd.valorComprado);
                cmd.Parameters.AddWithValue("@VALORVENDA", prd.valorVenda);
                cmd.Parameters.AddWithValue("@DESCRICAO", prd.descricao);
                cmd.Parameters.AddWithValue("@QUANTIDADE", prd.quantidade);
                cmd.Parameters.AddWithValue("@DATACOMPRA", prd.dataCompra);
                cmd.Parameters.AddWithValue("@CATEGORIA", prd.categoria);

              


                cmd.ExecuteNonQuery();




                Conn.Close();
                
                
               
            }
            catch (Exception ex)
            {  }
       
        }



    }
}
