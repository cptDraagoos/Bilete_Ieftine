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

        
        private Label lblHeaderArtist;
        private Label lblHeaderLocatie;
        private Label lblHeaderDataConcert;
        private Label lblHeaderDataCumparare;

        private Label[] lblsArtist;
        private Label[] lblsLocatie;
        private Label[] lblsDataConcert;
        private Label[] lblsDataCumparare;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 600;
        public Form1()
        {
            string NumeFisierBilete = ConfigurationManager.AppSettings["NumeFisierBilete"];
            InitializeComponent();
            this.Size = new Size(500, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9 , FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "Informatii Concerte";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mesaj.Text = "";
            Mesaj.ForeColor = Color.Red;
            AfiseazaBiletele();
        }

        private void AfiseazaBiletele()
        {
            lblHeaderArtist = new Label();
            lblHeaderArtist.Width = LATIME_CONTROL;
            lblHeaderArtist.Text = "Artist";
            lblHeaderArtist.Left = OFFSET_X + 0;
            lblHeaderArtist.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderArtist);

            lblHeaderLocatie = new Label();
            lblHeaderLocatie.Width = LATIME_CONTROL;
            lblHeaderLocatie.Text = "Locatie";
            lblHeaderLocatie.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblHeaderLocatie.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderLocatie);

            lblHeaderDataConcert = new Label();
            lblHeaderDataConcert.Width = LATIME_CONTROL;
            lblHeaderDataConcert.Text = "Data Concert";
            lblHeaderDataConcert.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblHeaderDataConcert.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderDataConcert);

            lblHeaderDataCumparare = new Label();
            lblHeaderDataCumparare.Width = LATIME_CONTROL;
            lblHeaderDataCumparare.Text = "Data Cumparare";
            lblHeaderDataCumparare.Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblHeaderDataCumparare.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderDataCumparare);

            int nrBilete = 0;
            Bilete[] bilete = adminBilete.getBilete(out nrBilete);

            lblsArtist = new Label[nrBilete];
            lblsLocatie = new Label[nrBilete];
            lblsDataConcert = new Label[nrBilete];
            lblsDataCumparare = new Label[nrBilete];

            int i = 0;
            foreach(Bilete bilet in bilete)
            {
                if (i >= nrBilete)
                    break;
                lblsArtist[i] = new Label();
                lblsArtist[i].Width = LATIME_CONTROL;
                lblsArtist[i].Text = bilet.NumeArtist;
                lblsArtist[i].Left = OFFSET_X + 0;
                lblsArtist[i].Top = (i+ 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsArtist[i]);

                lblsLocatie[i] = new Label();
                lblsLocatie[i].Width = LATIME_CONTROL;
                lblsLocatie[i].Text = bilet.LocatieConcert;
                lblsLocatie[i].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsLocatie[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsLocatie[i]);

                lblsDataConcert[i] = new Label();
                lblsDataConcert[i].Width = LATIME_CONTROL;
                lblsDataConcert[i].Text = bilet.DataConcert.ToString("yyyy-MM-dd HH:mm");
                lblsDataConcert[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsDataConcert[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsDataConcert[i]);

                lblsDataCumparare[i] = new Label();
                lblsDataCumparare[i].Width = LATIME_CONTROL;
                lblsDataCumparare[i].Text = bilet.DataCumparare.ToString("yyyy-MM-dd HH:mm");
                lblsDataCumparare[i].Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
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
    }
}
