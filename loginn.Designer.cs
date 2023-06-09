namespace signup
{
    partial class loginn
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
            login = new Button();
            username = new Label();
            password = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(285, 263);
            login.Name = "login";
            login.Size = new Size(125, 29);
            login.TabIndex = 0;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(311, 71);
            username.Name = "username";
            username.Size = new Size(73, 20);
            username.TabIndex = 1;
            username.Text = "username";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(311, 162);
            password.Name = "password";
            password.Size = new Size(72, 20);
            password.TabIndex = 2;
            password.Text = "password";
            password.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(285, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.Location = new Point(285, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // loginn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(login);
            Name = "loginn";
            Text = "loginn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private Label username;
        private Label password;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}