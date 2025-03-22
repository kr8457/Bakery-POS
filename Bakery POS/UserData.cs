using MySql.Data.MySqlClient;

internal class UserData
{
    private string connString = "server=localhost;database=mydb;user=root;password=khalid;";

    public List<User> GetAllUsers()
    {
        List<User> userList = new List<User>();

        using (MySqlConnection connect = new MySqlConnection(connString))
        {
            connect.Open();
            string query = "SELECT UserID, Username, Password, Role, Status, Date FROM users";

            using (MySqlCommand cmd = new MySqlCommand(query, connect))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User
                        {
                            UserID = reader.GetInt32("UserID"),
                            Username = reader.IsDBNull(reader.GetOrdinal("Username")) ? "N/A" : reader.GetString("Username"),
                            Password = reader.IsDBNull(reader.GetOrdinal("Password")) ? "N/A" : reader.GetString("Password"),
                            Role = reader.IsDBNull(reader.GetOrdinal("Role")) ? "N/A" : reader.GetString("Role"),
                            Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? "Inactive" : reader.GetString("Status"),
                            Date = reader.IsDBNull(reader.GetOrdinal("Date")) ? DateTime.MinValue : reader.GetDateTime("Date")
                        };
                        userList.Add(user);
                    }
                }
            }
        }

        return userList;
    }
}


public class User
{
    public int UserID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; } // Added Password property
    public string Role { get; set; }
    public string Status { get; set; }
    public DateTime Date { get; set; }
}
