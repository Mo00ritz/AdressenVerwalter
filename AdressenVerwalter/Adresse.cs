using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressenVerwalter
{
    public class Adresse
    {
        public string Straße { get; set; }
        public string Stadt { get; set; }
        public string Postleitzahl { get; set; }

        public string Bezeichnung { get; set; }

        public Adresse(string straße, string stadt, string postleitzahl, string bezeichnung)
        {
            Straße = straße;
            Stadt = stadt;
            Postleitzahl = postleitzahl;
            Bezeichnung = bezeichnung;
        }

        public override string ToString()
        {
            return $"{Straße}, {Stadt}, {Postleitzahl}, {Bezeichnung}";
        }
    }
}

