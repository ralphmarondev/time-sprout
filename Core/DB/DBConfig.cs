using System;
using System.Data.SQLite;
using System.IO;

namespace TimeSprout.Core.DB
{
    internal static class DBConfig
    {
        public static string connectionString = "Data Source=daily.db; Version=3;";

        public static void InitializeDatabase()
        {
            try
            {
                if (!File.Exists("daily.db"))
                {
                    SQLiteConnection.CreateFile("daily.db");
                }

                // creating users table
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createUserTableQuery = @"CREATE TABLE IF NOT EXISTS users(username TEXT NOT NULL, password TEXT NOT NULL, fullName TEXT NOT NULL);";
                    using (var command = new SQLiteCommand(createUserTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // default user if len(user) == 0
                    string checkUserQuery = @"SELECT COUNT(*) FROM users";
                    using (var command = new SQLiteCommand(checkUserQuery, connection))
                    {
                        long userCount = (long)command.ExecuteScalar();

                        if (userCount == 0)
                        {
                            string insertUserQuery = @"INSERT INTO users (username, password, fullName) VALUES ('root', 'toor', 'i am root');";
                            using (var insertCommand = new SQLiteCommand(insertUserQuery, connection))
                            {
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
