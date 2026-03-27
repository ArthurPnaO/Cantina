using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cantina.Models
{
    public class Produtos
    {
        public Produtos(int id, decimal preco, String nome, int estoque)
        {
            Id = id;
            Preco = preco;
            Nome = nome;
            Estoque = estoque;
        }
        public Produtos(decimal preco, String nome, int estoque)
        {
            Id = ColetarProximoIdValido();
            Preco = preco;
            Nome = nome;
            Estoque = estoque;
        }
        //Implementar próximo id válido
        private int ColetarProximoIdValido(){return 0;}
        public int Id { get; set; }
        public decimal Preco { get; set; }
        public String Nome { get; set; }
        public int Estoque { get; set; }
    }
}