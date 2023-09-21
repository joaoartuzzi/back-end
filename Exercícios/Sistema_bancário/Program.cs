using Banco;

public class Program
{

    public static void Main()
    {
        Console.Clear();

        Menu();
    }
    public static void Menu(){

        Console.WriteLine("titular da conta");
        string Titular = Console.ReadLine();
        Console.WriteLine($"Bem-vindo ao sistema {Titular}");
        ContaCorrente titular = new ContaCorrente(Titular);
        titular.titular = Titular;

        string opcao = "";

        do {
            Console.WriteLine("######## M E N U ########");
            Console.WriteLine("1- Consultar saldo");
            Console.WriteLine("2- Depositar");
            Console.WriteLine("3- Sacar");
            Console.WriteLine("0- Para fechar sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao){
                case "0":
                    Console.WriteLine("Obrigado, volte sempre !!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    titular.ConsultarSaldo();
                    break;
                case "2":
                    Console.WriteLine("Informe o valor a ser depositado");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    titular.Depositar(valor);
                    break;
                case "3":
                Console.WriteLine("Informe o valor a ser depositado");
                    titular.Sacar(decimal.Parse(Console.ReadLine()));
                    break;
                default:
                    Console.WriteLine("Opcçao inválida!!!");
                    break;
            }

        } while (opcao != "0");

    }
}
