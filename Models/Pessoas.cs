using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Cantina.Models
{
    public class Pessoas
    {
        public Pessoas(int id, String nome, String sobrenome)
        {
            ID = id;
            Nome = nome;
            Sobrenome = sobrenome;

        }



        public int ID { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
    }
}