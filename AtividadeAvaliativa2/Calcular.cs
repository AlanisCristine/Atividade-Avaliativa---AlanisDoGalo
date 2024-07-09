using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa2
{
    public class Calcular
    {
        public void iniciarsistema()
        {
            int variavel1 =0;
            int variavel2 = 0;

            Console.WriteLine("Qual das opções você deseja realizar?");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            int escolha = 0;
            escolha = int.Parse(Console.ReadLine());
            if(escolha == 1)
            {
                Console.WriteLine("Qual é o primeiro número?");
                variavel1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual é o segundo número?");
                variavel2 = int.Parse(Console.ReadLine());

                int resultado = variavel1 + variavel2 ;

                Console.WriteLine($"{variavel1} + {variavel2} = {resultado}");
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Qual é o primeiro número?");
                variavel1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual é o segundo número?");
                variavel2 = int.Parse(Console.ReadLine());

                int resultado = variavel1 - variavel2;

                Console.WriteLine($"{variavel1} - {variavel2} = {resultado}");
            }
            else if (escolha == 3)
            {
                Console.WriteLine("Qual é o primeiro número?");
                variavel1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual é o segundo número?");
                variavel2 = int.Parse(Console.ReadLine());

                int resultado = variavel1 * variavel2;

                Console.WriteLine($"{variavel1} * {variavel2} = {resultado}");
            }
            else if (escolha == 4)
            {
                Console.WriteLine("Qual é o primeiro número?");
                variavel1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual é o segundo número?");
                variavel2 = int.Parse(Console.ReadLine());

                int resultado = variavel1 / variavel2;

                Console.WriteLine($"{variavel1} / {variavel2} = {resultado}");
            }
        }
    }
}
