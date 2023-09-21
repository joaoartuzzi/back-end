public class Program
{
    public static void Main()
    {
        var pessoa1 = new {
            nome = "João",
            idade = 16
        };
        var pessoa2 = new {
            nome = "André",
            idade = 16
        };
        Console.WriteLine($"A Pessoa 1 se chama {pessoa1.nome} e a Pessoa 2 {pessoa2.nome}");

        Console.WriteLine("Digite a marca do carro");
        string marcaDigitada = Console.ReadLine();
        Console.WriteLine("Digite o modelo do carro");
        string modeloDigitado = Console.ReadLine();
        Console.WriteLine("Digite o ano do carro");
        string anoDigitado = Console.ReadLine();
        Console.WriteLine("Digite a cor do carro");
        string corDigitada = Console.ReadLine();


        var carro1 = new {
            marca = marcaDigitada,
            modelo = modeloDigitado,
            ano = anoDigitado,
            cor = corDigitada
        };
        Console.WriteLine($"Caminhonete do véi Artuzzi da marca {carro1.marca}, modelo {carro1.modelo}, ano {carro1.ano} da cor {carro1.cor}");
    }
}