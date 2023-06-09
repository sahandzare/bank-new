namespace signup
{
    partial class setting
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
            pictureBox1 = new PictureBox();
            changepicture = new Button();
            changepassword = new Button();
            oldpassword = new Label();
            newpassword = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            deleteaccount = new Button();
            home = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.default_avatar_profile_icon_of_social_media_user_vector;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 208);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // changepicture
            // 
            changepicture.Location = new Point(28, 231);
            changepicture.Name = "changepicture";
            changepicture.Size = new Size(140, 29);
            changepicture.TabIndex = 1;
            changepicture.Text = "change picture";
            changepicture.UseVisualStyleBackColor = true;
            changepicture.Click += changepicture_Click;
            // 
            // changepassword
            // 
            changepassword.Location = new Point(572, 101);
            changepassword.Name = "changepassword";
            changepassword.Size = new Size(144, 29);
            changepassword.TabIndex = 2;
            changepassword.Text = "change password";
            changepassword.UseVisualStyleBackColor = true;
            changepassword.Click += changepassword_Click;
            // 
            // oldpassword
            // 
            oldpassword.AutoSize = true;
            oldpassword.Location = new Point(506, 9);
            oldpassword.Name = "oldpassword";
            oldpassword.Size = new Size(98, 20);
            oldpassword.TabIndex = 3;
            oldpassword.Text = "old password";
            // 
            // newpassword
            // 
            newpassword.AutoSize = true;
            newpassword.Location = new Point(685, 9);
            newpassword.Name = "newpassword";
            newpassword.Size = new Size(103, 20);
            newpassword.TabIndex = 4;
            newpassword.Text = "new password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(494, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(667, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // deleteaccount
            // 
            deleteaccount.Location = new Point(667, 409);
            deleteaccount.Name = "deleteaccount";
            deleteaccount.Size = new Size(125, 29);
            deleteaccount.TabIndex = 7;
            deleteaccount.Text = "delete account";
            deleteaccount.UseVisualStyleBackColor = true;
            deleteaccount.Click += deleteaccount_Click;
            // 
            // home
            // 
            home.Location = new Point(28, 409);
            home.Name = "home";
            home.Size = new Size(94, 29);
            home.TabIndex = 8;
            home.Text = "home";
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // setting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(home);
            Controls.Add(deleteaccount);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(newpassword);
            Controls.Add(oldpassword);
            Controls.Add(changepassword);
            Controls.Add(changepicture);
            Controls.Add(pictureBox1);
            Name = "setting";
            Text = "setting";
            Load += changepicture_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button changepicture;
        private Button changepassword;
        private Label oldpassword;
        private Label newpassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button deleteaccount;
        private Button home;
    }
}