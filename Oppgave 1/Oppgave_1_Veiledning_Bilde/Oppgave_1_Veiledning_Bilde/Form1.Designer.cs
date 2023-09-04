namespace Veiledning
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
            this.bildeFjell3 = new System.Windows.Forms.PictureBox();
            this.bildeFjell2 = new System.Windows.Forms.PictureBox();
            this.bildeFjell1 = new System.Windows.Forms.PictureBox();
            this.lblOverskrift = new System.Windows.Forms.Label();
            this.lblTekst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bildeFjell3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildeFjell2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildeFjell1)).BeginInit();
            this.SuspendLayout();
            // 
            // bildeFjell3
            // 
            this.bildeFjell3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bildeFjell3.Image = global::Veiledning.Properties.Resources.fjell_3;
            this.bildeFjell3.Location = new System.Drawing.Point(36, 441);
            this.bildeFjell3.Name = "bildeFjell3";
            this.bildeFjell3.Size = new System.Drawing.Size(336, 177);
            this.bildeFjell3.TabIndex = 2;
            this.bildeFjell3.TabStop = false;
            this.bildeFjell3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bilde_Fjell3_Click);
            // 
            // bildeFjell2
            // 
            this.bildeFjell2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bildeFjell2.Image = global::Veiledning.Properties.Resources.fjell_2;
            this.bildeFjell2.Location = new System.Drawing.Point(36, 237);
            this.bildeFjell2.Name = "bildeFjell2";
            this.bildeFjell2.Size = new System.Drawing.Size(336, 177);
            this.bildeFjell2.TabIndex = 1;
            this.bildeFjell2.TabStop = false;
            this.bildeFjell2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bilde_Fjell1_Click);
            // 
            // bildeFjell1
            // 
            this.bildeFjell1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bildeFjell1.Image = global::Veiledning.Properties.Resources.fjell_1;
            this.bildeFjell1.Location = new System.Drawing.Point(36, 32);
            this.bildeFjell1.Name = "bildeFjell1";
            this.bildeFjell1.Size = new System.Drawing.Size(336, 177);
            this.bildeFjell1.TabIndex = 0;
            this.bildeFjell1.TabStop = false;
            this.bildeFjell1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bilde_Fjell1_Click);
            // 
            // lblOverskrift
            // 
            this.lblOverskrift.AutoSize = true;
            this.lblOverskrift.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverskrift.Location = new System.Drawing.Point(399, 32);
            this.lblOverskrift.Name = "lblOverskrift";
            this.lblOverskrift.Size = new System.Drawing.Size(0, 33);
            this.lblOverskrift.TabIndex = 3;
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Font = new System.Drawing.Font("Calibri", 13F);
            this.lblTekst.Location = new System.Drawing.Point(401, 88);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(0, 22);
            this.lblTekst.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 630);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.lblOverskrift);
            this.Controls.Add(this.bildeFjell3);
            this.Controls.Add(this.bildeFjell2);
            this.Controls.Add(this.bildeFjell1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Veiledning";
            ((System.ComponentModel.ISupportInitialize)(this.bildeFjell3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildeFjell2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildeFjell1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bildeFjell1;
        private System.Windows.Forms.PictureBox bildeFjell2;
        private System.Windows.Forms.PictureBox bildeFjell3;
        private System.Windows.Forms.Label lblOverskrift;
        private System.Windows.Forms.Label lblTekst;
    }
}

