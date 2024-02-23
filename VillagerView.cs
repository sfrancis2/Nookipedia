namespace Nookipedia
{
    public partial class VillagerView : Form
    {
        readonly BindingSource villagerBindingSource = new();
        readonly BindingSource villagerMuseumBindingSource = new();
        readonly BindingSource villagerAddBindingSource = new();

        public VillagerView()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            villagerBindingSource.DataSource = new VillagerDAO().GetAllVillagers();
            data_All.DataSource = villagerBindingSource.DataSource;
            villagerMuseumBindingSource.DataSource = new VillagerMuseumDAO().GetAllPMVillagers();
            data_personal.DataSource = villagerMuseumBindingSource.DataSource;
            villagerAddBindingSource.DataSource = new VillagerDAO().GetAllVillagersID();
            data_add.DataSource = villagerAddBindingSource.DataSource;
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            this.Close();
            UserView frm = new();
            frm.Show(this);
        }

        private void btn_creature_Click(object sender, EventArgs e)
        {
            this.Close();
            CreatureView frm = new();
            frm.Show(this);
        }

        private void btn_fossil_Click(object sender, EventArgs e)
        {
            this.Close();
            FossilView frm = new();
            frm.Show(this);
        }

        private void btn_creatureM_Click(object sender, EventArgs e)
        {
            this.Close();
            EditMuseumView frm = new();
            frm.Show(this);

        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = tb_name.Text;
            btn_search.Tag = searchQuery;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchQuery = (string)btn_search.Tag;
            villagerAddBindingSource.DataSource = new VillagerDAO().SearchAllVillagersID(searchQuery);
            data_add.DataSource = villagerAddBindingSource;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //datagrid values
            VillagerMuseumDAO vm = new();
            foreach (DataGridViewRow row in data_add.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == "1")
                {
                    int id = (int)row.Cells[1].Value;
                    DateTime dt = dateTimePicker1.Value;
                    vm.AddVillager(id, dt);
                    row.Cells[0].Value = 0;
                }
            }

            btn_add.Tag = string.Empty;
            villagerMuseumBindingSource.DataSource = new VillagerMuseumDAO().GetAllPMVillagers();
            data_personal.DataSource = villagerMuseumBindingSource.DataSource;
        }
    }
}
