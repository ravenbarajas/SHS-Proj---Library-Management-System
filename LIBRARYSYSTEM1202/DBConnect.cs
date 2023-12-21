using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LIBRARYSYSTEM1202
{
    class DBConnect
    {
        public SqlConnection connection;
        public DBConnect()
        {
            Initialize();
        }
        public void Initialize()
        {
            string connectionString = LIBRARYSYSTEM1202.Properties.Settings.Default.DB;
            connection = new SqlConnection(connectionString);
        }
        public bool Open()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool Close()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
