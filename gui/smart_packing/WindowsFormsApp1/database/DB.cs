using Dapper;
using Newtonsoft.Json.Linq;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
                conn = null;
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

        static public bool IsRunning()
        {
            return conn != null;
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

        static public User GetUserByCardId(string cardID)
        {
            string query = "SELECT * FROM \"user\" WHERE card = @CardID";
            var users = conn.Query<User>(query, new
            {
                CardID = cardID
            }).ToList();
            if(users.Count > 0)
            {
                return users[0];
            }
            return null;
        }

        static public void AddUser(User usr)
        {
            string insertQuery = "INSERT INTO \"user\" (Name, Company, Card, Status, Role, Password) " +
                         "VALUES (@Name, @Company, @Card, @Status, @Role, @Password)";
            conn.Execute(insertQuery, usr);
        }

        static public void DeleteUserById(int id)
        {
            string query = "DELETE FROM \"user\" WHERE id = @UserId";
            conn.Execute(query, new { UserId = id });
        }

        static public void CreateLog(Log log)
        {
            string query = "INSERT INTO log (type, occurrence, userId) VALUES (@Type, @Occurrence, @UserID)";
            conn.Execute(query, log);
        }

        internal static List<Log> GetLogWithCondition(string cond)
        {
            string query = $"SELECT * FROM \"log\"";

            if (!string.IsNullOrEmpty(cond))
            {
                query += $" WHERE {cond}";
            }
            var logs = conn.Query<Log>(query).ToList();
            return logs;
        }

        internal static Log GetLatestLog(string id)
        {
            string query = $"SELECT * FROM \"log\" WHERE card='{id}' ORDER BY occurrence DESC LIMIT 1";

            
            var logs = conn.Query<Log>(query).ToList();
            if(logs.Count > 0)
            {
                return logs[0];
            }
            return null;
            
        }

        internal static List<Setting> GetAllSetting()
        {
            string query = $"SELECT * FROM \"setting\"";


            var settings = conn.Query<Setting>(query).ToList();
            if (settings.Count > 0)
            {
                return settings;
            }
            return null;
        }

        internal static void UpsertSetting(string name, string value)
        {
            // Check if the setting with the given name exists
            var existingSetting = conn.QueryFirstOrDefault<Setting>(
                "SELECT * FROM setting WHERE name = @Name",
                new { Name = name }
            );

            if (existingSetting == null)
            {
                // Insert a new record if the setting doesn't exist
                conn.Execute(
                    "INSERT INTO setting (name, value) VALUES (@Name, @Value)",
                    new { Name = name, Value = value }
                );
            }
            else
            {
                // Update the existing record if the setting already exists
                conn.Execute(
                    "UPDATE setting SET value = @Value WHERE name = @Name",
                    new { Name = name, Value = value }
                );
            }
        }

        internal static int GetTotalCheckToday(string type)
        {
            string query = "SELECT COUNT(*) FROM \"log\" WHERE type = @Type AND DATE_TRUNC('day', occurrence) = CURRENT_DATE";
            int count = conn.ExecuteScalar<int>(query, new
            {
                Type = type,
            });
            return count;
        }

        internal static Log GetLatestCheck(string type)
        {
            string query = "SELECT * FROM \"log\" WHERE type = @Type ORDER BY occurrence DESC LIMIT 1";
            var logs = conn.Query<Log>(query, new
            {
                Type = type,
            }).ToList();
            if (logs.Count > 0)
            {
                return logs[0];
            }
            return null;
        }

        internal static int GetAvaiableSlot()
        {
            string query = $"SELECT (SELECT COUNT(*) FROM \"log\" WHERE type = '{Constant.CHECKIN_STATE}') - (SELECT COUNT(*) FROM \"log\" WHERE type = '{Constant.CHECKOUT_STATE}') AS result";
            int count = conn.ExecuteScalar<int>(query);
            return Constant.MAX_PARKING_SLOT - count;
        }
    }
}
