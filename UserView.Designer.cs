namespace Nookipedia
{
    partial class UserView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserView));
            btn_fossil = new Button();
            btn_villager = new Button();
            btn_profile = new Button();
            btn_museum = new Button();
            pictureBox1 = new PictureBox();
            usernameTB = new TextBox();
            villageNameTB = new TextBox();
            creatureCountTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            villagerCountTB = new TextBox();
            label4 = new Label();
            fossilCountTB = new TextBox();
            title_nookipedia = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_fossil
            // 
            btn_fossil.BackColor = Color.FromArgb(200, 200, 169);
            btn_fossil.FlatStyle = FlatStyle.Flat;
            btn_fossil.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fossil.ForeColor = Color.FromArgb(117, 78, 56);
            btn_fossil.Location = new Point(456, 12);
            btn_fossil.Name = "btn_fossil";
            btn_fossil.Size = new Size(127, 29);
            btn_fossil.TabIndex = 20;
            btn_fossil.Text = "Fossil Museum";
            btn_fossil.UseVisualStyleBackColor = false;
            // 
            // btn_villager
            // 
            btn_villager.BackColor = Color.FromArgb(200, 200, 169);
            btn_villager.FlatStyle = FlatStyle.Flat;
            btn_villager.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_villager.ForeColor = Color.FromArgb(117, 78, 56);
            btn_villager.Location = new Point(312, 12);
            btn_villager.Name = "btn_villager";
            btn_villager.Size = new Size(127, 29);
            btn_villager.TabIndex = 19;
            btn_villager.Text = "Villager Museum";
            btn_villager.UseVisualStyleBackColor = false;
            // 
            // btn_profile
            // 
            btn_profile.BackColor = Color.FromArgb(200, 200, 169);
            btn_profile.FlatStyle = FlatStyle.Flat;
            btn_profile.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_profile.ForeColor = Color.FromArgb(117, 78, 56);
            btn_profile.Location = new Point(12, 12);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(127, 29);
            btn_profile.TabIndex = 18;
            btn_profile.Text = "Logout";
            btn_profile.UseVisualStyleBackColor = false;
            btn_profile.Click += btn_profile_Click;
            // 
            // btn_museum
            // 
            btn_museum.BackColor = Color.FromArgb(200, 200, 169);
            btn_museum.FlatStyle = FlatStyle.Flat;
            btn_museum.Font = new Font("Britannic Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_museum.ForeColor = Color.FromArgb(117, 78, 56);
            btn_museum.Location = new Point(163, 12);
            btn_museum.Name = "btn_museum";
            btn_museum.Size = new Size(127, 29);
            btn_museum.TabIndex = 17;
            btn_museum.Text = "Creature Museum";
            btn_museum.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(117, 78, 56);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // usernameTB
            // 
            usernameTB.BackColor = Color.FromArgb(200, 200, 169);
            usernameTB.BorderStyle = BorderStyle.None;
            usernameTB.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTB.ForeColor = Color.FromArgb(117, 78, 56);
            usernameTB.Location = new Point(36, 265);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(125, 17);
            usernameTB.TabIndex = 23;
            usernameTB.Text = "User Name";
            usernameTB.TextAlign = HorizontalAlignment.Center;
            usernameTB.TextChanged += usernameTB_TextChanged;
            // 
            // villageNameTB
            // 
            villageNameTB.BackColor = Color.FromArgb(200, 200, 169);
            villageNameTB.BorderStyle = BorderStyle.None;
            villageNameTB.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            villageNameTB.ForeColor = Color.FromArgb(117, 78, 56);
            villageNameTB.Location = new Point(36, 288);
            villageNameTB.Name = "villageNameTB";
            villageNameTB.Size = new Size(125, 17);
            villageNameTB.TabIndex = 24;
            villageNameTB.Text = "Village Name";
            villageNameTB.TextAlign = HorizontalAlignment.Center;
            // 
            // creatureCountTB
            // 
            creatureCountTB.BackColor = Color.FromArgb(200, 200, 169);
            creatureCountTB.BorderStyle = BorderStyle.None;
            creatureCountTB.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            creatureCountTB.ForeColor = Color.FromArgb(117, 78, 56);
            creatureCountTB.Location = new Point(408, 181);
            creatureCountTB.Name = "creatureCountTB";
            creatureCountTB.Size = new Size(127, 17);
            creatureCountTB.TabIndex = 25;
            creatureCountTB.Text = "Creature Count";
            creatureCountTB.TextAlign = HorizontalAlignment.Center;
            creatureCountTB.TextChanged += creatureCountTB_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(200, 200, 169);
            label1.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(117, 78, 56);
            label1.Location = new Point(275, 175);
            label1.Name = "label1";
            label1.Size = new Size(127, 29);
            label1.TabIndex = 26;
            label1.Text = "Creature Count";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(200, 200, 169);
            label2.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(117, 78, 56);
            label2.Location = new Point(275, 236);
            label2.Name = "label2";
            label2.Size = new Size(127, 29);
            label2.TabIndex = 28;
            label2.Text = "Villager Count";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // villagerCountTB
            // 
            villagerCountTB.BackColor = Color.FromArgb(200, 200, 169);
            villagerCountTB.BorderStyle = BorderStyle.None;
            villagerCountTB.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            villagerCountTB.ForeColor = Color.FromArgb(117, 78, 56);
            villagerCountTB.Location = new Point(408, 242);
            villagerCountTB.Name = "villagerCountTB";
            villagerCountTB.Size = new Size(127, 17);
            villagerCountTB.TabIndex = 27;
            villagerCountTB.Text = "Villager Count";
            villagerCountTB.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(200, 200, 169);
            label4.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(117, 78, 56);
            label4.Location = new Point(275, 292);
            label4.Name = "label4";
            label4.Size = new Size(127, 29);
            label4.TabIndex = 30;
            label4.Text = "Fossil Count";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // fossilCountTB
            // 
            fossilCountTB.BackColor = Color.FromArgb(200, 200, 169);
            fossilCountTB.BorderStyle = BorderStyle.None;
            fossilCountTB.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fossilCountTB.ForeColor = Color.FromArgb(117, 78, 56);
            fossilCountTB.Location = new Point(408, 295);
            fossilCountTB.MinimumSize = new Size(127, 17);
            fossilCountTB.Name = "fossilCountTB";
            fossilCountTB.Size = new Size(127, 17);
            fossilCountTB.TabIndex = 29;
            fossilCountTB.Text = "Fossil Count";
            fossilCountTB.TextAlign = HorizontalAlignment.Center;
            // 
            // title_nookipedia
            // 
            title_nookipedia.AutoSize = true;
            title_nookipedia.BackColor = Color.FromArgb(200, 200, 169);
            title_nookipedia.FlatStyle = FlatStyle.Flat;
            title_nookipedia.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            title_nookipedia.ForeColor = Color.FromArgb(117, 78, 56);
            title_nookipedia.Location = new Point(227, 68);
            title_nookipedia.Margin = new Padding(2, 0, 2, 0);
            title_nookipedia.Name = "title_nookipedia";
            title_nookipedia.Size = new Size(344, 67);
            title_nookipedia.TabIndex = 31;
            title_nookipedia.Text = "User Profile";
            title_nookipedia.Click += title_nookipedia_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(117, 78, 56);
            label3.Location = new Point(-3, -2);
            label3.Name = "label3";
            label3.Size = new Size(793, 56);
            label3.TabIndex = 32;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(200, 200, 169);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(117, 78, 56);
            button1.Location = new Point(612, 12);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 33;
            button1.Text = "Creature View";
            button1.UseVisualStyleBackColor = false;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(131, 175, 155);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(751, 450);
            Controls.Add(button1);
            Controls.Add(title_nookipedia);
            Controls.Add(label4);
            Controls.Add(fossilCountTB);
            Controls.Add(label2);
            Controls.Add(villagerCountTB);
            Controls.Add(label1);
            Controls.Add(creatureCountTB);
            Controls.Add(villageNameTB);
            Controls.Add(usernameTB);
            Controls.Add(pictureBox1);
            Controls.Add(btn_fossil);
            Controls.Add(btn_villager);
            Controls.Add(btn_profile);
            Controls.Add(btn_museum);
            Controls.Add(label3);
            DoubleBuffered = true;
            Name = "UserView";
            Text = "2";
            Load += UserView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_fossil;
        private Button btn_villager;
        private Button btn_profile;
        private Button btn_museum;
        private PictureBox pictureBox1;
        private TextBox usernameTB;
        private TextBox villageNameTB;
        private TextBox creatureCountTB;
        private Label label1;
        private Label label2;
        private TextBox villagerCountTB;
        private Label label4;
        private TextBox fossilCountTB;
        private Label title_nookipedia;
        private Label label3;
        private Button button1;
    }
}