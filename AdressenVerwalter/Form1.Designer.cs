namespace AdressenVerwalter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // GUI-Komponenten (z. B. Textfelder, Buttons)
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtPersonalnummer;
        private System.Windows.Forms.TextBox txtNachnameSuchen;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Button btnEntfernen;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.ListBox listBoxPersonen;
        private System.Windows.Forms.ListBox listBoxAdressen;
        private System.Windows.Forms.Button btnAddAdresse;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtPersonalnummer = new System.Windows.Forms.TextBox();
            this.txtNachnameSuchen = new System.Windows.Forms.TextBox();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.btnEntfernen = new System.Windows.Forms.Button();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.listBoxPersonen = new System.Windows.Forms.ListBox();
            this.listBoxAdressen = new System.Windows.Forms.ListBox();
            this.btnAddAdresse = new System.Windows.Forms.Button();
            this.Personalnummer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdresseEntf = new System.Windows.Forms.Button();
            this.listBoxTel = new System.Windows.Forms.ListBox();
            this.btnTelHin = new System.Windows.Forms.Button();
            this.btnTelEntf = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnAdresseBearbeiten = new System.Windows.Forms.Button();
            this.btnTelefonnummerBearbeiten = new System.Windows.Forms.Button();
            this.btnLeeren = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGeburtsdatum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(120, 46);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(200, 20);
            this.txtVorname.TabIndex = 0;
            // 
            // txtNachname
            // 
            this.txtNachname.Location = new System.Drawing.Point(120, 72);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(200, 20);
            this.txtNachname.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(120, 150);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(200, 20);
            this.txtPosition.TabIndex = 4;
            // 
            // txtPersonalnummer
            // 
            this.txtPersonalnummer.Location = new System.Drawing.Point(120, 20);
            this.txtPersonalnummer.Name = "txtPersonalnummer";
            this.txtPersonalnummer.ReadOnly = true;
            this.txtPersonalnummer.Size = new System.Drawing.Size(200, 20);
            this.txtPersonalnummer.TabIndex = 5;
            // 
            // txtNachnameSuchen
            // 
            this.txtNachnameSuchen.Location = new System.Drawing.Point(120, 200);
            this.txtNachnameSuchen.Name = "txtNachnameSuchen";
            this.txtNachnameSuchen.Size = new System.Drawing.Size(200, 20);
            this.txtNachnameSuchen.TabIndex = 6;
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.ForeColor = System.Drawing.Color.Black;
            this.btnHinzufügen.Location = new System.Drawing.Point(340, 50);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(100, 23);
            this.btnHinzufügen.TabIndex = 7;
            this.btnHinzufügen.Text = "Hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // btnEntfernen
            // 
            this.btnEntfernen.Location = new System.Drawing.Point(340, 77);
            this.btnEntfernen.Name = "btnEntfernen";
            this.btnEntfernen.Size = new System.Drawing.Size(100, 23);
            this.btnEntfernen.TabIndex = 8;
            this.btnEntfernen.Text = "Entfernen";
            this.btnEntfernen.UseVisualStyleBackColor = true;
            this.btnEntfernen.Click += new System.EventHandler(this.btnEntfernen_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(340, 106);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(100, 23);
            this.btnSuchen.TabIndex = 9;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // listBoxPersonen
            // 
            this.listBoxPersonen.FormattingEnabled = true;
            this.listBoxPersonen.Location = new System.Drawing.Point(20, 226);
            this.listBoxPersonen.Name = "listBoxPersonen";
            this.listBoxPersonen.Size = new System.Drawing.Size(420, 95);
            this.listBoxPersonen.TabIndex = 10;
            this.listBoxPersonen.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonen_SelectedIndexChanged);
            // 
            // listBoxAdressen
            // 
            this.listBoxAdressen.FormattingEnabled = true;
            this.listBoxAdressen.Location = new System.Drawing.Point(20, 360);
            this.listBoxAdressen.Name = "listBoxAdressen";
            this.listBoxAdressen.Size = new System.Drawing.Size(420, 95);
            this.listBoxAdressen.TabIndex = 11;
            // 
            // btnAddAdresse
            // 
            this.btnAddAdresse.Location = new System.Drawing.Point(20, 331);
            this.btnAddAdresse.Name = "btnAddAdresse";
            this.btnAddAdresse.Size = new System.Drawing.Size(135, 23);
            this.btnAddAdresse.TabIndex = 12;
            this.btnAddAdresse.Text = "Adresse Hinzufügen";
            this.btnAddAdresse.UseVisualStyleBackColor = true;
            this.btnAddAdresse.Click += new System.EventHandler(this.btnAddAdresse_Click);
            // 
            // Personalnummer
            // 
            this.Personalnummer.AutoSize = true;
            this.Personalnummer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.Personalnummer.Location = new System.Drawing.Point(29, 27);
            this.Personalnummer.Name = "Personalnummer";
            this.Personalnummer.Size = new System.Drawing.Size(85, 13);
            this.Personalnummer.TabIndex = 13;
            this.Personalnummer.Text = "Personalnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vorname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nachname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nachnamen Suchen";
            // 
            // btnAdresseEntf
            // 
            this.btnAdresseEntf.Location = new System.Drawing.Point(161, 331);
            this.btnAdresseEntf.Name = "btnAdresseEntf";
            this.btnAdresseEntf.Size = new System.Drawing.Size(108, 23);
            this.btnAdresseEntf.TabIndex = 20;
            this.btnAdresseEntf.Text = "Adresse Entfernen";
            this.btnAdresseEntf.UseVisualStyleBackColor = true;
            this.btnAdresseEntf.Click += new System.EventHandler(this.btnAdresseEntf_Click);
            // 
            // listBoxTel
            // 
            this.listBoxTel.FormattingEnabled = true;
            this.listBoxTel.Location = new System.Drawing.Point(446, 360);
            this.listBoxTel.Name = "listBoxTel";
            this.listBoxTel.Size = new System.Drawing.Size(416, 95);
            this.listBoxTel.TabIndex = 21;
            // 
            // btnTelHin
            // 
            this.btnTelHin.Location = new System.Drawing.Point(446, 330);
            this.btnTelHin.Name = "btnTelHin";
            this.btnTelHin.Size = new System.Drawing.Size(134, 24);
            this.btnTelHin.TabIndex = 23;
            this.btnTelHin.Text = "Tel Hinzufügen";
            this.btnTelHin.UseVisualStyleBackColor = true;
            this.btnTelHin.Click += new System.EventHandler(this.btnTelHin_Click);
            // 
            // btnTelEntf
            // 
            this.btnTelEntf.Location = new System.Drawing.Point(586, 330);
            this.btnTelEntf.Name = "btnTelEntf";
            this.btnTelEntf.Size = new System.Drawing.Size(134, 24);
            this.btnTelEntf.TabIndex = 24;
            this.btnTelEntf.Text = "Tel Entfernen";
            this.btnTelEntf.UseVisualStyleBackColor = true;
            this.btnTelEntf.Click += new System.EventHandler(this.btnTelEntf_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(340, 136);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(100, 23);
            this.btnSpeichern.TabIndex = 25;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnAdresseBearbeiten
            // 
            this.btnAdresseBearbeiten.Location = new System.Drawing.Point(275, 331);
            this.btnAdresseBearbeiten.Name = "btnAdresseBearbeiten";
            this.btnAdresseBearbeiten.Size = new System.Drawing.Size(114, 22);
            this.btnAdresseBearbeiten.TabIndex = 26;
            this.btnAdresseBearbeiten.Text = "Adresse Bearbeiten";
            this.btnAdresseBearbeiten.UseVisualStyleBackColor = true;
            this.btnAdresseBearbeiten.Click += new System.EventHandler(this.btnAdresseBearbeiten_Click);
            // 
            // btnTelefonnummerBearbeiten
            // 
            this.btnTelefonnummerBearbeiten.Location = new System.Drawing.Point(726, 330);
            this.btnTelefonnummerBearbeiten.Name = "btnTelefonnummerBearbeiten";
            this.btnTelefonnummerBearbeiten.Size = new System.Drawing.Size(136, 23);
            this.btnTelefonnummerBearbeiten.TabIndex = 27;
            this.btnTelefonnummerBearbeiten.Text = "Tel Bearbeiten";
            this.btnTelefonnummerBearbeiten.UseVisualStyleBackColor = true;
            this.btnTelefonnummerBearbeiten.Click += new System.EventHandler(this.btnTelefonnummerBearbeiten_Click);
            // 
            // btnLeeren
            // 
            this.btnLeeren.Location = new System.Drawing.Point(340, 20);
            this.btnLeeren.Name = "btnLeeren";
            this.btnLeeren.Size = new System.Drawing.Size(100, 23);
            this.btnLeeren.TabIndex = 28;
            this.btnLeeren.Text = "Leeren";
            this.btnLeeren.UseVisualStyleBackColor = true;
            this.btnLeeren.Click += new System.EventHandler(this.btnLeeren_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Geburtsdatum";
            // 
            // txtGeburtsdatum
            // 
            this.txtGeburtsdatum.Location = new System.Drawing.Point(120, 98);
            this.txtGeburtsdatum.Name = "txtGeburtsdatum";
            this.txtGeburtsdatum.Size = new System.Drawing.Size(200, 20);
            this.txtGeburtsdatum.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.BackgroundImage = global::AdressenVerwalter.Properties.Resources.Kitty;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.Controls.Add(this.txtGeburtsdatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLeeren);
            this.Controls.Add(this.btnTelefonnummerBearbeiten);
            this.Controls.Add(this.btnAdresseBearbeiten);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnTelEntf);
            this.Controls.Add(this.btnTelHin);
            this.Controls.Add(this.listBoxTel);
            this.Controls.Add(this.btnAdresseEntf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Personalnummer);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtPersonalnummer);
            this.Controls.Add(this.txtNachnameSuchen);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.btnEntfernen);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.listBoxPersonen);
            this.Controls.Add(this.listBoxAdressen);
            this.Controls.Add(this.btnAddAdresse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Adressenverwalter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Personalnummer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdresseEntf;
        private System.Windows.Forms.ListBox listBoxTel;
        private System.Windows.Forms.Button btnTelHin;
        private System.Windows.Forms.Button btnTelEntf;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnAdresseBearbeiten;
        private System.Windows.Forms.Button btnTelefonnummerBearbeiten;
        private System.Windows.Forms.Button btnLeeren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGeburtsdatum;
    }
}

