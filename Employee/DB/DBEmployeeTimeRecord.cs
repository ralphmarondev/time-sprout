using System;
using System.Data.SQLite;
using TimeSprout.Employee.Model;

namespace TimeSprout.Employee.DB
{
    internal static class DBEmployeeTimeRecord
    {
        private static string connectionString = "Data Source=daily.db; Version=3;";

        public static void InitializeTimeRecordTable(string tableName)
        {
            // create new table ex: record_20240604
            // insert: id, empName, currentProject, am-in, am-out, pm-in, pm-out, ot-in, ot-out
            //var currentDate = "20240604";
            //var tableName = $"record_{currentDate}";
            try
            {
                Console.WriteLine("Initializing time-record table...");

                using (var connection = new SQLiteConnection(connectionString))
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

        public static void CreateEmployeeTimeRecord(
            string tableName,
            string id,
            string name,
            string currentProject,
            string amIn,
            string amOut,
            string pmIn,
            string pmOut,
            string otIn,
            string otOut)
        {
            try
            {
                InitializeTimeRecordTable(tableName);

                Console.WriteLine("Creating new time record...");
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createTimeRecordQuery = $@"INSERT INTO {tableName} (id, name, currentProject, amIn, amOut, pmIn, pmOut, otIn, otOut) VALUES (@id, @name, @currentProject, @amIn, @amOut, @pmIn, @pmOut, @otIn, @otOut);";
                    using (var command = new SQLiteCommand(createTimeRecordQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@currentProject", currentProject);
                        command.Parameters.AddWithValue("@amIn", amIn);
                        command.Parameters.AddWithValue("@amOut", amOut);
                        command.Parameters.AddWithValue("@pmIn", pmIn);
                        command.Parameters.AddWithValue("@pmOut", pmOut);
                        command.Parameters.AddWithValue("@otIn", otIn);
                        command.Parameters.AddWithValue("@otOut", otOut);

                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine($"Time record for '{tableName}' created successfully.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static bool IsEmployeeRecordExists(string tableName, string id)
        {
            bool exists = false;

            try
            {
                InitializeTimeRecordTable(tableName);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string countQuery = $"SELECT COUNT(1) FROM {tableName} WHERE id = @id";
                    using (var command = new SQLiteCommand(countQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        long count = (long)command.ExecuteScalar();
                        exists = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return exists;
        }

        public static void UpdateEmployeeTimeRecord(
            string tableName,
            string id,
            string amIn,
            string amOut,
            string pmIn,
            string pmOut,
            string otIn,
            string otOut)
        {
            try
            {
                InitializeTimeRecordTable(tableName);

                Console.WriteLine($"Updating time record for: [{tableName}]...");
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string updateTimeRecordQuery = $@"UPDATE {tableName} 
                            set amIn = @amIn, 
                            amOut = @amOut,
                            pmIn = @pmIn, 
                            pmOut = @pmOut,
                            otIn = @otIn,
                            otOut = @otOut WHERE id = @id";
                    using (var command = new SQLiteCommand(updateTimeRecordQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@amIn", amIn);
                        command.Parameters.AddWithValue("@amOut", amOut);
                        command.Parameters.AddWithValue("@pmIn", pmIn);
                        command.Parameters.AddWithValue("@pmOut", pmOut);
                        command.Parameters.AddWithValue("@otIn", otIn);
                        command.Parameters.AddWithValue("@otOut", otOut);

                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine($"Time record for '{currentDate}' created successfully.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        public static EmployeeDataClass ReadEmployeeTimeRecord(string tableName, string _id)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT id, name, currentProject, amIn, amOut, pmIn, pmOut, otIn, otOut FROM {tableName} WHERE id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", _id);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                EmployeeDataClass employeeData = new EmployeeDataClass
                                {
                                    id = reader["id"].ToString(),
                                    name = reader["name"].ToString(),
                                    currentProject = reader["currentProject"].ToString(),
                                    amIn = reader["amIn"].ToString(),
                                    amOut = reader["amOut"].ToString(),
                                    pmIn = reader["pmIn"].ToString(),
                                    pmOut = reader["pmOut"].ToString()
                                };
                                return employeeData;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return new EmployeeDataClass();
        }

    }
}
