using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEstoque
{
    public class Estoque
    {
        public double QuantidadeMaxima { get; set; }
        public double QuantidadeMinima { get; set; }
        public int IdVendedor { get; set; }

        public int IdPeca { get; set; }


        public void CalculaEstoqueMedio()
        {
            Console.WriteLine("Qual é a quantidade maxima?");
            QuantidadeMaxima = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a quantidade minima?");
            QuantidadeMinima = double.Parse(Console.ReadLine());
            double EstoqueMedio = (QuantidadeMaxima + QuantidadeMinima) / 2;
            Console.WriteLine($"O estoque médio é de {EstoqueMedio}");
        }

        public void CotacaoDolar()
        {
            Console.WriteLine("Qual é o valor em dolar que voce deseja cotar?");
            double dolar = double.Parse(Console.ReadLine());
            double cotacao = dolar * 5.49;
            Console.WriteLine($"o valor desse dólar convertido em reais é R${cotacao}");
        }

        public void id()
        {
            this.IdVendedor++;
            this.IdPeca++;
        }
        public void VendedorPecas()
        {
            Console.WriteLine($"Qual é o id do vendedor?");
            IdVendedor = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual é o id da Peça?");
            IdPeca = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a quantidade de peças vendidas?");
            int QuantidadeVendida = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual é o valor da peça?");
            double precoUnitario = double.Parse(Console.ReadLine());

            double valor = QuantidadeVendida * precoUnitario;

            double comissao = valor * 0.05;
            Console.WriteLine($"o id do vendedor é {IdVendedor}");
            Console.WriteLine($"o Código da peça é {IdPeca}");
            Console.WriteLine($"O preço unitário da peça é {precoUnitario}");
            Console.WriteLine($"O valor da comissão é de {comissao}");

        }


    }

}
