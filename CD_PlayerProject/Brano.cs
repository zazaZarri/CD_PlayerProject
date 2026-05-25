using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_PlayerProject
{
    public class Brano
    {
        public string Titolo { get; set; }
        public int Durata_S { get; set; }
        public Autore autore { get; set; }
        public Brano(string Titolo, int Durata_s, Autore autore)
        {
            this.Titolo = Titolo;
            this.Durata_S = Durata_s;
            this.autore = autore;
        }
        public string getTitolo()
        {
            return Titolo;
        }
        public Autore getAutore()
        {
            return autore;
        }
        public int getDurata()
        {
            return Durata_S;
        }

        public override string ToString()
        {
            return $"Titolo: {Titolo} - Autore: {autore} - Durata: {Durata_S}";
        }
        public bool shortSong(int x)
        {
            if (x <= 0)
            {
                throw new ArgumentException("iol valore deve essere positivo");
            }
            if (Durata_S <= x)
            {
                return true ;
            }
            else
            {
                return false ;
            }
        }

    }
}
