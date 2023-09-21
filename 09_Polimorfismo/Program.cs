//Classe Pai que será herdada - SuperClasse
class Animal
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal fazendo algum som");
    }
}

//Classe filha que herdará da classe Animal
class Cachorro : Animal
{
    //Sobrescrevendo o método EmitirSom
    public override void EmitirSom()
    {
        Console.WhiteLine{$"Cachorro da cor {cor} está latindo! au au au"}
    }
}

class Gato : Animal
{
    //Sobrescrevendo o método EmitirSom
    public override void EmitirSom()
    {
        Console.WriteLite($"Gato da cor {cor} está miando! miau miau");
    }
    public override void Ronronar()
    {
        Console.WhiteLine("O gato está ronronando!")
    }
}

class Program
{
    public static void Main()
    {
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "preto";
        animalGenerico.EmitirSom();
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "preto";
        meuCachorro.EmitirSom();
        // meuCachorro.Ronronar(); // Não posso chamar este método pois não existe nessa classe
        Gato meuGato = new Gato();
        meuGato.cor = "branco";
        meuGato.EmitirSom();
        meuGato.Ronronar();
    }
}