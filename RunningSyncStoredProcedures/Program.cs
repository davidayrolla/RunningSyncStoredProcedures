using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Define the connection string with the SQL Server database
        string connectionString = "Put your Connection String here";

        // Name of the stored procedure
        string storedProcedureName = "RunningProcedure";

        // Create a connection to the database
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                // Open the connection
                connection.Open();

                // Create a command to execute the stored procedure
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters if necessary
                    // command.Parameters.AddWithValue("@ParamName", paramValue);

                    Console.WriteLine("Calling the stored procedure...");

                    // Execute the stored procedure
                    command.ExecuteNonQuery();

                    Console.WriteLine("Stored procedure finished.");
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
