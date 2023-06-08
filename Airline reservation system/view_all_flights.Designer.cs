namespace Airline_reservation_system
{
    partial class view_all_flights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_all_flights));
            label3 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            textBox3 = new TextBox();
            label11 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            label18 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            panel14 = new Panel();
            label15 = new Label();
            pictureBox12 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(834, 9);
            label3.Name = "label3";
            label3.Size = new Size(545, 65);
            label3.TabIndex = 25;
            label3.Text = "All Available Flights";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(191, 255, 254);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(322, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(1540, 917);
            panel2.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.Aqua;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Lucida Sans Unicode", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LimeGreen;
            button1.Location = new Point(718, 173);
            button1.Name = "button1";
            button1.Size = new Size(143, 59);
            button1.TabIndex = 62;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(826, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(314, 32);
            textBox3.TabIndex = 61;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Sans Unicode", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 0, 192);
            label11.Location = new Point(91, 85);
            label11.Name = "label11";
            label11.Size = new Size(101, 27);
            label11.TabIndex = 60;
            label11.Text = "Flight ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(826, 85);
            label5.Name = "label5";
            label5.Size = new Size(73, 27);
            label5.TabIndex = 56;
            label5.Text = "Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1210, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 32);
            dateTimePicker1.TabIndex = 59;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(444, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 32);
            textBox2.TabIndex = 58;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Lucida Sans Unicode", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(0, 0, 192);
            label18.Location = new Point(1210, 88);
            label18.Name = "label18";
            label18.Size = new Size(102, 27);
            label18.TabIndex = 57;
            label18.Text = "BirthDay";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Sans Unicode", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 0, 192);
            label12.Location = new Point(444, 85);
            label12.Name = "label12";
            label12.Size = new Size(52, 27);
            label12.TabIndex = 55;
            label12.Text = "SSN";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 115);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(314, 32);
            textBox1.TabIndex = 54;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Aqua;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1319, 597);
            dataGridView1.TabIndex = 53;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Sans Unicode", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(43, 6, 247);
            label10.Location = new Point(646, 11);
            label10.Name = "label10";
            label10.Size = new Size(271, 48);
            label10.TabIndex = 21;
            label10.Text = "Flight details";
            // 
            // panel14
            // 
            panel14.Controls.Add(label15);
            panel14.Controls.Add(pictureBox12);
            panel14.Location = new Point(21, 838);
            panel14.Name = "panel14";
            panel14.Size = new Size(275, 104);
            panel14.TabIndex = 27;
            panel14.Paint += panel14_Paint;
            panel14.Click += panel14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Lucida Sans Unicode", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(162, 35);
            label15.Name = "label15";
            label15.Size = new Size(85, 42);
            label15.TabIndex = 15;
            label15.Text = "Exit";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(11, 15);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(95, 83);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 14;
            pictureBox12.TabStop = false;
            // 
            // view_all_flights
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(1924, 965);
            Controls.Add(panel14);
            Controls.Add(panel2);
            Controls.Add(label3);
            Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "view_all_flights";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "view_all_flights";
            Load += view_all_flights_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label10;
        private TextBox textBox3;
        private Label label11;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Label label18;
        private Label label12;
        private TextBox textBox1;
        private Button button1;
        private Panel panel14;
        private Label label15;
        private PictureBox pictureBox12;
    }
}