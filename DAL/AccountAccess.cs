using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connection.BLL;

namespace Connection.DAL
{
    class AccountAccess
    {
        private static string SELECT = "SELECT * FROM account";
        private static string INSERT = "INSERT INTO `account` (`UserName`, `Password`, `BackgroundStyle`) VALUES (@UserName, @Password, @BackgroundStyle)";
        
    
    public List<Account> getAccount()
        {
            List<Account> accounts = new List<Account>();

            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    accounts.Add(new Account()
                    {
                        UserName = reader.GetString(0),
                        Password = reader.GetString(1),
                        BackgroundStyle = reader.GetString(2)
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

            return accounts;
        }

        public static void insertAccount(string UserName, string Password, string BackgroundStyle)
        {
            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@BackgroundStyle", BackgroundStyle);

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
            foreach (Account accounts in getAccount())
            {
                Console.WriteLine("UserName" + accounts.UserName);
                Console.WriteLine("Password" + accounts.Password);
                Console.WriteLine("BackgroundStyle" + accounts.BackgroundStyle);
            }
        }
    }
}
