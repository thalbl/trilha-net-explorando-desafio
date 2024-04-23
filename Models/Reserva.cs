namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Reserva(Suite suite) 
        {
            this.Suite = suite;
   
        }
                public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("CAPACIDADE MENOR QUE O NUMERO DE HOSPEDES");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor;
            valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor -= valor * (decimal)0.1;
            }

            return valor;
        }
    }
}