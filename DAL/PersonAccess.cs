using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connection;
using Connection.BLL;

namespace Connection.DAL
{
    internal class PersonAccess
    {
        private static string SELECT = "SELECT * FROM person";
        private static string INSERT = "INSERT INTO `person` (`JMB`, `FirstName`, `LastName`, `Address`, `Contact`) VALUES (@JMB, @FirstName, @LastName, @Address, @Contact)";

        public List<Person> getPerson()
        {
            List<Person> persons = new List<Person>();

            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    persons.Add(new Person()
                    {
                        JMB = reader.GetString(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Address = reader.GetString(3),
                        Contact = reader.GetString(4)
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

            return persons;
        }

        public static void insertPerson(string JMB, string FirstName, string LastName, string Address, string Contact)
        {
            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@JMB", JMB);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Contact", Contact);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
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
            foreach (Person person in getPerson())
            {
                Console.WriteLine("JMB" + person.JMB);
                Console.WriteLine("First Name" + person.FirstName);
                Console.WriteLine("Last Name" + person.LastName);
                Console.WriteLine("Address" + person.Address);
                Console.WriteLine("Contact" + person.Contact);
            }
        }

    }
}
