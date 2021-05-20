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

namespace StockSystemErk.View
{
    public partial class Controle_de_Estoque : Form
    {
        public Controle_de_Estoque()
        {
            InitializeComponent();
        }

        private void btnCadastraProduto_Click(object sender, EventArgs e)
        {
            Cadastro_Produto cadastrarProduto = new Cadastro_Produto();

                cadastrarProduto.Show();
        }
    }
}
