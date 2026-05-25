using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_PlayerProject
{
    public class CD
    {

        public string Titolo { get; set; }
        public List<Brano> Brani { get; set; }

        public Autore autore { get; set; }

        public CD(string Titolo, List<Brano> Brani, Autore autore)
        {
            this.Titolo = Titolo;
            this.Brani = Brani;
            this.autore = autore;
        }


        public string getTitolo()
        {
            return Titolo;
        }

        public List<Brano> getBrani()
        {
            return Brani;
        }


        public Autore getAutore()
        {
            return autore;
        }



        public void setTitolo(string Titolo)
        {
            this.Titolo = Titolo;
        }

        public void setAutore(Autore autore)
        {
            this.autore = autore;
        }
    }
}
