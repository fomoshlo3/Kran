namespace UKran
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CmdBeenden = new System.Windows.Forms.Button();
            this.PnKranFuss = new System.Windows.Forms.Panel();
            this.PnKran = new System.Windows.Forms.Panel();
            this.PnAusleger = new System.Windows.Forms.Panel();
            this.PnHaken = new System.Windows.Forms.Panel();
            this.TimKran = new System.Windows.Forms.Timer(this.components);
            this.CmdStart = new System.Windows.Forms.Button();
            this.OptHakenAus = new System.Windows.Forms.RadioButton();
            this.OptHakenEin = new System.Windows.Forms.RadioButton();
            this.OptAuslegerAus = new System.Windows.Forms.RadioButton();
            this.OptAuslegerEin = new System.Windows.Forms.RadioButton();
            this.OptKranAus = new System.Windows.Forms.RadioButton();
            this.OptKranEin = new System.Windows.Forms.RadioButton();
            this.OptKranLinks = new System.Windows.Forms.RadioButton();
            this.OptKranRechts = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // CmdBeenden
            // 
            this.CmdBeenden.Location = new System.Drawing.Point(654, 526);
            this.CmdBeenden.Name = "CmdBeenden";
            this.CmdBeenden.Size = new System.Drawing.Size(118, 23);
            this.CmdBeenden.TabIndex = 8;
            this.CmdBeenden.Text = "Beenden";
            this.CmdBeenden.UseVisualStyleBackColor = true;
            this.CmdBeenden.Click += new System.EventHandler(this.CmdBeenden_Click);
            // 
            // PnKranFuss
            // 
            this.PnKranFuss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnKranFuss.Location = new System.Drawing.Point(350, 504);
            this.PnKranFuss.Name = "PnKranFuss";
            this.PnKranFuss.Size = new System.Drawing.Size(100, 20);
            this.PnKranFuss.TabIndex = 9;
            // 
            // PnKran
            // 
            this.PnKran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnKran.Location = new System.Drawing.Point(390, 356);
            this.PnKran.Name = "PnKran";
            this.PnKran.Size = new System.Drawing.Size(20, 150);
            this.PnKran.TabIndex = 10;
            // 
            // PnAusleger
            // 
            this.PnAusleger.BackColor = System.Drawing.Color.Yellow;
            this.PnAusleger.Location = new System.Drawing.Point(310, 356);
            this.PnAusleger.Name = "PnAusleger";
            this.PnAusleger.Size = new System.Drawing.Size(100, 20);
            this.PnAusleger.TabIndex = 11;
            // 
            // PnHaken
            // 
            this.PnHaken.BackColor = System.Drawing.Color.Silver;
            this.PnHaken.Location = new System.Drawing.Point(310, 356);
            this.PnHaken.Name = "PnHaken";
            this.PnHaken.Size = new System.Drawing.Size(20, 60);
            this.PnHaken.TabIndex = 12;
            // 
            // TimKran
            // 
            this.TimKran.Interval = 500;
            this.TimKran.Tick += new System.EventHandler(this.TimKran_Tick);
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(573, 526);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(75, 23);
            this.CmdStart.TabIndex = 21;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // OptHakenAus
            // 
            this.OptHakenAus.AutoSize = true;
            this.OptHakenAus.Location = new System.Drawing.Point(678, 12);
            this.OptHakenAus.Name = "OptHakenAus";
            this.OptHakenAus.Size = new System.Drawing.Size(80, 19);
            this.OptHakenAus.TabIndex = 22;
            this.OptHakenAus.TabStop = true;
            this.OptHakenAus.Text = "Haken aus";
            this.OptHakenAus.UseVisualStyleBackColor = true;
            // 
            // OptHakenEin
            // 
            this.OptHakenEin.AutoSize = true;
            this.OptHakenEin.Location = new System.Drawing.Point(678, 37);
            this.OptHakenEin.Name = "OptHakenEin";
            this.OptHakenEin.Size = new System.Drawing.Size(78, 19);
            this.OptHakenEin.TabIndex = 23;
            this.OptHakenEin.TabStop = true;
            this.OptHakenEin.Text = "Haken ein";
            this.OptHakenEin.UseVisualStyleBackColor = true;
            // 
            // OptAuslegerAus
            // 
            this.OptAuslegerAus.AutoSize = true;
            this.OptAuslegerAus.Location = new System.Drawing.Point(678, 62);
            this.OptAuslegerAus.Name = "OptAuslegerAus";
            this.OptAuslegerAus.Size = new System.Drawing.Size(92, 19);
            this.OptAuslegerAus.TabIndex = 24;
            this.OptAuslegerAus.TabStop = true;
            this.OptAuslegerAus.Text = "Ausleger aus";
            this.OptAuslegerAus.UseVisualStyleBackColor = true;
            // 
            // OptAuslegerEin
            // 
            this.OptAuslegerEin.AutoSize = true;
            this.OptAuslegerEin.Location = new System.Drawing.Point(678, 87);
            this.OptAuslegerEin.Name = "OptAuslegerEin";
            this.OptAuslegerEin.Size = new System.Drawing.Size(90, 19);
            this.OptAuslegerEin.TabIndex = 25;
            this.OptAuslegerEin.TabStop = true;
            this.OptAuslegerEin.Text = "Ausleger ein";
            this.OptAuslegerEin.UseVisualStyleBackColor = true;
            // 
            // OptKranAus
            // 
            this.OptKranAus.AutoSize = true;
            this.OptKranAus.Location = new System.Drawing.Point(678, 112);
            this.OptKranAus.Name = "OptKranAus";
            this.OptKranAus.Size = new System.Drawing.Size(70, 19);
            this.OptKranAus.TabIndex = 26;
            this.OptKranAus.TabStop = true;
            this.OptKranAus.Text = "Kran aus";
            this.OptKranAus.UseVisualStyleBackColor = true;
            // 
            // OptKranEin
            // 
            this.OptKranEin.AutoSize = true;
            this.OptKranEin.Location = new System.Drawing.Point(678, 137);
            this.OptKranEin.Name = "OptKranEin";
            this.OptKranEin.Size = new System.Drawing.Size(68, 19);
            this.OptKranEin.TabIndex = 27;
            this.OptKranEin.TabStop = true;
            this.OptKranEin.Text = "Kran ein";
            this.OptKranEin.UseVisualStyleBackColor = true;
            // 
            // OptKranLinks
            // 
            this.OptKranLinks.AutoSize = true;
            this.OptKranLinks.Location = new System.Drawing.Point(678, 162);
            this.OptKranLinks.Name = "OptKranLinks";
            this.OptKranLinks.Size = new System.Drawing.Size(76, 19);
            this.OptKranLinks.TabIndex = 28;
            this.OptKranLinks.TabStop = true;
            this.OptKranLinks.Text = "Kran links";
            this.OptKranLinks.UseVisualStyleBackColor = true;
            // 
            // OptKranRechts
            // 
            this.OptKranRechts.AutoSize = true;
            this.OptKranRechts.Location = new System.Drawing.Point(678, 187);
            this.OptKranRechts.Name = "OptKranRechts";
            this.OptKranRechts.Size = new System.Drawing.Size(84, 19);
            this.OptKranRechts.TabIndex = 29;
            this.OptKranRechts.TabStop = true;
            this.OptKranRechts.Text = "Kran rechts";
            this.OptKranRechts.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.OptKranRechts);
            this.Controls.Add(this.OptKranLinks);
            this.Controls.Add(this.OptKranEin);
            this.Controls.Add(this.OptKranAus);
            this.Controls.Add(this.OptAuslegerEin);
            this.Controls.Add(this.OptAuslegerAus);
            this.Controls.Add(this.OptHakenEin);
            this.Controls.Add(this.OptHakenAus);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.PnKran);
            this.Controls.Add(this.PnKranFuss);
            this.Controls.Add(this.CmdBeenden);
            this.Controls.Add(this.PnAusleger);
            this.Controls.Add(this.PnHaken);
            this.Name = "MainForm";
            this.Text = "UKran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button CmdBeenden;
        private Panel PnKranFuss;
        private Panel PnKran;
        private Panel PnAusleger;
        private Panel PnHaken;
        private System.Windows.Forms.Timer TimKran;
        private Button CmdStart;
        private RadioButton OptHakenAus;
        private RadioButton OptHakenEin;
        private RadioButton OptAuslegerAus;
        private RadioButton OptAuslegerEin;
        private RadioButton OptKranAus;
        private RadioButton OptKranEin;
        private RadioButton OptKranLinks;
        private RadioButton OptKranRechts;
    }
}