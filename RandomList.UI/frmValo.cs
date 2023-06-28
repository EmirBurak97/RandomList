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
    public partial class frmValo : Form
    {
        public frmValo()
        {
            InitializeComponent();
            _valoService = InstanceFactory.GetInstance<IValoService>();
        }
        private IValoService _valoService;
        private void frmValo_Load(object sender, EventArgs e)
        {
            LoadValo();
        }

        private void LoadValo()
        {

            dgwChars.DataSource = _valoService.GetAll();

        }

        private void btnAddChar_Click(object sender, EventArgs e)
        {
            int rowControl = dgwChars.RowCount;
            _valoService.AddUnique(new Valo
            {
                ValoName = tbxValoChar.Text
            });
            LoadValo();
            if (rowControl == dgwChars.RowCount)
            {
                MessageBox.Show("Ekleme Başarısız.");
            }
        }

        private void btnDeleteChar_Click(object sender, EventArgs e)
        {
            _valoService.Delete(new Valo
            {
                ValoId = Convert.ToInt32(dgwChars.CurrentRow.Cells[0].Value)
            });
            LoadValo();
        }

        private void btnRndValo_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lbxRndValoCharList.Items.Add(dgwChars.Rows[rnd.Next(0, dgwChars.RowCount)].Cells[1].Value.ToString());
        }

        private void frmValo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
