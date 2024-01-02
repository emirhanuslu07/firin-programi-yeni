namespace fırın
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
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            textBox14 = new TextBox();
            label15 = new Label();
            label14 = new Label();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            label13 = new Label();
            textBox11 = new TextBox();
            label12 = new Label();
            textBox10 = new TextBox();
            label11 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button6 = new Button();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            label16 = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(118, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(482, 232);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 239);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(570, 90);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(562, 62);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ekle";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(457, 21);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(452, 3);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 13;
            label8.Text = "gönderelecek tarih";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(399, 21);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(52, 23);
            textBox6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(409, 3);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 11;
            label7.Text = "fiyat";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(335, 21);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(50, 23);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 3);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 9;
            label6.Text = "adet";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 3);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 8;
            label5.Text = "ekmek türü";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(273, 21);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(52, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(209, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(49, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 2);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 5;
            label4.Text = "dükkan ismi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 3);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 4;
            label3.Text = "telefon numara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 3);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(53, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 3);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "alıcı ismi soy ismi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(68, 23);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox14);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(textBox13);
            tabPage2.Controls.Add(textBox12);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBox9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(label9);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(562, 62);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "güncelle";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(466, 24);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(100, 23);
            textBox14.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(461, 6);
            label15.Name = "label15";
            label15.Size = new Size(105, 15);
            label15.TabIndex = 12;
            label15.Text = "gönderelecek tarih";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(411, 6);
            label14.Name = "label14";
            label14.Size = new Size(30, 15);
            label14.TabIndex = 11;
            label14.Text = "fiyat";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(394, 24);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(69, 23);
            textBox13.TabIndex = 10;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(330, 23);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(47, 23);
            textBox12.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(336, 6);
            label13.Name = "label13";
            label13.Size = new Size(30, 15);
            label13.TabIndex = 8;
            label13.Text = "adet";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(265, 23);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(48, 23);
            textBox11.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(256, 5);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 6;
            label12.Text = "ekmek türü";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(182, 24);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(65, 23);
            textBox10.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(178, 5);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 4;
            label11.Text = "dükkan ismi";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(87, 23);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(58, 23);
            textBox9.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(80, 3);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 2;
            label10.Text = "telefon numarası";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(19, 21);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(48, 23);
            textBox8.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 3);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 0;
            label9.Text = "ismi soy ismi";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(89, 181);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "fırın";
            // 
            // button5
            // 
            button5.Location = new Point(6, 138);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "güncelle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 109);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 80);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 51);
            button2.Name = "button2";
            button2.Size = new Size(77, 23);
            button2.TabIndex = 1;
            button2.Text = "güncelle \" \"";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "ekle menü";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(6, 22);
            button6.Name = "button6";
            button6.Size = new Size(29, 23);
            button6.TabIndex = 3;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(111, 22);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(71, 23);
            textBox15.TabIndex = 4;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(111, 51);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(71, 23);
            textBox16.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(218, 41);
            label16.Name = "label16";
            label16.Size = new Size(18, 20);
            label16.TabIndex = 6;
            label16.Text = "0";
            label16.Click += label16_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(6, 50);
            button7.Name = "button7";
            button7.Size = new Size(29, 23);
            button7.TabIndex = 7;
            button7.Text = "%";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(41, 22);
            button8.Name = "button8";
            button8.RightToLeft = RightToLeft.No;
            button8.Size = new Size(29, 23);
            button8.TabIndex = 8;
            button8.Text = "-";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(41, 50);
            button9.Name = "button9";
            button9.Size = new Size(29, 23);
            button9.TabIndex = 9;
            button9.Text = "X";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(textBox15);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(textBox16);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(label16);
            groupBox2.Location = new Point(16, 335);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(303, 85);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "hesab makinesi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(325, 321);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 99);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(221, 12);
            label17.Name = "label17";
            label17.Size = new Size(0, 15);
            label17.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(603, 422);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tabControl1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label8;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox14;
        private Label label15;
        private Label label14;
        private TextBox textBox13;
        private TextBox textBox12;
        private Label label13;
        private TextBox textBox11;
        private Label label12;
        private TextBox textBox10;
        private Button button6;
        private TextBox textBox15;
        private TextBox textBox16;
        private Label label16;
        private Button button7;
        private Button button8;
        private Button button9;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label label17;
    }
}