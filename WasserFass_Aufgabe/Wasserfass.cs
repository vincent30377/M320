using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasserFass_Aufgabe
{
    public class Wasserfass
    {
        private readonly int minimalPegel = 0;
        private readonly int maximalPegel;
        public int fuellstand { get; private set; }
        public int kapazitaet => maximalPegel;

        public void Befuellen(int menge)
        {
            if (menge < 0)
                Console.WriteLine("menge darf nicht negativ sein");

            fuellstand += menge;

            if (fuellstand > maximalPegel)
                fuellstand = maximalPegel;
        }
        public void Entnehmen(int menge)
        {
            if (menge < 0)
                Console.WriteLine("menge darf nicht negativ sein");

            fuellstand -= menge;

            if (fuellstand < minimalPegel)
                fuellstand = minimalPegel;
        }

        public void Entleeren()
        {
            fuellstand = minimalPegel;

        }
    }
}
