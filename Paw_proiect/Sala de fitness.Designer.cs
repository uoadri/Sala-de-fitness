namespace Paw_proiect
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelGrafic = new System.Windows.Forms.Panel();
            this.contextMenuStripGrafic = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bExercitii = new System.Windows.Forms.Button();
            this.lminute = new System.Windows.Forms.Label();
            this.panelImages = new System.Windows.Forms.Panel();
            this.contextMenuStripImages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bDurata = new System.Windows.Forms.Button();
            this.clbExercitii = new System.Windows.Forms.CheckedListBox();
            this.tbRepetari = new System.Windows.Forms.TextBox();
            this.tbSerii = new System.Windows.Forms.TextBox();
            this.tbDurataAntrenament = new System.Windows.Forms.TextBox();
            this.cbAntrenament = new System.Windows.Forms.ComboBox();
            this.lRepetari = new System.Windows.Forms.Label();
            this.lSerii = new System.Windows.Forms.Label();
            this.lDurata = new System.Windows.Forms.Label();
            this.lExercitii = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRezervare = new System.Windows.Forms.Button();
            this.dtpRezervare = new System.Windows.Forms.DateTimePicker();
            this.labelRezervare = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salveazaDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaDateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.contextMenuStripGrafic.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStripImages.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelLogo);
            this.groupBox1.Controls.Add(this.panelGrafic);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonRezervare);
            this.groupBox1.Controls.Add(this.dtpRezervare);
            this.groupBox1.Controls.Add(this.labelRezervare);
            this.groupBox1.Controls.Add(this.tbPrenume);
            this.groupBox1.Controls.Add(this.tbNume);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 411);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Location = new System.Drawing.Point(565, 10);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(129, 128);
            this.panelLogo.TabIndex = 5;
            // 
            // panelGrafic
            // 
            this.panelGrafic.ContextMenuStrip = this.contextMenuStripGrafic;
            this.panelGrafic.Location = new System.Drawing.Point(217, 14);
            this.panelGrafic.Name = "panelGrafic";
            this.panelGrafic.Size = new System.Drawing.Size(342, 118);
            this.panelGrafic.TabIndex = 5;
            this.panelGrafic.Visible = false;
            this.panelGrafic.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrafic_Paint);
            // 
            // contextMenuStripGrafic
            // 
            this.contextMenuStripGrafic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.contextMenuStripGrafic.Name = "contextMenuStrip1";
            this.contextMenuStripGrafic.Size = new System.Drawing.Size(100, 26);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bExercitii);
            this.groupBox2.Controls.Add(this.lminute);
            this.groupBox2.Controls.Add(this.panelImages);
            this.groupBox2.Controls.Add(this.bDurata);
            this.groupBox2.Controls.Add(this.clbExercitii);
            this.groupBox2.Controls.Add(this.tbRepetari);
            this.groupBox2.Controls.Add(this.tbSerii);
            this.groupBox2.Controls.Add(this.tbDurataAntrenament);
            this.groupBox2.Controls.Add(this.cbAntrenament);
            this.groupBox2.Controls.Add(this.lRepetari);
            this.groupBox2.Controls.Add(this.lSerii);
            this.groupBox2.Controls.Add(this.lDurata);
            this.groupBox2.Controls.Add(this.lExercitii);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 264);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Antrenament";
            // 
            // bExercitii
            // 
            this.bExercitii.Location = new System.Drawing.Point(163, 233);
            this.bExercitii.Name = "bExercitii";
            this.bExercitii.Size = new System.Drawing.Size(108, 23);
            this.bExercitii.TabIndex = 5;
            this.bExercitii.Text = "Afiseaza Exercitii";
            this.bExercitii.UseVisualStyleBackColor = true;
            this.bExercitii.Visible = false;
            this.bExercitii.Click += new System.EventHandler(this.bExercitii_Click);
            // 
            // lminute
            // 
            this.lminute.AutoSize = true;
            this.lminute.Location = new System.Drawing.Point(170, 211);
            this.lminute.Name = "lminute";
            this.lminute.Size = new System.Drawing.Size(38, 13);
            this.lminute.TabIndex = 13;
            this.lminute.Text = "minute";
            this.lminute.Visible = false;
            // 
            // panelImages
            // 
            this.panelImages.AutoScroll = true;
            this.panelImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelImages.ContextMenuStrip = this.contextMenuStripImages;
            this.panelImages.Location = new System.Drawing.Point(277, 19);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(404, 237);
            this.panelImages.TabIndex = 4;
            this.panelImages.Visible = false;
            this.panelImages.Paint += new System.Windows.Forms.PaintEventHandler(this.panelImages_Paint);
            // 
            // contextMenuStripImages
            // 
            this.contextMenuStripImages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem1});
            this.contextMenuStripImages.Name = "contextMenuStripImages";
            this.contextMenuStripImages.Size = new System.Drawing.Size(100, 26);
            this.contextMenuStripImages.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripImages_Opening);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.printToolStripMenuItem1_Click);
            // 
            // bDurata
            // 
            this.bDurata.Location = new System.Drawing.Point(6, 233);
            this.bDurata.Name = "bDurata";
            this.bDurata.Size = new System.Drawing.Size(108, 23);
            this.bDurata.TabIndex = 12;
            this.bDurata.Text = "Calculeaza Durata";
            this.bDurata.UseVisualStyleBackColor = true;
            this.bDurata.Visible = false;
            this.bDurata.Click += new System.EventHandler(this.bDurata_Click);
            // 
            // clbExercitii
            // 
            this.clbExercitii.FormattingEnabled = true;
            this.clbExercitii.Location = new System.Drawing.Point(9, 70);
            this.clbExercitii.Name = "clbExercitii";
            this.clbExercitii.Size = new System.Drawing.Size(262, 79);
            this.clbExercitii.TabIndex = 11;
            this.clbExercitii.Visible = false;
            this.clbExercitii.SelectedIndexChanged += new System.EventHandler(this.clbExercitii_SelectedIndexChanged);
            // 
            // tbRepetari
            // 
            this.tbRepetari.Location = new System.Drawing.Point(117, 181);
            this.tbRepetari.Name = "tbRepetari";
            this.tbRepetari.Size = new System.Drawing.Size(47, 20);
            this.tbRepetari.TabIndex = 10;
            this.tbRepetari.Visible = false;
            this.tbRepetari.TextChanged += new System.EventHandler(this.tbRepetari_TextChanged);
            this.tbRepetari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSerii_KeyPress);
            // 
            // tbSerii
            // 
            this.tbSerii.Location = new System.Drawing.Point(117, 155);
            this.tbSerii.Name = "tbSerii";
            this.tbSerii.Size = new System.Drawing.Size(47, 20);
            this.tbSerii.TabIndex = 9;
            this.tbSerii.Visible = false;
            this.tbSerii.TextChanged += new System.EventHandler(this.tbSerii_TextChanged);
            this.tbSerii.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSerii_KeyPress);
            // 
            // tbDurataAntrenament
            // 
            this.tbDurataAntrenament.Location = new System.Drawing.Point(117, 207);
            this.tbDurataAntrenament.Name = "tbDurataAntrenament";
            this.tbDurataAntrenament.ReadOnly = true;
            this.tbDurataAntrenament.Size = new System.Drawing.Size(47, 20);
            this.tbDurataAntrenament.TabIndex = 8;
            this.tbDurataAntrenament.Visible = false;
            this.tbDurataAntrenament.TextChanged += new System.EventHandler(this.tbDurataAntrenament_TextChanged);
            // 
            // cbAntrenament
            // 
            this.cbAntrenament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAntrenament.FormattingEnabled = true;
            this.cbAntrenament.Items.AddRange(new object[] {
            "Piept",
            "Spate",
            "Biceps",
            "Triceps",
            "Umeri",
            "Picioare",
            "Abdomen"});
            this.cbAntrenament.Location = new System.Drawing.Point(76, 18);
            this.cbAntrenament.Name = "cbAntrenament";
            this.cbAntrenament.Size = new System.Drawing.Size(121, 21);
            this.cbAntrenament.TabIndex = 6;
            this.cbAntrenament.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lRepetari
            // 
            this.lRepetari.AutoSize = true;
            this.lRepetari.Location = new System.Drawing.Point(6, 185);
            this.lRepetari.Name = "lRepetari";
            this.lRepetari.Size = new System.Drawing.Size(79, 13);
            this.lRepetari.TabIndex = 4;
            this.lRepetari.Text = "Repetari/Serie:";
            this.lRepetari.Visible = false;
            // 
            // lSerii
            // 
            this.lSerii.AutoSize = true;
            this.lSerii.Location = new System.Drawing.Point(6, 159);
            this.lSerii.Name = "lSerii";
            this.lSerii.Size = new System.Drawing.Size(78, 13);
            this.lSerii.TabIndex = 3;
            this.lSerii.Text = "Serii/Exercititu:";
            this.lSerii.Visible = false;
            // 
            // lDurata
            // 
            this.lDurata.AutoSize = true;
            this.lDurata.Location = new System.Drawing.Point(6, 211);
            this.lDurata.Name = "lDurata";
            this.lDurata.Size = new System.Drawing.Size(105, 13);
            this.lDurata.TabIndex = 2;
            this.lDurata.Text = "Durata Antrenament:";
            this.lDurata.Visible = false;
            // 
            // lExercitii
            // 
            this.lExercitii.AutoSize = true;
            this.lExercitii.Location = new System.Drawing.Point(117, 48);
            this.lExercitii.Name = "lExercitii";
            this.lExercitii.Size = new System.Drawing.Size(46, 13);
            this.lExercitii.TabIndex = 1;
            this.lExercitii.Text = "Exercitii:";
            this.lExercitii.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Antrenament:";
            // 
            // buttonRezervare
            // 
            this.buttonRezervare.BackColor = System.Drawing.Color.DarkRed;
            this.buttonRezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRezervare.Location = new System.Drawing.Point(76, 99);
            this.buttonRezervare.Name = "buttonRezervare";
            this.buttonRezervare.Size = new System.Drawing.Size(135, 23);
            this.buttonRezervare.TabIndex = 7;
            this.buttonRezervare.Text = "Adauga Rezervare";
            this.buttonRezervare.UseVisualStyleBackColor = false;
            this.buttonRezervare.Visible = false;
            this.buttonRezervare.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpRezervare
            // 
            this.dtpRezervare.CustomFormat = "dd/MM/yyyy, hh:mm";
            this.dtpRezervare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRezervare.Location = new System.Drawing.Point(76, 73);
            this.dtpRezervare.Name = "dtpRezervare";
            this.dtpRezervare.Size = new System.Drawing.Size(135, 20);
            this.dtpRezervare.TabIndex = 3;
            this.dtpRezervare.Visible = false;
            this.dtpRezervare.ValueChanged += new System.EventHandler(this.dtpRezervare_ValueChanged);
            // 
            // labelRezervare
            // 
            this.labelRezervare.AutoSize = true;
            this.labelRezervare.Location = new System.Drawing.Point(12, 77);
            this.labelRezervare.Name = "labelRezervare";
            this.labelRezervare.Size = new System.Drawing.Size(59, 13);
            this.labelRezervare.TabIndex = 6;
            this.labelRezervare.Text = "Rezervare:";
            this.labelRezervare.Visible = false;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(76, 47);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(135, 20);
            this.tbPrenume.TabIndex = 4;
            this.tbPrenume.TextChanged += new System.EventHandler(this.tbPrenume_TextChanged);
            this.tbPrenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNume_KeyPress);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(76, 21);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(135, 20);
            this.tbNume.TabIndex = 3;
            this.tbNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNume_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaDateToolStripMenuItem,
            this.salveazaDateToolStripMenuItem1,
            this.ajutorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salveazaDateToolStripMenuItem
            // 
            this.salveazaDateToolStripMenuItem.Name = "salveazaDateToolStripMenuItem";
            this.salveazaDateToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.salveazaDateToolStripMenuItem.Text = "Salveaza Date";
            this.salveazaDateToolStripMenuItem.Click += new System.EventHandler(this.salveazaDateToolStripMenuItem_Click);
            // 
            // salveazaDateToolStripMenuItem1
            // 
            this.salveazaDateToolStripMenuItem1.Name = "salveazaDateToolStripMenuItem1";
            this.salveazaDateToolStripMenuItem1.Size = new System.Drawing.Size(82, 20);
            this.salveazaDateToolStripMenuItem1.Text = "Afisare Date";
            this.salveazaDateToolStripMenuItem1.Click += new System.EventHandler(this.salveazaDateToolStripMenuItem1_Click);
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            this.ajutorToolStripMenuItem.Click += new System.EventHandler(this.ajutorToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sala de Fitness";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStripGrafic.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStripImages.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRezervare;
        private System.Windows.Forms.DateTimePicker dtpRezervare;
        private System.Windows.Forms.Label labelRezervare;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bExercitii;
        private System.Windows.Forms.Label lminute;
        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.Button bDurata;
        private System.Windows.Forms.CheckedListBox clbExercitii;
        private System.Windows.Forms.TextBox tbRepetari;
        private System.Windows.Forms.TextBox tbSerii;
        private System.Windows.Forms.TextBox tbDurataAntrenament;
        private System.Windows.Forms.ComboBox cbAntrenament;
        private System.Windows.Forms.Label lRepetari;
        private System.Windows.Forms.Label lSerii;
        private System.Windows.Forms.Label lDurata;
        private System.Windows.Forms.Label lExercitii;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelGrafic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salveazaDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaDateToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGrafic;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImages;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

