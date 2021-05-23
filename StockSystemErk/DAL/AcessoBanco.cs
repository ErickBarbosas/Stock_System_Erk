using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
         

        }



    }
}
