using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem;

public interface IDesconto
{
    public decimal CalcularFatorDesconto(Reserva reserva);

}

class Desconto10OuMaisDias : IDesconto
{
    public decimal CalcularFatorDesconto(Reserva reserva)
    {
        if (reserva.DiasReservados >= 10)
            return 0.1M;
        return 0;
    }
}