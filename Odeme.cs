using OdemeYontemi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeYontemi
{
    internal class Odeme
    {
        public IOdemeYontem odemeYontem;

        
        public Odeme(IOdemeYontem odemeYontem)
        {
            this.odemeYontem = odemeYontem;
        }

        public string odemeYap(int tutar)
        {
            return odemeYontem.odemeYap(tutar);
        }
    }
}
