using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static Coursework2024.GetUserData;


namespace Coursework2024
{
    public partial class GetUserData : Form
    {
        List<Person> people = new List<Person>();
        private int nextID = 1;


        public string Id
        {
            get { return Id; }
            private set { Id = value; }
        }

        
        public enum Role
        {
            Teacher,
            Admin,
            Students
        }
        
        public class Person
        {

            private int id;
            public int ID
            {
                get { return id; }
                set { id = value; }
            }

            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string telephone;
            public string Telephone
            {
                get { return telephone; }
                set { telephone = value; }
            }

            private string email;
            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            private Role userRole;
            public Role UserRole
            {
                get { return userRole; }
                set { userRole = value; }
            }

            
            private int internalId;
            internal int InternalId
            {
                get { return internalId; }
                set { internalId = value; }
            }

            public virtual void DisplayInfo()
            {
                // Display basic information about the person
                MessageBox.Show($"Name: {Name}, Telephone: {Telephone}, Email: {Email}");
            }

            // for auto increase id
            public int nextID = 1;
            public Person()
            {
                ID = nextID;
                nextID++;
            }
        }
       
        public class Teacher : Person
        {
            private double salary;
            public double Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            private string subject1;
            public string Subject1
            {
                get { return subject1; }
                set { subject1 = value; }
            }

            private string subject2;
            public string Subject2
            {
                get { return subject2; }
                set { subject2 = value; }
            }

            public override void DisplayInfo()
            {
                // Customize the display for a teacher
                MessageBox.Show($"Teacher - Name: {Name}," +
                    $" Telephone: {Telephone}, Email: {Email}," +
                    $" Salary: {Salary}, Subject 1: {Subject1}, Subject 2: {Subject2}");
            }
        }
     
        public class Admin : Person
        {
            private double salary;
            public double Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            private int fullTime;
            public int FullTime
            {
                get { return fullTime; }
                set { fullTime = value; }
            }

            private int workingHours;
            public int WorkingHours
            {
                get { return workingHours; }
                set { workingHours = value; }
            }

            public override void DisplayInfo()
            {
              
                MessageBox.Show($"Admin - Name: {Name}," +
                    $" Telephone: {Telephone}, Email: {Email}, Salary: {Salary}, " +
                    $"Full-time: {(FullTime == 1 ? "Yes" : "No")}, Working Hours: {WorkingHours}");
            }
        }

        public class Student : Person
        {
            private string currentSubject1;
            public string CurrentSubject1
            {
                get { return currentSubject1; }
                set { currentSubject1 = value; }
            }

            private string currentSubject2;
            public string CurrentSubject2
            {
                get { return currentSubject2; }
                set { currentSubject2 = value; }
            }

            private string previousSubject1;
            public string PreviousSubject1
            {
                get { return previousSubject1; }
                set { previousSubject1 = value; }
            }

            private string previousSubject2;
            public string PreviousSubject2
            {
                get { return previousSubject2; }
                set { previousSubject2 = value; }
            }

            public override void DisplayInfo()
            {
                // Customize the display for a student
                MessageBox.Show($"Student - Name: {Name}, Telephone: {Telephone}, Email: {Email}," +
                    $" Current Subject 1: {CurrentSubject1}, Current Subject 2: {CurrentSubject2}," +
                    $" Previous Subject 1: {PreviousSubject1}, Previous Subject 2: {PreviousSubject2}");
            }
        }

       
        public int teacherID;
        public int adminID;
        public int studentID;

        public GetUserData()
        {
            InitializeComponent();
            InitializeRoleComboBox();
            

        }

     

        // Button part
        private void displayBtn_Click(object sender, EventArgs e)
        {
            DisplayUserInfo();

        }

    

        private void DisplayUserInfo()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear(); // Clear all columns before adding new ones


            // Load data from SQLite based on the selected role
            switch ((Role)roleComboBox.SelectedItem)
            {
                case Role.Teacher:
                    List<Teacher> teachers = SQLiteDataAccess.LoadTeachers();
                    AddColumn("Name", "Name");
                    AddColumn("ID", "ID");
                    AddColumn("Telephone", "Telephone");
                    AddColumn("Email", "Email");
                    AddColumn("Salary", "Salary");
                    AddColumn("Subject1", "Subject 1");
                    AddColumn("Subject2", "Subject 2");
                    foreach (Teacher teacher in teachers)
                    {
                        dataGridView1.Rows.Add(
                            teacher.Name,
                            teacher.ID,
                            teacher.Telephone,
                            teacher.Email,
                            teacher.Salary,
                            teacher.Subject1,
                            teacher.Subject2
                        );
                    }
                    break;

                case Role.Admin:
                    List<Admin> admins = SQLiteDataAccess.LoadAdmins();
                    AddColumn("Name", "Name");
                    AddColumn("ID", "ID");
                    AddColumn("Telephone", "Telephone");
                    AddColumn("Email", "Email");
                    AddColumn("Salary", "Salary");
                    AddColumn("FullTime", "Full-time");
                    AddColumn("WorkingHours", "Working Hours");
                    foreach (Admin admin in admins)
                    {
                        dataGridView1.Rows.Add(
                            admin.Name,
                            admin.ID,
                            admin.Telephone,
                            admin.Email,
                            admin.Salary,
                            admin.FullTime == 1 ? "Yes" : "No",
                            admin.WorkingHours
                        );
                    }
                    break;

                case Role.Students:
                    List<Student> students = SQLiteDataAccess.LoadStudents();
                    AddColumn("Name", "Name");
                    AddColumn("ID", "ID");
                    AddColumn("Telephone", "Telephone");
                    AddColumn("Email", "Email");
                    AddColumn("CurrentSubject1", "Current Subject 1");
                    AddColumn("CurrentSubject2", "Current Subject 2");
                    AddColumn("PreviousSubject1", "Previous Subject 1");
                    AddColumn("PreviousSubject2", "Previous Subject 2");
                    foreach (Student student in students)
                    {
                        dataGridView1.Rows.Add(
                            student.Name,
                            student.ID,
                            student.Telephone,
                            student.Email,
                            student.CurrentSubject1,
                            student.CurrentSubject2,
                            student.PreviousSubject1,
                            student.PreviousSubject2
                        );
                    }
                    break;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Helper method to add a column to the DataGridView
        private void AddColumn(string columnName, string headerText)
        {
            dataGridView1.Columns.Add(columnName, headerText);
        }


       
            
        private void deletebutton_Click(object sender, EventArgs e)
        {
            // Check if any rows are selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Retrieve the ID from the selected row (assuming the ID is stored in the first column)
                int resultId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                teacherID = resultId;
                adminID = resultId;
                studentID = resultId;

                MessageBox.Show("ID: " + resultId);

                // Create instances of the entities
                Student student = new Student { ID = studentID };
                Admin admin = new Admin { ID = adminID };
                Teacher teacher = new Teacher { ID = teacherID };

                // Determine the role and delete accordingly
                if (roleComboBox.SelectedItem != null)
                {
                    switch ((Role)roleComboBox.SelectedItem)
                    {
                        case Role.Teacher:
                            SQLiteDataAccess.DeleteTeacher(teacher);
                            break;
                        case Role.Admin:
                            SQLiteDataAccess.DeleteAdmin(admin);
                            break;
                        case Role.Students:
                            SQLiteDataAccess.DeleteStudent(student);
                            break;
                    }

                    // Remove the selected row from the DataGridView
                    dataGridView1.Rows.Remove(selectedRow);

                    MessageBox.Show("Item has been deleted.");
                }
                else
                {
                    MessageBox.Show("Please select a role.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Declare variables for teacher, admin, and student
            Teacher teacher = null;
            Admin admin = null;
            Student student = null;

            // Determine the role selected in the combo box
            switch ((Role)roleComboBox.SelectedItem)
            {
                case Role.Teacher:
                    // Create a new teacher object with data from the form
                    teacher = new Teacher
                    {
                        Name = nameBox.Text,
                        Telephone = telephoneBox.Text,
                        Email = emailBox.Text,
                        UserRole = Role.Teacher,
                        Salary = Convert.ToDouble(salaryBox.Value),
                        Subject1 = subject1Box.Text,
                        Subject2 = subject2Box.Text
                    };
                    break;
                case Role.Admin:
                    // Create a new admin object with data from the form
                    admin = new Admin
                    {
                        Name = nameBox.Text,
                        Telephone = telephoneBox.Text,
                        Email = emailBox.Text,
                        UserRole = Role.Admin,
                        Salary = Convert.ToDouble(salaryBox.Value),
                        FullTime = fullTimeCheckbox.Checked ? 1 : 0, // Convert checkbox state to integer
                        WorkingHours = Convert.ToInt32(workingHoursBox.Value)
                    };
                    break;
                case Role.Students:
                    // Create a new student object with data from the form
                    student = new Student
                    {
                        Name = nameBox.Text,
                        Telephone = telephoneBox.Text,
                        Email = emailBox.Text,
                        UserRole = Role.Students,
                        CurrentSubject1 = subject1Box.Text,
                        CurrentSubject2 = subject2Box.Text,
                        PreviousSubject1 = prevSubject1Box.Text,
                        PreviousSubject2 = prevSubject2Box.Text
                    };
                    break;
            }

            // Try to save the teacher, student, and admin data to the database
            try
            {
                if (teacher != null)
                {
                    SQLiteDataAccess.SaveTeacher(teacher);
                }

                if (student != null)
                {
                    SQLiteDataAccess.SaveStudent(student);
                }

                if (admin != null)
                {
                    SQLiteDataAccess.SaveAdmin(admin);
                }

                // Display success message if data is successfully saved
                MessageBox.Show("Added");
                DisplayUserInfo();

            }
            catch (Exception ex)
            {
                // Display error message if an exception occurs during database operation
                MessageBox.Show($"Failed to add person. Error: {ex.Message}");
            }
        }

        private void viewalldatabutton_Click(object sender, EventArgs e)
        {
            //InitializeDataGridView();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear(); // Clear all columns before adding new ones


            // Load data from SQLite based on the selected role
            AddColumn("Name", "Name");
            AddColumn("ID", "ID");
            AddColumn("Telephone", "Telephone");
            AddColumn("Email", "Email");
            AddColumn("Role", "Role");



            List<Teacher> teachers = SQLiteDataAccess.LoadTeachers();
                  
            foreach (Teacher teacher in teachers)
            {
                dataGridView1.Rows.Add(
                    teacher.Name,
                    teacher.ID,
                    teacher.Telephone,
                    teacher.Email,
                    "Teacher"
                    //teacher.Salary,
                    //teacher.Subject1,
                    //teacher.Subject2
                );
            }
                   

               
            List<Admin> admins = SQLiteDataAccess.LoadAdmins();
            foreach (Admin admin in admins)
            {
                dataGridView1.Rows.Add(
                    admin.Name,
                    admin.ID,
                    admin.Telephone,
                    admin.Email,
                    "Admin"

                //admin.Salary,
                //admin.FullTime == 1 ? "Yes" : "No",
                //admin.WorkingHours
                );
            }
                 
            List<Student> students = SQLiteDataAccess.LoadStudents();
            foreach (Student student in students)
            {
                dataGridView1.Rows.Add(
                    student.Name,
                    student.ID,
                    student.Telephone,
                    student.Email,
                    "Student"

               
                );
            }
                 
            

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

          
        }




        private void editbutton_Click(object sender, EventArgs e)
        {
            // Check if any rows are selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Assuming the ID is stored in the "ID" column, retrieve it directly
                int selectedId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Assign the ID to teacherID, adminID, or studentID (based on the role)
                teacherID = selectedId;
                adminID = selectedId;
                studentID = selectedId;

                MessageBox.Show("ID: " + selectedId);

                // Check if roleComboBox.SelectedItem is not null
                if (roleComboBox.SelectedItem != null)
                {
                    // Determine the type of selected item and open the corresponding edit form
                    switch ((Role)roleComboBox.SelectedItem)
                    {
                        case Role.Teacher:
                            // Get the selected teacher from the database
                            Teacher selectedTeacher = SQLiteDataAccess.GetTeacherByID(selectedId);
                            // Open the edit form for teachers with the selected teacher
                            OpenTeacherEditForm(selectedTeacher);
                            break;
                        case Role.Admin:
                            // Get the selected admin from the database
                            Admin selectedAdmin = SQLiteDataAccess.GetAdminByID(selectedId);
                            // Open the edit form for admins with the selected admin
                            OpenAdminEditForm(selectedAdmin);
                            break;
                        case Role.Students:
                            // Get the selected student from the database
                            Student selectedStudent = SQLiteDataAccess.GetStudentByID(selectedId);
                            // Open the edit form for students with the selected student
                            OpenStudentEditForm(selectedStudent);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a role.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }



    
        private void OpenTeacherEditForm(Teacher teacher)
        {
            // Instantiate and display the EditTeacher form with the selected teacher data
            Editteacher editTeacherForm = new Editteacher(teacher);
            editTeacherForm.teacherId = teacherID; 
            editTeacherForm.ShowDialog(); // Show the EditTeacher form as a modal dialog
        }
        private void OpenAdminEditForm(Admin admin)
        {
            // Instantiate and display the EditAdmin form with the selected admin data
            EditAdmin editAdminForm = new EditAdmin(admin);
            editAdminForm.adminId = adminID;
            editAdminForm.ShowDialog(); // Show the EditAdmin form as a modal dialog
        }
        private void OpenStudentEditForm(Student student)
        {
            // Instantiate and display the EditStudent form with the selected student data
            EditStudent editStudentForm = new EditStudent(student);
            editStudentForm.studentId = studentID;
            editStudentForm.ShowDialog(); // Show the EditStudent form as a modal dialog
        }

















        // UI part
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)

        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void salaryBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset visibility of all controls
            salaryBox.Visible = true;
            fullTimeCheckbox.Visible = true;
            workingHoursBox.Visible = true;
            prevSubject2Box.Visible = true;
            prevSubject1Box.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label11.Visible = true;
            subject1Box.Visible = true;
            subject2Box.Visible = true;
            // Your combo box selected index changed logic...
            Role selectedRole = (Role)roleComboBox.SelectedItem;

            // Hide or show text boxes based on the selected role
            switch (selectedRole)
            {
                case Role.Teacher:
                    // Hide text boxes related to other roles
                    fullTimeCheckbox.Visible = false;
                    workingHoursBox.Visible = false;
                    prevSubject2Box.Visible = false;
                    prevSubject1Box.Visible = false;
                    label9.Visible = false;
                    label8.Visible = false;
                    label11.Visible = false;

                    break;
                case Role.Admin:
                    prevSubject2Box.Visible = false;
                    prevSubject1Box.Visible = false;
                    label9.Visible = false;
                    label8.Visible = false;
                    label6.Visible = false;
                    subject2Box.Visible = false;
                    subject1Box.Visible = false;
                    label5.Visible = false;
                    break;
                case Role.Students:
                    salaryBox.Visible = false;
                    label3.Visible = false;
                    fullTimeCheckbox.Visible = false;
                    workingHoursBox.Visible = false;
                    label11.Visible = false;
                    label9.Visible = true;
                    prevSubject2Box.Visible = true;
                    prevSubject1Box.Visible = true;
                    label8.Visible = true;
                    break;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void workingHoursBox_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void InitializeRoleComboBox()
        {
            roleComboBox.Items.Add(Role.Teacher);
            roleComboBox.Items.Add(Role.Admin);
            roleComboBox.Items.Add(Role.Students);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}
