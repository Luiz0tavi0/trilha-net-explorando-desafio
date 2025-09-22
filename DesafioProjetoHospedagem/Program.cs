using System.Text;
using DesafioProjetoHospedagem;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

foreach (var nHospede in Enumerable.Range(start:1, count:10))
{
    hospedes.Add(new Pessoa(nome: $"Hóspede {nHospede}"));
}

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 10, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Desconto10OuMaisDias desconto10 = new Desconto10OuMaisDias();
Reserva reserva = new Reserva(diasReservados: 10, desconto:desconto10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");