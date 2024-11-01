using AdressenVerwalter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Person
{
    public string Personalnummer { get; set; }
    public string Vorname { get; set; }
    public string Nachname { get; set; }
    public string Geburtsdatum { get; set; }
    public List<AdressenVerwalter.Adresse> Adressen { get; set; }
    public List<AdressenVerwalter.Telefonnummer> Telefonnummer { get; set; }
    public string Email { get; set; }
    public string Position { get; set; }

    public Person(string personalNummer, string vorname, string nachname,string geburtsdatum, string email, string position)
    {
        Personalnummer = personalNummer;
        Vorname = vorname;
        Nachname = nachname;
        Geburtsdatum = geburtsdatum;
        Email = email;
        Position = position;
        Adressen = new List<AdressenVerwalter.Adresse>();
        Telefonnummer = new List<AdressenVerwalter.Telefonnummer>();
    }

    public void AdresseHinzufügen(AdressenVerwalter.Adresse adresse)
    {
        Adressen.Add(adresse);
    }
    public void TelefonummerHinzufügen(AdressenVerwalter.Telefonnummer telefonnummer)
    {
        Telefonnummer.Add(telefonnummer);
    }
    public override string ToString()
    {
        return $"{Vorname} {Nachname} ({Personalnummer})";
    }

}