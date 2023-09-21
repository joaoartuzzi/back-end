﻿using System.Collections.Generic;
using Sesi.Models;

public class program
{
    public static void Main()
    {
        //Criando uma lista de números inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos à lista
        listaNumeros.Add(10); //posição [0]
        listaNumeros.Add(20); //posição [1]
        listaNumeros.Add(45); //posição [2]

        //Contando a quantidade de objetos em nossa lista 
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNumeros[1]);

        listaNumeros.Add(6); //posição [3]
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

        Console.WriteLine("-------------------------------------------------");

        //Criem uma nova lista de nomes e adiciona alguns nomes a ela e exibam a quantidade de nomes que contém nessa lista
        List<string> listaNomes = new List<string>();

        listaNomes.Add("Artuzzi");
        listaNomes.Add("Gilberto");
        listaNomes.Add("Milton");
        
        Console.WriteLine($"Temos {listaNomes.Count} Adicionados");

        Console.WriteLine("-------------------------------------");

        //Criando uma lista já atribuindo valores
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};
        numeros.Add(10);

        //Iterando sobre todos os itens da lista
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        numeros.Remove(2); //Remove o elemento buscando pelo conteúdo
        numeros.RemoveAt(4); //Remove o elemento pela posição (índice)
        numeros.RemoveRange(2, 2); //Remove o elemento da posição 2 e os próximos 2 elementos
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        //Criando uma nova lista da classe aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionando um novo aluno à listaAluno
        Aluno novoAluno = new Aluno("Marcos", 15);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("César", 17));
        listaAlunos.Add(new Aluno("Patrícia", 19));

        Console.WriteLine("Lista de Alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome Aluno: {item.nome} idade {item.idade}");
        }

        //Criando uma nova lista, filtrando e ordenando por nome
        //LINQ utilizando Sintaxe de consulta
        var consulta = from aluno in listaAlunos
                        where aluno.idade > 18
                        orderby aluno.nome
                        select aluno;
        Console.WriteLine("Lista de alunos maiores de 18 anos");
        foreach (var item in consulta)
        {
            Console.WriteLine($"Nome Aluno: {item.nome} idade: {item.idade}");
        }

        //LINQ utilizando Sintaxe de método
        var metodo = listaAlunos
                            .Where(aluno => aluno.idade < 18)
                            .OrderBy(aluno => aluno.nome);
        Console.WriteLine("Lista de alunos menores de 18 anos");
        foreach (var item in metodo)
        {
            Console.WriteLine($"Nome Aluno: {item.nome} idade: {item.idade}");
        }
    }
}