namespace BileteUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Mesaj = new System.Windows.Forms.Label();
            this.ArtistText = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.LocatieText = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblAcces = new System.Windows.Forms.Label();
            this.viprb = new System.Windows.Forms.RadioButton();
            this.normalrb = new System.Windows.Forms.RadioButton();
            this.NrBileteText = new System.Windows.Forms.TextBox();
            this.PretText = new System.Windows.Forms.TextBox();
            this.lblNrBilete = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.txtcauta = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.Mesaj2 = new System.Windows.Forms.Label();
            this.btnCumpara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mesaj
            // 
            this.Mesaj.AutoSize = true;
            this.Mesaj.Location = new System.Drawing.Point(100, 388);
            this.Mesaj.Name = "Mesaj";
            this.Mesaj.Size = new System.Drawing.Size(35, 13);
            this.Mesaj.TabIndex = 0;
            this.Mesaj.Text = "Mesaj";
            this.Mesaj.Click += new System.EventHandler(this.label1_Click);
            // 
            // ArtistText
            // 
            this.ArtistText.Location = new System.Drawing.Point(29, 29);
            this.ArtistText.Name = "ArtistText";
            this.ArtistText.Size = new System.Drawing.Size(200, 20);
            this.ArtistText.TabIndex = 1;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(29, 13);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(46, 13);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "ARTIST";
            this.lblArtist.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Location = new System.Drawing.Point(29, 63);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(52, 13);
            this.lblLocatie.TabIndex = 3;
            this.lblLocatie.Text = "LOCATIE";
            // 
            // LocatieText
            // 
            this.LocatieText.Location = new System.Drawing.Point(29, 79);
            this.LocatieText.Name = "LocatieText";
            this.LocatieText.Size = new System.Drawing.Size(200, 20);
            this.LocatieText.TabIndex = 4;
            this.LocatieText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(29, 185);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA CUMPARARII";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DATA CONCERT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(29, 419);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 9;
            this.btnAdauga.Text = "ADAUGA";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lblAcces
            // 
            this.lblAcces.AutoSize = true;
            this.lblAcces.Location = new System.Drawing.Point(29, 223);
            this.lblAcces.Name = "lblAcces";
            this.lblAcces.Size = new System.Drawing.Size(62, 13);
            this.lblAcces.TabIndex = 10;
            this.lblAcces.Text = "TIP ACCES";
            // 
            // viprb
            // 
            this.viprb.AutoSize = true;
            this.viprb.Location = new System.Drawing.Point(29, 240);
            this.viprb.Name = "viprb";
            this.viprb.Size = new System.Drawing.Size(42, 17);
            this.viprb.TabIndex = 11;
            this.viprb.TabStop = true;
            this.viprb.Text = "VIP";
            this.viprb.UseVisualStyleBackColor = true;
            // 
            // normalrb
            // 
            this.normalrb.AutoSize = true;
            this.normalrb.Location = new System.Drawing.Point(77, 240);
            this.normalrb.Name = "normalrb";
            this.normalrb.Size = new System.Drawing.Size(71, 17);
            this.normalrb.TabIndex = 12;
            this.normalrb.TabStop = true;
            this.normalrb.Text = "NORMAL";
            this.normalrb.UseVisualStyleBackColor = true;
            // 
            // NrBileteText
            // 
            this.NrBileteText.Location = new System.Drawing.Point(29, 291);
            this.NrBileteText.Name = "NrBileteText";
            this.NrBileteText.Size = new System.Drawing.Size(200, 20);
            this.NrBileteText.TabIndex = 13;
            // 
            // PretText
            // 
            this.PretText.Location = new System.Drawing.Point(29, 350);
            this.PretText.Name = "PretText";
            this.PretText.Size = new System.Drawing.Size(200, 20);
            this.PretText.TabIndex = 14;
            // 
            // lblNrBilete
            // 
            this.lblNrBilete.AutoSize = true;
            this.lblNrBilete.Location = new System.Drawing.Point(29, 275);
            this.lblNrBilete.Name = "lblNrBilete";
            this.lblNrBilete.Size = new System.Drawing.Size(87, 13);
            this.lblNrBilete.TabIndex = 15;
            this.lblNrBilete.Text = "NUMAR BILETE";
            this.lblNrBilete.Click += new System.EventHandler(this.nrBilete_Click);
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(33, 334);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(36, 13);
            this.lblPret.TabIndex = 16;
            this.lblPret.Text = "PRET";
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(154, 419);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(75, 23);
            this.btnAfiseaza.TabIndex = 17;
            this.btnAfiseaza.Text = "AFISEAZA";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // txtcauta
            // 
            this.txtcauta.Location = new System.Drawing.Point(264, 350);
            this.txtcauta.Name = "txtcauta";
            this.txtcauta.Size = new System.Drawing.Size(197, 20);
            this.txtcauta.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(266, 334);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 13);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "ID bilet";
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(264, 419);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.TabIndex = 21;
            this.btnCauta.Text = "CAUTA";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // Mesaj2
            // 
            this.Mesaj2.AutoSize = true;
            this.Mesaj2.Location = new System.Drawing.Point(266, 388);
            this.Mesaj2.Name = "Mesaj2";
            this.Mesaj2.Size = new System.Drawing.Size(34, 13);
            this.Mesaj2.TabIndex = 22;
            this.Mesaj2.Text = "mesaj";
            // 
            // btnCumpara
            // 
            this.btnCumpara.Location = new System.Drawing.Point(91, 466);
            this.btnCumpara.Name = "btnCumpara";
            this.btnCumpara.Size = new System.Drawing.Size(75, 23);
            this.btnCumpara.TabIndex = 23;
            this.btnCumpara.Text = "CUMPARA BILET";
            this.btnCumpara.UseVisualStyleBackColor = true;
            this.btnCumpara.Click += new System.EventHandler(this.btnCumpara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(466, 560);
            this.Controls.Add(this.btnCumpara);
            this.Controls.Add(this.Mesaj2);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtcauta);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblNrBilete);
            this.Controls.Add(this.PretText);
            this.Controls.Add(this.NrBileteText);
            this.Controls.Add(this.normalrb);
            this.Controls.Add(this.viprb);
            this.Controls.Add(this.lblAcces);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LocatieText);
            this.Controls.Add(this.lblLocatie);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.ArtistText);
            this.Controls.Add(this.Mesaj);
            this.MinimumSize = new System.Drawing.Size(482, 599);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mesaj;
        private System.Windows.Forms.TextBox ArtistText;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.TextBox LocatieText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblAcces;
        private System.Windows.Forms.RadioButton viprb;
        private System.Windows.Forms.RadioButton normalrb;
        private System.Windows.Forms.TextBox NrBileteText;
        private System.Windows.Forms.TextBox PretText;
        private System.Windows.Forms.Label lblNrBilete;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.TextBox txtcauta;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label Mesaj2;
        private System.Windows.Forms.Button btnCumpara;
    }
}

