using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Adressbuch
{
    private List<Person> personenListe = new List<Person>();

    public void Hinzufügen(Person person)
    {
        personenListe.Add(person);
    }

    public void Entfernen(Person person)
    {
        personenListe.Remove(person);
    }

    public List<Person> AllePersonen()
    {
        return personenListe;
    }

    public Person Suchen(string nachname)
    {
        return personenListe.FirstOrDefault(p => p.Nachname == nachname);
    }
}