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
        OleDbCommand cmd = new OleDbCommand();
        
        string Comand = "";

        public DataTable CarregaGridEstoque()
        {
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable tbProdutos = new DataTable();

            try
            {
                Conn.Open();

                Comand = "Select * From TB_PRODUTOS";

                cmd.Connection=Conn;
                cmd.CommandText = Comand;
                cmd.CommandType = CommandType.Text;
                
                da.Fill(tbProdutos);
            }
            catch
            { }

            Conn.Close();
            return tbProdutos;
        }

        public DataTable PesquisarProduto(string pesquisa)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable produto = new DataTable();

            try
            {
                Comand = "Select * from TB_PRODUTOS Where PRD_PRODUTO LIKE '%"+ pesquisa + "%'";

                Conn.Open();
                cmd.Connection = Conn;
                cmd.CommandText = Comand;
                cmd.CommandType = CommandType.Text;

                da.Fill(produto);
            }
            catch(Exception ex)
            { }

            Conn.Close();
            return produto;
        }
        public void InserirNovoProduto(ObjNovoProduto prd)
        {
            try
            {

                Conn.Open();

                Comand = "INSERT INTO TB_PRODUTOS" +
                   "(PRD_PRODUTO,PRD_VLRCOMPRA,PRD_VLRVENDA,PRD_DESCRICAO,PRD_QUANTIDADE,PRD_DATACOMPRA,PRD_CATEGORIA) " +
               "VALUES (@PRODUTO, @VALORCOMPRA,@VALORVENDA,@DESCRICAO, @QUANTIDADE, @DATACOMPRA,@CATEGORIA)";

                cmd.Connection = Conn;
                cmd.CommandText = Comand;
                cmd.CommandType = CommandType.Text;

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
