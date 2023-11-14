using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1.database
{
    public class DB
    {
        static NpgsqlConnection conn = null;

        static public void Connect()
        {
            string sqlConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=Abc12345;Database=smart_parking";
            try
            {
                conn = new NpgsqlConnection(sqlConnectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to PostgreSQL. Error: " + ex.Message);
            }
            finally
            {
                // Close connection
                if (null != conn)
                {
                    conn.Close();
                }
            }
        }

        static public List<User> GetUserWithCondition(string cond)
        {
            string query = $"SELECT * FROM \"user\"";

            if(!string.IsNullOrEmpty(cond))
            {
                query += $" WHERE {cond}";
            }
            var users = conn.Query<User>(query).ToList();
            return users;
        }

        static public void AddUser(User usr)
        {
            string insertQuery = "INSERT INTO \"user\" (Name, Company, ParkingCardId, Status, Role, Plate, Password) " +
                         "VALUES (@Name, @Company, @ParkingCardId, @Status, @Role, @Plate, @Password)";
            conn.Execute(insertQuery, usr);
        }
    }
}
