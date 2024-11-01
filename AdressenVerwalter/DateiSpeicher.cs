using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AdressenVerwalter
{
    internal static class DateiSpeicher
    {
        public static void beispielPersonen(Adressbuch adressbuch)
        {
            adressbuch.Hinzufügen(new Person("1234", "Max", "Mustermann", "max@example.com", "Entwickler"));
            adressbuch.Hinzufügen(new Person("5678", "Erika", "Musterfrau", "erika@example.com", "Manager"));
        }
    }
}