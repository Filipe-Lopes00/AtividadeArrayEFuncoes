using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeArrayEFuncoes
{
    internal class Program
    {
        static int[] LerValores()
        {
            int[] valores = new int[10];
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write("Digite o {0}º valor: ", i + 1);
                valores[i] = int.Parse(Console.ReadLine());
            }
            return valores;
        }

        static int MaiorValor(int[] valores)
        {
            return valores.Max();
        }

        static int MenorValor(int[] valores)
        {
            return valores.Min();
        }

        static double ValorMedio(int[] valores)
        {
            return valores.Average();
        }

        static int[] MaioresValores(int[] valores, int n)
        {
            return valores.OrderByDescending(x => x).Take(n).ToArray();
        }

        static int[] ValoresNegativos(int[] valores)
        {
            return valores.Where(x => x < 0).ToArray();
        }

        static int[] RemoverValor(int[] valores)
        {
            Console.Write("Digite o índice do valor a ser removido: ");
            int indiceRemover = int.Parse(Console.ReadLine());
            return valores.Where((x, i) => i != indiceRemover).ToArray();
        }
        static void Main(string[] args)
        {
            int[] valores = LerValores();
            Console.WriteLine("Maior valor: {0}", MaiorValor(valores));
            Console.WriteLine("Menor valor: {0}", MenorValor(valores));
            Console.WriteLine("Valor médio: {0}", ValorMedio(valores));
            Console.Write("Maiores valores: ");
            foreach (int valor in MaioresValores(valores, 3))
            {
                Console.Write("{0} ", valor);
            }
            Console.WriteLine();
            Console.Write("Valores negativos: ");
            foreach (int valor in ValoresNegativos(valores))
            {
                Console.Write("{0} ", valor);
            }
            Console.WriteLine();
            Console.Write("Valores da sequência: ");
            foreach (int valor in valores)
            {
                Console.Write("{0} ", valor);
            }
            Console.WriteLine();
            valores = RemoverValor(valores);
            Console.Write("Valores da sequência após remoção: ");
            foreach (int valor in valores)
            {
                Console.Write("{0} ", valor);
            }
            Console.WriteLine();
        }

       

    }
}
