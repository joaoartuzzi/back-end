class Program
{
    public static string[] poltronas = new string[14];

    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem-Vindo ao UsBrutusTur");
        Console.WriteLine("------------------------");
        Console.WriteLine("Contamos com 13 lugares");

        Menu();
    }

    public static void Menu(){
        string opcao = "";

        contacorrente conta = new contacorrente(titular, 0);

        do {
            Console.WriteLine("######## M E N U ########");
            Console.WriteLine("1- Para comprar passagem");
            Console.WriteLine("2- Para poltronas disponíveis");
            Console.WriteLine("3- Quantidade disponivel");
            Console.WriteLine("4- Lista de passageiros");
            Console.WriteLine("0- Para fechar sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao){
                case "0":
                    Console.WriteLine("Obrigado, volte sempre !!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                    PoltronasDisponiveis();
                    break;
                case "3":
                    QuantidadeDisponivel();
                    break;
                    case "4":
                    ListaPassageiros();
                    break;
                default:
                    Console.WriteLine("Opcçao inválida!!!");
                    break;
            }

        } while (opcao != "0");

    }

    public static void ComprarPassagem() {
        Console.WriteLine("Quantas passagens deseja comprar?");
        int nrPassagens = int.Parse(Console.ReadLine());

        for (int i= 1; i <= nrPassagens; i++){
            Console.WriteLine($"Digite a poltrona da {i}ª passagem:");
            int nrPoltorna = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro:");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltorna, nome);
        }
    }

    public static void MarcarPoltrona(int nrPoltorna, string nome){
        poltronas[nrPoltorna] = nome;
    }

    public static void PoltronasDisponiveis(){
        Console.WriteLine("Lista de Poltronas disponíveis");
        for(int i = 1; i <= 13; i++){
            if (poltronas[i] == null)
            {
                Console.WriteLine($"Nº {i}");
            }
        }
    }
    public static void QuantidadeDisponivel(){
        int total = 0;
        //for (int i= 1; i <= 13; i++){
        //    if (poltronas[i] == null)
        //    {
        //        total++;
        //    }
        //}
        foreach (string item in poltronas)
        //total = (item == null) ? total += 1 : total += 0;
        {
            if (item == null)
                total = total + 1;
        }
        Console.WriteLine("Temos " + total + " poltronas disponíveis");
    }
    public static void ListaPassageiros(){
        Console.WriteLine("Lista de Passageiros");
        for(int i = 1; i <= 13; i++){
            if (poltronas[i] != null)
            {
                Console.WriteLine($"Nº {i} - Nome: {poltronas[i]}");
            }
        }
    }

}