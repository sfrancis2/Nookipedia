namespace Nookipedia
{
    partial class FossilView
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
            dataGridView1 = new DataGridView();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            PersonalMuseumTab = new TabPage();
            dataGridView2 = new DataGridView();
            dataGridViewCheckBoxColumn2 = new DataGridViewCheckBoxColumn();
            AddTab = new TabPage();
            btn_add = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            data_add = new DataGridView();
            col_chekck = new DataGridViewCheckBoxColumn();
            RemoveTab = new TabPage();
            button1 = new Button();
            data_remove = new DataGridView();
            col_check2 = new DataGridViewCheckBoxColumn();
            btn_fossil = new Button();
            btn_villager = new Button();
            btn_profile = new Button();
            btn_museum = new Button();
            label3 = new Label();
            button2 = new Button();
            table_main.SuspendLayout();
            AllTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            PersonalMuseumTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            title_nookipedia.Location = new Point(198, 73);
            title_nookipedia.Margin = new Padding(2, 0, 2, 0);
            title_nookipedia.Name = "title_nookipedia";
            title_nookipedia.Size = new Size(420, 67);
            title_nookipedia.TabIndex = 14;
            title_nookipedia.Text = "Fossil Museum";
            title_nookipedia.Click += title_nookipedia_Click;
            // 
            // table_main
            // 
            table_main.Controls.Add(AllTab);
            table_main.Controls.Add(PersonalMuseumTab);
            table_main.Controls.Add(AddTab);
            table_main.Controls.Add(RemoveTab);
            table_main.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            table_main.Location = new Point(64, 143);
            table_main.Name = "table_main";
            table_main.SelectedIndex = 0;
            table_main.Size = new Size(675, 289);
            table_main.TabIndex = 13;
            // 
            // AllTab
            // 
            AllTab.Controls.Add(dataGridView1);
            AllTab.Location = new Point(4, 25);
            AllTab.Name = "AllTab";
            AllTab.Size = new Size(667, 260);
            AllTab.TabIndex = 3;
            AllTab.Text = "All";
            AllTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(131, 175, 155);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn1 });
            dataGridView1.GridColor = Color.FromArgb(117, 78, 56);
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(399, 246);
            dataGridView1.TabIndex = 2;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.HeaderText = "";
            dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // PersonalMuseumTab
            // 
            PersonalMuseumTab.Controls.Add(dataGridView2);
            PersonalMuseumTab.Location = new Point(4, 25);
            PersonalMuseumTab.Name = "PersonalMuseumTab";
            PersonalMuseumTab.Size = new Size(667, 260);
            PersonalMuseumTab.TabIndex = 4;
            PersonalMuseumTab.Text = "Personal Museum";
            PersonalMuseumTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(131, 175, 155);
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn2 });
            dataGridView2.GridColor = Color.FromArgb(117, 78, 56);
            dataGridView2.Location = new Point(3, 0);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RightToLeft = RightToLeft.No;
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(399, 246);
            dataGridView2.TabIndex = 2;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            dataGridViewCheckBoxColumn2.HeaderText = "";
            dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // AddTab
            // 
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
            // btn_add
            // 
            btn_add.Location = new Point(491, 89);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(411, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 24);
            dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(411, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 24);
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
            data_add.Location = new Point(6, 7);
            data_add.Margin = new Padding(3, 4, 3, 4);
            data_add.Name = "data_add";
            data_add.RightToLeft = RightToLeft.No;
            data_add.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            data_add.RowHeadersVisible = false;
            data_add.RowHeadersWidth = 51;
            data_add.RowTemplate.Height = 25;
            data_add.Size = new Size(399, 246);
            data_add.TabIndex = 1;
            // 
            // col_chekck
            // 
            col_chekck.HeaderText = "";
            col_chekck.MinimumWidth = 6;
            col_chekck.Name = "col_chekck";
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
            // btn_fossil
            // 
            btn_fossil.BackColor = Color.FromArgb(200, 200, 169);
            btn_fossil.FlatStyle = FlatStyle.Flat;
            btn_fossil.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fossil.ForeColor = Color.FromArgb(117, 78, 56);
            btn_fossil.Location = new Point(495, 12);
            btn_fossil.Name = "btn_fossil";
            btn_fossil.Size = new Size(140, 30);
            btn_fossil.TabIndex = 41;
            btn_fossil.Text = "User Profile";
            btn_fossil.UseVisualStyleBackColor = false;
            // 
            // btn_villager
            // 
            btn_villager.BackColor = Color.FromArgb(200, 200, 169);
            btn_villager.FlatStyle = FlatStyle.Flat;
            btn_villager.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_villager.ForeColor = Color.FromArgb(117, 78, 56);
            btn_villager.Location = new Point(339, 12);
            btn_villager.Name = "btn_villager";
            btn_villager.Size = new Size(140, 30);
            btn_villager.TabIndex = 40;
            btn_villager.Text = "Villager Museum";
            btn_villager.UseVisualStyleBackColor = false;
            // 
            // btn_profile
            // 
            btn_profile.BackColor = Color.FromArgb(200, 200, 169);
            btn_profile.FlatStyle = FlatStyle.Flat;
            btn_profile.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_profile.ForeColor = Color.FromArgb(117, 78, 56);
            btn_profile.Location = new Point(24, 12);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(140, 30);
            btn_profile.TabIndex = 39;
            btn_profile.Text = "Logout";
            btn_profile.UseVisualStyleBackColor = false;
            // 
            // btn_museum
            // 
            btn_museum.BackColor = Color.FromArgb(200, 200, 169);
            btn_museum.FlatStyle = FlatStyle.Flat;
            btn_museum.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_museum.ForeColor = Color.FromArgb(117, 78, 56);
            btn_museum.Location = new Point(183, 12);
            btn_museum.Name = "btn_museum";
            btn_museum.Size = new Size(140, 30);
            btn_museum.TabIndex = 38;
            btn_museum.Text = "Creature Museum";
            btn_museum.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(117, 78, 56);
            label3.Location = new Point(-2, -1);
            label3.Name = "label3";
            label3.Size = new Size(803, 56);
            label3.TabIndex = 42;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(200, 200, 169);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(117, 78, 56);
            button2.Location = new Point(648, 12);
            button2.Name = "button2";
            button2.Size = new Size(140, 30);
            button2.TabIndex = 43;
            button2.Text = "Creature View";
            button2.UseVisualStyleBackColor = false;
            // 
            // FossilView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 200, 169);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btn_fossil);
            Controls.Add(btn_villager);
            Controls.Add(btn_profile);
            Controls.Add(btn_museum);
            Controls.Add(label3);
            Controls.Add(title_nookipedia);
            Controls.Add(table_main);
            Name = "FossilView";
            Text = "Form2";
            table_main.ResumeLayout(false);
            AllTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            PersonalMuseumTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private TabPage AddTab;
        private Button btn_add;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private DataGridView data_add;
        private DataGridViewCheckBoxColumn col_chekck;
        private TabPage RemoveTab;
        private Button button1;
        private DataGridView data_remove;
        private DataGridViewCheckBoxColumn col_check2;
        private TabPage AllTab;
        private TabPage PersonalMuseumTab;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridView dataGridView2;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private Button btn_fossil;
        private Button btn_villager;
        private Button btn_profile;
        private Button btn_museum;
        private Label label3;
        private Button button2;
    }
}