class Sesi 
{
    public static void Main()
    {
        int resultadoDobro = Dobrar(3);
        int resultadoMetade = Dividir(8);
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine(resultadoDobro);
        Console.WriteLine(resultadoMetade);

        TabuadaComWhile(num1);
        SomaComDoWhile();
    }

public static int Dobrar(int n1)
{
    int resultadoDobro = n1 * 2;
    return(resultadoDobro);
}

public static int Dividir(int n2)
{
    int resultadoMetade = n2 / 2;
    return(resultadoMetade);
}


public static void TabuadaComWhile(int num)
{
    
    int contador = 1;
    
    while (contador <=10)
    {
        Console.WriteLine($"{contador}º execução: {num} x {contador} = {num * contador}");
        contador++;
    }
}

public static void SomaComDoWhile()
{
    int maior = 0;
    int menor = 10000;
    int soma = 0;
    int num = 0;

        do {
            Console.WriteLine("Informe um número positivo, negativo para encerrar");
            num = int.Parse(Console.ReadLine());

            if (num > maior)
                maior = num;

            if (num < menor && num > 0)
                menor = num;

            if (num > 0)
                soma = soma + num;
        } while (num > 0);
        Console.WriteLine($"Menor nº {menor} - maior nº {maior} - soma dos nº {soma}");
}

}