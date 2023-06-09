namespace signup
{
    partial class home
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
            dataGridView1 = new DataGridView();
            balance = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            transfer = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridView2 = new DataGridView();
            history = new Button();
            setting = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(628, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(169, 188);
            dataGridView1.TabIndex = 0;
            // 
            // balance
            // 
            balance.Location = new Point(682, 225);
            balance.Name = "balance";
            balance.Size = new Size(94, 29);
            balance.TabIndex = 1;
            balance.Text = "balance";
            balance.UseVisualStyleBackColor = true;
            balance.Click += balance_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 2;
            label1.Text = "sender username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 93);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 3;
            label2.Text = "reciever username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 184);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 4;
            label3.Text = "amount";
            // 
            // transfer
            // 
            transfer.Location = new Point(287, 259);
            transfer.Name = "transfer";
            transfer.Size = new Size(94, 29);
            transfer.TabIndex = 5;
            transfer.Text = "transfer";
            transfer.UseVisualStyleBackColor = true;
            transfer.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(283, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(283, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(456, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(166, 188);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // history
            // 
            history.Location = new Point(493, 226);
            history.Name = "history";
            history.Size = new Size(94, 29);
            history.TabIndex = 10;
            history.Text = "history";
            history.UseVisualStyleBackColor = true;
            history.Click += history_Click;
            // 
            // setting
            // 
            setting.Location = new Point(682, 376);
            setting.Name = "setting";
            setting.Size = new Size(94, 29);
            setting.TabIndex = 12;
            setting.Text = "setting";
            setting.UseVisualStyleBackColor = true;
            setting.Click += setting_Click;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(setting);
            Controls.Add(history);
            Controls.Add(dataGridView2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(transfer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(balance);
            Controls.Add(dataGridView1);
            Name = "home";
            Text = "home";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button balance;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button transfer;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridView2;
        private Button history;
        private Button setting;
    }
}