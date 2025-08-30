
namespace ESTACIONAMENTOAPP.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? placa = Console.ReadLine()?.Trim();

            if (!string.IsNullOrEmpty(placa))
            {
                veiculos.Add(placa.ToUpperInvariant());
                Console.WriteLine($"Veículo {placa} adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa inválida.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string? placa = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(placa))
            {
                Console.WriteLine("Placa inválida.");
                return;
            }

            string placaUpper = placa.ToUpperInvariant();

            if (veiculos.Any(x => string.Equals(x, placaUpper, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string? entradaHoras = Console.ReadLine();
                if (!int.TryParse(entradaHoras, out int horas) || horas < 0)
                {
                    Console.WriteLine("Quantidade de horas inválida.");
                    return;
                }

                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.RemoveAll(x => string.Equals(x, placaUpper, StringComparison.OrdinalIgnoreCase));
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Veículos estacionados:");
                foreach (string v in veiculos)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
