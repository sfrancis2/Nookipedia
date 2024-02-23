namespace Nookipedia
{
    partial class SignUpView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpView));
            btn_signup = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            txt_repassword = new TextBox();
            label3 = new Label();
            title_nookipedia = new Label();
            SuspendLayout();
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.FromArgb(200, 200, 169);
            btn_signup.FlatStyle = FlatStyle.Flat;
            btn_signup.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_signup.ForeColor = Color.FromArgb(117, 78, 56);
            btn_signup.Location = new Point(270, 259);
            btn_signup.Margin = new Padding(2);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(122, 33);
            btn_signup.TabIndex = 0;
            btn_signup.Text = "Sign Up";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += signedUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(200, 200, 169);
            label1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(117, 78, 56);
            label1.Location = new Point(66, 112);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 22);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(200, 200, 169);
            label2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(117, 78, 56);
            label2.Location = new Point(70, 150);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 22);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(117, 78, 56);
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.Location = new Point(176, 109);
            txt_username.Margin = new Padding(2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(216, 27);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(117, 78, 56);
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Location = new Point(176, 150);
            txt_password.Margin = new Padding(2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(216, 27);
            txt_password.TabIndex = 4;
            // 
            // txt_repassword
            // 
            txt_repassword.BackColor = Color.FromArgb(117, 78, 56);
            txt_repassword.BorderStyle = BorderStyle.FixedSingle;
            txt_repassword.Location = new Point(176, 191);
            txt_repassword.Margin = new Padding(2);
            txt_repassword.Name = "txt_repassword";
            txt_repassword.Size = new Size(216, 27);
            txt_repassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(200, 200, 169);
            label3.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(117, 78, 56);
            label3.Location = new Point(6, 191);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 22);
            label3.TabIndex = 6;
            label3.Text = "Repeat Password";
            // 
            // title_nookipedia
            // 
            title_nookipedia.AutoSize = true;
            title_nookipedia.BackColor = Color.FromArgb(200, 200, 169);
            title_nookipedia.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            title_nookipedia.ForeColor = Color.FromArgb(117, 78, 56);
            title_nookipedia.Location = new Point(196, 28);
            title_nookipedia.Margin = new Padding(2, 0, 2, 0);
            title_nookipedia.Name = "title_nookipedia";
            title_nookipedia.Size = new Size(181, 52);
            title_nookipedia.TabIndex = 13;
            title_nookipedia.Text = "Sign Up";
            // 
            // SignUpView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(131, 175, 155);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(469, 360);
            Controls.Add(title_nookipedia);
            Controls.Add(label3);
            Controls.Add(txt_repassword);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_signup);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "SignUpView";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_signup;
        private Label label1;
        private Label label2;
        private TextBox txt_username;
        private TextBox txt_password;
        private TextBox txt_repassword;
        private Label label3;
        private Label title_nookipedia;
    }
}