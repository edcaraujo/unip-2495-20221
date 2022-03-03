using System;

namespace Exemplos
{
    class E09
    {
        static void Main(string[] args)
        {
            (int, double) produto = (3, 7.55);
            Console.WriteLine($"Total de {produto.Item1} itens com valor unitário de {produto.Item2}.");
          

            (int qtd, double preco) meuProduto = (6, 1.5);
            Console.WriteLine($"Total de {meuProduto.qtd} itens com valor unitário de {meuProduto.preco}.");

            var meuNovoProduto = (Qtd: 1, Preco: 11.89);
            Console.WriteLine($"Total de {meuNovoProduto.Qtd} itens com valor unitário de {meuNovoProduto.Preco}.");

            var gigaTupla = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                    11, 12, 13, 14, 15, 16, 17, 18,
                    19, 20, 21, 22, 23, 24, 25, 26);

            Console.WriteLine(gigaTupla.Item26);
        }
    }
}