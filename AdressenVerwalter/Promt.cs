using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class Prompt
{
    //Methode um ein zweites Fenster zu erzeugen
    public static string ShowDialog(string text, string caption, string defaultValue = "")
    {
        Form prompt = new Form()
        {
            Width = 300,
            Height = 200,
            Text = caption
        };
        Label textLabel = new Label() { Left = 10, Top = 20, Text = text };
        TextBox textBox = new TextBox() { Left = 10, Top = 50, Width = 260, Text = defaultValue };
        Button confirmation = new Button() { Text = "Bestätigen", Left = 200, Width = 75, Top = 100, DialogResult = DialogResult.OK };
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
    }
}