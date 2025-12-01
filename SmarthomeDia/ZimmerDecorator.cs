using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarthomeDia
{
    public abstract class ZimmerDecorator
    {
        public string Name { get; set; }
        public bool PersonImZimmer { get; set; }
        public double TemperaturVorgabe { get; set; }
        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            //TODO
        }
    }
}
