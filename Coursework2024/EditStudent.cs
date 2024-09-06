using System;
using System.Windows.Forms;
using static Coursework2024.GetUserData;

namespace Coursework2024
{
    public partial class EditStudent : Form
    {
        public EditStudent(GetUserData.Person selectedPerson)
        {
            InitializeComponent();
        }

        public int studentId;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if studentId is not null before updating the student
                if (studentId != null)
                {
                    // Create a new Student object with updated values from the form fields
                    Student updatedStudent = new Student
                    {
                        ID = studentId,
                        Name = nameBox.Text,
                        Telephone = telephoneBox.Text,
                        Email = emailBox.Text,
                        CurrentSubject1 = subject1Box.Text,
                        CurrentSubject2 = subject2Box.Text,
                        PreviousSubject1 = previousSubject1Box.Text, 
                        PreviousSubject2 = previousSubject2Box.Text 
                    };

                    // Call the UpdateStudent method with the updated student object
                    SQLiteDataAccess.UpdateStudent(updatedStudent);

                    MessageBox.Show("Student data updated successfully.");
                }
                else
                {
                    MessageBox.Show("No student selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student data: {ex.Message}");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subject2Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
