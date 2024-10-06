using System.Drawing;
using System.Windows.Forms;

namespace StudentRegistrationApplication
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            button1 = new Button();
            image1 = new PictureBox();
            label8 = new Label();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 26);
            label1.Name = "label1";
            label1.Size = new Size(248, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 67);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 1;
            label2.Text = "Last name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 113);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 2;
            label3.Text = "First name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 159);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 3;
            label4.Text = "Middle name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 205);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 4;
            label5.Text = "Gender *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 228);
            label6.Name = "label6";
            label6.Size = new Size(95, 17);
            label6.TabIndex = 5;
            label6.Text = "Date of birth *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(30, 274);
            label7.Name = "label7";
            label7.Size = new Size(125, 17);
            label7.TabIndex = 6;
            label7.Text = "Program to apply *";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(18, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(302, 23);
            textBox3.TabIndex = 9;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(98, 208);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 17);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(154, 208);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 17);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBox1.Location = new Point(18, 248);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(57, 23);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "-Day-";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024" });
            comboBox2.Location = new Point(183, 248);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(71, 23);
            comboBox2.TabIndex = 14;
            comboBox2.Text = "-Year-";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "January", "February", "March", "April ", "May", "June ", "July", "August", "September", "October", "November", "December" });
            comboBox3.Location = new Point(81, 248);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(96, 23);
            comboBox3.TabIndex = 15;
            comboBox3.Text = "-Month-";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Bachelor of Architecture (B.Arch.)", "Bachelor of Arts (B.A.)", "Bachelor of Business (B.B.)", "Bachelor of Business Administration (B.B.A.)", "Bachelor of Science in Business (B.S.B.)", "Bachelor of Canon Law (B.C.L.)", "Bachelor of Computer Science (B.C.S.)", "Bachelor of Science in Computer Science (B.S.C.S.)", "Bachelor of Criminal Justice (B.C.J.)", "Bachelor of Science in Criminal Justice (B.S.C.J.)", "Bachelor of Divinity (B.D.)", "Bachelor of Education (B.Ed.)", "Bachelor of Science in Education (B.S.Ed.)", "Bachelor of Wireless Engineering (B.W.E.)", "Bachelor of Engineering (B.E./B.Eng.)", "Bachelor of Science in Engineering (B.S.E./B.S.EN.)", "Bachelor of Science in Aerospace Engineering (B.S.A.E.)", "Bachelor of Science in Agricultural Engineering (B.S.A.E.)", "Bachelor of Science in Biological Systems (B.S.B.S.)", "Bachelor of Science in Biosystems and Agricultural Engineering (B.S.B.A.E.)", "Bachelor of Science in Biological Engineering (B.S.B.E.)", "Bachelor of Biomedical Engineering (B.B.m.E.)", "Bachelor of Science in Biomedical Engineering (B.S.B.E./B.S.B.M.E.)", "Bachelor of Science in Chemical Engineering (B.S.Ch.E.)", "Bachelor of Science in Chemical and Biomolecular Engineering (B.S.Ch.B.E.)", "Bachelor of Science in Chemical and Materials Engineering (B.S.C.M.E.)", "Bachelor of Civil Engineering (B.C.E.)", "Bachelor of Science in Civil Engineering (B.S.C.E.)", "Bachelor of Science in Civil and Infrastructure Engineering (B.S.-C.I.E.)", "Bachelor of Computer Engineering (B.Comp.E.)", "Bachelor of Science in Computer Engineering (B.S.C.E./B.S.Cmp.E.)", "Bachelor of Science in Computer Science and Engineering (B.S.C.S.E.)", "Bachelor of Science in Electrical and Computer Engineering (B.S.E.C.E.)", "Bachelor of Electrical Engineering (B.E.E.)", "Bachelor of Science in Electrical Engineering (B.S.E.E.)", "Bachelor of Science in Engineering Management (B.S.E.Mgt.)", "Bachelor of Science in Environmental Engineering (B.S.En.E./B.S.Env.E.)", "Bachelor of Fiber Engineering (B.F.E.)", "Bachelor of Science in Industrial Engineering (B.S.I.E.)", "Bachelor of Science in Manufacturing Engineering (B.S.Mfg.E.)", "Bachelor of Science in Manufacturing Systems Engineering (B.S.M.S.E.)", "Bachelor of Science in Materials Science and Engineering (B.S.M.S.E.)", "Bachelor of Science in Materials Engineering (B.S.MA.E.)", "Bachelor of Mechanical Engineering (B.M.E.)", "Bachelor of Science in Mechanical Engineering (B.S.M.E.)", "Bachelor of Science in Metallurgical Engineering (B.S.Mt.E.)", "Bachelor of Science in Mining Engineering (B.S.MI.E.)", "Bachelor of Science in Systems (B.S.-SYST.)", "Bachelor of Software Engineering (B.S.W.E.)", "Bachelor of Science in Software Engineering (B.S.S.E.)", "Bachelor of Systems Engineering (B.S.E.)", "Bachelor of Science in Systems Engineering (B.S.S.E.)", "Bachelor of Engineering Technology (B.E.T.)", "Bachelor of Science in Engineering Technology (B.S.E.T.)", "Bachelor of Science in Civil Engineering Technology (B.S.C.E.T./B.S.Civ.E.T.)", "Bachelor of Science in Computer Engineering Technology (B.S.C.E.T.)", "Bachelor of Science in Construction Engineering Technology (B.S.Con.E.T.)", "Bachelor of Science in Drafting Design Technology (B.S.D.D.T.)", "Bachelor of Science in Electrical/Electronics Technology (B.S.E.T.)", "Bachelor of Science in Electrical Engineering Technology (B.S.E.E.T.)", "Bachelor of Science in Electro-Mechanical Engineering Technology (B.S.E.M.E.T.)", "Bachelor of Science in Mechanical Engineering Technology (B.S.M.E.T.)", "Bachelor of Fine Arts (B.F.A.)", "Bachelor of Forestry (B.F.)", "Bachelor of Science in Forest Research (B.S.For.Res.)", "Bachelor of Hebrew Letters (B.H.L.)", "Bachelor of Journalism (B.J.)", "Bachelor of Laws (LL.B.)", "Bachelor of Liberal Studies (B.L.S.)", "Bachelor of Literature (B.Lit.)", "Bachelor of Marine Science (B.M.S.)", "Bachelor of Music (B.M.)", "Bachelor of Nursing (B.N.)", "Bachelor of Science in Nursing (B.S.N.)", "Bachelor of Pharmacy (B.Pharm.)", "Bachelor of Philosophy (B.Phil.)", "Bachelor of Religious Education (B.R.E.)", "Bachelor of Science (B.S.)", "Bachelor of Science in Chemistry (B.S.Ch.)", "Bachelor of Technology (B.T./B.Tech.)" });
            comboBox4.Location = new Point(18, 294);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(306, 23);
            comboBox4.TabIndex = 16;
            comboBox4.Text = "-Select program-";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(18, 323);
            button1.Name = "button1";
            button1.Size = new Size(159, 29);
            button1.TabIndex = 17;
            button1.Text = "Register student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // image1
            // 
            image1.Location = new Point(388, 67);
            image1.Name = "image1";
            image1.Size = new Size(201, 178);
            image1.TabIndex = 18;
            image1.TabStop = false;
            image1.Click += pictureBox1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(441, 292);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 19;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(432, 251);
            button2.Name = "button2";
            button2.Size = new Size(110, 30);
            button2.TabIndex = 20;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 371);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(image1);
            Controls.Add(button1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Registration Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button1;
        private PictureBox image1;
        private Label label8;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}