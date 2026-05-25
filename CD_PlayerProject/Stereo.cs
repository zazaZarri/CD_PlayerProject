using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_PlayerProject
{
    public class Stereo
    {
        public CD cd { get; set; }
        public Brano canzone_playata { get; set; }
        public int x;
        public Stereo(CD cd)
        {
            this.cd = cd;
            canzone_playata = cd.Brani[x];
        }

        public CD getCD()
        {
            return cd;
        }
        public void play()
        {
            if (cd != null)
            {
                Console.WriteLine($"Playing CD: {cd.Titolo} by {cd.autore}");
                Console.WriteLine($"song playing: {canzone_playata} ");
            }
            else
            {
                Console.WriteLine("No CD inserted.");
            }
        }
        public void setCD(CD cd)
        {
            this.cd = cd;
        }
        public void nextSong()
        {
            if (x+1>cd.Brani.Count)
            {
                canzone_playata=cd.Brani[0];
                x = 0;
            }
            else
            {
                x += 1;
                canzone_playata = cd.Brani[x];
            }
        }
        public void previousSong()
        {
            if (x-1<0)
            {
                x =cd.Brani.Count;
                canzone_playata = cd.Brani[x];
                
            }
            else
            {
                x += 1;
                canzone_playata = cd.Brani[x];
            }
        }

    }
}
