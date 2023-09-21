namespace Banco
{
    public class ContaCorrente
    {
        public string titular { get; set; }
        public decimal saldo { get; set; }

        public ContaCorrente (string titular)
        {
            this.titular = titular;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"{titular} seu saldo é: R${saldo}");
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
            Console.WriteLine($"Você depositou R${valor}");
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0 || valor > saldo)
            {
                Console.WriteLine("Você não tem todo esse valor");
            } 
            else
            {
                Console.WriteLine($"Seu saldo é R${saldo - valor}");
            }

            saldo -= valor;
        }
    }
}
