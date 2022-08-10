using OdemeYontemi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeYontemi.OdemeYontemleri
{
    internal class KrediKartı : IOdemeYontem
    {
        public string odemeYap(int tutar)
        {
            return "Kredi Kartı ile " + tutar + " ödeme yapıldı.";
        }
    }
}
