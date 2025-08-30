
using ESTACIONAMENTOAPP.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal LerDecimal(string mensagem)
{
    decimal valor;
    while (true)
    {
        Console.WriteLine(mensagem);
        string? entrada = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(entrada) && decimal.TryParse(entrada, out valor))
            return valor;

        Console.WriteLine("Valor inválido. Tente novamente.");
    }
}

decimal precoInicial = LerDecimal("Digite o preço inicial:");
decimal precoPorHora = LerDecimal("Digite o preço por hora:");

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadKey(true);
}

Console.WriteLine("O programa se encerrou");
