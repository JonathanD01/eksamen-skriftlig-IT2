namespace Hytte
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
            this.cbBoxHytter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNesteHytte = new System.Windows.Forms.Label();
            this.cbBoxNesteHytter = new System.Windows.Forms.ComboBox();
            this.lblSisteHytte = new System.Windows.Forms.Label();
            this.cbBoxSisteHytter = new System.Windows.Forms.ComboBox();
            this.lblRuteOverskrift = new System.Windows.Forms.Label();
            this.lblRuteTekst = new System.Windows.Forms.Label();
            this.lblRuteOppsummering = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBoxHytter
            // 
            this.cbBoxHytter.Font = new System.Drawing.Font("Calibri", 14F);
            this.cbBoxHytter.FormattingEnabled = true;
            this.cbBoxHytter.Location = new System.Drawing.Point(370, 24);
            this.cbBoxHytter.Name = "cbBoxHytter";
            this.cbBoxHytter.Size = new System.Drawing.Size(143, 31);
            this.cbBoxHytter.TabIndex = 0;
            this.cbBoxHytter.SelectedValueChanged += new System.EventHandler(this.cbBoxHytter_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Velg en hytte som utgangspunkt for turen";
            // 
            // lblNesteHytte
            // 
            this.lblNesteHytte.AutoSize = true;
            this.lblNesteHytte.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblNesteHytte.Location = new System.Drawing.Point(12, 80);
            this.lblNesteHytte.Name = "lblNesteHytte";
            this.lblNesteHytte.Size = new System.Drawing.Size(205, 23);
            this.lblNesteHytte.TabIndex = 3;
            this.lblNesteHytte.Text = "Velg neste hytte for turen";
            // 
            // cbBoxNesteHytter
            // 
            this.cbBoxNesteHytter.Font = new System.Drawing.Font("Calibri", 14F);
            this.cbBoxNesteHytter.FormattingEnabled = true;
            this.cbBoxNesteHytter.Location = new System.Drawing.Point(370, 77);
            this.cbBoxNesteHytter.Name = "cbBoxNesteHytter";
            this.cbBoxNesteHytter.Size = new System.Drawing.Size(143, 31);
            this.cbBoxNesteHytter.TabIndex = 2;
            this.cbBoxNesteHytter.SelectedValueChanged += new System.EventHandler(this.cbBoxNesteHytte_SelectedValueChanged);
            // 
            // lblSisteHytte
            // 
            this.lblSisteHytte.AutoSize = true;
            this.lblSisteHytte.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblSisteHytte.Location = new System.Drawing.Point(12, 137);
            this.lblSisteHytte.Name = "lblSisteHytte";
            this.lblSisteHytte.Size = new System.Drawing.Size(198, 23);
            this.lblSisteHytte.TabIndex = 5;
            this.lblSisteHytte.Text = "Velg siste hytte for turen";
            // 
            // cbBoxSisteHytter
            // 
            this.cbBoxSisteHytter.Font = new System.Drawing.Font("Calibri", 14F);
            this.cbBoxSisteHytter.FormattingEnabled = true;
            this.cbBoxSisteHytter.Location = new System.Drawing.Point(370, 134);
            this.cbBoxSisteHytter.Name = "cbBoxSisteHytter";
            this.cbBoxSisteHytter.Size = new System.Drawing.Size(143, 31);
            this.cbBoxSisteHytter.TabIndex = 4;
            this.cbBoxSisteHytter.SelectedValueChanged += new System.EventHandler(this.cbBoxSisteHytte_SelectedValueChanged);
            // 
            // lblRuteOverskrift
            // 
            this.lblRuteOverskrift.AutoSize = true;
            this.lblRuteOverskrift.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuteOverskrift.Location = new System.Drawing.Point(12, 208);
            this.lblRuteOverskrift.Name = "lblRuteOverskrift";
            this.lblRuteOverskrift.Size = new System.Drawing.Size(0, 29);
            this.lblRuteOverskrift.TabIndex = 7;
            // 
            // lblRuteTekst
            // 
            this.lblRuteTekst.AutoSize = true;
            this.lblRuteTekst.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblRuteTekst.Location = new System.Drawing.Point(12, 255);
            this.lblRuteTekst.Name = "lblRuteTekst";
            this.lblRuteTekst.Size = new System.Drawing.Size(0, 23);
            this.lblRuteTekst.TabIndex = 8;
            // 
            // lblRuteOppsummering
            // 
            this.lblRuteOppsummering.AutoSize = true;
            this.lblRuteOppsummering.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuteOppsummering.Location = new System.Drawing.Point(12, 315);
            this.lblRuteOppsummering.Name = "lblRuteOppsummering";
            this.lblRuteOppsummering.Size = new System.Drawing.Size(0, 23);
            this.lblRuteOppsummering.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 395);
            this.Controls.Add(this.lblRuteOppsummering);
            this.Controls.Add(this.lblRuteTekst);
            this.Controls.Add(this.lblRuteOverskrift);
            this.Controls.Add(this.lblSisteHytte);
            this.Controls.Add(this.cbBoxSisteHytter);
            this.Controls.Add(this.lblNesteHytte);
            this.Controls.Add(this.cbBoxNesteHytter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBoxHytter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Jotunheimen - Hyttetur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxHytter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNesteHytte;
        private System.Windows.Forms.ComboBox cbBoxNesteHytter;
        private System.Windows.Forms.Label lblSisteHytte;
        private System.Windows.Forms.ComboBox cbBoxSisteHytter;
        private System.Windows.Forms.Label lblRuteOverskrift;
        private System.Windows.Forms.Label lblRuteTekst;
        private System.Windows.Forms.Label lblRuteOppsummering;
    }
}

