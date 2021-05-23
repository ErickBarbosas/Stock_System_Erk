using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSystemErk.Objetos;

namespace StockSystemErk.DAL
{
    class AcessoBanco
    {
        string Conn = StockSystemErk.Properties.Settings.Default.ConexaoBD.ToString();
        string Comand;



        public void InserirNovoProduto()
        {
            DataSet ds = new DataSet();
            SqlParameter[] param = new SqlParameter[4];
            ObjNovoProduto prd = new ObjNovoProduto();
           

            Comand = "INSERT INTO TB_PRODUTOS (PRD_PRODUTO,PRD_VLRCOMPRA,PRD_VLRVENDA,PRD_DESCRICAO,PRD_QUANTIDADE,PRD_DATACOMPRA,PRD_CATEGORIA)"+
                                      "VALUES ("+prd.+")";

        }



    }
}
