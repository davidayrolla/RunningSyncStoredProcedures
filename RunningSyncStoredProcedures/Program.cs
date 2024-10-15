using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Defina a string de conexão com o banco de dados SQL Server
        string connectionString = "Put your Connection String here";

        // Nome da stored procedure
        string storedProcedureName = "RunningProcedure";

        // Crie uma conexão com o banco de dados
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                // Abra a conexão
                connection.Open();

                // Crie um comando para executar a stored procedure
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Adicione parâmetros, se necessário
                    // command.Parameters.AddWithValue("@ParamName", paramValue);

                    Console.WriteLine("Calling the stored procedure...");

                    // Executar a stored procedure
                    command.ExecuteNonQuery();

                    Console.WriteLine("Stored procedure finished.");
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
