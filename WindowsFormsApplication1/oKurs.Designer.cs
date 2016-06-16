namespace WindowsFormsApplication1
{
    partial class oKurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oKurs));
            this.vCale = new AxWMPLib.AxWindowsMediaPlayer();
            this.vNogi = new AxWMPLib.AxWindowsMediaPlayer();
            this.bPowrot = new System.Windows.Forms.Button();
            this.bPauza = new System.Windows.Forms.Button();
            this.bPomoc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pbL = new System.Windows.Forms.PictureBox();
            this.pbDL = new System.Windows.Forms.PictureBox();
            this.pbD = new System.Windows.Forms.PictureBox();
            this.pbDP = new System.Windows.Forms.PictureBox();
            this.pbP = new System.Windows.Forms.PictureBox();
            this.pbS = new System.Windows.Forms.PictureBox();
            this.pbGL = new System.Windows.Forms.PictureBox();
            this.pbGP = new System.Windows.Forms.PictureBox();
            this.pbG = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vCale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNogi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG)).BeginInit();
            this.SuspendLayout();
            // 
            // vCale
            // 
            this.vCale.Enabled = true;
            this.vCale.Location = new System.Drawing.Point(498, 60);
            this.vCale.Name = "vCale";
            this.vCale.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vCale.OcxState")));
            this.vCale.Size = new System.Drawing.Size(362, 455);
            this.vCale.TabIndex = 0;
            this.vCale.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.vCale_PlayStateChange);
            this.vCale.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.vCale_KeyDownEvent);
            this.vCale.KeyUpEvent += new AxWMPLib._WMPOCXEvents_KeyUpEventHandler(this.vCale_KeyUpEvent);
            // 
            // vNogi
            // 
            this.vNogi.Enabled = true;
            this.vNogi.Location = new System.Drawing.Point(54, 60);
            this.vNogi.Name = "vNogi";
            this.vNogi.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vNogi.OcxState")));
            this.vNogi.Size = new System.Drawing.Size(362, 148);
            this.vNogi.TabIndex = 1;
            // 
            // bPowrot
            // 
            this.bPowrot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.bPowrot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPowrot.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPowrot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.bPowrot.Location = new System.Drawing.Point(54, 536);
            this.bPowrot.Name = "bPowrot";
            this.bPowrot.Size = new System.Drawing.Size(172, 23);
            this.bPowrot.TabIndex = 11;
            this.bPowrot.Text = "POWRÓT";
            this.bPowrot.UseVisualStyleBackColor = false;
            this.bPowrot.Click += new System.EventHandler(this.bPowrot_Click);
            // 
            // bPauza
            // 
            this.bPauza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.bPauza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPauza.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPauza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.bPauza.Location = new System.Drawing.Point(244, 536);
            this.bPauza.Name = "bPauza";
            this.bPauza.Size = new System.Drawing.Size(172, 23);
            this.bPauza.TabIndex = 12;
            this.bPauza.Text = "PAUZA";
            this.bPauza.UseVisualStyleBackColor = false;
            this.bPauza.Click += new System.EventHandler(this.bPauza_Click);
            // 
            // bPomoc
            // 
            this.bPomoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.bPomoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPomoc.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPomoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.bPomoc.Location = new System.Drawing.Point(498, 536);
            this.bPomoc.Name = "bPomoc";
            this.bPomoc.Size = new System.Drawing.Size(172, 23);
            this.bPomoc.TabIndex = 13;
            this.bPomoc.Text = "POMOC";
            this.bPomoc.UseVisualStyleBackColor = false;
            this.bPomoc.Click += new System.EventHandler(this.bPomoc_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.startButton.Location = new System.Drawing.Point(688, 536);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(172, 23);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pbL
            // 
            this.pbL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.pbL.Image = global::WindowsFormsApplication1.Properties.Resources.lewo;
            this.pbL.Location = new System.Drawing.Point(78, 319);
            this.pbL.Name = "pbL";
            this.pbL.Size = new System.Drawing.Size(99, 90);
            this.pbL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbL.TabIndex = 10;
            this.pbL.TabStop = false;
            // 
            // pbDL
            // 
            this.pbDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.pbDL.Image = global::WindowsFormsApplication1.Properties.Resources.t;
            this.pbDL.Location = new System.Drawing.Point(78, 415);
            this.pbDL.Name = "pbDL";
            this.pbDL.Size = new System.Drawing.Size(99, 90);
            this.pbDL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDL.TabIndex = 9;
            this.pbDL.TabStop = false;
            // 
            // pbD
            // 
            this.pbD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.pbD.Image = global::WindowsFormsApplication1.Properties.Resources.dol;
            this.pbD.Location = new System.Drawing.Point(183, 415);
            this.pbD.Name = "pbD";
            this.pbD.Size = new System.Drawing.Size(99, 90);
            this.pbD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbD.TabIndex = 8;
            this.pbD.TabStop = false;
            // 
            // pbDP
            // 
            this.pbDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.pbDP.Image = global::WindowsFormsApplication1.Properties.Resources.k;
            this.pbDP.Location = new System.Drawing.Point(288, 415);
            this.pbDP.Name = "pbDP";
            this.pbDP.Size = new System.Drawing.Size(99, 90);
            this.pbDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDP.TabIndex = 7;
            this.pbDP.TabStop = false;
            // 
            // pbP
            // 
            this.pbP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.pbP.Image = global::WindowsFormsApplication1.Properties.Resources.prawo_z;
            this.pbP.Location = new System.Drawing.Point(288, 319);
            this.pbP.Name = "pbP";
            this.pbP.Size = new System.Drawing.Size(99, 90);
            this.pbP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbP.TabIndex = 6;
            this.pbP.TabStop = false;
            // 
            // pbS
            // 
            this.pbS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.pbS.Location = new System.Drawing.Point(183, 319);
            this.pbS.Name = "pbS";
            this.pbS.Size = new System.Drawing.Size(99, 90);
            this.pbS.TabIndex = 5;
            this.pbS.TabStop = false;
            // 
            // pbGL
            // 
            this.pbGL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.pbGL.Image = global::WindowsFormsApplication1.Properties.Resources.x;
            this.pbGL.Location = new System.Drawing.Point(78, 223);
            this.pbGL.Name = "pbGL";
            this.pbGL.Size = new System.Drawing.Size(99, 90);
            this.pbGL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGL.TabIndex = 4;
            this.pbGL.TabStop = false;
            // 
            // pbGP
            // 
            this.pbGP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.pbGP.Image = global::WindowsFormsApplication1.Properties.Resources.o;
            this.pbGP.Location = new System.Drawing.Point(288, 223);
            this.pbGP.Name = "pbGP";
            this.pbGP.Size = new System.Drawing.Size(99, 90);
            this.pbGP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGP.TabIndex = 3;
            this.pbGP.TabStop = false;
            // 
            // pbG
            // 
            this.pbG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.pbG.Image = global::WindowsFormsApplication1.Properties.Resources.gora;
            this.pbG.Location = new System.Drawing.Point(183, 223);
            this.pbG.Name = "pbG";
            this.pbG.Size = new System.Drawing.Size(99, 90);
            this.pbG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbG.TabIndex = 2;
            this.pbG.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // oKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.tlo2;
            this.ClientSize = new System.Drawing.Size(884, 571);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPomoc);
            this.Controls.Add(this.bPauza);
            this.Controls.Add(this.bPowrot);
            this.Controls.Add(this.pbL);
            this.Controls.Add(this.pbDL);
            this.Controls.Add(this.pbD);
            this.Controls.Add(this.pbDP);
            this.Controls.Add(this.pbP);
            this.Controls.Add(this.pbS);
            this.Controls.Add(this.pbGL);
            this.Controls.Add(this.pbGP);
            this.Controls.Add(this.pbG);
            this.Controls.Add(this.vNogi);
            this.Controls.Add(this.vCale);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "oKurs";
            this.Text = "oKurs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wyjdz);
            this.Load += new System.EventHandler(this.oKurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vCale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNogi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer vCale;
        private AxWMPLib.AxWindowsMediaPlayer vNogi;
        private System.Windows.Forms.PictureBox pbG;
        private System.Windows.Forms.PictureBox pbGP;
        private System.Windows.Forms.PictureBox pbGL;
        private System.Windows.Forms.PictureBox pbS;
        private System.Windows.Forms.PictureBox pbP;
        private System.Windows.Forms.PictureBox pbDP;
        private System.Windows.Forms.PictureBox pbD;
        private System.Windows.Forms.PictureBox pbDL;
        private System.Windows.Forms.PictureBox pbL;
        private System.Windows.Forms.Button bPowrot;
        private System.Windows.Forms.Button bPauza;
        private System.Windows.Forms.Button bPomoc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label3;
    }
}