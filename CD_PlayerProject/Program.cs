using System;
using System.Collections.Generic;
using CD_PlayerProject;

namespace CD_PlayerProject 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BENVENUTO NEL CREATORE DI CD ===");
            
            // 1. Creazione Autore
            Console.WriteLine("\n--- Creazione Autore del CD ---");
            Console.Write("Inserisci il nome dell'autore: ");
            string nomeAutore = Console.ReadLine() ?? "Sconosciuto";
            
            Console.Write("Inserisci il cognome dell'autore: ");
            string cognomeAutore = Console.ReadLine() ?? "";
            
            Console.Write("Inserisci l'età dell'autore: ");
            int etaAutore;
            while (!int.TryParse(Console.ReadLine(), out etaAutore))
            {
                Console.Write("Età non valida. Inserisci un numero: ");
            }

            Autore autoreCD = new Autore(nomeAutore, cognomeAutore, etaAutore);
            Console.WriteLine($"Autore creato: {autoreCD.GetFullName()} (Età: {autoreCD.GetEta()})");

            // 2. Creazione Brani
            Console.WriteLine("\n--- Creazione Brani ---");
            List<Brano> listaBrani = new List<Brano>();
            bool inserisciAncora = true;

            while (inserisciAncora)
            {
                Console.Write("Inserisci il titolo del brano: ");
                string titoloBrano = Console.ReadLine() ?? "Titolo Ignoto";
                
                Console.Write("Inserisci la durata del brano in secondi: ");
                int durata;
                while (!int.TryParse(Console.ReadLine(), out durata) || durata <= 0)
                {
                    Console.Write("Durata non valida. Inserisci un numero di secondi positivo: ");
                }
                
                Brano nuovoBrano = new Brano(titoloBrano, durata, autoreCD);
                listaBrani.Add(nuovoBrano);
                Console.WriteLine($"Brano aggiunto: {nuovoBrano.ToString()}");

                Console.Write("\nVuoi inserire un altro brano in questo CD? (s/n): ");
                string risposta = Console.ReadLine() ?? "n";
                if (risposta.ToLower() != "s")
                {
                    inserisciAncora = false;
                }
            }

            // 3. Creazione CD
            Console.WriteLine("\n--- Creazione CD ---");
            Console.Write("Inserisci il titolo del CD: ");
            string titoloCD = Console.ReadLine() ?? "CD Senza Titolo";

            CD mioCD = new CD(titoloCD, listaBrani, autoreCD);

            // 4. Test Funzionalità CD
            Console.WriteLine("\n=== TEST FUNZIONALITÀ CD ===");
            Console.WriteLine($"Titolo CD (getTitolo): {mioCD.getTitolo()}");
            Console.WriteLine($"Autore CD (getAutore): {mioCD.getAutore().GetFullName()}");
            
            Console.WriteLine("\nLista dei brani nel CD (getBrani):");
            foreach (Brano b in mioCD.getBrani())
            {
                Console.WriteLine($" - {b.getTitolo()} ({b.getDurata()} sec)");
            }

            // 5. Test Funzionalità Brano
            Console.WriteLine("\n=== TEST FUNZIONALITÀ BRANO ===");
            if (listaBrani.Count > 0)
            {
                Brano branoTest = listaBrani[0];
                Console.WriteLine($"Test sul primo brano: {branoTest.getTitolo()}");
                Console.Write("Inserisci un limite di secondi per testare la funzione 'shortSong': ");
                
                int limite;
                if (int.TryParse(Console.ReadLine(), out limite))
                {
                    try
                    {
                        bool isShort = branoTest.shortSong(limite);
                        Console.WriteLine($"Il brano dura meno o uguale a {limite} secondi? {isShort}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Eccezione catturata durante il test: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Nessun brano presente per effettuare il test.");
            }

            Console.WriteLine("\nTest completati. Premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}
