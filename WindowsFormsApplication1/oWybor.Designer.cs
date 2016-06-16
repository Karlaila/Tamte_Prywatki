namespace WindowsFormsApplication1
{
    partial class oWybor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oWybor));
            this.bPowrot = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.wKroku = new System.Windows.Forms.GroupBox();
            this.rbOL = new System.Windows.Forms.RadioButton();
            this.rbOP = new System.Windows.Forms.RadioButton();
            this.rbKL = new System.Windows.Forms.RadioButton();
            this.rbKP = new System.Windows.Forms.RadioButton();
            this.wpoziom = new System.Windows.Forms.GroupBox();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbBP = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbKPK = new System.Windows.Forms.RadioButton();
            this.bWybierz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.wKroku.SuspendLayout();
            this.wpoziom.SuspendLayout();
            this.SuspendLayout();
            // 
            // bPowrot
            // 
            this.bPowrot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.bPowrot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPowrot.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPowrot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.bPowrot.Location = new System.Drawing.Point(12, 441);
            this.bPowrot.Name = "bPowrot";
            this.bPowrot.Size = new System.Drawing.Size(161, 45);
            this.bPowrot.TabIndex = 0;
            this.bPowrot.Text = "POWRÓT";
            this.bPowrot.UseVisualStyleBackColor = false;
            this.bPowrot.Click += new System.EventHandler(this.bPowrot_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(405, 68);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(456, 428);
            this.player.TabIndex = 1;
            // 
            // wKroku
            // 
            this.wKroku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.wKroku.Controls.Add(this.rbOL);
            this.wKroku.Controls.Add(this.rbOP);
            this.wKroku.Controls.Add(this.rbKL);
            this.wKroku.Controls.Add(this.rbKP);
            this.wKroku.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wKroku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.wKroku.Location = new System.Drawing.Point(12, 242);
            this.wKroku.Name = "wKroku";
            this.wKroku.Size = new System.Drawing.Size(356, 161);
            this.wKroku.TabIndex = 2;
            this.wKroku.TabStop = false;
            this.wKroku.Text = "Wybierz krok, który chcesz przećwiczyć:";
            this.wKroku.Enter += new System.EventHandler(this.wKroku_Enter);
            // 
            // rbOL
            // 
            this.rbOL.AutoSize = true;
            this.rbOL.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbOL.Location = new System.Drawing.Point(7, 121);
            this.rbOL.Name = "rbOL";
            this.rbOL.Size = new System.Drawing.Size(218, 25);
            this.rbOL.TabIndex = 3;
            this.rbOL.TabStop = true;
            this.rbOL.Text = "Obrót po kwadracie w lewo";
            this.rbOL.UseVisualStyleBackColor = true;
            // 
            // rbOP
            // 
            this.rbOP.AutoSize = true;
            this.rbOP.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbOP.Location = new System.Drawing.Point(6, 90);
            this.rbOP.Name = "rbOP";
            this.rbOP.Size = new System.Drawing.Size(229, 25);
            this.rbOP.TabIndex = 2;
            this.rbOP.TabStop = true;
            this.rbOP.Text = "Obrót po kwadracie w prawo";
            this.rbOP.UseVisualStyleBackColor = true;
            // 
            // rbKL
            // 
            this.rbKL.AutoSize = true;
            this.rbKL.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbKL.Location = new System.Drawing.Point(6, 59);
            this.rbKL.Name = "rbKL";
            this.rbKL.Size = new System.Drawing.Size(207, 25);
            this.rbKL.TabIndex = 1;
            this.rbKL.TabStop = true;
            this.rbKL.Text = "Krok podstawowy w lewo";
            this.rbKL.UseVisualStyleBackColor = true;
            // 
            // rbKP
            // 
            this.rbKP.AutoSize = true;
            this.rbKP.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbKP.Location = new System.Drawing.Point(7, 28);
            this.rbKP.Name = "rbKP";
            this.rbKP.Size = new System.Drawing.Size(218, 25);
            this.rbKP.TabIndex = 0;
            this.rbKP.TabStop = true;
            this.rbKP.Text = "Krok podstawowy w prawo";
            this.rbKP.UseVisualStyleBackColor = true;
            // 
            // wpoziom
            // 
            this.wpoziom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.wpoziom.Controls.Add(this.rbM);
            this.wpoziom.Controls.Add(this.rbBP);
            this.wpoziom.Controls.Add(this.rbC);
            this.wpoziom.Controls.Add(this.rbKPK);
            this.wpoziom.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wpoziom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.wpoziom.Location = new System.Drawing.Point(12, 68);
            this.wpoziom.Name = "wpoziom";
            this.wpoziom.Size = new System.Drawing.Size(356, 141);
            this.wpoziom.TabIndex = 3;
            this.wpoziom.TabStop = false;
            this.wpoziom.Text = "Wybierz poziom:";
            this.wpoziom.Enter += new System.EventHandler(this.wpoziom_Enter);
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbM.Location = new System.Drawing.Point(7, 92);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(95, 25);
            this.rbM.TabIndex = 3;
            this.rbM.TabStop = true;
            this.rbM.Text = "z muzyką";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbBP
            // 
            this.rbBP.AutoSize = true;
            this.rbBP.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbBP.Location = new System.Drawing.Point(7, 69);
            this.rbBP.Name = "rbBP";
            this.rbBP.Size = new System.Drawing.Size(147, 25);
            this.rbBP.TabIndex = 2;
            this.rbBP.TabStop = true;
            this.rbBP.Text = "bez podpowiedzi";
            this.rbBP.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbC.Location = new System.Drawing.Point(7, 44);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(224, 25);
            this.rbC.TabIndex = 1;
            this.rbC.TabStop = true;
            this.rbC.Text = "Cały krok z podpowiedziami";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbKPK
            // 
            this.rbKPK.AutoSize = true;
            this.rbKPK.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbKPK.Location = new System.Drawing.Point(7, 20);
            this.rbKPK.Name = "rbKPK";
            this.rbKPK.Size = new System.Drawing.Size(126, 25);
            this.rbKPK.TabIndex = 0;
            this.rbKPK.TabStop = true;
            this.rbKPK.Text = "Krok po kroku";
            this.rbKPK.UseVisualStyleBackColor = true;
            // 
            // bWybierz
            // 
            this.bWybierz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.bWybierz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bWybierz.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bWybierz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.bWybierz.Location = new System.Drawing.Point(207, 441);
            this.bWybierz.Name = "bWybierz";
            this.bWybierz.Size = new System.Drawing.Size(161, 45);
            this.bWybierz.TabIndex = 4;
            this.bWybierz.Text = "WYBIERZ";
            this.bWybierz.UseVisualStyleBackColor = false;
            this.bWybierz.Click += new System.EventHandler(this.bWybierz_Click);
            // 
            // oWybor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.tlo2;
            this.ClientSize = new System.Drawing.Size(884, 571);
            this.Controls.Add(this.bWybierz);
            this.Controls.Add(this.wpoziom);
            this.Controls.Add(this.wKroku);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bPowrot);
            this.Name = "oWybor";
            this.Text = "Wybór poziomu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.oWybor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.wKroku.ResumeLayout(false);
            this.wKroku.PerformLayout();
            this.wpoziom.ResumeLayout(false);
            this.wpoziom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bPowrot;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.GroupBox wKroku;
        private System.Windows.Forms.RadioButton rbOL;
        private System.Windows.Forms.RadioButton rbOP;
        private System.Windows.Forms.RadioButton rbKL;
        private System.Windows.Forms.RadioButton rbKP;
        private System.Windows.Forms.GroupBox wpoziom;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbBP;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbKPK;
        private System.Windows.Forms.Button bWybierz;
    }
}