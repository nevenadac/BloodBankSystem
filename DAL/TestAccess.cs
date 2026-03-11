using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connection.BLL;

namespace Connection.DAL
{
    internal class TestAccess
    {
        private static string SELECT = @"SELECT tt.Description, t.TestResult, t.DateOfTest, d.DonationID, e.Person_JMB
                FROM `test` t
                INNER JOIN `type_of_test` tt ON tt.TypeOfTestID=t.TYPE_OF_TEST_TypeOfTestID
                INNER JOIN `donation` d ON d.DonationID=t.Donation_DonationID
                INNER JOIN `employee` e ON e.Person_JMB=t.Employee_Person_JMB";
        private static string INSERT = "INSERT INTO `test` (`TestID`, `TestResult`, `DateOfTest`, `Donation_DonationID`, `TYPE_OF_TEST_TypeOfTestID`, `EMPLOYEE_ACCOUNT_UserName`, `EMPLOYEE_PERSON_JMB`) " +
            "VALUES(@TestID, @TestResult, @DateOfTest, @Donation_DonationID, @TYPE_OF_TEST_TypeOfTestID, @EMPLOYEE_ACCOUNT_UserName, @EMPLOYEE_PERSON_JMB);";
        private static string UPDATE = "UPDATE TEST SET TestID=@TestID, TestResult=@TestResult, DateOfTest=@DateOfTest, Donation_DonationID=@Donation_DonationID, TYPE_OF_TEST_TypeOfTestID= @TYPE_OF_TEST_TypeOfTestID, EMPLOYEE_ACCOUNT_UserName=@EMPLOYEE_ACCOUNT_UserName, EMPLOYEE_PERSON_JMB=@EMPLOYEE_PERSON_JMB WHERE TestID=@TestID";

        public static List<Test> getTest()
        {
            List<Test> test = new List<Test>();

            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    test.Add(new Test()
                    {
                        TypeOfTestID = new TypeOfTest()
                        {
                            Description = reader.GetString(0),
                        },
                        TestResult = reader.GetString(1),
                        DateOfTest = reader.GetDateTime(2),
                        DonationID = new Donation
                        {
                            DonationID = reader.GetInt32(3),
                        },
                        Employee_Person_JMB = new Employee()
                        {
                            Person_JMB = new Person()
                            {
                                JMB = reader.GetString(4),
                            },
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

            return test;
        }

        public static void insertTest(int testId, DateTime date, string JMB, string userName, int donationID, string testResult, int typeID)
        {
            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@TestID", testId);
                cmd.Parameters.AddWithValue("@TestResult", testResult);
                cmd.Parameters.AddWithValue("@DateOfTest", date);
                cmd.Parameters.AddWithValue("@Donation_DonationID", donationID);
                cmd.Parameters.AddWithValue("@EMPLOYEE_PERSON_JMB", JMB);
                cmd.Parameters.AddWithValue("@EMPLOYEE_ACCOUNT_UserName", userName);
                cmd.Parameters.AddWithValue("@TYPE_OF_TEST_TypeOfTestID", typeID);

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

        public static void updateTest(int testId, DateTime date, string JMB, string userName, int donationID, string testResult, int typeID)
        {
            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@TestID", testId);
                cmd.Parameters.AddWithValue("@TestResult", testResult);
                cmd.Parameters.AddWithValue("@DateOfTest", date);
                cmd.Parameters.AddWithValue("@Donation_DonationID", donationID);
                cmd.Parameters.AddWithValue("@EMPLOYEE_PERSON_JMB", JMB);
                cmd.Parameters.AddWithValue("@EMPLOYEE_ACCOUNT_UserName", userName);
                cmd.Parameters.AddWithValue("@TYPE_OF_TEST_TypeOfTestID", typeID);

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
