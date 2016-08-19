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
        // array punkte anlegen
        Label[] arrPunkte = new Label[8];
        // vars fürs aktuelle Spiel
        int anzPlayer = 0;
        int aktiverSpieler = 0;
        int durchgang;
        bool isDouble = false;
        bool isTriple = false;
        bool wurfIsValid = false;
        int punkteModus;


        public punktestand()
        {
            InitializeComponent();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // einstellungen Laden
        private void punktestand_Load(object sender, EventArgs e)
        {
            punkteModus = Settings.mode301;
            lblSpielmodus.Text = Convert.ToString(punkteModus);
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            einstellungen einstellungen = new einstellungen();
            einstellungen.ShowDialog();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            punkteModus = Settings.mode301;
            lblSpielmodus.Text = Convert.ToString(punkteModus);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            punkteModus = Settings.mode501;
            lblSpielmodus.Text = Convert.ToString(punkteModus);
        }


        // Spieler Labels erzeugen
        private void btnAnzSpieler_Click(object sender, EventArgs e)
        {

            int posX = 0;
            int posY = 6;
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
                lblPunkte.Anchor = lblVorlagePunkte.Anchor;
                lblPunkte.MinimumSize = lblVorlagePunkte.MinimumSize;
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
            wurfIsValid = true;
            durchgang++;
            isDouble = false;
            isTriple = false;
            lblDurchgang.Text = "RUNDE " + (durchgang / anzPlayer+1);

            int punkteErzielt = 0;

            int spielerPunkte = Convert.ToInt32(arrPunkte[aktiverSpieler].Text);

            int w1 = eingabePruefen(txtWurf1.Text);
            int w2 = eingabePruefen(txtWurf2.Text);
            int w3 = eingabePruefen(txtWurf3.Text);

            // unmögliche eingabe , auf rückgabewert -1 prüfen
            if (w1 < 0)
            {
                txtWurf1.Focus();
                inputBetreten_Enter(txtWurf1, null);
                return;
            }
            if (w2 < 0)
            {
                txtWurf2.Focus();
                inputBetreten_Enter(txtWurf2, null);
                return;
            }
            if (w3 < 0)
            {
                txtWurf3.Focus();
                inputBetreten_Enter(txtWurf3, null);
                return;
            }

            //|| w2 == -1 || w3 == -1)
            punkteErzielt = w1 + w2 + w3;

            if (punkteErzielt > spielerPunkte)
                return;


            // Ziel Punktestan prüfen

            if (wurfIsValid == true)
            {
                if (punkteErzielt > spielerPunkte)
                {

                }
                else if (punkteErzielt == spielerPunkte)
                {
                    MessageBox.Show("Spieler " + arrPlayer[aktiverSpieler] + "gewinnt.");
                    spielerPunkte -= punkteErzielt;
                    arrPunkte[aktiverSpieler].Text = Convert.ToString(spielerPunkte);
                }

                else
                {
                    spielerPunkte -= punkteErzielt;
                    arrPunkte[aktiverSpieler].Text = Convert.ToString(spielerPunkte);
                }

                // nach runde wieder zum ersten Spieler
                if (aktiverSpieler == anzPlayer - 1)
                {
                    aktiverSpieler = 0;
                    grpEingabe.Top = 0;
                    txtWurf1.Text = "";
                    txtWurf2.Text = "";
                    txtWurf3.Text = "";
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
            else
                return;
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
                    isDouble = true;
                    s = s.Replace("d", "");
                    wurf = zahlenbereichPruefen(s) * 2;
                }
                else if (s.Contains('t'))
                {
                    isTriple = true;
                    s = s.Replace("t", "");
                    wurf = zahlenbereichPruefen(s) * 3;
                }
                else
                    wurf = zahlenbereichPruefen(s);
                btnStandBerechnen.Enabled = true;

                if (wurf <= 60)
                {
                    return wurf;
                }
                else
                    return -1;
            }
            else
            {
                //btnStandBerechnen.Enabled = false;
                return wurf = 0;
            }
        }
        private int zahlenbereichPruefen(String s)
        {
            int wurf;
            int ergebnis;
            if (!(int.TryParse(s, out ergebnis)))
                return -1;
            wurf = (Convert.ToInt32(s));
            if (wurf == 25)
            {
                return wurf = 25;
            }
            else if (wurf == 50)
                return wurf = 50;
            else if (wurf < 0 || wurf > 20)
                return -1;
            return wurf;
        }
    }
}
