using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermecado
{
    internal class Carrinho
    {
        private Dictionary<string, int > itens = new Dictionary<string, int>();

        public void AdcionarProduto(Produto produto, int quantidade)
        {
            if(itens.ContainsKey(produto.Nome))
                itens[produto.Nome] += quantidade;
            else itens[produto.Nome] = quantidade;
        }

        public double CalcularTotal(Dictionary<string, Produto> produtos)
        {
            double total = 0;  

            foreach(var item in itens)
            {
                var produto = produtos[item.Key];
                total += item.Value * produto.Preco;
            }
            return total;
        }

        public void ExibirCarrinho()
        {
            Console.WriteLine("Itens no carrinho:");

            foreach(var item in itens)
            {
                Console.WriteLine($"Produto: {item.Key}, Quantidade: {item.Value}");
            }
        }
    }
}
