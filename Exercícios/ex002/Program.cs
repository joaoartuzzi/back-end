Console.WriteLine("Informe sua placa:");
string placa = Console.ReadLine();

string final = placa.Substring(placa.Length - 1, 1);

Console.WriteLine(final);

if (final == "1" || final == "2") {
    Console.WriteLine("Você não pode sair em São Paulo na segunda-feira");
} else if (final == "3" || final == "4") {
    Console.WriteLine("Você não pode sair em São Paulo na terça-feira");
} else if (final == "5" || final == "6") {
    Console.WriteLine("Você não pode sair em São Paulo na quarta-feira");
} else if (final == "7" || final == "8") {
    Console.WriteLine("Você não pode sair em São Paulo na quinta-feira");
} else if (final == "9" || final == "0") {
    Console.WriteLine("Você não pode sair em São Paulo na sexta-feira");
}