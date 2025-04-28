using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;

public class DataBase
{
    static string mySQLConnection = "server=127.0.0.1 ; user=root; database=floursystem; password=";

    public static int loggedOwner;
    public static int retrieveOwnerID(string username)
    {
        string query = "SELECT OwnerID FROM owner WHERE Username = @username";

        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@username", username);
        cmd.CommandTimeout = 60;
        MySqlDataReader reader;
        try
        {
            conn.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return int.Parse(reader["OwnerID"].ToString());
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            conn.Close();
        }
        return -1;
    }

    public static string GetHashedPassword(string username)
    {
        string query = "SELECT Password FROM owner WHERE Username = @username";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@username", username);
        cmd.CommandTimeout = 60;
        MySqlDataReader reader;
        try
        {
            conn.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var dbPassword = reader["Password"];
                if (dbPassword == DBNull.Value)
                    return "";

                return dbPassword.ToString();
            }
            else return "";
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
            return "";
        }
        finally
        {
            conn.Close();
        }
    }
    #region Use for logging in without hashing
    //public static bool login(string username, string password)
    //{
    //    string query = "SELECT * FROM owner WHERE Username = @username AND Password = @password";
    //    MySqlConnection conn = new MySqlConnection(mySQLConnection);
    //    MySqlCommand cmd = new MySqlCommand(query, conn);
    //    cmd.Parameters.AddWithValue("@username", username);
    //    cmd.Parameters.AddWithValue("@password", password);
    //    cmd.CommandTimeout = 60;
    //    MySqlDataReader reader;
    //    try
    //    {
    //        conn.Open();
    //        reader = cmd.ExecuteReader();
    //        if (reader.Read())
    //            return true;
    //    }
    //    catch (MySqlException ex)
    //    {
    //        MessageBox.Show(ex.Message);
    //    }
    //    finally
    //    {
    //        conn.Close();
    //    }
    //    return false;
    //}
    #endregion

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


    #region Adding Buttons Group
    public static bool AddCustomer(long cardID, string ownerName, int numberOfPeople, int totalQuantity, int price, int registration, int delivered, string renewalDate, int index)
    {
        string query = @"
        INSERT INTO customer (CustomerID, OwnerName, NumberOfPeople, TotalQuantity, Price, Registration, Delivered, RenewalDate, customerIndex, OwnerID)
        VALUES (@customerID, @ownerName, @numberOfPeople, @totalQuantity, @price, @registration, @delivered, @renewalDate, @customerIndex, @ownerID)";
        
        MySqlConnection conn = new MySqlConnection(mySQLConnection); 
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@customerID", cardID);
        cmd.Parameters.AddWithValue("@ownerName", ownerName);
        cmd.Parameters.AddWithValue("@numberOfPeople", numberOfPeople);
        cmd.Parameters.AddWithValue("@totalQuantity", totalQuantity);
        cmd.Parameters.AddWithValue("@price", price);
        cmd.Parameters.AddWithValue("@registration", registration);
        cmd.Parameters.AddWithValue("@delivered", delivered);
        cmd.Parameters.AddWithValue("@renewalDate", renewalDate);
        cmd.Parameters.AddWithValue("@ownerID", loggedOwner);
        cmd.Parameters.AddWithValue("@customerIndex", index);
        cmd.CommandTimeout = 60;

        try
        {
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
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
    public static bool addQuota(float amount, int amountPerKG, int price, string dateReceived, int ownerID)
    {
        string query =
            "INSERT INTO quota (amount, AmountPerKG, Price, DateReceived, OwnerID) " +
            "   VALUES (@amount, @amountPerKG, @price, @dateReceived, @ownerID)";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@amount", amount);
        cmd.Parameters.AddWithValue("@amountPerKG", amountPerKG);
        cmd.Parameters.AddWithValue("@price", price);
        cmd.Parameters.AddWithValue("@dateReceived", dateReceived);
        cmd.Parameters.AddWithValue("@ownerID", ownerID);
        cmd.CommandTimeout = 60;
        try
        {
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0) return true;
            else return false;

        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to add quota.");
            MessageBox.Show(ex.Message);
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
    public static bool AddOwner(string name, string username, string password)
    {
        string query = "INSERT INTO owner (Name, Username, Password) VALUES (@name, @username, @password)";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@password", password);
        cmd.CommandTimeout = 60;
        try
        {
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0) return true;
            else return false;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to add owner.");
            MessageBox.Show(ex.Message);
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
    #endregion


    #region Checking Adding Buttons Group
    public static bool CustomerExists(long cardID)
    {
        string query = "SELECT COUNT(*) FROM customer WHERE CustomerID = @customerID";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@customerID", cardID);
        cmd.CommandTimeout = 60;
        try
        {
            conn.Open();
            //int c = int.Parse((string)cmd.ExecuteScalar());
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to check customer existence.");
            MessageBox.Show(ex.Message);
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
    public static bool QuotaExists(int loggedOwner, string date)
    {
        string query = "SELECT COUNT(*) FROM quota WHERE OwnerID = @ownerID AND DateReceived = @date";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@ownerID", loggedOwner);
        cmd.Parameters.AddWithValue("@date", date);
        cmd.CommandTimeout = 60;
        try
        {
            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to check quota existence.");
            MessageBox.Show(ex.Message);
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
    public static bool OwnerExists(string username)
    {
        string query = "SELECT COUNT(*) FROM owner WHERE Username = @username";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@username", username);
        cmd.CommandTimeout = 60;
        try
        {
            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to check owner existence.");
            MessageBox.Show(ex.Message);
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
    #endregion
}

