using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIDL;

namespace OO_Samples_008_Lidl_01
{
    public abstract class Person : IPublish
    {
        public string Publiziere => throw new NotImplementedException();
        
    public string Name { get; set; }
        public string Vorname { get; set; }
        protected int IdentNr { get; private set; }
        private string Key { get; set; }

        public Person(string name, string vorname, int identNr, string key)
        {
            Name = name;
            Vorname = vorname;
            IdentNr = identNr;
            Key = key;
        }

        public void publiziere(string text)
        {
            Console.WriteLine($"Ich als Kunde {text}");
        }

        public virtual void Esse()
        {
            System.Console.WriteLine("Ich als Person {0} {1} {2} esse mit Messer und Gabel", Vorname, Name, IdentNr);
        }

        public abstract void Trage();
    }
}
