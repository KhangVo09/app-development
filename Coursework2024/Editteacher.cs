using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Coursework2024.GetUserData;

namespace Coursework2024
{
    public partial class Editteacher : Form
    {
        
    

        public Editteacher(GetUserData.Person selectedPerson)
        {
            InitializeComponent();
            
            

           

        }

       public int teacherId; 
       


   

      




        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if teacherId is not null before updating the teacher
                if (teacherId != null)
                {
                    // Create a new Teacher object with updated values from the form fields
                    Teacher updatedTeacher = new Teacher
                    {
                        ID = teacherId,
                        Name = nameBox.Text,
                        Telephone = telephoneBox.Text,
                        Email = emailBox.Text,
                        Salary = Convert.ToDouble(salaryBox.Text),
                        Subject1 = subject1Box.Text,
                        Subject2 = subject2Box.Text
                    };

                    // Call the UpdateTeacher method with the updated teacher object
                    SQLiteDataAccess.UpdateTeacher(updatedTeacher);

                    MessageBox.Show("Teacher data updated successfully.");
                }
                else
                {
                    MessageBox.Show("No teacher selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating teacher data: {ex.Message}");
            }
        }

        private void subject2Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
