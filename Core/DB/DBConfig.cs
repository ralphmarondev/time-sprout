using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace TimeSprout.Core.DB
{
    internal class DBConfig
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


        #region DELETE_EMPTY_TABLES
        public static void DeleteEmptyTables()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    var tables = GetTables(connection);

                    foreach (DataRow row in tables.Rows)
                    {
                        var table = row["name"].ToString();
                        if (IsTableEmpty(connection, table))
                        {
                            DeleteTable(connection, table);
                        }
                    }
                }
                Console.WriteLine("Empty tables deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Deleting empty table error: {ex.Message}");
            }
        }

        private static bool IsTableEmpty(SQLiteConnection connection, string tableName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName}";

            using (var command = new SQLiteCommand(query, connection))
            {
                long count = (long)command.ExecuteScalar();

                return count == 0;
            }
        }

        private static DataTable GetTables(SQLiteConnection connection)
        {
            var tables = new DataTable();
            string query = $"SELECT name FROM sqlite_master WHERE type = 'table' AND " +
                $"name NOT LIKE 'sqlite_%';";

            using (var command = new SQLiteCommand(query, connection))
            {
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(tables);
                }
            }

            return tables;
        }

        private static void DeleteTable(SQLiteConnection connection, string tableName)
        {
            string query = $"DROP TABLE IF EXISTS {tableName}";

            using (var command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        #endregion DELETE_EMPTY_TABLES
    }
}
