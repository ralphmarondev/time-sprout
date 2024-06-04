using System;
using System.Data.SQLite;

namespace TimeSprout.Core.DB
{
    internal class DBTimeRecord
    {
        public static void InitializeTimeRecordTable()
        {
            // create new table ex: record_20240604
            // insert: id, empName, currentProject, am-in, am-out, pm-in, pm-out, ot-in, ot-out
            var currentDate = "20240604";
            var tableName = $"record_{currentDate}";
            try
            {
                Console.WriteLine("Initializing time-record table...");

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string createTimeRecordTableQuery = $@"CREATE TABLE IF NOT EXISTS {tableName} (id TEXT NOT NULL, name TEXT NOT NULL, currentProject TEXT NOT NULL, amIn TEXT NOT NULL, amOut TEXT NOT NULL, 
                            pmIn TEXT NOT NULL, pmOut TEXT NOT NULL, otIn TEXT NOT NULL, otOut TEXT NOT NULL); ";
                    using (var command = new SQLiteCommand(createTimeRecordTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine($"Table '{tableName}' initialized successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void CreateTimeRecord(string id, string name, string currentProject, string amIn, string amOut, string pmIn, string pmOut, string otIn, string otOut)
        {
            try
            {
                InitializeTimeRecordTable();

                Console.WriteLine("Creating new time record...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string createTimeRecordQuery = @"INSERT INTO";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
