namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public IDesconto Desconto;

        public Reserva() { }

        public Reserva(int diasReservados, IDesconto desconto)
        {
            DiasReservados = diasReservados;
            Desconto = desconto;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
                Hospedes = hospedes;
            else
                throw new Exception("Capacidade excedida.");
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes => Hospedes.Count;        

        public decimal CalcularValorDiaria()
        {
            decimal valor =  DiasReservados * Suite.ValorDiaria; 
            decimal fatorDesconto = Desconto.CalcularFatorDesconto(this);
            valor -= valor * fatorDesconto;
            return valor;
        }
    }
}