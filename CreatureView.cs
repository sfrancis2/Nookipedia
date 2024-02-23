namespace Nookipedia
{
    public partial class CreatureView : Form
    {
        readonly BindingSource creatureBindingSource = new();
        readonly BindingSource fishBindingSource = new();
        readonly BindingSource insectBindingSource = new();
        readonly BindingSource seacreatureBindingSource = new();
        readonly BindingSource creatureActiveBindingSource = new();
        readonly BindingSource fishActiveBindingSource = new();
        readonly BindingSource insectActiveBindingSource = new();
        readonly BindingSource seacreatureActiveBindingSource = new();
        readonly BindingSource creatureMuseumBindingSource = new();
        readonly BindingSource fishMuseumBindingSource = new();
        readonly BindingSource insectMuseumBindingSource = new();
        readonly BindingSource seacreatureMuseumBindingSource = new();

        public CreatureView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            creatureBindingSource.DataSource = new CreatureDAO().GetAll();
            fishBindingSource.DataSource = new FishDAO().GetAllFish();
            insectBindingSource.DataSource = new InsectDAO().GetAllInsect();
            seacreatureBindingSource.DataSource = new SeaCreatureDAO().GetAllSeaCreature();
            creatureActiveBindingSource.DataSource = new CreatureDAO().GetAllActive();
            fishActiveBindingSource.DataSource = new FishDAO().GetAllActiveFish();
            insectActiveBindingSource.DataSource = new InsectDAO().GetAllActiveInsect();
            seacreatureActiveBindingSource.DataSource = new SeaCreatureDAO().GetAllActiveSeaCreature();
            creatureMuseumBindingSource.DataSource = new CreatureMuseumDAO().GetAll();
            fishMuseumBindingSource.DataSource = new FishMuseumDAO().GetAllFish();
            insectMuseumBindingSource.DataSource = new InsectMuseumDAO().GetAllInsect();
            seacreatureMuseumBindingSource.DataSource = new SeaCreatureMuseumDAO().GetAllSeaCreature();
            data_overview.DataSource = creatureBindingSource;
            data_active.DataSource = creatureActiveBindingSource;
            data_personal.DataSource = creatureMuseumBindingSource;

            List<Item> items = new()
            {
                new Item(0, "Month"),
                new Item(1, "January"),
                new Item(2, "February"),
                new Item(3, "March"),
                new Item(4, "April"),
                new Item(5, "May"),
                new Item(6, "June"),
                new Item(7, "July"),
                new Item(8, "August"),
                new Item(9, "September"),
                new Item(10, "October"),
                new Item(11, "November"),
                new Item(12, "December"),

            };
            cmbo_month.DisplayMember = "Text";
            cmbo_month.ValueMember = "Value";
            cmbo_month.DataSource = items;

        }

        private void btn_creature_Click(object sender, EventArgs e)//creature
        {
            data_overview.DataSource = null;
            data_overview.DataSource = creatureBindingSource;
            data_active.DataSource = creatureActiveBindingSource;
            data_personal.DataSource = creatureMuseumBindingSource;
        }

        private void btn_fish_Click(object sender, EventArgs e)//Fish button
        {
            data_overview.DataSource = null;
            data_overview.DataSource = fishBindingSource;
            data_active.DataSource = fishActiveBindingSource;
            data_personal.DataSource = fishMuseumBindingSource;
        }


        private void btn_insect_Click(object sender, EventArgs e)//insect button
        {
            data_overview.DataSource = null;
            data_overview.DataSource = insectBindingSource;
            data_active.DataSource = insectActiveBindingSource;
            data_personal.DataSource = insectMuseumBindingSource;
        }

        private void btn_seacreature_Click(object sender, EventArgs e)//sea creature button
        {
            data_overview.DataSource = null;
            data_overview.DataSource = seacreatureBindingSource;
            data_active.DataSource = seacreatureActiveBindingSource;
            data_personal.DataSource = seacreatureMuseumBindingSource;
        }

        private void btn_search_Click(object sender, EventArgs e)//search button
        {
            string searchQuery = (string)btn_search.Tag; // Retrieve the search query from the Tag property of the button
            string? monthName = cmbo_month.SelectedItem.ToString();
            int? month = monthName switch
            {
                "January" => 1,
                "February" => 2,
                "March" => 3,
                "April" => 4,
                "May" => 5,
                "June" => 6,
                "July" => 7,
                "August" => 8,
                "September" => 9,
                "October" => 10,
                "November" => 11,
                "December" => 12,
                _ => null,
            };
            if (data_overview.DataSource == creatureBindingSource)
            {
                creatureBindingSource.DataSource = new CreatureDAO().GetAllFilter(searchQuery, month);
                data_overview.DataSource = creatureBindingSource;
                creatureActiveBindingSource.DataSource = new CreatureDAO().GetAllActiveFilter(searchQuery, month);
                data_active.DataSource = creatureActiveBindingSource;
                creatureMuseumBindingSource.DataSource = new CreatureMuseumDAO().GetAllFilter(searchQuery, month);
                data_personal.DataSource = creatureMuseumBindingSource;
            }
            else if (data_overview.DataSource == fishBindingSource)
            {
                fishBindingSource.DataSource = new FishDAO().FilterFish(searchQuery, month);
                data_overview.DataSource = fishBindingSource;
                fishActiveBindingSource.DataSource = new FishDAO().FilterActiveFish(searchQuery, month);
                data_active.DataSource = fishActiveBindingSource;
                fishMuseumBindingSource.DataSource = new FishMuseumDAO().FilterFish(searchQuery, month);
                data_personal.DataSource = fishMuseumBindingSource;
            }
            else if (data_overview.DataSource == insectBindingSource)
            {
                insectBindingSource.DataSource = new InsectDAO().FilterInsect(searchQuery, month);
                data_overview.DataSource = insectBindingSource;
                insectActiveBindingSource.DataSource = new InsectDAO().FilterActiveInsect(searchQuery, month);
                data_active.DataSource = insectActiveBindingSource;
                insectMuseumBindingSource.DataSource = new InsectMuseumDAO().FilterInsect(searchQuery, month);
                data_personal.DataSource = insectMuseumBindingSource;
            }
            else if (data_overview.DataSource == seacreatureBindingSource)
            {
                seacreatureBindingSource.DataSource = new SeaCreatureDAO().FilterSeaCreature(searchQuery, month);
                data_overview.DataSource = seacreatureBindingSource;
                seacreatureActiveBindingSource.DataSource = new SeaCreatureDAO().FilterActiveSeaCreature(searchQuery, month);
                data_active.DataSource = seacreatureActiveBindingSource;
                seacreatureBindingSource.DataSource = new SeaCreatureDAO().FilterSeaCreature(searchQuery, month);
                data_personal.DataSource = seacreatureBindingSource;
                seacreatureMuseumBindingSource.DataSource = new SeaCreatureMuseumDAO().FilterSeaCreature(searchQuery, month);
                data_personal.DataSource = seacreatureMuseumBindingSource;
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)//search bar
        {
            string searchQuery = searchBar.Text;
            btn_search.Tag = searchQuery; // Store the search query in the Tag property of the button
        }

        private void cmbo_month_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void btn_logout_Click(object sender, EventArgs e)
        {

        }

        private void btn_userProf_Click(object sender, EventArgs e)
        {
            this.Hide();
            FossilView frm = new();
            frm.Show(this);

        }

        private void btn_villager_Click(object sender, EventArgs e)
        {
            this.Hide();
            VillagerView frm = new();
            frm.Show(this);
        }

        private void btn_fossil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FossilView frm = new();
            frm.Show(this);
        }

        private void btn_creatureM_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditMuseumView frm = new();
            frm.Show(this);

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            searchBar.Text = string.Empty;
            btn_search.Tag = string.Empty;
            cmbo_month.SelectedValue = 0;
            creatureBindingSource.DataSource = new CreatureDAO().GetAll();
            fishBindingSource.DataSource = new FishDAO().GetAllFish();
            insectBindingSource.DataSource = new InsectDAO().GetAllInsect();
            seacreatureBindingSource.DataSource = new SeaCreatureDAO().GetAllSeaCreature();
            creatureActiveBindingSource.DataSource = new CreatureDAO().GetAllActive();
            fishActiveBindingSource.DataSource = new FishDAO().GetAllActiveFish();
            insectActiveBindingSource.DataSource = new InsectDAO().GetAllActiveInsect();
            seacreatureActiveBindingSource.DataSource = new SeaCreatureDAO().GetAllActiveSeaCreature();
            creatureMuseumBindingSource.DataSource = new CreatureMuseumDAO().GetAll();
            fishMuseumBindingSource.DataSource = new FishMuseumDAO().GetAllFish();
            insectMuseumBindingSource.DataSource = new InsectMuseumDAO().GetAllInsect();
            seacreatureMuseumBindingSource.DataSource = new SeaCreatureMuseumDAO().GetAllSeaCreature();
            data_overview.DataSource = creatureBindingSource;
            data_active.DataSource = creatureActiveBindingSource;
            data_personal.DataSource = creatureMuseumBindingSource;

        }
    }
}