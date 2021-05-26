using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockSystemErk.Objetos
{
   class ObjNovoProduto
    {
        string _produto,_valorComprado,_dataCompra, _valorVenda, _categoria, _descricao, _quantidade;

        public string produto
        {
            get { return _produto; }
            set { _produto = value; }
        }
        public string valorComprado
        {
            get { return _valorComprado; }
            set { _valorComprado = value; }
        }
        public string dataCompra
        {
            get { return _dataCompra; }
            set { _dataCompra = value; }
        }
        public string valorVenda
        {
            get { return _valorVenda; }
            set { _valorVenda = value; }
        }
        public string categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        public string descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public string quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }


    }
}
