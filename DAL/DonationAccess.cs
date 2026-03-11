using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connection.BLL;

namespace Connection.DAL
{
    internal class DonationAccess
    {
        private static string SELECT = "SELECT do.PintOfBlood, do.DateOfDonation, don.ACCOUNT_UserName, don.PERSON_JMB " +
            "FROM `donation` do INNER JOIN `donor` don ON do.DONOR_ACCOUNT_UserName = don.ACCOUNT_UserName " +
            "INNER JOIN `delivery` d ON do.DELIVERY_DeliveryID=d.DeliveryID;";
        private static string INSERT = "INSERT INTO `donation` (`DonationID`, `PintOfBlood`, `DateOfDonation`, `DELIVERY_DeliveryID`, `DONOR_ACCOUNT_UserName`, `DONOR_PERSON_JMB`) " +
            "VALUES(@DonationID, @PintOfBlood, @DateOfDonation, @DELIVERY_DeliveryID, @DONOR_ACCOUNT_UserName, @DONOR_PERSON_JMB);";
        private static string UPDATE = "UPDATE DONATION SET DonationID=@DonationID, PintOfBlood=@PintOfBlood, DateOfDonation=@DateOfDonation, DELIVERY_DeliveryID=@DELIVERY_DeliveryID, DONOR_ACCOUNT_UserName=@DONOR_ACCOUNT_UserName, DONOR_PERSON_JMB=@DONOR_PERSON_JMB WHERE DonationID=@DonationID";



        public static List<Donation> getDonation()
        {
            List<Donation> donations = new List<Donation>();

            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    donations.Add(new Donation()
                    {
                        PintOfBlood=reader.GetDecimal(0),
                        DateOfDonation=reader.GetDateTime(1),
                        Donor_Account_UserName = new Donor()
                        {
                            Account_UserName = new Account
                            {
                                UserName=reader.GetString(2),
                            }
                        },
                        Donor_Person_JMB = new Donor()
                        {
                            Person_JMB=new Person()
                            {
                                JMB=reader.GetString(3),
                            }
                        },
                        
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

            return donations;
        }

        public static void insertDonation(int id, decimal quantity, DateTime date, int DeliveryID, string DonorJMB, string DonorUsername)
        {
            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@DonationID", id);
                cmd.Parameters.AddWithValue("@PintOfBlood", quantity);
                cmd.Parameters.AddWithValue("@DateOfDonation", date);
                cmd.Parameters.AddWithValue("@DELIVERY_DeliveryID", DeliveryID);
                cmd.Parameters.AddWithValue("@DONOR_PERSON_JMB", DonorJMB);
                cmd.Parameters.AddWithValue("@DONOR_ACCOUNT_UserName", DonorUsername);

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

        public static void updateDonation(int id, decimal quantity, DateTime date, int DeliveryID, string DonorJMB, string DonorUsername)
        {
            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@DonationID", id);
                cmd.Parameters.AddWithValue("@PintOfBlood", quantity);
                cmd.Parameters.AddWithValue("@DateOfDonation", date);
                cmd.Parameters.AddWithValue("@DELIVERY_DeliveryID", DeliveryID);
                cmd.Parameters.AddWithValue("@DONOR_PERSON_JMB", DonorJMB);
                cmd.Parameters.AddWithValue("@DONOR_ACCOUNT_UserName", DonorUsername);

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
    }
}
