namespace RandomList.UI
{
    partial class frmMusic
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
            gbxMusic = new GroupBox();
            tbxMusic = new TextBox();
            btnDeleteMusic = new Button();
            btnAddMusic = new Button();
            lblAddMusic = new Label();
            dgwMusics = new DataGridView();
            lbxRndMusicList = new ListBox();
            btnRndMusic = new Button();
            gbxMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMusics).BeginInit();
            SuspendLayout();
            // 
            // gbxMusic
            // 
            gbxMusic.Controls.Add(tbxMusic);
            gbxMusic.Controls.Add(btnDeleteMusic);
            gbxMusic.Controls.Add(btnAddMusic);
            gbxMusic.Controls.Add(lblAddMusic);
            gbxMusic.Controls.Add(dgwMusics);
            gbxMusic.Location = new Point(12, 12);
            gbxMusic.Name = "gbxMusic";
            gbxMusic.Size = new Size(394, 597);
            gbxMusic.TabIndex = 3;
            gbxMusic.TabStop = false;
            gbxMusic.Text = "Music";
            // 
            // tbxMusic
            // 
            tbxMusic.Location = new Point(103, 28);
            tbxMusic.Name = "tbxMusic";
            tbxMusic.Size = new Size(186, 23);
            tbxMusic.TabIndex = 5;
            // 
            // btnDeleteMusic
            // 
            btnDeleteMusic.Location = new Point(6, 547);
            btnDeleteMusic.Name = "btnDeleteMusic";
            btnDeleteMusic.Size = new Size(379, 42);
            btnDeleteMusic.TabIndex = 4;
            btnDeleteMusic.Text = "Delete A Music!";
            btnDeleteMusic.UseVisualStyleBackColor = true;
            btnDeleteMusic.Click += btnDeleteMusic_Click;
            // 
            // btnAddMusic
            // 
            btnAddMusic.Location = new Point(317, 24);
            btnAddMusic.Name = "btnAddMusic";
            btnAddMusic.Size = new Size(68, 29);
            btnAddMusic.TabIndex = 3;
            btnAddMusic.Text = "Add";
            btnAddMusic.UseVisualStyleBackColor = true;
            btnAddMusic.Click += btnAddMusic_Click;
            // 
            // lblAddMusic
            // 
            lblAddMusic.AutoSize = true;
            lblAddMusic.Location = new Point(15, 31);
            lblAddMusic.Name = "lblAddMusic";
            lblAddMusic.Size = new Size(82, 15);
            lblAddMusic.TabIndex = 1;
            lblAddMusic.Text = "Add a Music : ";
            // 
            // dgwMusics
            // 
            dgwMusics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMusics.Location = new Point(6, 59);
            dgwMusics.Name = "dgwMusics";
            dgwMusics.RowTemplate.Height = 25;
            dgwMusics.Size = new Size(379, 482);
            dgwMusics.TabIndex = 0;
            // 
            // lbxRndMusicList
            // 
            lbxRndMusicList.FormattingEnabled = true;
            lbxRndMusicList.ItemHeight = 15;
            lbxRndMusicList.Location = new Point(803, 75);
            lbxRndMusicList.Name = "lbxRndMusicList";
            lbxRndMusicList.Size = new Size(323, 484);
            lbxRndMusicList.TabIndex = 10;
            // 
            // btnRndMusic
            // 
            btnRndMusic.Location = new Point(412, 71);
            btnRndMusic.Name = "btnRndMusic";
            btnRndMusic.Size = new Size(385, 482);
            btnRndMusic.TabIndex = 9;
            btnRndMusic.Text = "Random Music";
            btnRndMusic.UseVisualStyleBackColor = true;
            btnRndMusic.Click += btnRndMusic_Click;
            // 
            // frmMusic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 621);
            Controls.Add(lbxRndMusicList);
            Controls.Add(btnRndMusic);
            Controls.Add(gbxMusic);
            Name = "frmMusic";
            Text = "Music";
            FormClosing += frmMusic_FormClosing;
            Load += frmMusic_Load;
            gbxMusic.ResumeLayout(false);
            gbxMusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMusics).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxMusic;
        private Button btnDeleteMusic;
        private Button btnAddMusic;
        private Label lblAddMusic;
        private DataGridView dgwMusics;
        private TextBox tbxMusic;
        private ListBox lbxRndMusicList;
        private Button btnRndMusic;
    }
}