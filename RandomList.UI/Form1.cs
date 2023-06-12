using RandomList.Business.Abstract;
using RandomList.Business.DependencyResolvers.Ninject;
using RandomList.Entities.Concrete;

namespace RandomList.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _lolService = InstanceFactory.GetInstance<ILolService>();

        }

        private ILolService _lolService;

        private void btnAddChamp_Click(object sender, EventArgs e)
        {
            _lolService.Add(new Lol
            {
                CharacterName = cbxChamps.Text
            });
            LoadLol();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLol();
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
    }
}