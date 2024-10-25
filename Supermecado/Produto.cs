using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermecado
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public bool ReduzirEstoque(int quantidade)
        {
            if(quantidade <= Estoque)
            {
                Estoque -= quantidade;
                return true;
            }
            return false;
        }
    }
    
}
