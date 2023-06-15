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
    public partial class Form2 : Form
    {
        Admnistrare adminBilete;
        public Form2()
        {
            string NumeFisierBilete = ConfigurationManager.AppSettings["NumeFisierBilete"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierBilete = locatieFisierSolutie + "\\" + NumeFisierBilete;
            adminBilete = new Admnistrare(caleCompletaFisierBilete);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCumpara_Click(object sender, EventArgs e)
        {
            bool ok = true;
            string mesaj = "";
            Bilete bilete = new Bilete();
            if (!int.TryParse(txtCumpara.Text, out int id))
            {
                ok = false;
                lblCumparat.Text = "ID neexistent!\n";
            }
            else
            {
                bilete = adminBilete.getBilet(id);
                if (bilete.IdBilet != 0)
                {
                    lblCumparat.ForeColor = Color.Green;
                }
                else
                {
                    lblCmp.ForeColor = Color.Red;
                    ok = false;
                    lblCumparat.Text = "Biletul nu exista\n";
                }
            }
            lblCumparat.Text = mesaj;
            if (!ok) return;
            lblCumparat.Text = bilete.Info2();
            lblCumparat.ForeColor = Color.Green;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
