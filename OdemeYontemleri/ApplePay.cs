using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeYontemi.OdemeYontemleri
{
    internal class ApplePay : Interface.IOdemeYontem
    {
        public string odemeYap(int tutar)
        {
            return "ApplePay ile " + tutar + " ödeme yapıldı.";
        }
    }
}
