namespace Airline_reservation_system
{
    partial class starting_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(starting_form));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(166, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Location = new Point(50, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 10);
            panel1.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.MediumBlue;
            label6.Location = new Point(105, 19);
            label6.Name = "label6";
            label6.Size = new Size(230, 28);
            label6.TabIndex = 21;
            label6.Text = "Airline Reservation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(82, 186);
            label1.Name = "label1";
            label1.Size = new Size(281, 28);
            label1.TabIndex = 24;
            label1.Text = "Welcome to Our Flight ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(99, 214);
            label2.Name = "label2";
            label2.Size = new Size(236, 28);
            label2.TabIndex = 25;
            label2.Text = "Reservation System";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(105, 355);
            label3.Name = "label3";
            label3.Size = new Size(139, 28);
            label3.TabIndex = 26;
            label3.Text = "Are you an";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(12, 403);
            label4.Name = "label4";
            label4.Size = new Size(239, 28);
            label4.TabIndex = 27;
            label4.Text = "Or Do You Want To";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(250, 355);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 28;
            label5.Text = "Admin";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = Color.MediumBlue;
            label7.Location = new Point(257, 403);
            label7.Name = "label7";
            label7.Size = new Size(172, 28);
            label7.TabIndex = 29;
            label7.Text = "Book a Plane";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.MediumBlue;
            label8.Location = new Point(59, 492);
            label8.Name = "label8";
            label8.Size = new Size(304, 28);
            label8.TabIndex = 30;
            label8.Text = "Or Do YOU Just Want To ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label9.ForeColor = Color.MediumBlue;
            label9.Location = new Point(117, 520);
            label9.Name = "label9";
            label9.Size = new Size(195, 28);
            label9.TabIndex = 31;
            label9.Text = "Close Program";
            label9.Click += label9_Click;
            // 
            // starting_form
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(191, 255, 254);
            ClientSize = new Size(446, 611);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "starting_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "starting_form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}