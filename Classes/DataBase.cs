using FlourSystem.Classes.ToastClass;
using FlourSystem.Forms.ToastMessage;
using MySql.Data.MySqlClient;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using System.Net.NetworkInformation;

public class DataBase
{
    static string mySQLConnection = "server=127.0.0.1 ; user=root; database=floursystem; password=";

    public static string? currentUsername;
    public static string? currentPassword;
    public static string RetriveName(string username)
    {
        string query = "SELECT Name FROM owner WHERE Username = @username";
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
                return reader["name"]?.ToString() ?? string.Empty;
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
        return string.Empty;
    }
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
            MessageBox.Show($"Failed to add customer: {ex.Message}");
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
    public static bool addQuota(float amount, int amountPerKG, string dateReceived, int ownerID)
    {
        string query =
            "INSERT INTO quota (amount, AmountPerKG, DateReceived, OwnerID) " +
            "   VALUES (@amount, @amountPerKG, @dateReceived, @ownerID)";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@amount", amount);
        cmd.Parameters.AddWithValue("@amountPerKG", amountPerKG);
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
            MessageBox.Show($"Failed to add quota: {ex.Message}");
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
            MessageBox.Show($"Failed to add owner: {ex.Message}");
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
            MessageBox.Show($"Failed to check customer existence: {ex.Message}");
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
            MessageBox.Show($"Failed to check quota existence: {ex.Message}");
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
            MessageBox.Show($"Failed to check owner existence: {ex.Message}");
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
            MessageBox.Show($"Connection Failed: {ex.Message}");
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
            MessageBox.Show($"Failed to update customer index: {ex.Message}");
        }
        finally
        {
            conn.Close();
        }
    }
    public static void Registration(Dictionary<string, object> customer, int? required, int? delivered, int? paid, string dateOperation)
    {
        string updateCustomerQuery = @"
            UPDATE customer 
            SET 
                Registration = Registration + 1, 
                TotalQuantity = TotalQuantity - @theReceivedQuantity,
                Price = Price - @paid,
                Delivered = Delivered - @delievered
            WHERE 
                CustomerID = @customerID";

        string insertStoreQuery = "INSERT INTO store (DateOfOperation, MoneyPaid, theReceivedQuantity, theDeliveredQuantity, CustomerID) VALUES (@dateOfOperation, @moneyPaid, @theReceivedQuantity, @theDeliveredQuantity, @customerID)";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand updateCustomerCmd = new MySqlCommand(updateCustomerQuery, conn);
        MySqlCommand insertStoreCmd = new MySqlCommand(insertStoreQuery, conn);

        updateCustomerCmd.Parameters.AddWithValue("@theReceivedQuantity", required);
        updateCustomerCmd.Parameters.AddWithValue("@paid", paid);
        updateCustomerCmd.Parameters.AddWithValue("@delievered", delivered);
        updateCustomerCmd.Parameters.AddWithValue("@customerID", customer["CustomerID"]);

        insertStoreCmd.Parameters.AddWithValue("@dateOfOperation", dateOperation);
        insertStoreCmd.Parameters.AddWithValue("@moneyPaid", paid);
        insertStoreCmd.Parameters.AddWithValue("@theReceivedQuantity", required);
        insertStoreCmd.Parameters.AddWithValue("@theDeliveredQuantity", delivered);
        insertStoreCmd.Parameters.AddWithValue("@customerID", customer["CustomerID"]);

        try
        {
            conn.Open();
            int rowsAffected = updateCustomerCmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                insertStoreCmd.ExecuteNonQuery();
                Toast.Show("تم تحديث بيانات العميل بنجاح.", ToastType.Success);
            }
            else Toast.Show("فشل في تحديث بيانات العميل.", ToastType.Error);
        }
        catch (MySqlException ex)
        {
            MessageBox.Show($"Connection Failed: {ex.Message}");
        }
        finally
        {
            conn.Close();
        }
    }
    #region Reset, Update & Delete Buttons
    public static bool ResetCustomer(long customerID, int totalQuantity, int price, string date, bool deleteStore = true)
    {
        string update = "UPDATE customer SET TotalQuantity = @totalQuantity, Price = @price, Registration = 0, Delivered = @totalQuantity WHERE CustomerID = @customerID";
        string delete = "DELETE FROM store WHERE CustomerID = @customerID AND DATE_FORMAT(DateOfOperation, '%Y-%m') = @date";

        using (MySqlConnection conn = new MySqlConnection(mySQLConnection))
        using (MySqlCommand cmdUpdate = new MySqlCommand(update, conn))
        {
            cmdUpdate.Parameters.AddWithValue("@totalQuantity", totalQuantity);
            cmdUpdate.Parameters.AddWithValue("@price", price);
            cmdUpdate.Parameters.AddWithValue("@customerID", customerID);
            cmdUpdate.CommandTimeout = 60;

            MySqlCommand? cmdDelete = null;
            if (deleteStore)
            {
                cmdDelete = new MySqlCommand(delete, conn);
                cmdDelete.Parameters.AddWithValue("@customerID", customerID);
                cmdDelete.Parameters.AddWithValue("@date", date);
                cmdDelete.CommandTimeout = 60;
            }

            try
            {
                conn.Open();

                if (deleteStore)
                    cmdDelete?.ExecuteNonQuery();

                int rowsUpdate = cmdUpdate.ExecuteNonQuery();
                return rowsUpdate > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Connection Failed: {ex.Message}");
                return false;
            }
        }
    }

    //public static bool ResetCustomer(long customerID, int totalQuantity, int price, string date)
    //{
    //    string update = "UPDATE customer SET Registration = 0, Delivered = 0, TotalQuantity = @totalQuantity, Price = @price WHERE CustomerID = @customerID";
    //    string delete = "DELETE FROM store WHERE CustomerID = @customerID AND DATE_FORMAT(DateOfOperation, '%Y-%m') = @date";
    //    MySqlConnection conn = new MySqlConnection(mySQLConnection);
    //    MySqlCommand cmdUpdate = new MySqlCommand(update, conn);
    //    MySqlCommand cmdDelete = new MySqlCommand(delete, conn);
    //    cmdUpdate.Parameters.AddWithValue("@totalQuantity", totalQuantity);
    //    cmdUpdate.Parameters.AddWithValue("@price", price);
    //    cmdUpdate.Parameters.AddWithValue("@customerID", customerID);
    //    cmdUpdate.CommandTimeout = 60;

    //    cmdDelete.Parameters.AddWithValue("@customerID", customerID);
    //    cmdDelete.Parameters.AddWithValue("@date", date);
    //    cmdDelete.CommandTimeout = 60;
    //    try
    //    {
    //        conn.Open();
    //        cmdDelete.ExecuteNonQuery();
    //        int rowsUpdate = cmdUpdate.ExecuteNonQuery();
    //        if (rowsUpdate > 0)
    //            return true;
    //        else
    //            return false;
            
    //    }
    //    catch (MySqlException ex)
    //    {
    //        MessageBox.Show($"Connection Failed: {ex.Message}");
    //        return false;
    //    }
    //    finally
    //    {
    //        conn.Close();
    //    }
    //}
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
                Toast.Show("فشل التحديث!", ToastType.Error);
                return false;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show($"Connection Failed: {ex.Message}");
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
    public static bool DeleteCustomer(long customerId)
    {
        string queryDeleteStore = @"
        DELETE FROM store 
        WHERE CustomerID = @customerID 
        AND MONTH(DateOfOperation) = @month 
        AND YEAR(DateOfOperation) = @year";

        string queryDeleteCustomer = "DELETE FROM customer WHERE CustomerID = @customerID";

        using (MySqlConnection conn = new MySqlConnection(mySQLConnection))
        using (MySqlCommand cmdDeleteStore = new MySqlCommand(queryDeleteStore, conn))
        using (MySqlCommand cmdDeleteCustomer = new MySqlCommand(queryDeleteCustomer, conn))
        {
            cmdDeleteStore.Parameters.AddWithValue("@customerID", customerId);
            cmdDeleteStore.Parameters.AddWithValue("@month", DateTime.Now.Month);
            cmdDeleteStore.Parameters.AddWithValue("@year", DateTime.Now.Year);

            cmdDeleteCustomer.Parameters.AddWithValue("@customerID", customerId);

            try
            {
                conn.Open();

                cmdDeleteStore.ExecuteNonQuery();

                int row = cmdDeleteCustomer.ExecuteNonQuery();

                return row > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Connection Failed: {ex.Message}");
                return false;
            }
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
            MessageBox.Show($"Failed to retrieve quota count: {ex.Message}");
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }
    public static int Cards(int month, int year)
    {
        string query = "SELECT COUNT(DISTINCT CustomerID)  FROM store WHERE MONTH(DateOfOperation) = @month AND YEAR(DateOfOperation) = @year";
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
            MessageBox.Show($"Failed to retrieve today's card count: {ex.Message}");
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }
    /*
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
            MessageBox.Show($"Failed to retrieve today's card count: {ex.Message}");
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }*/
    public static int flourStored;
    public static int FlourStored(int month, int year)
    {
        return AmountPerKGDelivered(month, year) - StoreDelivered(month, year);
    }
    public static int StoreDelivered(int month, int year)
    {
        int currentMonthAmount = GetStoreDeliveredQuantity(month, year);

        (int prevMonth, int prevYear) = GetPreviousMonthYear(month, year);

        int previousMonthAmount = GetStoreDeliveredQuantity(prevMonth, prevYear);

        if (previousMonthAmount > 0)
        {
            currentMonthAmount += previousMonthAmount;
        }

        return currentMonthAmount;
    }
    public static int GetStoreDeliveredQuantity(int month, int year)
    {
        string query = "SELECT SUM(theDeliveredQuantity) FROM store WHERE MONTH(DateOfOperation) = @month AND YEAR(DateOfOperation) = @year";
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
            MessageBox.Show($"Failed to retrieve store amount: {ex.Message}");
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }
    public static int AmountPerKGDelivered(int month, int year)
    {
        int currentMonthAmount = GetAmountPerKGForMonthDelivered(month, year);
        var (prevMonth, prevYear) = GetPreviousMonthYear(month, year);
        int previousMonthAmount = GetAmountPerKGForMonthDelivered(prevMonth, prevYear);

        if (previousMonthAmount > 0)
        {
            currentMonthAmount += previousMonthAmount;
        }

        return currentMonthAmount;
    }
    public static int GetAmountPerKGForMonthDelivered(int month, int year)
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
            MessageBox.Show($"Failed to retrieve quota amount: {ex.Message}");
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }

    #region Balance Calculation
    public static int balance;
    public static int Balance(int month, int year)
    {
        return AmountPerKG(month, year) - Store(month, year);
    }
    public static (int month, int year) GetPreviousMonthYear(int month, int year)
    {
        int prevMonth = (month == 1) ? 12 : month - 1;
        int prevYear = (month == 1) ? year - 1 : year;
        return (prevMonth, prevYear);
    }
    public static int Store(int month, int year)
    {
        int currentMonthAmount = GetStore(month, year);

        (int prevMonth, int prevYear) = GetPreviousMonthYear(month, year);

        int previousMonthAmount = GetStore(prevMonth, prevYear);

        if (previousMonthAmount > 0)
        {
            currentMonthAmount += previousMonthAmount;
        }

        return currentMonthAmount;
    }
    public static int GetStore(int day, int month, int year)
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
            MessageBox.Show($"Failed to retrieve store amount: {ex.Message}");
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }
    public static int GetStore(int month, int year)
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
            MessageBox.Show($"Failed to retrieve store amount: {ex.Message}");
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }
    public static int AmountPerKG(int month, int year)
    {
        int currentMonthAmount = GetAmountPerKGForMonth(month, year);
        var (prevMonth, prevYear) = GetPreviousMonthYear(month, year);
        int previousMonthAmount = GetAmountPerKGForMonth(prevMonth, prevYear);

        if (previousMonthAmount > 0)
        {
            currentMonthAmount += previousMonthAmount;
        }

        return currentMonthAmount;
    }
    public static int GetAmountPerKGForMonth(int month, int year)
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
            MessageBox.Show($"Failed to retrieve quota amount: {ex.Message}");
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }
    #endregion
    #endregion

    #region Settings UserControl
    public static void UpdateOwner(string originalUsername, string? newUsername = null, string? name = null, string? password = null)
    {
        List<string> updates = new List<string>();
        MySqlCommand cmd = new MySqlCommand();

        if (newUsername != null)
        {
            updates.Add("Username = @newUsername");
            cmd.Parameters.AddWithValue("@newUsername", newUsername);
        }

        if (name != null)
        {
            updates.Add("Name = @name");
            cmd.Parameters.AddWithValue("@name", name);
        }

        if (password != null)
        {
            updates.Add("Password = @password");
            cmd.Parameters.AddWithValue("@password", password);
        }

        string marge = string.Join(", ", updates);
        string query = $"UPDATE owner SET {marge} WHERE Username = @originalUsername";

        cmd.CommandText = query;
        cmd.Connection = new MySqlConnection(mySQLConnection);
        cmd.Parameters.AddWithValue("@originalUsername", originalUsername);
        cmd.CommandTimeout = 60;

        try
        {
            cmd.Connection.Open();
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
                Toast.Show("تم التحديث بنجاح.", ToastType.Success);
            else
                Toast.Show("فشل التحديث!", ToastType.Error);
        }
        catch (MySqlException ex)
        {
            MessageBox.Show($"Connection Failed: {ex.Message}");
        }
        finally
        {
            cmd.Connection.Close();
        }
    }
    public static bool CheckOwners()
    {
        string query = "SELECT COUNT(*) FROM owner";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.CommandTimeout = 60;

        try
        {
            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count == 1;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show($"Failed to check owners count: {ex.Message}");
            return false;
        }
        finally
        {
            conn.Close();
        }
    }

    internal static bool DeleteOwner(string? currentUsername)
    {
        string query = "DELETE FROM owner WHERE Username = @username";
        MySqlConnection conn = new MySqlConnection(mySQLConnection);
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@username", currentUsername);
        cmd.CommandTimeout = 60;

        try
        {
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
                return true;
            else
                return false;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show($"Connection Failed: {ex.Message}");
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
    #endregion
    #endregion
}