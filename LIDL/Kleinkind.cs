using OO_Samples_008_Lidl_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Samples_008_Lidl_03
{
    public class Kleinkind : Person
    {
        public int Alter { get; set; }

        public Kleinkind(string vorname, string name, int identNr, string key, int alter) : base(vorname, name, identNr, key)
        {
            Alter = alter;
        }

        public override void Esse()
        {
            base.Esse();
            Console.WriteLine("   ... Nein, als Kleinkind {0} {1} {2} mit Alter {3} natürlich von Hand...", Vorname, Name, IdentNr ,Alter);
        }

        public override void Trage()
        {
            Console.WriteLine("Ich als Kleinkind {0} {1} {2} trage gar nichts", Vorname, Name, IdentNr);

        }
    }
}
