namespace WindowsFormsApplication1
{
    partial class oMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oMenu));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lMenu = new System.Windows.Forms.Label();
            this.bKurs = new System.Windows.Forms.Button();
            this.bWybor = new System.Windows.Forms.Button();
            this.bInfo = new System.Windows.Forms.Button();
            this.bWyniki = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(371, 35);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(231, 288);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // lMenu
            // 
            this.lMenu.AutoSize = true;
            this.lMenu.Location = new System.Drawing.Point(33, 35);
            this.lMenu.Name = "lMenu";
            this.lMenu.Size = new System.Drawing.Size(34, 13);
            this.lMenu.TabIndex = 1;
            this.lMenu.Text = "Menu";
            // 
            // bKurs
            // 
            this.bKurs.Location = new System.Drawing.Point(77, 64);
            this.bKurs.Name = "bKurs";
            this.bKurs.Size = new System.Drawing.Size(130, 23);
            this.bKurs.TabIndex = 2;
            this.bKurs.Text = "Roczpocznij kurs";
            this.bKurs.UseVisualStyleBackColor = true;
            this.bKurs.Click += new System.EventHandler(this.bKurs_Click);
            // 
            // bWybor
            // 
            this.bWybor.Location = new System.Drawing.Point(77, 113);
            this.bWybor.Name = "bWybor";
            this.bWybor.Size = new System.Drawing.Size(130, 23);
            this.bWybor.TabIndex = 3;
            this.bWybor.Text = "Wybierz ćwiczenie";
            this.bWybor.UseVisualStyleBackColor = true;
            this.bWybor.Click += new System.EventHandler(this.bWybor_Click);
            // 
            // bInfo
            // 
            this.bInfo.Location = new System.Drawing.Point(77, 156);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(130, 23);
            this.bInfo.TabIndex = 4;
            this.bInfo.Text = "Informacje o grze";
            this.bInfo.UseVisualStyleBackColor = true;
            this.bInfo.Click += new System.EventHandler(this.bInfo_Click);
            // 
            // bWyniki
            // 
            this.bWyniki.Location = new System.Drawing.Point(77, 200);
            this.bWyniki.Name = "bWyniki";
            this.bWyniki.Size = new System.Drawing.Size(130, 23);
            this.bWyniki.TabIndex = 5;
            this.bWyniki.Text = "Wyniki";
            this.bWyniki.UseVisualStyleBackColor = true;
            this.bWyniki.Click += new System.EventHandler(this.bWyniki_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "wyjście";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.wyjdz);
            // 
            // oMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bWyniki);
            this.Controls.Add(this.bInfo);
            this.Controls.Add(this.bWybor);
            this.Controls.Add(this.bKurs);
            this.Controls.Add(this.lMenu);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "oMenu";
            this.Text = "oMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wyjdz);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lMenu;
        private System.Windows.Forms.Button bKurs;
        private System.Windows.Forms.Button bWybor;
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.Button bWyniki;
        private System.Windows.Forms.Button button1;
    }
}