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
    public static List<Dictionary<string, object>> list;
    public static List<Dictionary<string, object>> RetrieveCustomerTable()
    {
        string query = @"
            SELECT 
                c.CustomerID, 
                c.OwnerName, 
                c.NumberOfPeople, 
                c.Price, 
                c.Registration, 
                c.TotalQuantity AS remainQuantity,
                c.Delivered,
                c.customerIndex
            FROM 
                customer c
            LEFT JOIN 
                store s ON c.CustomerID = s.CustomerID
            GROUP BY 
                c.CustomerID";

        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.CommandTimeout = 60;
        MySqlDataReader reader;
        List<Dictionary<string, object>> customers = new List<Dictionary<string, object>>();

        try
        {
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Dictionary<string, object> customer = new Dictionary<string, object>
                {
                    { "CustomerID", reader["CustomerID"] },
                    { "name", reader["OwnerName"] },
                    { "numberOfPeople", reader["NumberOfPeople"] },
                    { "remainQuantity", reader["remainQuantity"] },
                    { "price", reader["Price"] },
                    { "registration", reader["Registration"] },
                    { "delivered", reader["Delivered"] },
                    { "index", reader["customerIndex"] }
                };
                customers.Add(customer);
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Connection Failed");
            MessageBox.Show(ex.Message);
        }
        finally
        {
            conn.Close();
        }

        return customers;
    }

    public static bool AddCustomer(string ownerName, int numberOfPeople, int price, string registration, int totalQuantity, int delivered, int customerIndex)
    {
        string query = @"
        INSERT INTO customer (OwnerName, NumberOfPeople, Price, Registration, TotalQuantity, Delivered, customerIndex)
        VALUES (@ownerName, @numberOfPeople, @price, @registration, @totalQuantity, @delivered, @customerIndex)";

        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@ownerName", ownerName);
        cmd.Parameters.AddWithValue("@numberOfPeople", numberOfPeople);
        cmd.Parameters.AddWithValue("@price", price);
        cmd.Parameters.AddWithValue("@registration", registration);
        cmd.Parameters.AddWithValue("@totalQuantity", totalQuantity);
        cmd.Parameters.AddWithValue("@delivered", delivered);
        cmd.Parameters.AddWithValue("@customerIndex", customerIndex);
        cmd.CommandTimeout = 60;

        try
        {
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0; // Return true if the insertion was successful
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to add customer.");
            MessageBox.Show(ex.Message);
            return false;
        }
        finally
        {
            conn.Close();
        }
    }

}

