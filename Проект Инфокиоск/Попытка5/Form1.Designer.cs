namespace Попытка5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gabriola", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(145, 219);
            button1.Name = "button1";
            button1.Size = new Size(307, 199);
            button1.TabIndex = 0;
            button1.Text = "Создать заявку на получение карты";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gabriola", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(94, 9);
            label1.Name = "label1";
            label1.Size = new Size(526, 108);
            label1.TabIndex = 1;
            label1.Text = "Виртуальный инфокиоск";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 904);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1926, 121);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1926, 121);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1926, 1025);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gabriola", 23F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(752, 221);
            button2.Name = "button2";
            button2.Size = new Size(301, 199);
            button2.TabIndex = 6;
            button2.Text = "Поиск инфромации по ключевым словам";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGreen;
            button3.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gabriola", 23F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1366, 219);
            button3.Name = "button3";
            button3.Size = new Size(301, 199);
            button3.TabIndex = 7;
            button3.Text = "Курсы валют";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleGreen;
            button4.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gabriola", 19F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(453, 584);
            button4.Name = "button4";
            button4.Size = new Size(301, 199);
            button4.TabIndex = 8;
            button4.Text = "Просмотр информации на сайте и заявка на консультацию";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleGreen;
            button5.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Gabriola", 23F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(1060, 584);
            button5.Name = "button5";
            button5.Size = new Size(301, 199);
            button5.TabIndex = 9;
            button5.Text = "Вход в личный кабинет";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1903, 1034);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Главная ";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}