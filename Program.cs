using System.Runtime.CompilerServices;
using Cantina.Models;

List<Pessoas> ListaPessoas = new List<Pessoas>();

Pessoas p1 = new Pessoas(0,"Arthur","Petenao");
Pessoas p2 = new Pessoas(0,"Jose","Regis");

ListaPessoas.Add(p1);
ListaPessoas.Add(p2);

List<Produtos> ListaProdutos = new List<Produtos>();
Produtos pr1 = new Produtos(5,"Coca",5);

ListaProdutos.Add(pr1);
Console.WriteLine("Hello, People!");

foreach(Pessoas index in ListaPessoas){
    Console.WriteLine($"ID:- {index.ID} Nome: {index.NomeCompleto}");
}

foreach(Produtos index in ListaProdutos)
{
    Console.WriteLine($"{index.Nome}: {index.Preco:c}");
}


