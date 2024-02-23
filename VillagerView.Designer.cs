namespace Nookipedia
{
    partial class VillagerView
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
            title_nookipedia = new Label();
            table_main = new TabControl();
            AllTab = new TabPage();
            data_All = new DataGridView();
            PersonalMuseumTab = new TabPage();
            data_personal = new DataGridView();
            AddTab = new TabPage();
            tb_name = new TextBox();
            btn_search = new Button();
            btn_add = new Button();
            data_add = new DataGridView();
            col_check = new DataGridViewCheckBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            RemoveTab = new TabPage();
            button1 = new Button();
            data_remove = new DataGridView();
            col_check2 = new DataGridViewCheckBoxColumn();
            btn_user = new Button();
            btn_fossil = new Button();
            btn_profile = new Button();
            btn_creatureM = new Button();
            label3 = new Label();
            btn_creature = new Button();
            table_main.SuspendLayout();
            AllTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_All).BeginInit();
            PersonalMuseumTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_personal).BeginInit();
            AddTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_add).BeginInit();
            RemoveTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_remove).BeginInit();
            SuspendLayout();
            // 
            // title_nookipedia
            // 
            title_nookipedia.AutoSize = true;
            title_nookipedia.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            title_nookipedia.ForeColor = Color.FromArgb(117, 78, 56);
            title_nookipedia.Location = new Point(176, 71);
            title_nookipedia.Margin = new Padding(2, 0, 2, 0);
            title_nookipedia.Name = "title_nookipedia";
            title_nookipedia.Size = new Size(468, 67);
            title_nookipedia.TabIndex = 16;
            title_nookipedia.Text = "Villager Museum";
            // 
            // table_main
            // 
            table_main.Controls.Add(AllTab);
            table_main.Controls.Add(PersonalMuseumTab);
            table_main.Controls.Add(AddTab);
            table_main.Controls.Add(RemoveTab);
            table_main.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            table_main.Location = new Point(63, 141);
            table_main.Name = "table_main";
            table_main.SelectedIndex = 0;
            table_main.Size = new Size(675, 289);
            table_main.TabIndex = 15;
            // 
            // AllTab
            // 
            AllTab.Controls.Add(data_All);
            AllTab.Location = new Point(4, 25);
            AllTab.Name = "AllTab";
            AllTab.Size = new Size(667, 260);
            AllTab.TabIndex = 3;
            AllTab.Text = "All";
            AllTab.UseVisualStyleBackColor = true;
            // 
            // data_All
            // 
            data_All.AllowUserToAddRows = false;
            data_All.AllowUserToDeleteRows = false;
            data_All.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_All.BackgroundColor = Color.FromArgb(131, 175, 155);
            data_All.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data_All.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_All.GridColor = Color.FromArgb(117, 78, 56);
            data_All.Location = new Point(3, 0);
            data_All.Margin = new Padding(3, 4, 3, 4);
            data_All.Name = "data_All";
            data_All.RightToLeft = RightToLeft.No;
            data_All.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            data_All.RowHeadersVisible = false;
            data_All.RowHeadersWidth = 51;
            data_All.RowTemplate.Height = 25;
            data_All.Size = new Size(664, 246);
            data_All.TabIndex = 2;
            // 
            // PersonalMuseumTab
            // 
            PersonalMuseumTab.Controls.Add(data_personal);
            PersonalMuseumTab.Location = new Point(4, 25);
            PersonalMuseumTab.Name = "PersonalMuseumTab";
            PersonalMuseumTab.Size = new Size(667, 260);
            PersonalMuseumTab.TabIndex = 4;
            PersonalMuseumTab.Text = "Personal Museum";
            PersonalMuseumTab.UseVisualStyleBackColor = true;
            // 
            // data_personal
            // 
            data_personal.AllowUserToAddRows = false;
            data_personal.AllowUserToDeleteRows = false;
            data_personal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_personal.BackgroundColor = Color.FromArgb(131, 175, 155);
            data_personal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data_personal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_personal.GridColor = Color.FromArgb(117, 78, 56);
            data_personal.Location = new Point(3, 0);
            data_personal.Margin = new Padding(3, 4, 3, 4);
            data_personal.Name = "data_personal";
            data_personal.RightToLeft = RightToLeft.No;
            data_personal.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            data_personal.RowHeadersVisible = false;
            data_personal.RowHeadersWidth = 51;
            data_personal.RowTemplate.Height = 25;
            data_personal.Size = new Size(661, 246);
            data_personal.TabIndex = 2;
            // 
            // AddTab
            // 
            AddTab.Controls.Add(tb_name);
            AddTab.Controls.Add(btn_search);
            AddTab.Controls.Add(btn_add);
            AddTab.Controls.Add(data_add);
            AddTab.Controls.Add(dateTimePicker1);
            AddTab.ForeColor = Color.FromArgb(117, 78, 56);
            AddTab.Location = new Point(4, 25);
            AddTab.Name = "AddTab";
            AddTab.Padding = new Padding(3);
            AddTab.Size = new Size(667, 260);
            AddTab.TabIndex = 1;
            AddTab.Text = "Add";
            AddTab.UseVisualStyleBackColor = true;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(66, 172);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(125, 24);
            tb_name.TabIndex = 7;
            tb_name.Text = "Search Name";
            tb_name.TextChanged += tb_name_TextChanged;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(83, 202);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 29);
            btn_search.TabIndex = 6;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(514, 183);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // data_add
            // 
            data_add.AllowUserToAddRows = false;
            data_add.AllowUserToDeleteRows = false;
            data_add.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_add.BackgroundColor = Color.FromArgb(131, 175, 155);
            data_add.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data_add.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_add.Columns.AddRange(new DataGridViewColumn[] { col_check });
            data_add.GridColor = Color.FromArgb(117, 78, 56);
            data_add.Location = new Point(6, 7);
            data_add.Margin = new Padding(3, 4, 3, 4);
            data_add.Name = "data_add";
            data_add.RightToLeft = RightToLeft.No;
            data_add.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            data_add.RowHeadersVisible = false;
            data_add.RowHeadersWidth = 51;
            data_add.RowTemplate.Height = 25;
            data_add.Size = new Size(661, 158);
            data_add.TabIndex = 1;
            // 
            // col_check
            // 
            col_check.FalseValue = "0";
            col_check.HeaderText = "";
            col_check.MinimumWidth = 6;
            col_check.Name = "col_check";
            col_check.TrueValue = "1";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(258, 183);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 24);
            dateTimePicker1.TabIndex = 3;
            // 
            // RemoveTab
            // 
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
            data_remove.Location = new Point(-4, 0);
            data_remove.Name = "data_remove";
            data_remove.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data_remove.RowHeadersVisible = false;
            data_remove.RowHeadersWidth = 51;
            data_remove.RowTemplate.Height = 29;
            data_remove.Size = new Size(675, 177);
            data_remove.TabIndex = 0;
            // 
            // col_check2
            // 
            col_check2.HeaderText = "";
            col_check2.MinimumWidth = 6;
            col_check2.Name = "col_check2";
            col_check2.Width = 125;
            // 
            // btn_user
            // 
            btn_user.BackColor = Color.FromArgb(200, 200, 169);
            btn_user.FlatStyle = FlatStyle.Flat;
            btn_user.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_user.ForeColor = Color.FromArgb(117, 78, 56);
            btn_user.Location = new Point(484, 12);
            btn_user.Name = "btn_user";
            btn_user.Size = new Size(137, 30);
            btn_user.TabIndex = 36;
            btn_user.Text = "User Profile";
            btn_user.UseVisualStyleBackColor = false;
            btn_user.Click += btn_user_Click;
            // 
            // btn_fossil
            // 
            btn_fossil.BackColor = Color.FromArgb(200, 200, 169);
            btn_fossil.FlatStyle = FlatStyle.Flat;
            btn_fossil.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fossil.ForeColor = Color.FromArgb(117, 78, 56);
            btn_fossil.Location = new Point(329, 12);
            btn_fossil.Name = "btn_fossil";
            btn_fossil.Size = new Size(137, 30);
            btn_fossil.TabIndex = 35;
            btn_fossil.Text = "Fossil Museum";
            btn_fossil.UseVisualStyleBackColor = false;
            btn_fossil.Click += btn_fossil_Click;
            // 
            // btn_profile
            // 
            btn_profile.BackColor = Color.FromArgb(200, 200, 169);
            btn_profile.FlatStyle = FlatStyle.Flat;
            btn_profile.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_profile.ForeColor = Color.FromArgb(117, 78, 56);
            btn_profile.Location = new Point(23, 12);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(137, 30);
            btn_profile.TabIndex = 34;
            btn_profile.Text = "Logout";
            btn_profile.UseVisualStyleBackColor = false;
            // 
            // btn_creatureM
            // 
            btn_creatureM.BackColor = Color.FromArgb(200, 200, 169);
            btn_creatureM.FlatStyle = FlatStyle.Flat;
            btn_creatureM.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_creatureM.ForeColor = Color.FromArgb(117, 78, 56);
            btn_creatureM.Location = new Point(176, 12);
            btn_creatureM.Name = "btn_creatureM";
            btn_creatureM.Size = new Size(137, 30);
            btn_creatureM.TabIndex = 33;
            btn_creatureM.Text = "Creature Museum";
            btn_creatureM.UseVisualStyleBackColor = false;
            btn_creatureM.Click += btn_creatureM_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(117, 78, 56);
            label3.Location = new Point(-3, -1);
            label3.Name = "label3";
            label3.Size = new Size(803, 56);
            label3.TabIndex = 37;
            // 
            // btn_creature
            // 
            btn_creature.BackColor = Color.FromArgb(200, 200, 169);
            btn_creature.FlatStyle = FlatStyle.Flat;
            btn_creature.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_creature.ForeColor = Color.FromArgb(117, 78, 56);
            btn_creature.Location = new Point(638, 12);
            btn_creature.Name = "btn_creature";
            btn_creature.Size = new Size(137, 30);
            btn_creature.TabIndex = 38;
            btn_creature.Text = "Creature View";
            btn_creature.UseVisualStyleBackColor = false;
            btn_creature.Click += btn_creature_Click;
            // 
            // VillagerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 200, 169);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_creature);
            Controls.Add(btn_user);
            Controls.Add(btn_fossil);
            Controls.Add(btn_profile);
            Controls.Add(btn_creatureM);
            Controls.Add(label3);
            Controls.Add(title_nookipedia);
            Controls.Add(table_main);
            Name = "VillagerView";
            Text = "Form3";
            Load += Form_Load;
            table_main.ResumeLayout(false);
            AllTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_All).EndInit();
            PersonalMuseumTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_personal).EndInit();
            AddTab.ResumeLayout(false);
            AddTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_add).EndInit();
            RemoveTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_remove).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_nookipedia;
        private TabControl table_main;
        private TabPage AllTab;
        private DataGridView data_All;
        private TabPage PersonalMuseumTab;
        private DataGridView data_personal;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private TabPage AddTab;
        private Button btn_add;
        private DateTimePicker dateTimePicker1;
        private DataGridView data_add;
        private TabPage RemoveTab;
        private Button button1;
        private DataGridView data_remove;
        private DataGridViewCheckBoxColumn col_check2;
        private Button btn_user;
        private Button btn_fossil;
        private Button btn_profile;
        private Button btn_creatureM;
        private Label label3;
        private Button btn_creature;
        private Button btn_search;
        private TextBox tb_name;
        private TextBox tb_searchbox;
        private DataGridViewCheckBoxColumn col_check;
    }
}