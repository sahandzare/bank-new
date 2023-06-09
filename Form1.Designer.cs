namespace signup
{
    partial class Form1
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
        private void InitializeComponent()
        {
            Signup = new Button();
            Firstname = new Label();
            Lastname = new Label();
            Username = new Label();
            Password = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            Email = new Label();
            amountmoney = new TextBox();
            login = new Button();
            SuspendLayout();
            // 
            // Signup
            // 
            Signup.Location = new Point(607, 360);
            Signup.Name = "Signup";
            Signup.Size = new Size(94, 29);
            Signup.TabIndex = 0;
            Signup.Text = "SignUp";
            Signup.UseVisualStyleBackColor = true;
            Signup.Click += Signup_Click;
            // 
            // Firstname
            // 
            Firstname.AutoSize = true;
            Firstname.Location = new Point(331, 28);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(73, 20);
            Firstname.TabIndex = 1;
            Firstname.Text = "Firstname";
            Firstname.Click += label1_Click;
            // 
            // Lastname
            // 
            Lastname.AutoSize = true;
            Lastname.Location = new Point(331, 111);
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(72, 20);
            Lastname.TabIndex = 2;
            Lastname.Text = "Lastname";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(331, 175);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 3;
            Username.Text = "Username";
            Username.Click += label3_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(331, 244);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(301, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(301, 285);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(301, 348);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 9;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(331, 325);
            Email.Name = "Email";
            Email.Size = new Size(52, 20);
            Email.TabIndex = 10;
            Email.Text = "E-mail";
            // 
            // amountmoney
            // 
            amountmoney.Location = new Point(58, 362);
            amountmoney.Name = "amountmoney";
            amountmoney.Size = new Size(125, 27);
            amountmoney.TabIndex = 11;
            // 
            // login
            // 
            login.Location = new Point(607, 258);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 12;
            login.Text = "login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(login);
            Controls.Add(amountmoney);
            Controls.Add(Email);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(Lastname);
            Controls.Add(Firstname);
            Controls.Add(Signup);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Signup;
        private Label Firstname;
        private Label Lastname;
        private Label Username;
        private Label Password;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label Email;
        private TextBox amountmoney;
        private Button login;
    }
}