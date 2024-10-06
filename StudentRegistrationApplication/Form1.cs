using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All Files (*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName = textBox1.Text;
            string firstName = textBox2.Text;
            string middleName = textBox3.Text;
            string gender = radioButton1.Checked ? "Male" : "Female";
            string dateOfBirth = $"{comboBox3.Text}/{comboBox1.Text}/{comboBox2.Text}";
            string program = comboBox4.Text;

            DisplayStudentInfo(lastName, firstName);
            DisplayStudentInfo(lastName, firstName, middleName);
            DisplayStudentInfo(lastName, firstName, middleName, gender, dateOfBirth, program);
        }

        private void DisplayStudentInfo(string lastName, string firstName)
        {
            MessageBox.Show($"Student Name: {firstName} {lastName}", "Student Information");
        }

        private void DisplayStudentInfo(string lastName, string firstName, string middleName)
        {
            MessageBox.Show($"Student Name: {firstName} {middleName} {lastName}", "Student Information");
        }

        private void DisplayStudentInfo(string lastName, string firstName, string middleName, string gender, string dateOfBirth, string program)
        {
            MessageBox.Show($"Student Name: {firstName} {middleName} {lastName}\n" +
                            $"Gender: {gender}\n" +
                            $"Date of Birth: {dateOfBirth}\n" +
                            $"Program: {program}", "Student Information");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}