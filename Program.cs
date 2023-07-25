using AtvProdutos;
using System.Reflection.Metadata.Ecma335;

Base Pipoca = new Base();
Pipoca.nome = "Pipoca";
Pipoca.quantidade = 10;
Pipoca.descrição = "Milho para fazer pipoca";
Pipoca.preço = 4.80;
Pipoca.Disponivel();
Pipoca.status = true;

Pipoca.mostra();
Console.ReadKey();

Base Miojo = new Base();
Miojo.nome = "Miojo";
Miojo.quantidade = 20;
Miojo.descrição = "Pacote de macarrão instantanêo";
Miojo.preço = 2.50;
Miojo.Disponivel();
Miojo.status = true;

Miojo.mostra();
Console.ReadKey();

Base Queijo = new Base();
Queijo.nome = "Queijo";
Queijo.quantidade = 12;
Queijo.descrição = "Queijo mineiro de Otima qualidade";
Queijo.preço = 7.50;
Queijo.Disponivel();
Queijo.status = true;

Queijo.mostra();
Console.ReadKey();

Console.WriteLine("Digite o nome do produto que você deseja desativar");
string resposta = Console.ReadLine();
for (int contador = 0; contador < 2; contador++)
{



    switch (resposta)
    {
        case "Pipoca":
            Pipoca.desativaProduto();
            Pipoca.mostra();
            break;

        case "Miojo":
            Miojo.desativaProduto();
            Miojo.mostra();
            break;

        case "Queijo":
            Queijo.desativaProduto();
            Queijo.mostra();
            break;
        default:
            return;
    }
  
}
Console.WriteLine("Digite o nome do produto que você deseja desativar");
resposta = Console.ReadLine();
for (int contador = 0; contador < 2; contador++)
{



    switch (resposta)
    {
        case "Pipoca":
            Pipoca.desativaProduto();
            Pipoca.mostra();
            break;

        case "Miojo":
            Miojo.desativaProduto();
            Miojo.mostra();
            break;

        case "Queijo":
            Queijo.desativaProduto();
            Queijo.mostra();
            break;
        default:
            return;
    }

}




