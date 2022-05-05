using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class CaixaEletrtonico
    {
       

        public static string calcularSaque(int valorSaque)
        {
            int dinheiro = valorSaque;
            string resultado = "";

            if(valorSaque==1 || valorSaque == 3)
            {
                resultado = "não é possivel realizar o saque";

            }

            return resultado;
        }
    }
}
