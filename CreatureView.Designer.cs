namespace Nookipedia
{
    partial class CreatureView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 

        public class Item
        {
            public int? Value { get; set; }
            public string Text { get; set; }

            public Item(int? value, string text)
            {
                Value = value;
                Text = text;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatureView));
            btn_creature = new Button();
            data_overview = new DataGridView();
            sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            btn_fish = new Button();
            btn_insect = new Button();
            btn_seacreature = new Button();
            searchBar = new TextBox();
            btn_search = new Button();
            cmbo_month = new ComboBox();
            table_main = new TabControl();
            ActiveCreaturesTab = new TabPage();
            data_active = new DataGridView();
            AllCreaturesTab = new TabPage();
            MuseumTab = new TabPage();
            data_personal = new DataGridView();
            title_nookipedia = new Label();
            comboHmsphr = new ComboBox();
            btn_fossil = new Button();
            btn_villager = new Button();
            btn_logout = new Button();
            btn_userProf = new Button();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            btn_creatureM = new Button();
            btn_clear = new Button();
            ((System.ComponentModel.ISupportInitialize)data_overview).BeginInit();
            table_main.SuspendLayout();
            ActiveCreaturesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_active).BeginInit();
            AllCreaturesTab.SuspendLayout();
            MuseumTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_personal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btn_creature
            // 
            btn_creature.FlatStyle = FlatStyle.Flat;
            btn_creature.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_creature.ForeColor = Color.FromArgb(117, 78, 56);
            btn_creature.Location = new Point(78, 270);
            btn_creature.Margin = new Padding(3, 4, 3, 4);
            btn_creature.Name = "btn_creature";
            btn_creature.Size = new Size(127, 31);
            btn_creature.TabIndex = 0;
            btn_creature.Text = "All";
            btn_creature.UseVisualStyleBackColor = true;
            btn_creature.Click += btn_creature_Click;
            // 
            // data_overview
            // 
            data_overview.AllowUserToAddRows = false;
            data_overview.AllowUserToDeleteRows = false;
            data_overview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_overview.BackgroundColor = Color.FromArgb(131, 175, 155);
            data_overview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data_overview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_overview.GridColor = Color.FromArgb(117, 78, 56);
            data_overview.Location = new Point(6, 7);
            data_overview.Margin = new Padding(3, 4, 3, 4);
            data_overview.Name = "data_overview";
            data_overview.RightToLeft = RightToLeft.No;
            data_overview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            data_overview.RowHeadersVisible = false;
            data_overview.RowHeadersWidth = 51;
            data_overview.RowTemplate.Height = 25;
            data_overview.Size = new Size(696, 149);
            data_overview.TabIndex = 1;
            // 
            // sqlConnection1
            // 
            sqlConnection1.AccessToken = null;
            sqlConnection1.Credential = null;
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            sqlConnection1.StatisticsEnabled = false;
            // 
            // btn_fish
            // 
            btn_fish.FlatStyle = FlatStyle.Flat;
            btn_fish.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fish.ForeColor = Color.FromArgb(117, 78, 56);
            btn_fish.Location = new Point(78, 317);
            btn_fish.Name = "btn_fish";
            btn_fish.Size = new Size(127, 29);
            btn_fish.TabIndex = 2;
            btn_fish.Text = "Fish";
            btn_fish.UseVisualStyleBackColor = true;
            btn_fish.Click += btn_fish_Click;
            // 
            // btn_insect
            // 
            btn_insect.FlatStyle = FlatStyle.Flat;
            btn_insect.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_insect.ForeColor = Color.FromArgb(117, 78, 56);
            btn_insect.Location = new Point(78, 366);
            btn_insect.Name = "btn_insect";
            btn_insect.Size = new Size(127, 29);
            btn_insect.TabIndex = 3;
            btn_insect.Text = "Insect";
            btn_insect.UseVisualStyleBackColor = true;
            btn_insect.Click += btn_insect_Click;
            // 
            // btn_seacreature
            // 
            btn_seacreature.FlatStyle = FlatStyle.Flat;
            btn_seacreature.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_seacreature.ForeColor = Color.FromArgb(117, 78, 56);
            btn_seacreature.Location = new Point(78, 410);
            btn_seacreature.Name = "btn_seacreature";
            btn_seacreature.Size = new Size(127, 29);
            btn_seacreature.TabIndex = 4;
            btn_seacreature.Text = "Sea Creature";
            btn_seacreature.UseVisualStyleBackColor = true;
            btn_seacreature.Click += btn_seacreature_Click;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.FromArgb(131, 175, 155);
            searchBar.BorderStyle = BorderStyle.FixedSingle;
            searchBar.ForeColor = Color.FromArgb(147, 97, 70);
            searchBar.Location = new Point(228, 215);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(439, 27);
            searchBar.TabIndex = 5;
            searchBar.Text = "Search Text";
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // btn_search
            // 
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search.ForeColor = Color.FromArgb(117, 78, 56);
            btn_search.Location = new Point(846, 213);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 29);
            btn_search.TabIndex = 6;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // cmbo_month
            // 
            cmbo_month.BackColor = Color.FromArgb(200, 200, 169);
            cmbo_month.DisplayMember = "Text";
            cmbo_month.FlatStyle = FlatStyle.Flat;
            cmbo_month.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbo_month.ForeColor = Color.FromArgb(117, 78, 56);
            cmbo_month.FormattingEnabled = true;
            cmbo_month.Location = new Point(680, 216);
            cmbo_month.Name = "cmbo_month";
            cmbo_month.Size = new Size(151, 24);
            cmbo_month.TabIndex = 8;
            cmbo_month.ValueMember = "Value";
            cmbo_month.SelectedIndexChanged += cmbo_month_SelectedIndexChanged;
            // 
            // table_main
            // 
            table_main.Controls.Add(ActiveCreaturesTab);
            table_main.Controls.Add(AllCreaturesTab);
            table_main.Controls.Add(MuseumTab);
            table_main.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            table_main.Location = new Point(228, 248);
            table_main.Name = "table_main";
            table_main.SelectedIndex = 0;
            table_main.Size = new Size(716, 196);
            table_main.TabIndex = 10;
            // 
            // ActiveCreaturesTab
            // 
            ActiveCreaturesTab.Controls.Add(data_active);
            ActiveCreaturesTab.ForeColor = Color.FromArgb(117, 78, 56);
            ActiveCreaturesTab.Location = new Point(4, 25);
            ActiveCreaturesTab.Name = "ActiveCreaturesTab";
            ActiveCreaturesTab.Padding = new Padding(3);
            ActiveCreaturesTab.Size = new Size(708, 167);
            ActiveCreaturesTab.TabIndex = 0;
            ActiveCreaturesTab.Text = "Active";
            ActiveCreaturesTab.UseVisualStyleBackColor = true;
            // 
            // data_active
            // 
            data_active.AllowUserToAddRows = false;
            data_active.AllowUserToDeleteRows = false;
            data_active.BackgroundColor = Color.FromArgb(131, 175, 155);
            data_active.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data_active.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(117, 78, 56);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(131, 175, 155);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            data_active.DefaultCellStyle = dataGridViewCellStyle1;
            data_active.GridColor = Color.FromArgb(117, 78, 56);
            data_active.Location = new Point(3, 3);
            data_active.Name = "data_active";
            data_active.RowHeadersVisible = false;
            data_active.RowHeadersWidth = 51;
            data_active.RowTemplate.Height = 29;
            data_active.Size = new Size(696, 151);
            data_active.TabIndex = 0;
            // 
            // AllCreaturesTab
            // 
            AllCreaturesTab.Controls.Add(data_overview);
            AllCreaturesTab.ForeColor = Color.FromArgb(117, 78, 56);
            AllCreaturesTab.Location = new Point(4, 25);
            AllCreaturesTab.Name = "AllCreaturesTab";
            AllCreaturesTab.Padding = new Padding(3);
            AllCreaturesTab.Size = new Size(708, 167);
            AllCreaturesTab.TabIndex = 1;
            AllCreaturesTab.Text = "All";
            AllCreaturesTab.UseVisualStyleBackColor = true;
            // 
            // MuseumTab
            // 
            MuseumTab.Controls.Add(data_personal);
            MuseumTab.ForeColor = Color.FromArgb(117, 78, 56);
            MuseumTab.Location = new Point(4, 25);
            MuseumTab.Name = "MuseumTab";
            MuseumTab.Size = new Size(708, 167);
            MuseumTab.TabIndex = 2;
            MuseumTab.Text = "Personal Museum";
            MuseumTab.UseVisualStyleBackColor = true;
            // 
            // data_personal
            // 
            data_personal.AllowUserToAddRows = false;
            data_personal.AllowUserToDeleteRows = false;
            data_personal.BackgroundColor = Color.FromArgb(131, 175, 155);
            data_personal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data_personal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_personal.GridColor = Color.FromArgb(117, 78, 56);
            data_personal.Location = new Point(3, 3);
            data_personal.Name = "data_personal";
            data_personal.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data_personal.RowHeadersVisible = false;
            data_personal.RowHeadersWidth = 51;
            data_personal.RowTemplate.Height = 29;
            data_personal.Size = new Size(699, 161);
            data_personal.TabIndex = 0;
            // 
            // title_nookipedia
            // 
            title_nookipedia.AutoSize = true;
            title_nookipedia.FlatStyle = FlatStyle.Flat;
            title_nookipedia.Font = new Font("Britannic Bold", 72F, FontStyle.Regular, GraphicsUnit.Point);
            title_nookipedia.ForeColor = Color.FromArgb(117, 78, 56);
            title_nookipedia.Location = new Point(300, 53);
            title_nookipedia.Margin = new Padding(2, 0, 2, 0);
            title_nookipedia.Name = "title_nookipedia";
            title_nookipedia.Size = new Size(644, 133);
            title_nookipedia.TabIndex = 11;
            title_nookipedia.Text = "Nookipedia";
            // 
            // comboHmsphr
            // 
            comboHmsphr.BackColor = Color.FromArgb(200, 200, 169);
            comboHmsphr.DisplayMember = "Text";
            comboHmsphr.FlatStyle = FlatStyle.Flat;
            comboHmsphr.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboHmsphr.ForeColor = Color.FromArgb(117, 78, 56);
            comboHmsphr.FormattingEnabled = true;
            comboHmsphr.Location = new Point(78, 218);
            comboHmsphr.Name = "comboHmsphr";
            comboHmsphr.Size = new Size(127, 24);
            comboHmsphr.TabIndex = 17;
            comboHmsphr.Text = "Hemisphere";
            // 
            // btn_fossil
            // 
            btn_fossil.BackColor = Color.FromArgb(200, 200, 169);
            btn_fossil.FlatStyle = FlatStyle.Flat;
            btn_fossil.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fossil.ForeColor = Color.FromArgb(117, 78, 56);
            btn_fossil.Location = new Point(602, 11);
            btn_fossil.Name = "btn_fossil";
            btn_fossil.Size = new Size(190, 30);
            btn_fossil.TabIndex = 36;
            btn_fossil.Text = "Fossil Museum";
            btn_fossil.UseVisualStyleBackColor = false;
            btn_fossil.Click += btn_fossil_Click;
            // 
            // btn_villager
            // 
            btn_villager.BackColor = Color.FromArgb(200, 200, 169);
            btn_villager.FlatStyle = FlatStyle.Flat;
            btn_villager.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_villager.ForeColor = Color.FromArgb(117, 78, 56);
            btn_villager.Location = new Point(406, 11);
            btn_villager.Name = "btn_villager";
            btn_villager.Size = new Size(190, 30);
            btn_villager.TabIndex = 35;
            btn_villager.Text = "Villager Museum";
            btn_villager.UseVisualStyleBackColor = false;
            btn_villager.Click += btn_villager_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(200, 200, 169);
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_logout.ForeColor = Color.FromArgb(117, 78, 56);
            btn_logout.Location = new Point(14, 11);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(190, 30);
            btn_logout.TabIndex = 34;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // btn_userProf
            // 
            btn_userProf.BackColor = Color.FromArgb(200, 200, 169);
            btn_userProf.FlatStyle = FlatStyle.Flat;
            btn_userProf.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_userProf.ForeColor = Color.FromArgb(117, 78, 56);
            btn_userProf.Location = new Point(210, 11);
            btn_userProf.Name = "btn_userProf";
            btn_userProf.Size = new Size(190, 30);
            btn_userProf.TabIndex = 33;
            btn_userProf.Text = "User Profile";
            btn_userProf.UseVisualStyleBackColor = false;
            btn_userProf.Click += btn_userProf_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(117, 78, 56);
            label3.Location = new Point(-1, -3);
            label3.Name = "label3";
            label3.Size = new Size(1048, 56);
            label3.TabIndex = 37;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(30, 53);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(269, 159);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // btn_creatureM
            // 
            btn_creatureM.BackColor = Color.FromArgb(200, 200, 169);
            btn_creatureM.FlatStyle = FlatStyle.Flat;
            btn_creatureM.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_creatureM.ForeColor = Color.FromArgb(117, 78, 56);
            btn_creatureM.Location = new Point(798, 11);
            btn_creatureM.Name = "btn_creatureM";
            btn_creatureM.Size = new Size(190, 30);
            btn_creatureM.TabIndex = 39;
            btn_creatureM.Text = "Creature Museum";
            btn_creatureM.UseVisualStyleBackColor = false;
            btn_creatureM.Click += btn_creatureM_Click;
            // 
            // btn_clear
            // 
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clear.ForeColor = Color.FromArgb(117, 78, 56);
            btn_clear.Location = new Point(846, 178);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 29);
            btn_clear.TabIndex = 40;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // CreatureView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 200, 169);
            ClientSize = new Size(1049, 450);
            Controls.Add(btn_clear);
            Controls.Add(btn_creatureM);
            Controls.Add(pictureBox3);
            Controls.Add(btn_fossil);
            Controls.Add(btn_villager);
            Controls.Add(btn_logout);
            Controls.Add(btn_userProf);
            Controls.Add(label3);
            Controls.Add(comboHmsphr);
            Controls.Add(title_nookipedia);
            Controls.Add(table_main);
            Controls.Add(cmbo_month);
            Controls.Add(btn_search);
            Controls.Add(searchBar);
            Controls.Add(btn_seacreature);
            Controls.Add(btn_insect);
            Controls.Add(btn_fish);
            Controls.Add(btn_creature);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreatureView";
            Text = "Nookipedia";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)data_overview).EndInit();
            table_main.ResumeLayout(false);
            ActiveCreaturesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_active).EndInit();
            AllCreaturesTab.ResumeLayout(false);
            MuseumTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_personal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_creature; //Creatures -> btn_creature
        private Button btn_fish; //Fish
        private Button btn_insect; //Insects
        private Button btn_seacreature; //SeaCreatures
        private Button btn_search; //Search Button
        private ComboBox cmbo_month;
        private TabControl table_main;
        private TabPage AllCreaturesTab;
        private DataGridView data_overview; //All Creatures
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private TabPage ActiveCreaturesTab;
        private DataGridView data_active;//Active Creatures
        private TabPage MuseumTab;
        private Label title_nookipedia;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn col_ActiveCreatureName;
        private DataGridViewTextBoxColumn col_ActiveCreatureType;
        private DataGridViewTextBoxColumn col_ActiveActiveStart;
        private DataGridViewTextBoxColumn col_ActiveActiveEnd;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView data_personal;
        private ComboBox comboHmsphr;
        private Button btn_fossil;
        private Button btn_villager;
        private Button btn_logout;
        private Button btn_userProf;
        private Label label3;
        private PictureBox pictureBox3;
        private Button btn_creatureM;
        private Button btn_clear;
        public TextBox searchBar;
    }
}