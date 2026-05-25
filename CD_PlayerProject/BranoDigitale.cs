using System;

namespace CD_PlayerProject
{
    // BranoDigitale eredita dalla classe Brano (utilizzando i due punti ':')
    public class BranoDigitale : Brano
    {
        public string Formato { get; set; }
        public int BitrateKbps { get; set; }
        public double DimensioneMB { get; set; }

        // Il costruttore richiama il costruttore della classe base (Brano) usando "base(...)"
        public BranoDigitale(string titolo, int durata_s, Autore autore, string formato, int bitrateKbps, double dimensioneMB) 
            : base(titolo, durata_s, autore)
        {
            Formato = formato;
            BitrateKbps = bitrateKbps;
            DimensioneMB = dimensioneMB;
        }

        public string GetFormato()
        {
            return Formato;
        }

        public int GetBitrate()
        {
            return BitrateKbps;
        }

        public double GetDimensione()
        {
            return DimensioneMB;
        }

        // Sovrascriviamo il metodo ToString per aggiungere i dettagli digitali
        public override string ToString()
        {
            // Richiamiamo il ToString della classe base (Brano) e aggiungiamo le nuove informazioni
            return $"{base.ToString()} - Formato: {Formato} ({BitrateKbps} kbps, {DimensioneMB} MB)";
        }
    }
}
