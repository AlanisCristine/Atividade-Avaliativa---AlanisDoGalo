using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa2
{
    public class Modulo
    {
        public void trocaModulo() 
        {
            int Modulox = 0;
            Console.WriteLine("Qual é o valor do módulo x?");
            Modulox = int.Parse(Console.ReadLine());
            if(Modulox >= 0) 
            {
                Console.WriteLine(Modulox);
            }
            else if( Modulox < 0)
            {
                Modulox = Modulox * (-1);
                Console.WriteLine(Modulox);
            }
        }
    }
}
