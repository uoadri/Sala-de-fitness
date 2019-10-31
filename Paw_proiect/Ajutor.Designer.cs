namespace Paw_proiect
{
    partial class Ajutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajutor));
            this.tbAjutor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbAjutor
            // 
            this.tbAjutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbAjutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAjutor.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAjutor.Location = new System.Drawing.Point(0, 0);
            this.tbAjutor.Multiline = true;
            this.tbAjutor.Name = "tbAjutor";
            this.tbAjutor.ReadOnly = true;
            this.tbAjutor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAjutor.Size = new System.Drawing.Size(426, 441);
            this.tbAjutor.TabIndex = 0;
            // 
            // Ajutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 441);
            this.Controls.Add(this.tbAjutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ajutor";
            this.Text = "Ajutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAjutor;
    }
}