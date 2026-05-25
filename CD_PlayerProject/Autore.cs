using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_PlayerProject
{
    public class Autore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

        public Autore(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }


        public string GetFullName()
        {
            return $"{Nome} {Cognome}";
        }

        public int GetEta()
        {
            return Eta;
        }
    }
}
