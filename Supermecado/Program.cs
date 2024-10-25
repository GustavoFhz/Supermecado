using Supermecado;

Supermercado supermecado = new();

Console.WriteLine("Bem vindo ao supermercado C#");

while (true)
{
    supermecado.ExibirProduto();
    supermecado.SelecionarProduto();

    Console.WriteLine("Deseja finalizar as compras? (s/n)");

    if(Console.ReadLine().ToLower() == "s")
    {
        supermecado.FinalizarCompra();
    }
}