using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.webservice
{
    public class StatusRetornoProdutos : StatusRetorno
    {
        public int id;
        public List<Produto> lstProdutos = new List<Produto>();
        public double d_Preco;
        public string preco;
    }
}