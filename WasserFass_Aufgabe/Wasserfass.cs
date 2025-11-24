using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasserFass_Aufgabe
{
    public class Wasserfass
    {
        private int minimalPegel;
        private int maximalPegel;
        private int fuellstand;

        public int MinimalPegel
        {
            get { return minimalPegel; }
        }
        public int MaximalPegel
        {
            get { return maximalPegel; }
        }
        public int Fuellstand
        {
            get { return fuellstand; }
        }
        public int Kapazitaet
        {
            get { return maximalPegel - minimalPegel; }
        }
        public Wasserfass(int kapazitaet)
        {
            minimalPegel = 0;
            maximalPegel = kapazitaet;
            fuellstand = 0;
        }
        public void Befuellen(int menge)
        {
            if (menge > 0)
            {
                fuellstand = fuellstand + menge;
                if (fuellstand > maximalPegel)
                {
                    fuellstand = maximalPegel;
                }
            }
        }
        public void Entnehmen(int menge)
        {
            if (menge > 0)
            {
                fuellstand = fuellstand - menge;
                if (fuellstand < minimalPegel)
                {
                    fuellstand = minimalPegel;
                }
            }
        }
        public void Entleeren()
        {
            fuellstand = minimalPegel;
        }
    }
}
s