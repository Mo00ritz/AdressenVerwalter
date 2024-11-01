using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressenVerwalter
{
    internal class Telefonnummer
    {
        public int laendercode { get; set; }
        public int vorwahl { get; set; }
        public int nummer { get; set; }
        public string bezeichnung { get; set; }

        public Telefonnummer(int Laendercode, int Vorwahl, int Nummer, string Bezeichnung)
        {
            this.laendercode = Laendercode;
            this.vorwahl = Vorwahl;
            this.nummer = Nummer;
            this.bezeichnung = Bezeichnung;
        }

        public override string ToString()
        {
            return $"+{laendercode} ({vorwahl}) {nummer} - {bezeichnung}";
        }
    }
}
