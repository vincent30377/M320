using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Samples_008_Lidl_01
{
    public class Kunde : MuendigePerson
    {

        public void zahle(int betrag);
        {
            Console.WriteLine($"Ich als Kunde {Vorname} {Name} {Betrag}")
        }
        public double Umsatz { get; set; }

        public Kunde(string vorname, string name, int identNr, string key, double umsatz) : base(vorname, name, identNr, key)
        {
            Umsatz = umsatz;
        }

        public void Kaufe()
        {
            Console.WriteLine("Ich als Kunde {0} {1} {2} kaufe bei Lidl", Vorname, Name, IdentNr);
        }

        public override void Trage()
        {
            Console.WriteLine("Ich als Kunde {0} {1} {2} trage mit dem Einkaufswagen", Vorname, Name, IdentNr);
        }

        public void TestKey()
        {
            Console.WriteLine(this.Umsatz);   //ist public
            Console.WriteLine(this.IdentNr);  //ist protected
            // Console.WriteLine(this.Key);      //ist private
        }
    }
}
