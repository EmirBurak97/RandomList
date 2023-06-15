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
    public partial class frmAssetto : Form
    {
        public frmAssetto()
        {
            InitializeComponent();
        }

        private void frmAssetto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
