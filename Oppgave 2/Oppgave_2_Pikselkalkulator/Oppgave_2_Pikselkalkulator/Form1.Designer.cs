namespace Pikselkalkulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegnPiksler = new System.Windows.Forms.Button();
            this.lblUtskrift = new System.Windows.Forms.Label();
            this.txtBoxBredde = new System.Windows.Forms.TextBox();
            this.txtBoxHøyde = new System.Windows.Forms.TextBox();
            this.bilde = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bilde)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skriv inn bredde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skriv inn høyde";
            // 
            // btnRegnPiksler
            // 
            this.btnRegnPiksler.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnRegnPiksler.Location = new System.Drawing.Point(130, 117);
            this.btnRegnPiksler.Name = "btnRegnPiksler";
            this.btnRegnPiksler.Size = new System.Drawing.Size(124, 35);
            this.btnRegnPiksler.TabIndex = 4;
            this.btnRegnPiksler.Text = "Regn ut piksler";
            this.btnRegnPiksler.UseVisualStyleBackColor = true;
            this.btnRegnPiksler.Click += new System.EventHandler(this.btnRegnPiksler_Click);
            // 
            // lblUtskrift
            // 
            this.lblUtskrift.AutoSize = true;
            this.lblUtskrift.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblUtskrift.Location = new System.Drawing.Point(22, 162);
            this.lblUtskrift.Name = "lblUtskrift";
            this.lblUtskrift.Size = new System.Drawing.Size(21, 19);
            this.lblUtskrift.TabIndex = 5;
            this.lblUtskrift.Text = "...";
            // 
            // txtBoxBredde
            // 
            this.txtBoxBredde.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBredde.Location = new System.Drawing.Point(130, 50);
            this.txtBoxBredde.Name = "txtBoxBredde";
            this.txtBoxBredde.Size = new System.Drawing.Size(124, 27);
            this.txtBoxBredde.TabIndex = 6;
            // 
            // txtBoxHøyde
            // 
            this.txtBoxHøyde.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtBoxHøyde.Location = new System.Drawing.Point(130, 84);
            this.txtBoxHøyde.Name = "txtBoxHøyde";
            this.txtBoxHøyde.Size = new System.Drawing.Size(124, 27);
            this.txtBoxHøyde.TabIndex = 7;
            // 
            // bilde
            // 
            this.bilde.Location = new System.Drawing.Point(59, 231);
            this.bilde.Name = "bilde";
            this.bilde.Size = new System.Drawing.Size(300, 300);
            this.bilde.TabIndex = 8;
            this.bilde.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.Location = new System.Drawing.Point(259, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "px";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.Location = new System.Drawing.Point(259, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "px";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bilde);
            this.Controls.Add(this.txtBoxHøyde);
            this.Controls.Add(this.txtBoxBredde);
            this.Controls.Add(this.lblUtskrift);
            this.Controls.Add(this.btnRegnPiksler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Pikselkalkulator";
            ((System.ComponentModel.ISupportInitialize)(this.bilde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegnPiksler;
        private System.Windows.Forms.Label lblUtskrift;
        private System.Windows.Forms.TextBox txtBoxBredde;
        private System.Windows.Forms.TextBox txtBoxHøyde;
        private System.Windows.Forms.PictureBox bilde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

