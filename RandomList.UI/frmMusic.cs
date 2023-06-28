using RandomList.Business.Abstract;
using RandomList.Business.DependencyResolvers.Ninject;
using RandomList.Entities.Concrete;
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
    public partial class frmMusic : Form
    {
        public frmMusic()
        {
            InitializeComponent();
            _musicService = InstanceFactory.GetInstance<IMusicService>();
        }

        private IMusicService _musicService;

        private void frmMusic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMusic_Load(object sender, EventArgs e)
        {
            LoadMusics();
        }

        private void LoadMusics()
        {
            dgwMusics.DataSource = _musicService.GetAll();
        }

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            int rowControl = dgwMusics.Rows.Count;
            _musicService.AddUnique(new Music
            {
                MusicName = tbxMusic.Text
            });
            LoadMusics();
            if (rowControl == dgwMusics.Rows.Count)
            {
                MessageBox.Show("Ekleme Başarısız.");
            }
        }

        private void btnDeleteMusic_Click(object sender, EventArgs e)
        {
            _musicService.Delete(new Music
            {
                MusicId = Convert.ToInt32(dgwMusics.CurrentRow.Cells[0].Value)
            });
            LoadMusics();
        }

        private void btnRndMusic_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lbxRndMusicList.Items.Add(dgwMusics.Rows[rnd.Next(0,dgwMusics.Rows.Count)].Cells[1].Value.ToString());
        }
    }
}
