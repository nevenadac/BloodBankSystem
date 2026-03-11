using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connection.BLL;

namespace Connection.DAL
{
    internal class EmployeeAccess
    {
        private static readonly string SELECT = "SELECT * FROM PERSON P INNER JOIN EMPLOYEE E ON E.Person_JMB = P.JMB";
        private static string INSERT = "INSERT INTO EMPLOYEE (`ACCOUNT_UserName`, `Person_JMB`, `Role`) VALUES (@ACCOUNT_UserName, @Person_JMB, @Role)";
        private static string UPDATE = "UPDATE EMPLOYEE SET ACCOUNT_UserName=@ACCOUNT_UserName, Person_JMB=@Person_JMB, Role=@Role WHERE Person_JMB=@Person_JMB";
        
        private static string DELETE = "DELETE FROM EMPLOYEE WHERE Person_JMB=@Person_JMB";


        public static List<Employee> getEmployee()
        {
            List<Employee> employees = new List<Employee>();

            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    employees.Add(new Employee()
                    {
                        Person_JMB = new Person()
                        {
                            JMB = reader.GetString(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Address = reader.GetString(3),
                            Contact = reader.GetString(4),
                        },
                        Role = reader.GetString(6)
                    });
                    
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return employees;
        }

        public static void insertEmployee(string JMB, string firstName, string lastName, string address, string contact, string role, string userName, string password)
        {
            DAL.PersonAccess.insertPerson(JMB, firstName, lastName, address, contact);
            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@ACCOUNT_UserName", userName);
                cmd.Parameters.AddWithValue("@PERSON_JMB", JMB);
                cmd.Parameters.AddWithValue("@Role", role);;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public static void updateEmployee(string Person_JMB, string Role)
        {
            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Person_JMB", Person_JMB);
                cmd.Parameters.AddWithValue("@Role", Role);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void deleteEmployee(string Person_JMB)
        {
            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("Person_JMB", Person_JMB);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void print()
        {
            foreach (Employee employee in getEmployee())
            {
                Console.WriteLine("Person_JMB" + employee.Person_JMB);
                Console.WriteLine("Role" + employee.Role);
            }
        }
    }
}
