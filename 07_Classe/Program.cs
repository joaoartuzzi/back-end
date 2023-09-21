using Sesi.Models
class Program
{
    public static void Main()
    {
        Gato meuGato = new Gato();
        meuGato.nome = "branca";
        meuGato.cor = "branco";
        meuGato.idade = 10;
        meuGato.especie = "Isfins";
        meuGato.genero = "femea";
        meuGato.peso = 800g;

        Peixe meuPeixe = new Peixe();
        meuPeixe.especie = "Dourado";
        meuPeixe.cor = "dourado";
        meuPeixe.tamanho = 0.40m;
        meuPeixe.peso = 5;
    }
}