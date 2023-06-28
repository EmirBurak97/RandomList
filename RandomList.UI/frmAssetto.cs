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
    public partial class frmAssetto : Form
    {
        public frmAssetto()
        {
            InitializeComponent();
            _carService = InstanceFactory.GetInstance<ICarService>();
            _trackService = InstanceFactory.GetInstance<ITrackService>();
        }

        private ICarService _carService;
        private ITrackService _trackService;
        private void frmAssetto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmAssetto_Load(object sender, EventArgs e)
        {
            LoadCars();
            LoadTracks();
        }

        private void LoadTracks()
        {
            dgwTracks.DataSource = _trackService.GetAll();
        }

        private void LoadCars()
        {
            dgwCars.DataSource = _carService.GetAll();
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            int rowControl = dgwTracks.RowCount;
            _trackService.AddUnique(new Track
            {
                TrackName = tbxAddTrack.Text
            });
            LoadTracks();
            if (rowControl == dgwTracks.RowCount)
            {
                MessageBox.Show("Add Failed.");
            }
        }

        private void btnDeleteTrack_Click(object sender, EventArgs e)
        {
            _trackService.Delete(new Track
            {
                TrackId = Convert.ToInt32(dgwTracks.CurrentRow.Cells[0].Value)
            });
            LoadTracks();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            int rowControl = dgwCars.RowCount;
            _carService.AddUnique(new Car
            {
                CarName = tbxAddCar.Text
            });
            LoadCars();
            if (rowControl == dgwCars.RowCount)
            {
                MessageBox.Show("Add Failed.");
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            _carService.Delete(new Car
            {
                CarId = Convert.ToInt32(dgwCars.CurrentRow.Cells[0].Value)
            });
            LoadCars();
        }

        private void btnRndMode_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            MessageBox.Show(lbxRndSpMp.Items[rnd.Next(1, 2)].ToString());
        }

        private void btnRndTrack_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lbxRndTrack.Items.Add(dgwTracks.Rows[rnd.Next(0, dgwTracks.Rows.Count)].Cells[1].Value.ToString());
        }

        private void btnRndCar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lbxRndCar.Items.Add(dgwCars.Rows[rnd.Next(0, dgwCars.Rows.Count)].Cells[1].Value.ToString());
        }

        private void rndNum_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lbxRndNum.Items.Add(rnd.Next(0, 50));
        }
    }
}
