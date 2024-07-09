using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa2
{
    public class Verificacao
    {
        int variavel1 = 0;
        int variavel2 = 0;
        public void Verificar()
        {


            Console.WriteLine("Qual das opções você deseja realizar?");
            Console.WriteLine("1- Verificar se os números são múltiplos um do outro");
            Console.WriteLine("2- Verifivar se os dois numeros são pares");
            Console.WriteLine("3 - Verificar se a média é maio ou igual a 7");
            Console.WriteLine("4 - Sair");
            int escolha = 0;
            escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                VerificarMultiplo(variavel1, variavel2);
            }
            else if (escolha == 2)
            {
                Pares(variavel1, variavel2);
            }
            else if (escolha ==3)
            {
                Media(variavel1+ 1, variavel2);
            }
            else
            {
                
            }
        }


        public void VerificarMultiplo(int variavel1, int variavel2)
        {
            Console.WriteLine("Qual é o primeiro número?");
            variavel1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o segundo número?");
            variavel2 = int.Parse(Console.ReadLine());
            int resultado=0; 
            if(variavel1 > variavel2)
            {
                resultado = variavel1 % variavel2;
            }
            else
            {
                resultado = variavel2 % variavel1;
            }
           


            if (resultado == 0)
            {
                Console.WriteLine("Os números são multiplos");
            }
            else
            {
                Console.WriteLine("Os números não são mutiplos");
            }
        }

        public void Pares(int variavel1, int variavel2)
        {
            Console.WriteLine("Qual é o primeiro número?");
            variavel1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o segundo número?");
            variavel2 = int.Parse(Console.ReadLine()); 

            int resultado = variavel1 % 2;
            int resultado1 = variavel2 % 2;

            if ( resultado == 0 && resultado == 0) 
            {
                Console.WriteLine("Os numeros são pares.");
            }
            else
            {
                Console.WriteLine("Os números não não pares");
            }
        }

        public void Media(int variavel1, int variavel2)
        {
            Console.WriteLine("Qual é o primeiro número?");
            variavel1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o segundo número?");
            variavel2 = int.Parse(Console.ReadLine());

            int media = (variavel1 + variavel2) / 2;
            if(media >= 7)
            {
                Console.WriteLine("A média é igual ou maior que sete.");
            }
            else
            {
                Console.WriteLine($"A média é de {media}");
            }
        }

    }
}
