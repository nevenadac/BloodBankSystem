using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connection.BLL;
using System.Windows.Forms;
using System.Data;

namespace Connection.DAL
{
    internal class DonorAccess
    {
        private static string SELECT = "SELECT * FROM PERSON P INNER JOIN DONOR D ON D.Person_JMB = P.JMB";
        private static string INSERT = "INSERT INTO `donor` (`Gender`, `BloodGroup`, `Person_JMB`, `ACCOUNT_UserName`) VALUES (@Gender, @BloodGroup, @Person_JMB, @ACCOUNT_UserName)";
        private static string UPDATE = "UPDATE DONOR SET Gender= @Gender, BloodGroup=@BloodGroup, Person_JMB=@Person_JMB, ACCOUNT_UserName=@ACCOUNT_UserName WHERE Person_JMB=@Person_JMB";


        private static string DELETE = "DELETE FROM DONOR WHERE Person_JMB=@Person_JMB";


        public static List<Donor> getDonor()
        {
            List<Donor> donors = new List<Donor>();

            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    donors.Add(new Donor()
                    {
                        Person_JMB = new Person()
                        {
                            JMB = reader.GetString(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Address = reader.GetString(3),
                            Contact = reader.GetString(4),
                        },
                        Gender = reader.GetString(5),
                        BloodGroup = reader.GetString(7),
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

            return donors;
        }

        public static void insertDonor(string JMB, string firstName, string lastName, string address, string contact, string gender, string bloodGroup, string userName)
        {
            DAL.PersonAccess.insertPerson(JMB, firstName, lastName, address, contact);

            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Person_JMB", JMB);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                cmd.Parameters.AddWithValue("ACCOUNT_UserName", userName);

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

        public static void updateDonor(string Person_JMB, string Gender, string BloodGroup, string UserName)
        {
            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Person_JMB", Person_JMB);
                cmd.Parameters.AddWithValue("@BloodGroup", BloodGroup);
                cmd.Parameters.AddWithValue("@ACCOUNT_UserName", UserName);

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

        public static void deleteDonor(int DonorID)
        {
            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@DonorID", DonorID);

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
            foreach (Donor donor in getDonor())
            {
                Console.WriteLine("JMB" + donor.Person_JMB);
                Console.WriteLine("Sex" +donor.Gender);
                Console.WriteLine("BloodGroup" + donor.BloodGroup);
            }
        }

        public string countDonors(string blood_group)
        {
            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            string donors = "0";

            try
            {
                string sql = "SELECT * FROM donor WHERE BloodGroup = '" + blood_group + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                donors = dt.Rows.Count.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return donors;
        }
    }
}
