using System.Windows.Forms;

namespace Nookipedia
{
    partial class EditMuseumView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RemoveTab = new TabPage();
            comboHmsphr = new ComboBox();
            btn_seacreature = new Button();
            btn_insect = new Button();
            btn_fish = new Button();
            btn_creature = new Button();
            button1 = new Button();
            data_remove = new DataGridView();
            col_check2 = new DataGridViewCheckBoxColumn();
            AddTab = new TabPage();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btn_add = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            data_add = new DataGridView();
            col_chekck = new DataGridViewCheckBoxColumn();
            table_main = new TabControl();
            title_nookipedia = new Label();
            btn_fossil = new Button();
            btn_villager = new Button();
            btn_profile = new Button();
            btn_museum = new Button();
            label3 = new Label();
            button6 = new Button();
            RemoveTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_remove).BeginInit();
            AddTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_add).BeginInit();
            table_main.SuspendLayout();
            SuspendLayout();
            // 
            // RemoveTab
            // 
            RemoveTab.Controls.Add(comboHmsphr);
            RemoveTab.Controls.Add(btn_seacreature);
            RemoveTab.Controls.Add(btn_insect);
            RemoveTab.Controls.Add(btn_fish);
            RemoveTab.Controls.Add(btn_creature);
            RemoveTab.Controls.Add(button1);
            RemoveTab.Controls.Add(data_remove);
            RemoveTab.ForeColor = Color.FromArgb(117, 78, 56);
            RemoveTab.Location = new Point(4, 25);
            RemoveTab.Name = "RemoveTab";
            RemoveTab.Size = new Size(667, 260);
            RemoveTab.TabIndex = 2;
            RemoveTab.Text = "Remove";
            RemoveTab.UseVisualStyleBackColor = true;
            // 
            // comboHmsphr
            // 
            comboHmsphr.BackColor = Color.FromArgb(200, 200, 169);
            comboHmsphr.DisplayMember = "Text";
            comboHmsphr.FlatStyle = FlatStyle.Flat;
            comboHmsphr.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboHmsphr.ForeColor = Color.FromArgb(117, 78, 56);
            comboHmsphr.FormattingEnabled = true;
            comboHmsphr.Location = new Point(13, 18);
            comboHmsphr.Name = "comboHmsphr";
            comboHmsphr.Size = new Size(127, 24);
            comboHmsphr.TabIndex = 22;
            comboHmsphr.Text = "Hemisphere";
            // 
            // btn_seacreature
            // 
            btn_seacreature.FlatStyle = FlatStyle.Flat;
            btn_seacreature.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_seacreature.ForeColor = Color.FromArgb(117, 78, 56);
            btn_seacreature.Location = new Point(13, 210);
            btn_seacreature.Name = "btn_seacreature";
            btn_seacreature.Size = new Size(127, 29);
            btn_seacreature.TabIndex = 21;
            btn_seacreature.Text = "Sea Creature";
            btn_seacreature.UseVisualStyleBackColor = true;
            // 
            // btn_insect
            // 
            btn_insect.FlatStyle = FlatStyle.Flat;
            btn_insect.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_insect.ForeColor = Color.FromArgb(117, 78, 56);
            btn_insect.Location = new Point(13, 166);
            btn_insect.Name = "btn_insect";
            btn_insect.Size = new Size(127, 29);
            btn_insect.TabIndex = 20;
            btn_insect.Text = "Insect";
            btn_insect.UseVisualStyleBackColor = true;
            // 
            // btn_fish
            // 
            btn_fish.FlatStyle = FlatStyle.Flat;
            btn_fish.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fish.ForeColor = Color.FromArgb(117, 78, 56);
            btn_fish.Location = new Point(13, 117);
            btn_fish.Name = "btn_fish";
            btn_fish.Size = new Size(127, 29);
            btn_fish.TabIndex = 19;
            btn_fish.Text = "Fish";
            btn_fish.UseVisualStyleBackColor = true;
            // 
            // btn_creature
            // 
            btn_creature.FlatStyle = FlatStyle.Flat;
            btn_creature.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_creature.ForeColor = Color.FromArgb(117, 78, 56);
            btn_creature.Location = new Point(13, 70);
            btn_creature.Margin = new Padding(3, 4, 3, 4);
            btn_creature.Name = "btn_creature";
            btn_creature.Size = new Size(127, 31);
            btn_creature.TabIndex = 18;
            btn_creature.Text = "All";
            btn_creature.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(258, 183);
            button1.Name = "button1";
            button1.Size = new Size(159, 56);
            button1.TabIndex = 1;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            // 
            // data_remove
            // 
            data_remove.AllowUserToAddRows = false;
            data_remove.AllowUserToDeleteRows = false;
            data_remove.BackgroundColor = Color.FromArgb(131, 175, 155);
            data_remove.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data_remove.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_remove.Columns.AddRange(new DataGridViewColumn[] { col_check2 });
            data_remove.GridColor = Color.FromArgb(117, 78, 56);
            data_remove.Location = new Point(154, 0);
            data_remove.Name = "data_remove";
            data_remove.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data_remove.RowHeadersVisible = false;
            data_remove.RowHeadersWidth = 51;
            data_remove.RowTemplate.Height = 29;
            data_remove.Size = new Size(513, 177);
            data_remove.TabIndex = 0;
            // 
            // col_check2
            // 
            col_check2.HeaderText = "";
            col_check2.MinimumWidth = 6;
            col_check2.Name = "col_check2";
            col_check2.Width = 125;
            // 
            // AddTab
            // 
            AddTab.Controls.Add(comboBox1);
            AddTab.Controls.Add(button2);
            AddTab.Controls.Add(button3);
            AddTab.Controls.Add(button4);
            AddTab.Controls.Add(button5);
            AddTab.Controls.Add(btn_add);
            AddTab.Controls.Add(dateTimePicker1);
            AddTab.Controls.Add(textBox1);
            AddTab.Controls.Add(data_add);
            AddTab.ForeColor = Color.FromArgb(117, 78, 56);
            AddTab.Location = new Point(4, 25);
            AddTab.Name = "AddTab";
            AddTab.Padding = new Padding(3);
            AddTab.Size = new Size(667, 260);
            AddTab.TabIndex = 1;
            AddTab.Text = "Add";
            AddTab.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(200, 200, 169);
            comboBox1.DisplayMember = "Text";
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.FromArgb(117, 78, 56);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(127, 24);
            comboBox1.TabIndex = 27;
            comboBox1.Text = "Hemisphere";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(117, 78, 56);
            button2.Location = new Point(6, 207);
            button2.Name = "button2";
            button2.Size = new Size(127, 29);
            button2.TabIndex = 26;
            button2.Text = "Sea Creature";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(117, 78, 56);
            button3.Location = new Point(6, 163);
            button3.Name = "button3";
            button3.Size = new Size(127, 29);
            button3.TabIndex = 25;
            button3.Text = "Insect";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(117, 78, 56);
            button4.Location = new Point(6, 114);
            button4.Name = "button4";
            button4.Size = new Size(127, 29);
            button4.TabIndex = 24;
            button4.Text = "Fish";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(117, 78, 56);
            button5.Location = new Point(6, 67);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(127, 31);
            button5.TabIndex = 23;
            button5.Text = "All";
            button5.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(524, 67);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(488, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 24);
            dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(488, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 24);
            textBox1.TabIndex = 2;
            // 
            // data_add
            // 
            data_add.AllowUserToAddRows = false;
            data_add.AllowUserToDeleteRows = false;
            data_add.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_add.BackgroundColor = Color.FromArgb(131, 175, 155);
            data_add.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data_add.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_add.Columns.AddRange(new DataGridViewColumn[] { col_chekck });
            data_add.GridColor = Color.FromArgb(117, 78, 56);
            data_add.Location = new Point(139, 7);
            data_add.Margin = new Padding(3, 4, 3, 4);
            data_add.Name = "data_add";
            data_add.RightToLeft = RightToLeft.No;
            data_add.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            data_add.RowHeadersVisible = false;
            data_add.RowHeadersWidth = 51;
            data_add.RowTemplate.Height = 25;
            data_add.Size = new Size(343, 246);
            data_add.TabIndex = 1;
            // 
            // col_chekck
            // 
            col_chekck.HeaderText = "";
            col_chekck.MinimumWidth = 6;
            col_chekck.Name = "col_chekck";
            // 
            // table_main
            // 
            table_main.Controls.Add(AddTab);
            table_main.Controls.Add(RemoveTab);
            table_main.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            table_main.Location = new Point(105, 102);
            table_main.Name = "table_main";
            table_main.SelectedIndex = 0;
            table_main.Size = new Size(675, 289);
            table_main.TabIndex = 11;
            // 
            // title_nookipedia
            // 
            title_nookipedia.AutoSize = true;
            title_nookipedia.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            title_nookipedia.ForeColor = Color.FromArgb(117, 78, 56);
            title_nookipedia.Location = new Point(264, 72);
            title_nookipedia.Margin = new Padding(2, 0, 2, 0);
            title_nookipedia.Name = "title_nookipedia";
            title_nookipedia.Size = new Size(390, 52);
            title_nookipedia.TabIndex = 12;
            title_nookipedia.Text = "Creature Museum";
            title_nookipedia.Click += title_nookipedia_Click;
            // 
            // btn_fossil
            // 
            btn_fossil.BackColor = Color.FromArgb(200, 200, 169);
            btn_fossil.FlatStyle = FlatStyle.Flat;
            btn_fossil.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fossil.ForeColor = Color.FromArgb(117, 78, 56);
            btn_fossil.Location = new Point(526, 12);
            btn_fossil.Name = "btn_fossil";
            btn_fossil.Size = new Size(150, 29);
            btn_fossil.TabIndex = 36;
            btn_fossil.Text = "Fossil Museum";
            btn_fossil.UseVisualStyleBackColor = false;
            // 
            // btn_villager
            // 
            btn_villager.BackColor = Color.FromArgb(200, 200, 169);
            btn_villager.FlatStyle = FlatStyle.Flat;
            btn_villager.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_villager.ForeColor = Color.FromArgb(117, 78, 56);
            btn_villager.Location = new Point(350, 12);
            btn_villager.Name = "btn_villager";
            btn_villager.Size = new Size(150, 29);
            btn_villager.TabIndex = 35;
            btn_villager.Text = "Villager Museum";
            btn_villager.UseVisualStyleBackColor = false;
            // 
            // btn_profile
            // 
            btn_profile.BackColor = Color.FromArgb(200, 200, 169);
            btn_profile.FlatStyle = FlatStyle.Flat;
            btn_profile.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_profile.ForeColor = Color.FromArgb(117, 78, 56);
            btn_profile.Location = new Point(14, 12);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(150, 29);
            btn_profile.TabIndex = 34;
            btn_profile.Text = "Logout";
            btn_profile.UseVisualStyleBackColor = false;
            // 
            // btn_museum
            // 
            btn_museum.BackColor = Color.FromArgb(200, 200, 169);
            btn_museum.FlatStyle = FlatStyle.Flat;
            btn_museum.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_museum.ForeColor = Color.FromArgb(117, 78, 56);
            btn_museum.Location = new Point(180, 12);
            btn_museum.Name = "btn_museum";
            btn_museum.Size = new Size(150, 29);
            btn_museum.TabIndex = 33;
            btn_museum.Text = "Creature View";
            btn_museum.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(117, 78, 56);
            label3.Location = new Point(-3, 1);
            label3.Name = "label3";
            label3.Size = new Size(866, 56);
            label3.TabIndex = 37;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(200, 200, 169);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(117, 78, 56);
            button6.Location = new Point(691, 12);
            button6.Name = "button6";
            button6.Size = new Size(150, 29);
            button6.TabIndex = 38;
            button6.Text = "User Profile";
            button6.UseVisualStyleBackColor = false;
            // 
            // EditMuseumView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 200, 169);
            ClientSize = new Size(863, 420);
            Controls.Add(button6);
            Controls.Add(btn_fossil);
            Controls.Add(btn_villager);
            Controls.Add(btn_profile);
            Controls.Add(btn_museum);
            Controls.Add(label3);
            Controls.Add(title_nookipedia);
            Controls.Add(table_main);
            Name = "EditMuseumView";
            Text = "EditMuseum";
            Load += EditMuseum_Load;
            RemoveTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_remove).EndInit();
            AddTab.ResumeLayout(false);
            AddTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_add).EndInit();
            table_main.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void EditMuseum_Load(object sender, EventArgs e)
        {
            creatureBindingSource.DataSource = new CreatureDAO().GetAll();
            fishBindingSource.DataSource = new FishDAO().GetAllFish();
            insectBindingSource.DataSource = new InsectDAO().GetAllInsect();
            seacreatureBindingSource.DataSource = new SeaCreatureDAO().GetAllSeaCreature();
            creatureMuseumBindingSource.DataSource = new CreatureMuseumDAO().GetAll();
            fishMuseumBindingSource.DataSource = new FishMuseumDAO().GetAllFish();
            insectMuseumBindingSource.DataSource = new InsectMuseumDAO().GetAllInsect();
            seacreatureMuseumBindingSource.DataSource = new SeaCreatureMuseumDAO().GetAllSeaCreature();
            data_add.DataSource = creatureBindingSource;
            data_add.Columns[4].Visible = false;
            data_add.Columns[5].Visible = false;
            data_remove.DataSource = creatureMuseumBindingSource;
        }

        #endregion
        private TabPage RemoveTab;
        private DataGridView data_remove;
        private TabPage AddTab;
        private DataGridView data_add;
        private TabControl table_main;
        private Label title_nookipedia;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private DataGridViewCheckBoxColumn col_check2;
        private DataGridViewCheckBoxColumn col_chekck;
        private Button btn_add;
        private Button button1;
        private ComboBox comboHmsphr;
        private Button btn_seacreature;
        private Button btn_insect;
        private Button btn_fish;
        private Button btn_creature;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btn_fossil;
        private Button btn_villager;
        private Button btn_profile;
        private Button btn_museum;
        private Label label3;
        private Button button6;
    }
}