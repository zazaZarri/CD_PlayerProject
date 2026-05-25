using System;
using System.Collections.Generic;

namespace CD_PlayerProject
{
    public class CasaDiscografica
    {
        public string Nome { get; set; }
        public int AnnoFondazione { get; set; }
        public string SedePrincipale { get; set; }

        public CasaDiscografica(string nome, int annoFondazione, string sedePrincipale)
        {
            Nome = nome;
            AnnoFondazione = annoFondazione;
            SedePrincipale = sedePrincipale;
        }

        public string GetNome()
        {
            return Nome;
        }

        public int GetAnnoFondazione()
        {
            return AnnoFondazione;
        }

        public string GetSedePrincipale()
        {
            return SedePrincipale;
        }

        public override string ToString()
        {
            return $"{Nome} (Fondata nel {AnnoFondazione}, Sede: {SedePrincipale})";
        }
    }
}
