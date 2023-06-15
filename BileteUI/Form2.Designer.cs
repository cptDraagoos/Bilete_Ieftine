namespace BileteUI
{
    partial class Form2
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
            this.lblCmp = new System.Windows.Forms.Label();
            this.txtCumpara = new System.Windows.Forms.TextBox();
            this.btnCumpara = new System.Windows.Forms.Button();
            this.lblCumparat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCmp
            // 
            this.lblCmp.AutoSize = true;
            this.lblCmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmp.Location = new System.Drawing.Point(0, 98);
            this.lblCmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCmp.Name = "lblCmp";
            this.lblCmp.Size = new System.Drawing.Size(354, 15);
            this.lblCmp.TabIndex = 0;
            this.lblCmp.Text = "Introduceti ID-ul biletului pe care doriti sa il cumparati";
            this.lblCmp.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCumpara
            // 
            this.txtCumpara.Location = new System.Drawing.Point(52, 144);
            this.txtCumpara.Name = "txtCumpara";
            this.txtCumpara.Size = new System.Drawing.Size(219, 20);
            this.txtCumpara.TabIndex = 1;
            // 
            // btnCumpara
            // 
            this.btnCumpara.Location = new System.Drawing.Point(126, 170);
            this.btnCumpara.Name = "btnCumpara";
            this.btnCumpara.Size = new System.Drawing.Size(75, 23);
            this.btnCumpara.TabIndex = 2;
            this.btnCumpara.Text = "CUMPARA";
            this.btnCumpara.UseVisualStyleBackColor = true;
            this.btnCumpara.Click += new System.EventHandler(this.btnCumpara_Click);
            // 
            // lblCumparat
            // 
            this.lblCumparat.AutoSize = true;
            this.lblCumparat.Location = new System.Drawing.Point(21, 221);
            this.lblCumparat.Name = "lblCumparat";
            this.lblCumparat.Size = new System.Drawing.Size(0, 13);
            this.lblCumparat.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.lblCumparat);
            this.Controls.Add(this.btnCumpara);
            this.Controls.Add(this.txtCumpara);
            this.Controls.Add(this.lblCmp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "Cumpara Bilet";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCmp;
        private System.Windows.Forms.TextBox txtCumpara;
        private System.Windows.Forms.Button btnCumpara;
        private System.Windows.Forms.Label lblCumparat;
    }
}