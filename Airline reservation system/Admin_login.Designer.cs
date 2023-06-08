namespace Airline_reservation_system
{
    partial class Admin_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_login));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(164, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Location = new Point(48, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 10);
            panel1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.MediumBlue;
            label6.Location = new Point(103, 29);
            label6.Name = "label6";
            label6.Size = new Size(230, 28);
            label6.TabIndex = 18;
            label6.Text = "Airline Reservation";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.FromArgb(191, 255, 254);
            button1.Location = new Point(164, 394);
            button1.Name = "button1";
            button1.Size = new Size(99, 35);
            button1.TabIndex = 15;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 346);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(236, 32);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(103, 315);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 259);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 32);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 228);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(134, 179);
            label3.Name = "label3";
            label3.Size = new Size(161, 28);
            label3.TabIndex = 21;
            label3.Text = "Admin Login";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(195, 542);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 17;
            label5.Text = "Back";
            label5.Click += label5_Click;
            // 
            // Admin_login
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(191, 255, 254);
            ClientSize = new Size(446, 611);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Admin_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label6;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Label label5;
    }
}