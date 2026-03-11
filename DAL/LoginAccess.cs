using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connection.BLL;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Connection.DAL
{
    class LoginAccess
    {
        
        public bool loginCheck(Login l)
        {
            bool isSuccess = false;

            MySqlConnection conn = new MySqlConnection(Connection.Forms.Connection.connectionString);

            try
            {
                string sql = "SELECT * FROM account WHERE userName=@userName AND password=@password";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", l.userName);
                cmd.Parameters.AddWithValue("@password", l.password);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if(dt.Rows.Count>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

    }
}
