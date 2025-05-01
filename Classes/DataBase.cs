using MySql.Data.MySqlClient;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using System.Net.NetworkInformation;

public class DataBase
{
    static string mySQLConnection = "server=127.0.0.1 ; user=root; database=floursystem; password=";

    #region Login Form
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
    #endregion


    #region Dashboard Form
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
    public static int CustomerExists(long cardID)
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
            return count;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to check customer existence.");
            MessageBox.Show(ex.Message);
            return -1;
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

    #region Home UserControl
    public static List<Dictionary<string, object>> CustomersList = new List<Dictionary<string, object>>();
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
                c.CustomerID
            ORDER BY
                c.customerIndex";

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
    public static void UpdateCustomerIndex(object customerId, int newIndex)
    {
        string query = "UPDATE customer SET customerIndex = @newIndex WHERE CustomerID = @customerId";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@newIndex", newIndex);
        cmd.Parameters.AddWithValue("@customerId", customerId);
        cmd.CommandTimeout = 60;
        try
        {
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to update customer index.");
            MessageBox.Show(ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }
    public static void Registration(Dictionary<string, object> customer, int? required, int? delievered, int? paid, string dateOperation)
    {
        string updateCustomerQuery = @"
            UPDATE customer 
            SET 
                Registration = Registration + 1, 
                TotalQuantity = TotalQuantity - @theReceivedQuantity,
                Price = Price - @paid,
                Delivered = @delievered
            WHERE 
                CustomerID = @customerID";
        string insertStoreQuery = "INSERT INTO store (DateOfOperation, MoneyPaid, theReceivedQuantity, CustomerID) VALUES (@dateOfOperation, @moneyPaid, @theReceivedQuantity, @customerID)";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand updateCustomerCmd = new MySqlCommand(updateCustomerQuery, conn);
        MySqlCommand insertStoreCmd = new MySqlCommand(insertStoreQuery, conn);

        updateCustomerCmd.Parameters.AddWithValue("@theReceivedQuantity", required);
        updateCustomerCmd.Parameters.AddWithValue("@paid", paid);
        updateCustomerCmd.Parameters.AddWithValue("@delievered", delievered);
        updateCustomerCmd.Parameters.AddWithValue("@customerID", customer["CustomerID"]);

        insertStoreCmd.Parameters.AddWithValue("@dateOfOperation", dateOperation);
        insertStoreCmd.Parameters.AddWithValue("@moneyPaid", paid);
        insertStoreCmd.Parameters.AddWithValue("@theReceivedQuantity", required);
        insertStoreCmd.Parameters.AddWithValue("@customerID", customer["CustomerID"]);

        try
        {
            conn.Open();
            int rowsAffected = updateCustomerCmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                insertStoreCmd.ExecuteNonQuery();
                MessageBox.Show("Customer record updated and store record created successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update customer record.");
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
    }
    #region Reset, Update & Delete Buttons
    public static bool ResetCustomer(int customerID, int totalQuantity, int price, string date)
    {
        string update = "UPDATE customer SET Registration = 0, Delivered = 0, TotalQuantity = @totalQuantity, Price = @price WHERE CustomerID = @customerID";
        string delete = "DELETE FROM store WHERE CustomerID = @customerID AND DATE_FORMAT(DateOfOperation, '%Y-%m') = @date";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmdUpdate = new MySqlCommand(update, conn);
        MySqlCommand cmdDelete = new MySqlCommand(delete, conn);
        cmdUpdate.Parameters.AddWithValue("@totalQuantity", totalQuantity);
        cmdUpdate.Parameters.AddWithValue("@price", price);
        cmdUpdate.Parameters.AddWithValue("@customerID", customerID);
        cmdUpdate.CommandTimeout = 60;

        cmdDelete.Parameters.AddWithValue("@customerID", customerID);
        cmdDelete.Parameters.AddWithValue("@date", date);
        cmdDelete.CommandTimeout = 60;
        try
        {
            conn.Open();
            cmdDelete.ExecuteNonQuery();
            int rowsUpdate = cmdUpdate.ExecuteNonQuery();
            if (rowsUpdate > 0)
            {
                MessageBox.Show("Customer record updated successfully.");
                return true;
            }
            else
            {
                MessageBox.Show("Failed to update customer record.");
                return false;
            }
            
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Connection Failed");
            MessageBox.Show(ex.Message);
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
    public static bool UpdateCustomer(long originalID, long cardID, string name, int members, int quantity, int price)
    {
        string query = "UPDATE customer set CustomerID = @cardId, OwnerName = @name, NumberOfPeople = @members, TotalQuantity = @total, price = @price WHERE CustomerID = @originalID";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@originalID", originalID);
        cmd.Parameters.AddWithValue("@cardId", cardID);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@members", members);
        cmd.Parameters.AddWithValue("@total", quantity);
        cmd.Parameters.AddWithValue("@price", price);
        cmd.CommandTimeout = 60;

        try
        {
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
                return true;
            else
            {
                MessageBox.Show("Failed to update!");
                return false;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Connection Failed");
            MessageBox.Show(ex.Message);
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
    public static bool DeleteCustomer(int customerId)
    {
        string query = "DELETE FROM customer WHERE CustomerID = @customerID";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@customerID", customerId);
        cmd.CommandTimeout = 60;
        try
        {
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
                return true;
            else return false;
        } 
        catch (MySqlException ex)
        {
            MessageBox.Show("Connection Failed");
            MessageBox.Show(ex.Message);
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
    #endregion
    #endregion

    #region Statistics UserControl
    public static int ReceivedQuotas(int month, int year)
    {
        string query = "SELECT COUNT(*) FROM quota WHERE MONTH(DateReceived) = @month AND YEAR(DateReceived) = @year";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@month", month);
        cmd.Parameters.AddWithValue("@year", year);
        cmd.CommandTimeout = 60;
        try
        {
            conn.Open();

            int count = 0;
            if (int.TryParse(cmd.ExecuteScalar().ToString(), out int value))
                count = value;

            return count;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to retrieve quota count.");
            MessageBox.Show(ex.Message);
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }
    public static int Cards(int month, int year)
    {
        string query = "SELECT COUNT(*) FROM store WHERE MONTH(DateOfOperation) = @month AND YEAR(DateOfOperation) = @year";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@month", month);
        cmd.Parameters.AddWithValue("@year", year);
        cmd.CommandTimeout = 60;
        try
        {
            conn.Open();

            int count = 0;
            if (int.TryParse(cmd.ExecuteScalar().ToString(), out int value))
                count = value;

            return count;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to retrieve today's card count.");
            MessageBox.Show(ex.Message);
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }
    public static int Cards(int day, int month, int year)
    {
        string query = "SELECT COUNT(*) FROM store WHERE DAY(DateOfOperation) = @day AND MONTH(DateOfOperation) = @month AND YEAR(DateOfOperation) = @year";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@day", day);
        cmd.Parameters.AddWithValue("@month", month);
        cmd.Parameters.AddWithValue("@year", year);
        cmd.CommandTimeout = 60;
        try
        {
            conn.Open();
            int count = 0;
            if (int.TryParse(cmd.ExecuteScalar().ToString(), out int value))
                count = value;

            return count;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to retrieve today's card count.");
            MessageBox.Show(ex.Message);
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }

    public static int Store(int day, int month, int year)
    {
        string query = "SELECT SUM(theReceivedQuantity) FROM store WHERE DAY(DateOfOperation) = @day AND MONTH(DateOfOperation) = @month AND YEAR(DateOfOperation) = @year";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@day", day);
        cmd.Parameters.AddWithValue("@month", month);
        cmd.Parameters.AddWithValue("@year", year);
        cmd.CommandTimeout = 60;
        try
        {
            conn.Open();

            int count = 0;
            if (int.TryParse(cmd.ExecuteScalar().ToString(), out int value))
                count = value;

            return count;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to retrieve store amount.");
            MessageBox.Show(ex.Message);
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }
    public static int balance;
    public static int Store(int month, int year)
    {
        string query = "SELECT SUM(theReceivedQuantity) FROM store WHERE MONTH(DateOfOperation) = @month AND YEAR(DateOfOperation) = @year";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@month", month);
        cmd.Parameters.AddWithValue("@year", year);
        cmd.CommandTimeout = 60;
        try
        {
            conn.Open();

            int count = 0;
            if (int.TryParse(cmd.ExecuteScalar().ToString(), out int value))
                count = value;

            return count;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to retrieve store amount.");
            MessageBox.Show(ex.Message);
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }
    public static int AmountPerKG(int month, int year)
    {
        string query = "SELECT SUM(AmountPerKG) FROM quota WHERE MONTH(DateReceived) = @month AND YEAR(DateReceived) = @year";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@month", month);
        cmd.Parameters.AddWithValue("@year", year);
        cmd.CommandTimeout = 60;
        try
        {
            conn.Open();
            int count = 0;
            if (int.TryParse(cmd.ExecuteScalar().ToString(), out int value))
                count = value;

            return count;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Failed to retrieve quota amount.");
            MessageBox.Show(ex.Message);
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }
    #endregion
    #endregion
}