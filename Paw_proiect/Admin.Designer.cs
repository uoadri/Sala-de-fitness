namespace Paw_proiect
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.dtpRezervare = new System.Windows.Forms.DateTimePicker();
            this.labelRezervare = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbExercitii = new System.Windows.Forms.CheckedListBox();
            this.cbAntrenament = new System.Windows.Forms.ComboBox();
            this.lExercitii = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbNume = new System.Windows.Forms.ComboBox();
            this.cbPrenume = new System.Windows.Forms.ComboBox();
            this.tbAfisare = new System.Windows.Forms.TextBox();
            this.tbRepetari = new System.Windows.Forms.TextBox();
            this.tbSerii = new System.Windows.Forms.TextBox();
            this.tbDurataAntrenament = new System.Windows.Forms.TextBox();
            this.lRepetari = new System.Windows.Forms.Label();
            this.lSerii = new System.Windows.Forms.Label();
            this.lDurata = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.bDurata = new System.Windows.Forms.Button();
            this.buttonRezervare = new System.Windows.Forms.Button();
            this.lminute = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRezervare = new System.Windows.Forms.ComboBox();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpRezervare
            // 
            this.dtpRezervare.CustomFormat = "dd/MM/yyyy, hh:mm";
            this.dtpRezervare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRezervare.Location = new System.Drawing.Point(104, 257);
            this.dtpRezervare.Name = "dtpRezervare";
            this.dtpRezervare.Size = new System.Drawing.Size(135, 20);
            this.dtpRezervare.TabIndex = 9;
            this.dtpRezervare.Visible = false;
            // 
            // labelRezervare
            // 
            this.labelRezervare.AutoSize = true;
            this.labelRezervare.Location = new System.Drawing.Point(12, 261);
            this.labelRezervare.Name = "labelRezervare";
            this.labelRezervare.Size = new System.Drawing.Size(86, 13);
            this.labelRezervare.TabIndex = 10;
            this.labelRezervare.Text = "Rezervare noua:";
            this.labelRezervare.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nume:";
            // 
            // clbExercitii
            // 
            this.clbExercitii.FormattingEnabled = true;
            this.clbExercitii.Location = new System.Drawing.Point(15, 171);
            this.clbExercitii.Name = "clbExercitii";
            this.clbExercitii.Size = new System.Drawing.Size(262, 79);
            this.clbExercitii.TabIndex = 15;
            this.clbExercitii.Visible = false;
            this.clbExercitii.SelectedIndexChanged += new System.EventHandler(this.clbExercitii_SelectedIndexChanged);
            // 
            // cbAntrenament
            // 
            this.cbAntrenament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAntrenament.FormattingEnabled = true;
            this.cbAntrenament.Location = new System.Drawing.Point(82, 115);
            this.cbAntrenament.Name = "cbAntrenament";
            this.cbAntrenament.Size = new System.Drawing.Size(135, 21);
            this.cbAntrenament.TabIndex = 14;
            this.cbAntrenament.SelectedIndexChanged += new System.EventHandler(this.cbAntrenament_SelectedIndexChanged);
            // 
            // lExercitii
            // 
            this.lExercitii.AutoSize = true;
            this.lExercitii.Location = new System.Drawing.Point(123, 149);
            this.lExercitii.Name = "lExercitii";
            this.lExercitii.Size = new System.Drawing.Size(46, 13);
            this.lExercitii.TabIndex = 13;
            this.lExercitii.Text = "Exercitii:";
            this.lExercitii.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Antrenament:";
            // 
            // cbNume
            // 
            this.cbNume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNume.FormattingEnabled = true;
            this.cbNume.Location = new System.Drawing.Point(82, 27);
            this.cbNume.Name = "cbNume";
            this.cbNume.Size = new System.Drawing.Size(135, 21);
            this.cbNume.TabIndex = 16;
            this.cbNume.SelectedIndexChanged += new System.EventHandler(this.cbNume_SelectedIndexChanged);
            // 
            // cbPrenume
            // 
            this.cbPrenume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrenume.FormattingEnabled = true;
            this.cbPrenume.Location = new System.Drawing.Point(82, 57);
            this.cbPrenume.Name = "cbPrenume";
            this.cbPrenume.Size = new System.Drawing.Size(135, 21);
            this.cbPrenume.TabIndex = 17;
            this.cbPrenume.SelectedIndexChanged += new System.EventHandler(this.cbPrenume_SelectedIndexChanged);
            // 
            // tbAfisare
            // 
            this.tbAfisare.Location = new System.Drawing.Point(15, 285);
            this.tbAfisare.Multiline = true;
            this.tbAfisare.Name = "tbAfisare";
            this.tbAfisare.ReadOnly = true;
            this.tbAfisare.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAfisare.Size = new System.Drawing.Size(415, 139);
            this.tbAfisare.TabIndex = 18;
            // 
            // tbRepetari
            // 
            this.tbRepetari.Location = new System.Drawing.Point(339, 172);
            this.tbRepetari.Name = "tbRepetari";
            this.tbRepetari.Size = new System.Drawing.Size(47, 20);
            this.tbRepetari.TabIndex = 24;
            this.tbRepetari.Visible = false;
            // 
            // tbSerii
            // 
            this.tbSerii.Location = new System.Drawing.Point(339, 145);
            this.tbSerii.Name = "tbSerii";
            this.tbSerii.Size = new System.Drawing.Size(47, 20);
            this.tbSerii.TabIndex = 23;
            this.tbSerii.Visible = false;
            // 
            // tbDurataAntrenament
            // 
            this.tbDurataAntrenament.Location = new System.Drawing.Point(339, 199);
            this.tbDurataAntrenament.Name = "tbDurataAntrenament";
            this.tbDurataAntrenament.ReadOnly = true;
            this.tbDurataAntrenament.Size = new System.Drawing.Size(47, 20);
            this.tbDurataAntrenament.TabIndex = 22;
            this.tbDurataAntrenament.Visible = false;
            // 
            // lRepetari
            // 
            this.lRepetari.AutoSize = true;
            this.lRepetari.Location = new System.Drawing.Point(283, 176);
            this.lRepetari.Name = "lRepetari";
            this.lRepetari.Size = new System.Drawing.Size(50, 13);
            this.lRepetari.TabIndex = 21;
            this.lRepetari.Text = "Repetari:";
            this.lRepetari.Visible = false;
            // 
            // lSerii
            // 
            this.lSerii.AutoSize = true;
            this.lSerii.Location = new System.Drawing.Point(283, 149);
            this.lSerii.Name = "lSerii";
            this.lSerii.Size = new System.Drawing.Size(30, 13);
            this.lSerii.TabIndex = 20;
            this.lSerii.Text = "Serii:";
            this.lSerii.Visible = false;
            // 
            // lDurata
            // 
            this.lDurata.AutoSize = true;
            this.lDurata.Location = new System.Drawing.Point(283, 203);
            this.lDurata.Name = "lDurata";
            this.lDurata.Size = new System.Drawing.Size(45, 13);
            this.lDurata.TabIndex = 19;
            this.lDurata.Text = "Durata :";
            this.lDurata.Visible = false;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Location = new System.Drawing.Point(316, 25);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(114, 112);
            this.panelLogo.TabIndex = 26;
            // 
            // bDurata
            // 
            this.bDurata.Location = new System.Drawing.Point(322, 227);
            this.bDurata.Name = "bDurata";
            this.bDurata.Size = new System.Drawing.Size(108, 23);
            this.bDurata.TabIndex = 27;
            this.bDurata.Text = "Calculeaza Durata";
            this.bDurata.UseVisualStyleBackColor = true;
            this.bDurata.Visible = false;
            this.bDurata.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRezervare
            // 
            this.buttonRezervare.BackColor = System.Drawing.Color.DarkRed;
            this.buttonRezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRezervare.Location = new System.Drawing.Point(245, 256);
            this.buttonRezervare.Name = "buttonRezervare";
            this.buttonRezervare.Size = new System.Drawing.Size(67, 23);
            this.buttonRezervare.TabIndex = 28;
            this.buttonRezervare.Text = "Modifica";
            this.buttonRezervare.UseVisualStyleBackColor = false;
            this.buttonRezervare.Visible = false;
            this.buttonRezervare.Click += new System.EventHandler(this.buttonRezervare_Click);
            // 
            // lminute
            // 
            this.lminute.AutoSize = true;
            this.lminute.Location = new System.Drawing.Point(392, 203);
            this.lminute.Name = "lminute";
            this.lminute.Size = new System.Drawing.Size(38, 13);
            this.lminute.TabIndex = 29;
            this.lminute.Text = "minute";
            this.lminute.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.salveazaToolStripMenuItem.Text = "Salveaza";
            this.salveazaToolStripMenuItem.Click += new System.EventHandler(this.salveazaToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Rezervare:";
            // 
            // cbRezervare
            // 
            this.cbRezervare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRezervare.FormattingEnabled = true;
            this.cbRezervare.Location = new System.Drawing.Point(82, 86);
            this.cbRezervare.Name = "cbRezervare";
            this.cbRezervare.Size = new System.Drawing.Size(135, 21);
            this.cbRezervare.TabIndex = 32;
            this.cbRezervare.SelectedIndexChanged += new System.EventHandler(this.cbRezervare_SelectedIndexChanged);
            // 
            // buttonSterge
            // 
            this.buttonSterge.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSterge.Location = new System.Drawing.Point(322, 256);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(108, 23);
            this.buttonSterge.TabIndex = 33;
            this.buttonSterge.Text = "Sterge Date";
            this.buttonSterge.UseVisualStyleBackColor = false;
            this.buttonSterge.Visible = false;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 439);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.cbRezervare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lminute);
            this.Controls.Add(this.buttonRezervare);
            this.Controls.Add(this.bDurata);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.tbRepetari);
            this.Controls.Add(this.tbSerii);
            this.Controls.Add(this.tbDurataAntrenament);
            this.Controls.Add(this.lRepetari);
            this.Controls.Add(this.lSerii);
            this.Controls.Add(this.lDurata);
            this.Controls.Add(this.tbAfisare);
            this.Controls.Add(this.cbPrenume);
            this.Controls.Add(this.cbNume);
            this.Controls.Add(this.clbExercitii);
            this.Controls.Add(this.cbAntrenament);
            this.Controls.Add(this.lExercitii);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpRezervare);
            this.Controls.Add(this.labelRezervare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpRezervare;
        private System.Windows.Forms.Label labelRezervare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbExercitii;
        private System.Windows.Forms.ComboBox cbAntrenament;
        private System.Windows.Forms.Label lExercitii;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbNume;
        private System.Windows.Forms.ComboBox cbPrenume;
        private System.Windows.Forms.TextBox tbAfisare;
        private System.Windows.Forms.TextBox tbRepetari;
        private System.Windows.Forms.TextBox tbSerii;
        private System.Windows.Forms.TextBox tbDurataAntrenament;
        private System.Windows.Forms.Label lRepetari;
        private System.Windows.Forms.Label lSerii;
        private System.Windows.Forms.Label lDurata;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button bDurata;
        private System.Windows.Forms.Button buttonRezervare;
        private System.Windows.Forms.Label lminute;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRezervare;
        private System.Windows.Forms.Button buttonSterge;
    }
}