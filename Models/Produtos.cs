using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cantina.Models
{
    public class Produtos
    {
        public Produtos(decimal preco, String nome, int estoque)
        {
            Preco = preco;
            Nome = nome;
            Estoque = estoque;
        }
        public decimal Preco { get; set; }
        public String Nome { get; set; }
        public int Estoque { get; set; }
    }
}