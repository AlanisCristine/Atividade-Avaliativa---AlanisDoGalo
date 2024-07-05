using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa2
{
    public class TrocaValores
    { 
        public int ValorA = 10;
        public int ValorB = 90;
        public void Troca()
        {
            int valorAAux = ValorA;
            int valorBAux = ValorB;
            Console.WriteLine($"Valor da Variável A:{ValorA}");
            
            Console.WriteLine($"Valor da Variável B:{ValorB}");

            ValorA = valorBAux; 
            ValorB = valorAAux;
             
            Console.WriteLine($"O valor de A:{ValorA}");
            Console.WriteLine($"O valor de B:{ValorB}");
        }
    }
}
