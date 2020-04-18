namespace Radio
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnRMF = new System.Windows.Forms.Button();
            this.btnZET = new System.Windows.Forms.Button();
            this.btnMARYJA = new System.Windows.Forms.Button();
            this.btnVOX = new System.Windows.Forms.Button();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnPowerOn = new System.Windows.Forms.Button();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.Location = new System.Drawing.Point(177, 162);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(320, 20);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "Stacja";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnRMF
            // 
            this.btnRMF.Location = new System.Drawing.Point(179, 202);
            this.btnRMF.Name = "btnRMF";
            this.btnRMF.Size = new System.Drawing.Size(75, 23);
            this.btnRMF.TabIndex = 1;
            this.btnRMF.Text = "1";
            this.btnRMF.UseVisualStyleBackColor = true;
            this.btnRMF.Click += new System.EventHandler(this.btnRMF_Click);
            // 
            // btnZET
            // 
            this.btnZET.Location = new System.Drawing.Point(260, 202);
            this.btnZET.Name = "btnZET";
            this.btnZET.Size = new System.Drawing.Size(75, 23);
            this.btnZET.TabIndex = 2;
            this.btnZET.Text = "2";
            this.btnZET.UseVisualStyleBackColor = true;
            this.btnZET.Click += new System.EventHandler(this.btnZET_Click);
            // 
            // btnMARYJA
            // 
            this.btnMARYJA.Location = new System.Drawing.Point(341, 202);
            this.btnMARYJA.Name = "btnMARYJA";
            this.btnMARYJA.Size = new System.Drawing.Size(75, 23);
            this.btnMARYJA.TabIndex = 3;
            this.btnMARYJA.Text = "3";
            this.btnMARYJA.UseVisualStyleBackColor = true;
            this.btnMARYJA.Click += new System.EventHandler(this.btnMARYJA_Click);
            // 
            // btnVOX
            // 
            this.btnVOX.Location = new System.Drawing.Point(422, 202);
            this.btnVOX.Name = "btnVOX";
            this.btnVOX.Size = new System.Drawing.Size(75, 23);
            this.btnVOX.TabIndex = 4;
            this.btnVOX.Text = "4";
            this.btnVOX.UseVisualStyleBackColor = true;
            this.btnVOX.Click += new System.EventHandler(this.btnVOX_Click);
            // 
            // VolumeBar
            // 
            this.VolumeBar.Location = new System.Drawing.Point(12, 40);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeBar.Size = new System.Drawing.Size(56, 174);
            this.VolumeBar.TabIndex = 5;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(83, 110);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(55, 17);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "Volume";
            // 
            // btnPowerOn
            // 
            this.btnPowerOn.BackColor = System.Drawing.Color.Lime;
            this.btnPowerOn.Location = new System.Drawing.Point(480, 27);
            this.btnPowerOn.Name = "btnPowerOn";
            this.btnPowerOn.Size = new System.Drawing.Size(131, 36);
            this.btnPowerOn.TabIndex = 7;
            this.btnPowerOn.Text = "POWER ON";
            this.btnPowerOn.UseVisualStyleBackColor = false;
            this.btnPowerOn.Click += new System.EventHandler(this.btnPowerOn_Click);
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.BackColor = System.Drawing.Color.Red;
            this.btnPowerOff.Location = new System.Drawing.Point(480, 69);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(131, 35);
            this.btnPowerOff.TabIndex = 8;
            this.btnPowerOff.Text = "POWER OFF";
            this.btnPowerOff.UseVisualStyleBackColor = false;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(150, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 17);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "AktualnaData";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 265);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnPowerOff);
            this.Controls.Add(this.btnPowerOn);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.btnVOX);
            this.Controls.Add(this.btnMARYJA);
            this.Controls.Add(this.btnZET);
            this.Controls.Add(this.btnRMF);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnRMF;
        private System.Windows.Forms.Button btnZET;
        private System.Windows.Forms.Button btnMARYJA;
        private System.Windows.Forms.Button btnVOX;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnPowerOn;
        private System.Windows.Forms.Button btnPowerOff;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}

