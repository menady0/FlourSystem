using MySql.Data.MySqlClient;

public class DataBase
{
    static string mySQLConnection = "server=127.0.0.1 ; user=root; database=floursystem; password=";
    public static bool login(string username, string password)
    {
        string query = "SELECT * FROM owner WHERE Username = @username AND Password = @password";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@password", password);
        cmd.CommandTimeout = 60;
        MySqlDataReader reader;
        try
        {
            conn.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
                return true;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            conn.Close();
        }
        return false;
    }


}

