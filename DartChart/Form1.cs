using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartChart
{
    public partial class punktestand : Form
    {
        // array spieler anlegen
        Label[] arrPlayer = new Label[8];
        Label[] arrPunkte = new Label[8];
        int anzPlayer = 0;
        int aktiverSpieler = 0;
        int durchgang;

        public punktestand()
        {
            InitializeComponent();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Spieler Labels erzeugen
        private void btnAnzSpieler_Click(object sender, EventArgs e)
        {

            int posX = 0;
            int posY = 6;
            int punkteModus = 301;
            int punkteStart = punkteModus;

            Label lbl;
            Label lblPunkte;

            anzPlayer = (int)numAnzPlayer.Value;
            grpPlayer.Controls.Clear();
            grpPunkte.Controls.Clear();

            for (int i = 0; i < anzPlayer; i++)
            {
                lbl = new Label();
                //spieler Label einstellen
                lbl.Size = lblVorlageSpieler.Size;
                lbl.TextAlign = lblVorlageSpieler.TextAlign;
                lbl.BackColor = lblVorlageSpieler.BackColor;
                //lbl.Location = new Point(posX, posY);
                lbl.Margin = lblVorlageSpieler.Margin;

                lbl.Name = "Spieler" + i;
                lbl.Text = ("Spieler" + " " + (i + 1)).ToUpper(); ;
                lbl.Tag = i;

                grpPlayer.Controls.Add(lbl);
                arrPlayer[i] = lbl;

                // Punktestand erzeugen
                lblPunkte = new Label();
                lblPunkte.Size = lblVorlagePunkte.Size;
                lblPunkte.TextAlign = lblVorlagePunkte.TextAlign;
                lblPunkte.BackColor = lblVorlagePunkte.BackColor;
                lblPunkte.ForeColor = lblVorlagePunkte.ForeColor;
                lblPunkte.Font = lblVorlagePunkte.Font;
                lblPunkte.Text = Convert.ToString(punkteModus);
                lblPunkte.Location = new Point(posX, posY);

                lblPunkte.Name = "Punkte" + i;
                lblPunkte.Tag = i;

                posY += lblVorlagePunkte.Height + 12;
                grpPunkte.Controls.Add(lblPunkte);
                arrPunkte[i] = lblPunkte;
            }

            // Eingabefeld erzeugen
            grpEingabe.Visible = true;
        }

        private void numAnzPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAnzSpieler_Click(null, null);
        }

        private void numAnzPlayer_Enter(object sender, EventArgs e)
        {
            numAnzPlayer.Select(0, 10);
        }


        // PUNKTE AUSRECHNEN
        private void btnStandBerechnen_Click(object sender, EventArgs e)
        {
            durchgang++;
            lblDurchgang.Text = "Durchgang " + (durchgang / anzPlayer);

            int punkteErzielt = 0;

            int spielerPunkte = Convert.ToInt32(arrPunkte[aktiverSpieler].Text);

            int w1 = eingabePruefen(txtWurf1.Text);
            int w2 = eingabePruefen(txtWurf2.Text);
            int w3 = eingabePruefen(txtWurf3.Text);

            // unmögliche eingabe , auf rückgabewert -1 prüfen
            if (w1 == -1)
            {
                w1 = 0;
                txtWurf1.Focus();
            }
            if (w2 == -1)
            {
                w2 = 0;
                txtWurf2.Focus();
            }
            if (w3 == -1)
            {
                w2 = 0;
                txtWurf3.Focus();
            }

            // Würfe einzeln prüfen
            if (w1 > spielerPunkte)
            {
                punkteErzielt = 0;
            }
            else if ((w1 + w2) > spielerPunkte)
            {
                punkteErzielt = 0;
            }
            else if ((w1 + w2 + w3) > spielerPunkte)
            {
                punkteErzielt = 0;
            }
            else
                punkteErzielt = w1 + w2 + w3;

            // Ziel Punktestan prüfen
            if (!(punkteErzielt > spielerPunkte))
            {
                spielerPunkte -= punkteErzielt;
                arrPunkte[aktiverSpieler].Text = Convert.ToString(spielerPunkte);
            }
            else
                MessageBox.Show("Zuviel");


            if (aktiverSpieler == anzPlayer - 1)
            {
                aktiverSpieler = 0;
                grpEingabe.Top = 0;
            }
            else
            {
                aktiverSpieler++;

                //Felder Leeren
                txtWurf1.Text = "";
                txtWurf2.Text = "";
                txtWurf3.Text = "";

                // eingabe feld verschieben
                grpEingabe.Top = grpEingabe.Location.Y + (lblVorlagePunkte.Height + 12);
            }
        }
        // Aktiven Spieler hervorheben
        private void inputBetreten_Enter(object sender, EventArgs e)
        {
            TextBox txt;
            txt = (TextBox)sender;
            txt.SelectAll();
            
            arrPlayer[aktiverSpieler].BackColor = System.Drawing.Color.Salmon;
            arrPlayer[aktiverSpieler].ForeColor = System.Drawing.Color.White;
        }

        private void inputVerlassen_Leave(object sender, EventArgs e)
        {
            arrPlayer[aktiverSpieler].BackColor = System.Drawing.Color.White;
            arrPlayer[aktiverSpieler].ForeColor = System.Drawing.Color.SlateGray;
        }

        private void numAnzPlayer_Leave(object sender, EventArgs e)
        {
            numAnzPlayer.TabStop = false;
        }

        private void txtWurf_TextChanged(object sender, EventArgs e)
        {

        }

        // Eingabe Erkennung
        // Darf Zahlen und (d)ouble und (t)riple als zeichen enthalten 
        private int eingabePruefen(String s)
        {
            int wurf = 0;
            if (s != "")
            {
                s = s.ToLower();
                s = s.Trim();
                if (s.Contains('d'))
                {
                    s = s.Replace("d", "");
                    wurf = (Convert.ToInt32(s)) * 2;
                }
                else if (s.Contains('t'))
                {
                    s = s.Replace("t", "");
                    wurf = (Convert.ToInt32(s)) * 3;
                }
                else
                    wurf = (Convert.ToInt32(s));
                btnStandBerechnen.Enabled = true;
                if (wurf < 60)
                {
                    return wurf;
                }
                else
                    return wurf = -1;
            }
            else
            {
                //btnStandBerechnen.Enabled = false;
                return wurf = 0;
            }
        }
    }
}
