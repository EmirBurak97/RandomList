namespace RandomList.UI
{
    partial class frmAssetto
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
            gbxAssetto = new GroupBox();
            btnDeleteCar = new Button();
            tbxAddCar = new TextBox();
            btnAddCar = new Button();
            lblCar = new Label();
            tbxAddTrack = new TextBox();
            dgwCars = new DataGridView();
            btnDeleteTrack = new Button();
            btnAddTrack = new Button();
            lblTrack = new Label();
            dgwTracks = new DataGridView();
            lbxRndSpMp = new ListBox();
            lbxRndTrack = new ListBox();
            lbxRndCar = new ListBox();
            btnRndMode = new Button();
            btnRndTrack = new Button();
            btnRndCar = new Button();
            rndNum = new Button();
            lbxRndNum = new ListBox();
            gbxAssetto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwTracks).BeginInit();
            SuspendLayout();
            // 
            // gbxAssetto
            // 
            gbxAssetto.Controls.Add(btnDeleteCar);
            gbxAssetto.Controls.Add(tbxAddCar);
            gbxAssetto.Controls.Add(btnAddCar);
            gbxAssetto.Controls.Add(lblCar);
            gbxAssetto.Controls.Add(tbxAddTrack);
            gbxAssetto.Controls.Add(dgwCars);
            gbxAssetto.Controls.Add(btnDeleteTrack);
            gbxAssetto.Controls.Add(btnAddTrack);
            gbxAssetto.Controls.Add(lblTrack);
            gbxAssetto.Controls.Add(dgwTracks);
            gbxAssetto.Location = new Point(12, 12);
            gbxAssetto.Name = "gbxAssetto";
            gbxAssetto.Size = new Size(610, 597);
            gbxAssetto.TabIndex = 2;
            gbxAssetto.TabStop = false;
            gbxAssetto.Text = "Assetto Corsa";
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Location = new Point(399, 547);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(205, 42);
            btnDeleteCar.TabIndex = 10;
            btnDeleteCar.Text = "Delete A Car!";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // tbxAddCar
            // 
            tbxAddCar.Location = new Point(366, 22);
            tbxAddCar.Name = "tbxAddCar";
            tbxAddCar.Size = new Size(238, 23);
            tbxAddCar.TabIndex = 9;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(309, 51);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(295, 58);
            btnAddCar.TabIndex = 8;
            btnAddCar.Text = "Add Car";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Location = new Point(309, 25);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(34, 15);
            lblCar.TabIndex = 7;
            lblCar.Text = "Car : ";
            // 
            // tbxAddTrack
            // 
            tbxAddTrack.Location = new Point(65, 22);
            tbxAddTrack.Name = "tbxAddTrack";
            tbxAddTrack.Size = new Size(217, 23);
            tbxAddTrack.TabIndex = 6;
            // 
            // dgwCars
            // 
            dgwCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCars.Location = new Point(309, 127);
            dgwCars.Name = "dgwCars";
            dgwCars.RowTemplate.Height = 25;
            dgwCars.Size = new Size(295, 414);
            dgwCars.TabIndex = 5;
            // 
            // btnDeleteTrack
            // 
            btnDeleteTrack.Location = new Point(6, 547);
            btnDeleteTrack.Name = "btnDeleteTrack";
            btnDeleteTrack.Size = new Size(205, 42);
            btnDeleteTrack.TabIndex = 4;
            btnDeleteTrack.Text = "Delete A Track!";
            btnDeleteTrack.UseVisualStyleBackColor = true;
            btnDeleteTrack.Click += btnDeleteTrack_Click;
            // 
            // btnAddTrack
            // 
            btnAddTrack.Location = new Point(16, 51);
            btnAddTrack.Name = "btnAddTrack";
            btnAddTrack.Size = new Size(266, 58);
            btnAddTrack.TabIndex = 3;
            btnAddTrack.Text = "Add Track";
            btnAddTrack.UseVisualStyleBackColor = true;
            btnAddTrack.Click += btnAddTrack_Click;
            // 
            // lblTrack
            // 
            lblTrack.AutoSize = true;
            lblTrack.Location = new Point(16, 25);
            lblTrack.Name = "lblTrack";
            lblTrack.Size = new Size(43, 15);
            lblTrack.TabIndex = 1;
            lblTrack.Text = "Track : ";
            // 
            // dgwTracks
            // 
            dgwTracks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwTracks.Location = new Point(6, 127);
            dgwTracks.Name = "dgwTracks";
            dgwTracks.RowTemplate.Height = 25;
            dgwTracks.Size = new Size(297, 414);
            dgwTracks.TabIndex = 0;
            // 
            // lbxRndSpMp
            // 
            lbxRndSpMp.FormattingEnabled = true;
            lbxRndSpMp.ItemHeight = 15;
            lbxRndSpMp.Items.AddRange(new object[] { "Single Player", "Online" });
            lbxRndSpMp.Location = new Point(753, 12);
            lbxRndSpMp.Name = "lbxRndSpMp";
            lbxRndSpMp.Size = new Size(227, 109);
            lbxRndSpMp.TabIndex = 3;
            // 
            // lbxRndTrack
            // 
            lbxRndTrack.FormattingEnabled = true;
            lbxRndTrack.ItemHeight = 15;
            lbxRndTrack.Location = new Point(753, 139);
            lbxRndTrack.Name = "lbxRndTrack";
            lbxRndTrack.Size = new Size(227, 109);
            lbxRndTrack.TabIndex = 4;
            // 
            // lbxRndCar
            // 
            lbxRndCar.FormattingEnabled = true;
            lbxRndCar.ItemHeight = 15;
            lbxRndCar.Location = new Point(753, 263);
            lbxRndCar.Name = "lbxRndCar";
            lbxRndCar.Size = new Size(227, 109);
            lbxRndCar.TabIndex = 5;
            // 
            // btnRndMode
            // 
            btnRndMode.Location = new Point(628, 12);
            btnRndMode.Name = "btnRndMode";
            btnRndMode.Size = new Size(119, 109);
            btnRndMode.TabIndex = 6;
            btnRndMode.Text = "Random Mode";
            btnRndMode.UseVisualStyleBackColor = true;
            btnRndMode.Click += btnRndMode_Click;
            // 
            // btnRndTrack
            // 
            btnRndTrack.Location = new Point(628, 139);
            btnRndTrack.Name = "btnRndTrack";
            btnRndTrack.Size = new Size(119, 109);
            btnRndTrack.TabIndex = 7;
            btnRndTrack.Text = "Random Track";
            btnRndTrack.UseVisualStyleBackColor = true;
            btnRndTrack.Click += btnRndTrack_Click;
            // 
            // btnRndCar
            // 
            btnRndCar.Location = new Point(628, 263);
            btnRndCar.Name = "btnRndCar";
            btnRndCar.Size = new Size(119, 109);
            btnRndCar.TabIndex = 8;
            btnRndCar.Text = "Random Car";
            btnRndCar.UseVisualStyleBackColor = true;
            btnRndCar.Click += btnRndCar_Click;
            // 
            // rndNum
            // 
            rndNum.Location = new Point(628, 378);
            rndNum.Name = "rndNum";
            rndNum.Size = new Size(119, 109);
            rndNum.TabIndex = 10;
            rndNum.Text = "Random Number";
            rndNum.UseVisualStyleBackColor = true;
            rndNum.Click += rndNum_Click;
            // 
            // lbxRndNum
            // 
            lbxRndNum.FormattingEnabled = true;
            lbxRndNum.ItemHeight = 15;
            lbxRndNum.Location = new Point(753, 378);
            lbxRndNum.Name = "lbxRndNum";
            lbxRndNum.Size = new Size(227, 109);
            lbxRndNum.TabIndex = 9;
            // 
            // frmAssetto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 636);
            Controls.Add(rndNum);
            Controls.Add(lbxRndNum);
            Controls.Add(btnRndCar);
            Controls.Add(btnRndTrack);
            Controls.Add(btnRndMode);
            Controls.Add(lbxRndCar);
            Controls.Add(lbxRndTrack);
            Controls.Add(lbxRndSpMp);
            Controls.Add(gbxAssetto);
            Name = "frmAssetto";
            Text = "Assetto Corsa";
            FormClosing += frmAssetto_FormClosing;
            Load += frmAssetto_Load;
            gbxAssetto.ResumeLayout(false);
            gbxAssetto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwTracks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxAssetto;
        private Button btnDeleteTrack;
        private Button btnAddTrack;
        private Label lblTrack;
        private DataGridView dgwTracks;
        private DataGridView dgwCars;
        private ListBox lbxRndSpMp;
        private ListBox lbxRndTrack;
        private ListBox lbxRndCar;
        private Button btnRndMode;
        private Button btnRndTrack;
        private Button btnRndCar;
        private TextBox tbxAddCar;
        private Button btnAddCar;
        private Label lblCar;
        private TextBox tbxAddTrack;
        private Button btnDeleteCar;
        private Button rndNum;
        private ListBox lbxRndNum;
    }
}