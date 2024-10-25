using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermecado
{
    internal class Supermercado
    {
        private Dictionary<string, Produto> produtos = new Dictionary<string, Produto>();
        private Carrinho carrinho = new Carrinho();

        public Supermercado()
        {
            produtos["arroz"] = new Produto("arroz", 10.5, 50);
            produtos["feijão"] = new Produto("feijão", 8.3, 30);
            produtos["macarrão"] = new Produto("macarrão", 4.5, 40);
            produtos["pasta de dente"] = new Produto("pasta de dente", 2.5, 20);
            produtos["frango"] = new Produto("frango", 9.2, 60);
        }

        public void ExibirProduto()
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine($"{produto.Key} - Preço: {produto.Value.Preco} - Estoque {produto.Value.Estoque}");
            }
        }

        public void SelecionarProduto()
        {
            Console.WriteLine("Informe o nome do produto que deseja comprar:");
            var produtoEscolhido = Console.ReadLine().ToLower();

            if (produtos.ContainsKey(produtoEscolhido))
            {
                var produto = produtos[produtoEscolhido];
                Console.WriteLine("Informe a quantidade desejada do produto:");
                var quantidadeDesejada = Convert.ToInt32(Console.ReadLine());

                if (produto.ReduzirEstoque(quantidadeDesejada))
                {
                    carrinho.AdcionarProduto(produto, quantidadeDesejada);
                    Console.WriteLine($"Adicionado {quantidadeDesejada} de {produto.Nome} ao carrinho.");
                }
                else
                {
                    Console.WriteLine("Quantidade solicitada é maior que em estoque.");
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        public void FinalizarCompra()
        {
            carrinho.ExibirCarrinho();
            double total = carrinho.CalcularTotal(produtos);
            Console.WriteLine($"Total da compra: {total}");
        }

    }
}
