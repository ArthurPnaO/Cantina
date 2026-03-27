using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Cantina.Models
{
    public class Pessoas
    {
        public Pessoas(int id, String nome, String sobrenome, decimal saldo)
        {
            ID = id;
            Nome = nome.ToUpper();
            Sobrenome = sobrenome.ToUpper();
            NomeCompleto = $"{Nome} {Sobrenome}";
            Saldo = saldo;
        }
        public Pessoas( String nome, String sobrenome, decimal saldo)
        {
            ID = ColetarProximoIdValido();
            Nome = nome.ToUpper();
            Sobrenome = sobrenome.ToUpper();
            NomeCompleto = $"{Nome} {Sobrenome}";
            Saldo = saldo;
        }
        public Pessoas(int id, String nome, String sobrenome)
        {
            ID = id;
            Nome = nome.ToUpper();
            Sobrenome = sobrenome.ToUpper();
            NomeCompleto = $"{Nome} {Sobrenome}";
            Saldo = 0M;
        }
        public Pessoas(String nome, String sobrenome)
        {
            ID = ColetarProximoIdValido();
            Nome = nome.ToUpper();
            Sobrenome = sobrenome.ToUpper();
            NomeCompleto = $"{Nome} {Sobrenome}";

        }



        public int ID { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }

        public String NomeCompleto {get;}

        public decimal Saldo { get; set; }

        private void AdicionarNome(String nome)
        {
            ListaPessoas
        }
        private int ColetarProximoIdValido(){return 0;}
    }
}