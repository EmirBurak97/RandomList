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
    public partial class frmLol : Form
    {
        public frmLol()
        {
            InitializeComponent();
            _lolService = InstanceFactory.GetInstance<ILolService>();
        }
        private ILolService _lolService;
        private void frmLol_Load(object sender, EventArgs e)
        {
            LoadLol();
        }

        private void btnAddChamp_Click(object sender, EventArgs e)
        {
            int rowControl = dgwLolChamps.RowCount;
            _lolService.AddUnique(new Lol
            {
                CharacterName = tbxChamp.Text
            });
            LoadLol();
            if (rowControl == dgwLolChamps.RowCount)
            {
                MessageBox.Show("Ekleme Başarısız.");
            }
        }

        private void LoadLol()
        {

            dgwLolChamps.DataSource = _lolService.GetAll();

        }

        private void btnDeleteChamp_Click(object sender, EventArgs e)
        {
            _lolService.Delete(new Lol
            {
                LolId = Convert.ToInt32(dgwLolChamps.CurrentRow.Cells[0].Value)
            });
            LoadLol();
        }

        private void btnRndLol_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lbxRndChampList.Items.Add(dgwLolChamps.Rows[rnd.Next(1, dgwLolChamps.RowCount)].Cells[1].Value.ToString());
        }

        private void frmLol_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
