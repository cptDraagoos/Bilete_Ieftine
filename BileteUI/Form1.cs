using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BileteLibrary;
using BeleteMgm;

namespace BileteUI
{
    public partial class Form1 : Form
    {
        Admnistrare adminBilete;

        private int nrBilet = 0;
        private int nextIdBilet = 1;

        private Label lblHeaderArtist;
        private Label lblHeaderLocatie;
        private Label lblHeaderId;
        private Label lblHeaderIntrare;
        private Label lblHeaderNrBilete;
        private Label lblHeaderPret;
        private Label lblHeaderDataConcert;
        private Label lblHeaderDataCumparare;

        private Label[] lblsArtist;
        private Label[] lblsId;
        private Label[] lblsIntrare;
        private Label[] lblsNrBilete;
        private Label[] lblsPret;
        private Label[] lblsLocatie;
        private Label[] lblsDataConcert;
        private Label[] lblsDataCumparare;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 350;
        private const int OFFSET_Y = 10;
        public Form1()
        {
            string NumeFisierBilete = ConfigurationManager.AppSettings["NumeFisierBilete"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierBilete = locatieFisierSolutie + "\\" + NumeFisierBilete;
            adminBilete = new Admnistrare(caleCompletaFisierBilete);
            InitializeComponent();
            this.Size = new Size(500, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9 , FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "Informatii Concerte";
            viprb.Text = "VIP";
            normalrb.Text = "NORMAL";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mesaj.Text = "";
            Mesaj.ForeColor = Color.Red;
            update_nextIdBilete(ref nrBilet, ref nextIdBilet, adminBilete);
        }

        private void AfiseazaBiletele()
        {
            lblHeaderId = new Label();
            lblHeaderId.Width = LATIME_CONTROL;
            lblHeaderId.Text = "ID";
            lblHeaderId.Left = OFFSET_X + 0;
            lblHeaderId.Top = OFFSET_Y;
            lblHeaderId.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderId);

            lblHeaderArtist = new Label();
            lblHeaderArtist.Width = LATIME_CONTROL;
            lblHeaderArtist.Text = "Artist";
            lblHeaderArtist.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblHeaderArtist.Top = OFFSET_Y;
            lblHeaderArtist.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderArtist);

            lblHeaderLocatie = new Label();
            lblHeaderLocatie.Width = LATIME_CONTROL;
            lblHeaderLocatie.Text = "Locatie";
            lblHeaderLocatie.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblHeaderLocatie.Top = OFFSET_Y;
            lblHeaderLocatie.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderLocatie);

            lblHeaderNrBilete = new Label();
            lblHeaderNrBilete.Width = LATIME_CONTROL;
            lblHeaderNrBilete.Text = "Numar Bilete";
            lblHeaderNrBilete.Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblHeaderNrBilete.Top = OFFSET_Y;
            lblHeaderNrBilete.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderNrBilete);

            lblHeaderPret = new Label();
            lblHeaderPret.Width = LATIME_CONTROL;
            lblHeaderPret.Text = "Pret[RON]";
            lblHeaderPret.Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
            lblHeaderPret.Top = OFFSET_Y;
            lblHeaderPret.ForeColor = Color.Black;
            this.Controls.Add( lblHeaderPret);

            lblHeaderIntrare = new Label();
            lblHeaderIntrare.Width = LATIME_CONTROL;
            lblHeaderIntrare.Text = "Tip Intrare";
            lblHeaderIntrare.Left = OFFSET_X + 5 * DIMENSIUNE_PAS_X;
            lblHeaderIntrare.Top = OFFSET_Y;
            lblHeaderIntrare.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderIntrare);

            lblHeaderDataConcert = new Label();
            lblHeaderDataConcert.Width = LATIME_CONTROL;
            lblHeaderDataConcert.Text = "Data Concert";
            lblHeaderDataConcert.Left = OFFSET_X + 6 * DIMENSIUNE_PAS_X;
            lblHeaderDataConcert.Top = OFFSET_Y;
            lblHeaderDataConcert.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderDataConcert);

            lblHeaderDataCumparare = new Label();
            lblHeaderDataCumparare.Width = LATIME_CONTROL;
            lblHeaderDataCumparare.Text = "Data Cumparare";
            lblHeaderDataCumparare.Left = OFFSET_X + 7 * DIMENSIUNE_PAS_X;
            lblHeaderDataCumparare.Top = OFFSET_Y;
            lblHeaderDataCumparare.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderDataCumparare);

            int nrBilete = 0;
            Bilete[] bilete = adminBilete.getBilete(out nrBilete);

            lblsArtist = new Label[nrBilete];
            lblsLocatie = new Label[nrBilete];
            lblsDataConcert = new Label[nrBilete];
            lblsDataCumparare = new Label[nrBilete];
            lblsId = new Label[nrBilete];
            lblsIntrare = new Label[nrBilete];
            lblsNrBilete = new Label[nrBilete];
            lblsPret = new Label[nrBilete];

            

            int i = 0;
            foreach(Bilete bilet in bilete)
            {
                if (i >= nrBilete)
                    break;
                lblsId[i] = new Label();
                lblsId[i].Width = LATIME_CONTROL;
                lblsId[i].Text = bilet.IdBilet.ToString();
                lblsId[i].Left = OFFSET_X + 0;
                lblsId[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsId[i]);

                lblsArtist[i] = new Label();
                lblsArtist[i].Width = LATIME_CONTROL;
                lblsArtist[i].Text = bilet.NumeArtist;
                lblsArtist[i].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsArtist[i].Top = (i+ 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsArtist[i]);

                lblsLocatie[i] = new Label();
                lblsLocatie[i].Width = LATIME_CONTROL;
                lblsLocatie[i].Text = bilet.LocatieConcert;
                lblsLocatie[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsLocatie[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsLocatie[i]);

                lblsNrBilete[i] = new Label();
                lblsNrBilete[i].Width = LATIME_CONTROL;
                lblsNrBilete[i].Text = bilet.NumarBilete.ToString();
                lblsNrBilete[i].Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
                lblsNrBilete[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNrBilete[i]);

                lblsPret[i] = new Label();
                lblsPret[i].Width = LATIME_CONTROL;
                lblsPret[i].Text = bilet.PretBilete.ToString();
                lblsPret[i].Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
                lblsPret[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPret[i]);

                lblsIntrare[i] = new Label();
                lblsIntrare[i].Width = LATIME_CONTROL;
                lblsIntrare[i].Text = bilet.TipAcces;
                lblsIntrare[i].Left = OFFSET_X + 5 * DIMENSIUNE_PAS_X;
                lblsIntrare[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsIntrare[i]);

                lblsDataConcert[i] = new Label();
                lblsDataConcert[i].Width = LATIME_CONTROL;
                lblsDataConcert[i].Text = bilet.DataConcert.ToString("yyyy-MM-dd HH:mm");
                lblsDataConcert[i].Left = OFFSET_X + 6 * DIMENSIUNE_PAS_X;
                lblsDataConcert[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsDataConcert[i]);

                lblsDataCumparare[i] = new Label();
                lblsDataCumparare[i].Width = LATIME_CONTROL;
                lblsDataCumparare[i].Text = bilet.DataCumparare.ToString("yyyy-MM-dd HH:mm");
                lblsDataCumparare[i].Left = OFFSET_X + 7 * DIMENSIUNE_PAS_X;
                lblsDataCumparare[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsDataCumparare[i]);

                i++;
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nrBilete_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Int32.TryParse(NrBileteText.Text, out int nrBil);
            Int32.TryParse(PretText.Text, out int pret);
            string intrare = "";
            if (!DateInvalide())
            {
                Mesaj.Text = "EROARE!";
                return;
            }
            Mesaj.Text = "";
            update_nextIdBilete(ref nrBilet, ref nextIdBilet, adminBilete);
            if (viprb.Checked)
            {
                intrare = viprb.Text;
            }
            else if (normalrb.Checked)
            {
                intrare = normalrb.Text;
            }

            Bilete bilete = new Bilete( nextIdBilet, ArtistText.Text, LocatieText.Text, nrBil, pret, intrare, dateTimePicker1.Value, dateTimePicker2.Value);
            adminBilete.AddBilet(bilete);
            Mesaj.Text = "Biletul a fost adaugat";
            Resetare();
        }

        private bool DateInvalide()
        {
            string artist = ArtistText.Text;
            string locatie = LocatieText.Text;
            if( !(Int32.TryParse(NrBileteText.Text, out int nrBil)))
            {
                nrBil = -1;
            }
            if(!(Int32.TryParse(PretText.Text, out int pret)))
            {
                pret = -1;
            }
            bool ok = true;

            if (artist.Length < 1)
            {
                lblArtist.ForeColor = Color.Red;
                ok = false;
            }
            else
            {
                lblArtist.ForeColor = Color.Green;
            }

            if (locatie.Length < 1)
            {
                lblLocatie.ForeColor = Color.Red;
                ok = false;
            }
            else
            {
                lblLocatie.ForeColor = Color.Green;
            }

            if (nrBil < 0)
            {
                lblNrBilete.ForeColor = Color.Red;
                ok = false;
            }
            else
            {
                lblNrBilete.ForeColor= Color.Green;
            }
            if (pret < 0)
            {
                lblPret.ForeColor = Color.Red;
                ok = false;
            }
            else
            {
                lblPret.ForeColor = Color.Green;
            }
            if ( !viprb.Checked && !normalrb.Checked ) 
            {
                lblAcces.ForeColor = Color.Red;
                ok = false;
            }
            else
            { 
                lblAcces.ForeColor = Color.Green;
            }

            return ok;
        }

        private void Resetare()
        {
            ArtistText.Text = LocatieText.Text = NrBileteText.Text = PretText.Text = string.Empty;
            viprb.Checked = false;
            normalrb.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            AfiseazaBiletele();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            bool ok = true;
            string mesaj = "";
            Bilete bilete = new Bilete();
            if (!int.TryParse(txtcauta.Text, out int id))
            {
                lblId.ForeColor = Color.Red;
                ok = false;
                Mesaj2.Text = "ID neexistent!\n";
            }
            else
            {
                bilete = adminBilete.getBilet(id);
                if (bilete.IdBilet != 0)
                {
                    lblId.ForeColor = Color.Green;
                }
                else
                {
                    lblId.ForeColor = Color.Red;
                    ok = false;
                    Mesaj2.Text = "Biletul nu exista\n";
                }
            }
            Mesaj2.Text = mesaj;
            if (!ok) return;
            Mesaj2.Text = bilete.Info();
            Mesaj2.ForeColor = Color.Green;
        }
        
        public void update_nextIdBilete(ref int nrBilet, ref int nextIdBilet, Admnistrare adminBilete)
        {
            Bilete[] bilete = adminBilete.getBilete(out nrBilet);
            if (nrBilet != 0)
            {
                nextIdBilet = bilete[nrBilet - 1].IdBilet + 1;
            }
        }
    }
}
