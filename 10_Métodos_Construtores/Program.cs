using Models;

public class Program
{
    public static void Main()
    {
        //Criar um objeto de classe Pessoa
        /*
        Instanciando objeto sem método construtor
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "João André";
        pessoa1.idade = 16;

        //Alternativa de um objeto instanciando sem construtor
        Pessoa pessoa1 = new Pessoa{
            nome = "João",
            idade = 16
        }
        */

        //Instanciando um objeto com o método construtor
        Pessoa pessoa1 = new Pessoa("João", 16);
        //Chamando o método Cantar da classe Pessoa
        pessoa1.Cantar();

        Pessoa pessoa2 = new Pessoa("André", 16);
        //Chamando o método Cantar da classe Pessoa
        pessoa2.Cantar();

        Pessoa pessoa3 = new Pessoa("Artuzzi", 16);
        //Chamando o método Cantar da classe Pessoa
        pessoa3.Cantar();
    }
}