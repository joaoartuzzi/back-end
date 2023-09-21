class ex005 {
    public static void Main()
    {
        //Chamar Método
        ListaDoChurrasco();
        SonhosDeConsumo();
    }

    public static void ListaDoChurrasco(){
        //Declarar o vetor com 6 posições tipo string
        string[] listaProdutos = new string[6];
        //Receber os produtos que precisamm ser comprados
        listaProdutos[0] = "carne 3kg";
        for (int i = 0; i < listaProdutos.Length; i++)
        {
        Console.WriteLine("Informe o produto:");
        string produto = Console.ReadLine();
        listaProdutos[i] = produto;
        }

        //Ordenar vetor
        Array.Sort(listaProdutos);

        //"Para cada" item na lista exibir no console
        foreach (string item in listaProdutos)
        {
            Console.WriteLine($"Item {item}");
        }
    }

    public static void SonhosDeConsumo(){
        string[] listaSonhos = new string(3);
        int[] valorSonhos = new int[3];
        int soma = 0;

        for (int i = 0; i < listaSonhos.Length; i++)
        {
            Console.WriteLine("Informe o sonho:");
            string sonho = Console.ReadLine();
            listaSonhos[i] = sonho;

            Console.WriteLine("Informe o valor:");
            int valor = Console.ReadLine();
            valorSonhos[i] = valor;
        }

        foreach(int item in listaSonhos)
        soma += item;

        Console.WriteLine ($"Seus sonhos custarão R$ {soma}");
    }
}