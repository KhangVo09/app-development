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
    public partial class EditAdmin : Form
    {
        public EditAdmin(GetUserData.Person selectedPerson)
        {
            InitializeComponent();
        }

        public int adminId;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if adminId is not null before updating the admin
                if (adminId != null)
                {
                    // Create a new Admin object with updated values from the form fields
                    Admin updatedAdmin = new Admin
                    {
                        ID = adminId,
                        Name = nameBox.Text,
                        Telephone = telephoneBox.Text,
                        Email = emailBox.Text,
                        Salary = Convert.ToDouble(salaryBox.Text),
                        FullTime = Convert.ToInt32(fullTimeCheckbox.Checked), 
                        WorkingHours = Convert.ToInt32(workingHoursBox.Text) 
                    };

                    // Call the UpdateAdmin method with the updated admin object
                    SQLiteDataAccess.UpdateAdmin(updatedAdmin);

                    MessageBox.Show("Admin data updated successfully.");
                }
                else
                {
                    MessageBox.Show("No admin selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating admin data: {ex.Message}");
            }

        }



    }
}
