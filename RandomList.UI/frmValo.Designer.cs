namespace RandomList.UI
{
    partial class frmValo
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
            gbxChars = new GroupBox();
            btnDeleteChar = new Button();
            btnAddChar = new Button();
            cbxChars = new ComboBox();
            lblAddChar = new Label();
            dgwChars = new DataGridView();
            lbxRndValoCharList = new ListBox();
            btnRndValo = new Button();
            gbxChars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwChars).BeginInit();
            SuspendLayout();
            // 
            // gbxChars
            // 
            gbxChars.Controls.Add(btnDeleteChar);
            gbxChars.Controls.Add(btnAddChar);
            gbxChars.Controls.Add(cbxChars);
            gbxChars.Controls.Add(lblAddChar);
            gbxChars.Controls.Add(dgwChars);
            gbxChars.Location = new Point(12, 12);
            gbxChars.Name = "gbxChars";
            gbxChars.Size = new Size(394, 597);
            gbxChars.TabIndex = 4;
            gbxChars.TabStop = false;
            gbxChars.Text = "Char";
            // 
            // btnDeleteChar
            // 
            btnDeleteChar.Location = new Point(6, 547);
            btnDeleteChar.Name = "btnDeleteChar";
            btnDeleteChar.Size = new Size(379, 42);
            btnDeleteChar.TabIndex = 4;
            btnDeleteChar.Text = "Delete A Char!";
            btnDeleteChar.UseVisualStyleBackColor = true;
            btnDeleteChar.Click += btnDeleteChar_Click;
            // 
            // btnAddChar
            // 
            btnAddChar.Location = new Point(317, 24);
            btnAddChar.Name = "btnAddChar";
            btnAddChar.Size = new Size(68, 29);
            btnAddChar.TabIndex = 3;
            btnAddChar.Text = "Add";
            btnAddChar.UseVisualStyleBackColor = true;
            btnAddChar.Click += btnAddChar_Click;
            // 
            // cbxChars
            // 
            cbxChars.FormattingEnabled = true;
            cbxChars.Items.AddRange(new object[] { "Jett", "Raze", "Breach", "Omen", "Brimstone", "Phoenix", "Sage", "Sova", "Viper", "Cypher", "Reyna", "Killjoy", "Skye", "Yoru", "Astra", "Kayo", "Chamber", "Neon", "Fade", "Harbor", "Gekko" });
            cbxChars.Location = new Point(127, 28);
            cbxChars.Name = "cbxChars";
            cbxChars.Size = new Size(165, 23);
            cbxChars.TabIndex = 2;
            // 
            // lblAddChar
            // 
            lblAddChar.AutoSize = true;
            lblAddChar.Location = new Point(15, 31);
            lblAddChar.Name = "lblAddChar";
            lblAddChar.Size = new Size(75, 15);
            lblAddChar.TabIndex = 1;
            lblAddChar.Text = "Add a Char : ";
            // 
            // dgwChars
            // 
            dgwChars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwChars.Location = new Point(6, 59);
            dgwChars.Name = "dgwChars";
            dgwChars.RowTemplate.Height = 25;
            dgwChars.Size = new Size(379, 482);
            dgwChars.TabIndex = 0;
            // 
            // lbxRndValoCharList
            // 
            lbxRndValoCharList.FormattingEnabled = true;
            lbxRndValoCharList.ItemHeight = 15;
            lbxRndValoCharList.Location = new Point(803, 75);
            lbxRndValoCharList.Name = "lbxRndValoCharList";
            lbxRndValoCharList.Size = new Size(323, 484);
            lbxRndValoCharList.TabIndex = 10;
            // 
            // btnRndValo
            // 
            btnRndValo.Location = new Point(412, 71);
            btnRndValo.Name = "btnRndValo";
            btnRndValo.Size = new Size(385, 482);
            btnRndValo.TabIndex = 9;
            btnRndValo.Text = "Random Valo Char";
            btnRndValo.UseVisualStyleBackColor = true;
            btnRndValo.Click += btnRndValo_Click;
            // 
            // frmValo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 621);
            Controls.Add(lbxRndValoCharList);
            Controls.Add(btnRndValo);
            Controls.Add(gbxChars);
            Name = "frmValo";
            Text = "Valorant";
            FormClosing += frmValo_FormClosing;
            Load += frmValo_Load;
            gbxChars.ResumeLayout(false);
            gbxChars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwChars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxChars;
        private Button btnDeleteChar;
        private Button btnAddChar;
        private ComboBox cbxChars;
        private Label lblAddChar;
        private DataGridView dgwChars;
        private ListBox lbxRndValoCharList;
        private Button btnRndValo;
    }
}