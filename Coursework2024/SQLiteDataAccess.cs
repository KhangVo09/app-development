using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using static Coursework2024.GetUserData;

namespace Coursework2024
{
    public class SQLiteDataAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<Teacher> LoadTeachers()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<Teacher>("SELECT * FROM Teacher");
                return output.ToList();
            }
        }

        public static void SaveTeacher(Teacher teacher)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO Teacher (Name, Telephone, Email, Salary, Subject1, Subject2) VALUES (@Name, @Telephone, @Email, @Salary, @Subject1, @Subject2)", teacher);
            }
        }

        public static List<Admin> LoadAdmins()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<Admin>("SELECT * FROM Admin");
                return output.ToList();
            }
        }

        public static void SaveAdmin(Admin admin)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO Admin (Name, Telephone, Email, Salary, FullTime, WorkingHours) VALUES (@Name, @Telephone, @Email, @Salary, @FullTime, @WorkingHours)", admin);
            }
        }

        public static List<Student> LoadStudents()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<Student>("SELECT * FROM Student");
                return output.ToList();
            }
        }

        public static void SaveStudent(Student student)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO Student (Name, Telephone, Email, CurrentSubject1, CurrentSubject2, Previoussubject1, Previoussubject2) VALUES (@Name, @Telephone, @Email, @CurrentSubject1, @CurrentSubject2, @PreviousSubject1, @PreviousSubject2)", student);
            }
        }


        public static List<Teacher> LoadAllTeachers()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                return connection.Query<Teacher>("SELECT * FROM Teacher").ToList();
            }
        }

        public static List<Admin> LoadAllAdmins()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                return connection.Query<Admin>("SELECT * FROM Admin").ToList();
            }
        }

        public static List<Student> LoadAllStudents()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                return connection.Query<Student>("SELECT * FROM Student").ToList();
            }
        }

        public static void DeleteTeacher(Teacher teacher)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Teacher WHERE ID = @ID",teacher);
               
            }
        }

        public static void DeleteAdmin(Admin admin)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Admin WHERE ID = @ID",admin);
                
            }
        }

        public static void DeleteStudent(Student student)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {


                cnn.Execute(@"DELETE FROM Student WHERE ID = @ID",
                             student);
            }
        }
        public static void UpdateTeacher(Teacher teacher)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(@"UPDATE Teacher 
                      SET Name = @Name, Telephone = @Telephone, Email = @Email, Salary = @Salary, Subject1 = @Subject1, Subject2 = @Subject2 
                      WHERE ID = @ID",
                             teacher); 
            }
        }

        public static void UpdateAdmin(Admin admin)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(@"UPDATE Admin 
                      SET Name = @Name, Telephone = @Telephone, Email = @Email, Salary = @Salary, FullTime = @FullTime, WorkingHours = @WorkingHours 
                      WHERE ID = @ID",
                             admin);
            }
        }

        public static void UpdateStudent(Student student)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute(@"UPDATE Student 
                             SET Name = @Name, Telephone = @Telephone,  Email = @Email,  CurrentSubject1 = @CurrentSubject1,  CurrentSubject2 = @CurrentSubject2,  Previoussubject1 = @PreviousSubject1,  Previoussubject2 = @PreviousSubject2 
                             WHERE ID = @ID", 
                             student);
            }
        }



        public static Person GetPersonByID(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Query the database to retrieve the person with the given ID
                string query = "SELECT * FROM People WHERE ID = @ID";
                return cnn.QueryFirstOrDefault<Person>(query, new { ID = id });
            }
        }

        public static Teacher GetTeacherByID(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.QueryFirstOrDefault<Teacher>("SELECT * FROM Teacher WHERE ID = @ID", new { ID = id });
            }
        }

        public static Admin GetAdminByID(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.QueryFirstOrDefault<Admin>("SELECT * FROM Admin WHERE ID = @ID", new { ID = id });
            }
        }

        public static Student GetStudentByID(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.QueryFirstOrDefault<Student>("SELECT * FROM Student WHERE ID = @ID", new { ID = id });
            }
        }

        






    }
}

        
  