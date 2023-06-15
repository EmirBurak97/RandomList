using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomList.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnLol_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLol frmLol = new frmLol();
            frmLol.Show();
        }

        private void btnAssetto_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAssetto frmAssetto = new frmAssetto();
            frmAssetto.Show();
        }

        private void btnValo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmValo frmValo = new frmValo();
            frmValo.Show();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMusic frmMusic = new frmMusic();
            frmMusic.Show();
        }
    }
}
