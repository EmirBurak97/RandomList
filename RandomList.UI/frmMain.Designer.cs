namespace RandomList.UI
{
    partial class frmMain
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
            btnLol = new Button();
            btnAssetto = new Button();
            btnValo = new Button();
            btnMusic = new Button();
            SuspendLayout();
            // 
            // btnLol
            // 
            btnLol.Location = new Point(12, 12);
            btnLol.Name = "btnLol";
            btnLol.Size = new Size(75, 174);
            btnLol.TabIndex = 0;
            btnLol.Text = "League of Legends";
            btnLol.UseVisualStyleBackColor = true;
            btnLol.Click += btnLol_Click;
            // 
            // btnAssetto
            // 
            btnAssetto.Location = new Point(95, 12);
            btnAssetto.Name = "btnAssetto";
            btnAssetto.Size = new Size(75, 174);
            btnAssetto.TabIndex = 1;
            btnAssetto.Text = "Assetto Corsa";
            btnAssetto.UseVisualStyleBackColor = true;
            btnAssetto.Click += btnAssetto_Click;
            // 
            // btnValo
            // 
            btnValo.Location = new Point(176, 12);
            btnValo.Name = "btnValo";
            btnValo.Size = new Size(75, 174);
            btnValo.TabIndex = 2;
            btnValo.Text = "Valorant";
            btnValo.UseVisualStyleBackColor = true;
            btnValo.Click += btnValo_Click;
            // 
            // btnMusic
            // 
            btnMusic.Location = new Point(257, 12);
            btnMusic.Name = "btnMusic";
            btnMusic.Size = new Size(75, 174);
            btnMusic.TabIndex = 3;
            btnMusic.Text = "Music";
            btnMusic.UseVisualStyleBackColor = true;
            btnMusic.Click += btnMusic_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 198);
            Controls.Add(btnMusic);
            Controls.Add(btnValo);
            Controls.Add(btnAssetto);
            Controls.Add(btnLol);
            Name = "frmMain";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLol;
        private Button btnAssetto;
        private Button btnValo;
        private Button btnMusic;
    }
}