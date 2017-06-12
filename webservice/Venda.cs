using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication1.webservice
{
    public class Venda
    {
        public string mes;
        public double valor;
        public string sValor
        {
            get { return valor.ToString("R$ 0.00"); }
        }

        public Venda(Constantes.Meses mes, double valor)
        {
            this.mes = mes.ToString();
            this.valor = valor;
        }
    }
}
