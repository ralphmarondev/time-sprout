using System;
using System.Data.SQLite;

namespace TimeSprout.Core.DB
{
    internal static class DBProjects
    {
        private static void InitializeProjectTable()
        {
            try
            {
                Console.WriteLine("Initializing project table...");

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string createEmployeeTableQuery = @"CREATE TABLE IF NOT EXISTS projects(id TEXT NOT NULL, name TEXT NOT NULL);";
                    using (var command = new SQLiteCommand(createEmployeeTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine("Employee table initilized successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
