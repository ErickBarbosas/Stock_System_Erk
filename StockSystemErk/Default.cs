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

namespace StockSystemErk
{


    public partial class Default : Form
    {
        
        public Default()
        {
            InitializeComponent();
        }

        private void btnControleEstoque_Click(object sender, EventArgs e)
        {
            Controle_de_Estoque ControleEstoque = new Controle_de_Estoque();

            ControleEstoque.Show();
        }

        private void Default_Load(object sender, EventArgs e)
        {

        }
    }
    
}
