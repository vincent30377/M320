using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO_Samples_008_Lidl_01;

namespace LIDL
{
    internal abstract class MuendigePerson : Person, IPayment
    {
        protected MuendigePerson(string name, string vorname, int identNr, string key) : base(name, vorname, identNr, key)
        {
        }

        public virtual void zahle(int betrag)
        {
            Console.WriteLine("tmm");
        }
    }
}
