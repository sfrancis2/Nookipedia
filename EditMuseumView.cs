namespace Nookipedia
{
    public partial class EditMuseumView : Form
    {
        readonly BindingSource creatureBindingSource = new();
        readonly BindingSource fishBindingSource = new();
        readonly BindingSource insectBindingSource = new();
        readonly BindingSource seacreatureBindingSource = new();
        readonly BindingSource creatureMuseumBindingSource = new();
        readonly BindingSource fishMuseumBindingSource = new();
        readonly BindingSource insectMuseumBindingSource = new();
        readonly BindingSource seacreatureMuseumBindingSource = new();
        public EditMuseumView()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Get input values from the TextBox and DateTimePicker
            string userInput = textBox1.Text;
            DateTime selectedDate = dateTimePicker1.Value;
            // Perform any validation or data processing as needed
            // ...

            // Initialize DAO outside the loop
            CreatureMuseumDAO creatureMuseumDAO = new();

            // Get the data from the DataGridView
            foreach (DataGridViewRow row in data_add.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["CheckboxColumn"].Value);

                if (isChecked)
                {
                    // Use int.TryParse to handle potential non-integer values
                    if (int.TryParse(row.Cells["CreatureID"].Value.ToString(), out int ID))
                    {
                        string type = (string)row.Cells["CreatureType"].Value;

                        // Call CreateCreature with the retrieved values
                        creatureMuseumDAO.CreateCreature(ID, type, userInput, selectedDate);

                        // Show acknowledgment message
                        string acknowledgmentMessage = $"Creature created with ID: {ID}, Type: {type}, Location: {userInput}, Date: {selectedDate}";
                        MessageBox.Show(acknowledgmentMessage);
                    }
                    else
                    {
                        MessageBox.Show("Invalid CreatureID format. Unable to create creature.");
                    }
                }
            }

            // Reset the TextBox and DateTimePicker
            textBox1.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void title_nookipedia_Click(object sender, EventArgs e)
        {

        }
    }
}

