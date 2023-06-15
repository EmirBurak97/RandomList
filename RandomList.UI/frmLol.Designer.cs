﻿namespace RandomList.UI
{
    partial class frmLol
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
            btnRndLol = new Button();
            gbxLol = new GroupBox();
            btnDeleteChamp = new Button();
            btnAddChamp = new Button();
            cbxChamps = new ComboBox();
            lblAddChamp = new Label();
            dgwLolChamps = new DataGridView();
            lbxRndChampList = new ListBox();
            gbxLol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwLolChamps).BeginInit();
            SuspendLayout();
            // 
            // btnRndLol
            // 
            btnRndLol.Location = new Point(409, 71);
            btnRndLol.Name = "btnRndLol";
            btnRndLol.Size = new Size(385, 482);
            btnRndLol.TabIndex = 7;
            btnRndLol.Text = "Random Lol Champ";
            btnRndLol.UseVisualStyleBackColor = true;
            btnRndLol.Click += btnRndLol_Click;
            // 
            // gbxLol
            // 
            gbxLol.Controls.Add(btnDeleteChamp);
            gbxLol.Controls.Add(btnAddChamp);
            gbxLol.Controls.Add(cbxChamps);
            gbxLol.Controls.Add(lblAddChamp);
            gbxLol.Controls.Add(dgwLolChamps);
            gbxLol.Location = new Point(12, 12);
            gbxLol.Name = "gbxLol";
            gbxLol.Size = new Size(391, 597);
            gbxLol.TabIndex = 6;
            gbxLol.TabStop = false;
            gbxLol.Text = "League Of Legends";
            // 
            // btnDeleteChamp
            // 
            btnDeleteChamp.Location = new Point(6, 547);
            btnDeleteChamp.Name = "btnDeleteChamp";
            btnDeleteChamp.Size = new Size(379, 42);
            btnDeleteChamp.TabIndex = 4;
            btnDeleteChamp.Text = "Delete A Champ!";
            btnDeleteChamp.UseVisualStyleBackColor = true;
            btnDeleteChamp.Click += btnDeleteChamp_Click;
            // 
            // btnAddChamp
            // 
            btnAddChamp.Location = new Point(317, 24);
            btnAddChamp.Name = "btnAddChamp";
            btnAddChamp.Size = new Size(68, 29);
            btnAddChamp.TabIndex = 3;
            btnAddChamp.Text = "Add";
            btnAddChamp.UseVisualStyleBackColor = true;
            btnAddChamp.Click += btnAddChamp_Click;
            // 
            // cbxChamps
            // 
            cbxChamps.FormattingEnabled = true;
            cbxChamps.Items.AddRange(new object[] { "Aatrox", "Ahri", "Akali", "Akshan", "Alistar", "Amumu", "Anivia", "Annie", "Aphelios", "Ashe", "Aurelion Sol", "Azir", "Bard", "Bel'Veth", "Blitzcrank", "Brand", "Braum", "Caitlyn", "Camille", "Cassiopeia", "Cho'Gath", "Corki", "Darius", "Diana", "Dr. Mundo", "Draven", "Ekko", "Elise", "Evelynn", "Ezreal", "Fiddlesticks", "Fiora", "Fizz", "Galio", "Gangplank", "Garen", "Gnar", "Gragas", "Graves", "Gwen", "Hecarim", "Heimerdinger", "Illaoi", "Irelia", "Ivern", "Janna", "Jarvan IV", "Jax", "Jayce", "Jhin", "Jinx", "K'Sante", "Kai'Sa", "Kalista", "Karma", "Karthus", "Kassadin", "Katarina", "Kayle", "Kayn", "Kennen", "Kha'Zix", "Kindred", "Kled", "Kog'Maw", "LeBlanc", "Lee Sin", "Leona", "Lillia", "Lissandra", "Lucian", "Lulu", "Lux", "Malphite", "Malzahar", "Maokai", "Master Yi", "Miss Fortune", "Mordekaiser", "Morgana", "Nami", "Nasus", "Nautilus", "Neeko", "Nidalee", "Nilah", "Nocturne", "Nunu ve Willump", "Olaf", "Orianna", "Ornn", "Pantheon", "Poppy", "Pyke", "Qiyana", "Quinn", "Rakan", "Rammus", "Rek'Sai", "Rell", "Renata Glasc", "Renekton", "Rengar", "Riven", "Rumble", "Ryze", "Samira", "Sejuani", "Senna", "Seraphine", "Sett", "Shaco", "Shen", "Shyvana", "Singed", "Sion", "Sivir", "Skarner", "Sona", "Soraka", "Swain", "Sylas", "Syndra", "Tahm Kench", "Taliyah", "Talon", "Taric", "Teemo", "Thresh", "Tristana", "Trundle", "Tryndamare", "Twisted Fate", "Twitch", "Udyr", "Urgot", "Varus", "Vayne", "Veigar", "Vel'Koz", "Vex", "Vi", "Viego", "Viktor", "Vladimir", "Volibear", "Warwick", "Wukong", "Xayah", "Xerath", "Xin Zhao", "Yasuo", "Yone", "Yorick", "Yuumi", "Zac", "Zed", "Zeri", "Ziggs", "Zilean", "Zoe", "Zyra", "", "", "" });
            cbxChamps.Location = new Point(127, 28);
            cbxChamps.Name = "cbxChamps";
            cbxChamps.Size = new Size(165, 23);
            cbxChamps.TabIndex = 2;
            // 
            // lblAddChamp
            // 
            lblAddChamp.AutoSize = true;
            lblAddChamp.Location = new Point(15, 31);
            lblAddChamp.Name = "lblAddChamp";
            lblAddChamp.Size = new Size(106, 15);
            lblAddChamp.TabIndex = 1;
            lblAddChamp.Text = "Add a Champion : ";
            // 
            // dgwLolChamps
            // 
            dgwLolChamps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLolChamps.Location = new Point(6, 59);
            dgwLolChamps.Name = "dgwLolChamps";
            dgwLolChamps.RowTemplate.Height = 25;
            dgwLolChamps.Size = new Size(379, 482);
            dgwLolChamps.TabIndex = 0;
            // 
            // lbxRndChampList
            // 
            lbxRndChampList.FormattingEnabled = true;
            lbxRndChampList.ItemHeight = 15;
            lbxRndChampList.Location = new Point(800, 75);
            lbxRndChampList.Name = "lbxRndChampList";
            lbxRndChampList.Size = new Size(323, 484);
            lbxRndChampList.TabIndex = 8;
            // 
            // frmLol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 626);
            Controls.Add(lbxRndChampList);
            Controls.Add(btnRndLol);
            Controls.Add(gbxLol);
            Name = "frmLol";
            Text = "frmLol";
            FormClosing += frmLol_FormClosing;
            Load += frmLol_Load;
            gbxLol.ResumeLayout(false);
            gbxLol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwLolChamps).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRndLol;
        private GroupBox gbxLol;
        private Button btnDeleteChamp;
        private Button btnAddChamp;
        private ComboBox cbxChamps;
        private Label lblAddChamp;
        private DataGridView dgwLolChamps;
        private ListBox lbxRndChampList;
    }
}