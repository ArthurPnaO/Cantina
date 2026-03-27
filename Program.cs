using Cantina.Models;


Pessoas p1 = new Pessoas(0,"Arthur","Petenao");
Produtos pr1 = new Produtos(5,"Coca");

Console.WriteLine("Hello, People!");

Console.WriteLine($"ID:- {p1.ID} Nome: {p1.Nome} Sobrenome: {p1.Sobrenome}");
Console.WriteLine($"{pr1.Nome}: {pr1.Preco:c}");

