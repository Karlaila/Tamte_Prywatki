namespace WindowsFormsApplication1
{
    partial class oLogowania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oLogowania));
            this.wmpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.rBwybierz = new System.Windows.Forms.RadioButton();
            this.rBnowe = new System.Windows.Forms.RadioButton();
            this.cBwybierz = new System.Windows.Forms.ComboBox();
            this.bAnuluj = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.lNazwa = new System.Windows.Forms.Label();
            this.tBnazwa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpPlayer
            // 
            this.wmpPlayer.Enabled = true;
            this.wmpPlayer.Location = new System.Drawing.Point(296, 40);
            this.wmpPlayer.Name = "wmpPlayer";
            this.wmpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPlayer.OcxState")));
            this.wmpPlayer.Size = new System.Drawing.Size(126, 236);
            this.wmpPlayer.TabIndex = 0;
            this.wmpPlayer.MediaError += new AxWMPLib._WMPOCXEvents_MediaErrorEventHandler(this.axWindowsMediaPlayer1_MediaError);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz użytkownika lub stwórz nowego:";
            // 
            // rBwybierz
            // 
            this.rBwybierz.AutoSize = true;
            this.rBwybierz.Location = new System.Drawing.Point(12, 68);
            this.rBwybierz.Name = "rBwybierz";
            this.rBwybierz.Size = new System.Drawing.Size(127, 17);
            this.rBwybierz.TabIndex = 2;
            this.rBwybierz.TabStop = true;
            this.rBwybierz.Text = "Mam już swoje konto.";
            this.rBwybierz.UseVisualStyleBackColor = true;
            this.rBwybierz.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rBnowe
            // 
            this.rBnowe.AutoSize = true;
            this.rBnowe.Location = new System.Drawing.Point(12, 135);
            this.rBnowe.Name = "rBnowe";
            this.rBnowe.Size = new System.Drawing.Size(157, 17);
            this.rBnowe.TabIndex = 3;
            this.rBnowe.TabStop = true;
            this.rBnowe.Text = "Chcę utworzyć nowe konto.";
            this.rBnowe.UseVisualStyleBackColor = true;
            this.rBnowe.CheckedChanged += new System.EventHandler(this.rBnowe_CheckedChanged);
            // 
            // cBwybierz
            // 
            this.cBwybierz.FormattingEnabled = true;
            this.cBwybierz.Location = new System.Drawing.Point(16, 103);
            this.cBwybierz.Name = "cBwybierz";
            this.cBwybierz.Size = new System.Drawing.Size(121, 21);
            this.cBwybierz.TabIndex = 4;
            // 
            // bAnuluj
            // 
            this.bAnuluj.Location = new System.Drawing.Point(28, 252);
            this.bAnuluj.Name = "bAnuluj";
            this.bAnuluj.Size = new System.Drawing.Size(75, 23);
            this.bAnuluj.TabIndex = 5;
            this.bAnuluj.Text = "anuluj";
            this.bAnuluj.UseVisualStyleBackColor = true;
            this.bAnuluj.Click += new System.EventHandler(this.bAnuluj_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(139, 253);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 6;
            this.bOk.Text = "ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // lNazwa
            // 
            this.lNazwa.AutoSize = true;
            this.lNazwa.Location = new System.Drawing.Point(28, 159);
            this.lNazwa.Name = "lNazwa";
            this.lNazwa.Size = new System.Drawing.Size(135, 13);
            this.lNazwa.TabIndex = 7;
            this.lNazwa.Text = "Wpisz nazwę użytkownika:";
            // 
            // tBnazwa
            // 
            this.tBnazwa.Location = new System.Drawing.Point(28, 176);
            this.tBnazwa.Name = "tBnazwa";
            this.tBnazwa.Size = new System.Drawing.Size(100, 20);
            this.tBnazwa.TabIndex = 8;
            // 
            // oLogowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 308);
            this.Controls.Add(this.tBnazwa);
            this.Controls.Add(this.lNazwa);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.bAnuluj);
            this.Controls.Add(this.cBwybierz);
            this.Controls.Add(this.rBnowe);
            this.Controls.Add(this.rBwybierz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wmpPlayer);
            this.Name = "oLogowania";
            this.Text = "Logowanie";
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBwybierz;
        private System.Windows.Forms.RadioButton rBnowe;
        private System.Windows.Forms.ComboBox cBwybierz;
        private System.Windows.Forms.Button bAnuluj;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label lNazwa;
        private System.Windows.Forms.TextBox tBnazwa;
    }
}

