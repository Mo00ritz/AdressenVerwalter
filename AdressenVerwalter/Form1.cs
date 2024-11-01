using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdressenVerwalter
{
    public partial class Form1 : Form
    {
        private Adressbuch adressbuch = new Adressbuch();
        private int personalnummerCounter = 000;

        public Form1()
        {
            InitializeComponent();
            BeispielPersonenHinzufügen();
            AktualisiereListe();
        }
        //Neue Person anlegen
        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVorname.Text) ||
                string.IsNullOrWhiteSpace(txtNachname.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
                return;
            }

            string generiertePersonalnummer = GenerierePersonalnummer();

            var person = new Person(generiertePersonalnummer, txtVorname.Text, txtNachname.Text,txtGeburtsdatum.Text, txtEmail.Text, txtPosition.Text);
            adressbuch.Hinzufügen(person);
            AktualisiereListe();
            LeereEingabefelder();
        }
        //Leert die Eingabefelder
        private void LeereEingabefelder()
        {
            txtPersonalnummer.Clear();
            txtVorname.Clear();
            txtNachname.Clear();
            txtGeburtsdatum.Clear();
            txtEmail.Clear();
            txtPosition.Clear();
        }
        //Entfernt eine Person
        private void btnEntfernen_Click(object sender, EventArgs e)
        {
            var person = adressbuch.Suchen(txtNachname.Text);
            if (person != null)
            {
                adressbuch.Entfernen(person);
                AktualisiereListe();
            }
            else
            {
                MessageBox.Show("Person nicht gefunden.");
            }
        }
        //Nach einer Person suchen Nachname only
        private void btnSuchen_Click(object sender, EventArgs e)
        {
            var person = adressbuch.Suchen(txtNachnameSuchen.Text);
            if (person != null)
            {
                MessageBox.Show($"{person.Vorname} {person.Nachname} gefunden.");
            }
            else
            {
                MessageBox.Show("Person nicht gefunden.");
            }
        }
        //Zeigt die Daten einer ausgewählten Person an
        private void listBoxPersonen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPersonen.SelectedItem is Person selectedPerson)
            {
                txtPersonalnummer.Text = selectedPerson.Personalnummer;
                txtVorname.Text = selectedPerson.Vorname;
                txtNachname.Text = selectedPerson.Nachname;
                txtGeburtsdatum.Text = selectedPerson.Geburtsdatum;
                txtEmail.Text = selectedPerson.Email;
                txtPosition.Text = selectedPerson.Position;

                AktualisiereAdressenListe(selectedPerson);
                AktualisiereTelefonnummernListe(selectedPerson);
            }
        }
        //Aktualisiert die Liste
        private void AktualisiereListe()
        {
            listBoxPersonen.Items.Clear();

            foreach (var person in adressbuch.AllePersonen())
            {
                listBoxPersonen.Items.Add(person);
            }
        }
        //Button um eine Adresse hinzuzufügen
        private void btnAddAdresse_Click(object sender, EventArgs e)
        {
            if (listBoxPersonen.SelectedItem is Person selectedPerson)
            {
                string neueStraße = Prompt.ShowDialog("Straße:", "Neue Adresse");
                string neueStadt = Prompt.ShowDialog("Stadt:", "Neue Adresse");
                string neuePLZ = Prompt.ShowDialog("Postleitzahl:", "Neue Adresse");
                string neueBezeichnung = Prompt.ShowDialog("Bezeichnung:", "Bezeichnung");

                if (string.IsNullOrWhiteSpace(neueStraße) ||
                    string.IsNullOrWhiteSpace(neueStadt) ||
                    string.IsNullOrWhiteSpace(neuePLZ) ||
                    string.IsNullOrWhiteSpace(neueBezeichnung))
                {
                    MessageBox.Show("Bitte füllen Sie alle Felder aus.");
                    return;
                }

                Adresse neueAdresse = new Adresse(neueStraße, neueStadt, neuePLZ, neueBezeichnung);
                selectedPerson.AdresseHinzufügen(neueAdresse);

                AktualisiereAdressenListe(selectedPerson);
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Person aus.");
            }
        }
        //Adresse zu einer Person hinzuzufügen
        private void btnAdresseEntf_Click(object sender, EventArgs e)
        {
            if (listBoxPersonen.SelectedItem is Person selectedPerson && listBoxAdressen.SelectedItem != null)
            {
                string ausgewählteAdresse = listBoxAdressen.SelectedItem.ToString();

                if (selectedPerson.Adressen.RemoveAll(a => a.ToString() == ausgewählteAdresse) > 0)
                {
                    MessageBox.Show("Adresse erfolgreich entfernt.");
                    AktualisiereAdressenListe(selectedPerson);
                }
                else
                {
                    MessageBox.Show("Fehler beim Entfernen der Adresse.");
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Person und eine Adresse aus.");
            }
        }
        //Aktualisiert die Telefonnummerliste
        private void AktualisiereTelefonnummernListe(Person person)
        {
            listBoxTel.Items.Clear();
            foreach (var telefonnummer in person.Telefonnummer)
            {
                listBoxTel.Items.Add(telefonnummer.ToString());
            }
        }
        //Aktualisiert die Adressen Liste
        private void AktualisiereAdressenListe(Person person)
        {
            listBoxAdressen.Items.Clear();
            foreach (var adresse in person.Adressen)
            {
                listBoxAdressen.Items.Add(adresse.ToString());
            }
        }
        //Tel entfernen
        private void btnTelEntf_Click(object sender, EventArgs e)
        {
            if (listBoxPersonen.SelectedItem is Person selectedPerson && listBoxTel.SelectedItem != null)
            {
                string ausgewählteNummer = listBoxTel.SelectedItem.ToString();

                if (selectedPerson.Telefonnummer.RemoveAll(t => t.ToString() == ausgewählteNummer) > 0)
                {
                    MessageBox.Show("Telefonnummer erfolgreich entfernt.");
                    AktualisiereTelefonnummernListe(selectedPerson);
                }
                else
                {
                    MessageBox.Show("Fehler beim Entfernen der Telefonnummer.");
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Person und eine Telefonnummer aus.");
            }
        }
        //Tel entferenen
        private void btnTelHin_Click(object sender, EventArgs e)
        {
            if (listBoxPersonen.SelectedItem is Person selectedPerson)
            {
                string inputBezeichnung = Prompt.ShowDialog("Bezeichnung:", "Neue Telefonnummer");
                string inputLaendercode = Prompt.ShowDialog("Ländercode:", "Neue Telefonnummer");
                string inputVorwahl = Prompt.ShowDialog("Vorwahl:", "Neue Telefonnummer");
                string inputNummer = Prompt.ShowDialog("Nummer:", "Neue Telefonnummer");

                if (int.TryParse(inputLaendercode, out int laendercode) &&
                    int.TryParse(inputVorwahl, out int vorwahl) &&
                    int.TryParse(inputNummer, out int nummer) &&
                    !string.IsNullOrWhiteSpace(inputBezeichnung))
                {
                    Telefonnummer neueNummer = new Telefonnummer(laendercode, vorwahl, nummer, inputBezeichnung);
                    selectedPerson.TelefonummerHinzufügen(neueNummer);
                    AktualisiereTelefonnummernListe(selectedPerson);
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie gültige Nummern ein.");
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Person aus.");
            }
        }
        //Speichern der Daten 
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (listBoxPersonen.SelectedItem is Person selectedPerson)
            {
                selectedPerson.Personalnummer = txtPersonalnummer.Text;
                selectedPerson.Vorname = txtVorname.Text;
                selectedPerson.Nachname = txtNachname.Text;
                selectedPerson.Geburtsdatum = txtGeburtsdatum.Text;
                selectedPerson.Email = txtEmail.Text;
                selectedPerson.Position = txtPosition.Text;

                MessageBox.Show("Änderungen gespeichert.");

                AktualisiereListe();
                LeereEingabefelder();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Person aus der Liste aus.");
            }
        }
        //Adresse Bearbeiten
        private void btnAdresseBearbeiten_Click(object sender, EventArgs e)
        {
            if (listBoxPersonen.SelectedItem is Person selectedPerson && listBoxAdressen.SelectedItem != null)
            {
                string ausgewählteAdresse = listBoxAdressen.SelectedItem.ToString();
                Adresse adresse = selectedPerson.Adressen.FirstOrDefault(a => a.ToString() == ausgewählteAdresse);

                if (adresse != null)
                {
                    string neueStraße = Prompt.ShowDialog("Straße:", "Adresse bearbeiten", adresse.Straße);
                    string neueStadt = Prompt.ShowDialog("Stadt:", "Adresse bearbeiten", adresse.Stadt);
                    string neuePLZ = Prompt.ShowDialog("Postleitzahl:", "Adresse bearbeiten", adresse.Postleitzahl);
                    string neueBezeichnung = Prompt.ShowDialog("Bezeichnung:", "Adresse bearbeiten", adresse.Bezeichnung);

                    if (!string.IsNullOrWhiteSpace(neueStraße) &&
                        !string.IsNullOrWhiteSpace(neueStadt) &&
                        !string.IsNullOrWhiteSpace(neuePLZ) &&
                        !string.IsNullOrWhiteSpace(neueBezeichnung))
                    {
                        adresse.Straße = neueStraße;
                        adresse.Stadt = neueStadt;
                        adresse.Postleitzahl = neuePLZ;
                        adresse.Bezeichnung = neueBezeichnung;

                        MessageBox.Show("Adresse erfolgreich bearbeitet.");
                        AktualisiereAdressenListe(selectedPerson);
                    }
                    else
                    {
                        MessageBox.Show("Bitte füllen Sie alle Felder aus.");
                    }
                }
                else
                {
                    MessageBox.Show("Fehler beim Bearbeiten der Adresse.");
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Person und eine Adresse aus.");
            }
        }
        //Button um Telefonnummern zu bearbeiten
        private void btnTelefonnummerBearbeiten_Click(object sender, EventArgs e)
        {
            if (listBoxPersonen.SelectedItem is Person selectedPerson && listBoxTel.SelectedItem != null)
            {
                string ausgewählteNummer = listBoxTel.SelectedItem.ToString();
                Telefonnummer telefonnummer = selectedPerson.Telefonnummer.FirstOrDefault(t => t.ToString() == ausgewählteNummer);

                if (telefonnummer != null)
                {
                    string neueBezeichnung = Prompt.ShowDialog("Bezeichnung:", "Telefonnummer bearbeiten", telefonnummer.bezeichnung);
                    string neuerLaendercode = Prompt.ShowDialog("Ländercode:", "Telefonnummer bearbeiten", telefonnummer.laendercode.ToString());
                    string neueVorwahl = Prompt.ShowDialog("Vorwahl:", "Telefonnummer bearbeiten", telefonnummer.vorwahl.ToString());
                    string neueNummer = Prompt.ShowDialog("Nummer:", "Telefonnummer bearbeiten", telefonnummer.nummer.ToString());

                    if (int.TryParse(neuerLaendercode, out int laendercode) &&
                        int.TryParse(neueVorwahl, out int vorwahl) &&
                        int.TryParse(neueNummer, out int nummer) &&
                        !string.IsNullOrWhiteSpace(neueBezeichnung))
                    {
                        telefonnummer.bezeichnung = neueBezeichnung;
                        telefonnummer.laendercode = laendercode;
                        telefonnummer.vorwahl = vorwahl;
                        telefonnummer.nummer = nummer;

                        MessageBox.Show("Telefonnummer erfolgreich bearbeitet.");
                        AktualisiereTelefonnummernListe(selectedPerson);
                    }
                    else
                    {
                        MessageBox.Show("Bitte geben Sie gültige Nummern ein.");
                    }
                }
                else
                {
                    MessageBox.Show("Fehler beim Bearbeiten der Telefonnummer.");
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Person und eine Telefonnummer aus.");
            }
        }
        //Button um eingabefelder zu Leeren
        private void btnLeeren_Click(object sender, EventArgs e)
        {
            LeereEingabefelder();
            listBoxAdressen.Items.Clear();
            listBoxTel.Items.Clear();
        }
        //Fügt zwei Beispiel Personen hinzu
        private void BeispielPersonenHinzufügen()
        {
            var maxMustermann = new Person(GenerierePersonalnummer(), "Max", "Mustermann","22.11.1963", "max.mustermann@example.com", "Mitarbeiter");
            maxMustermann.AdresseHinzufügen(new Adresse("Musterstraße 1", "Musterstadt", "12345", "Geschäftlich"));
            maxMustermann.TelefonummerHinzufügen(new Telefonnummer(49, 30, 12345678, "Geschäftlich"));
            adressbuch.Hinzufügen(maxMustermann);

            var erikaMustermann = new Person(GenerierePersonalnummer(), "Erika", "Mustermann", "20.10.1981", "erika.mustermann@example.com", "Managerin");
            erikaMustermann.AdresseHinzufügen(new Adresse("Blumenweg 5", "Blütenstadt", "67890", "Privat"));
            erikaMustermann.TelefonummerHinzufügen(new Telefonnummer(49, 40, 87654321, "Privat"));
            adressbuch.Hinzufügen(erikaMustermann);
        }
        //Generiert automatisch eine Personalnummer 
        private string GenerierePersonalnummer()
        {
            personalnummerCounter++;
            return personalnummerCounter.ToString("D3");
        }
    }
}
