using System;
using System.Collections.Generic;
using System.Data.SQLite;
using TimeSprout.Forms.TimeRecord.Model;

namespace TimeSprout.Core.DB
{
    internal class DBTimeRecord
    {
        public static void InitializeTimeRecordTable(string tableName)
        {
            // create new table ex: record_20240604
            // insert: id, empName, currentProject, am-in, am-out, pm-in, pm-out, ot-in, ot-out
            //var currentDate = "20240604";
            //var tableName = $"record_{currentDate}";
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

        public static void CreateEmployeeTimeRecord(string currentDate, string id, string name, string currentProject, string amIn, string amOut, string pmIn, string pmOut, string otIn, string otOut)
        {
            var tableName = $"record_{currentDate}";
            try
            {
                InitializeTimeRecordTable(tableName);

                Console.WriteLine("Creating new time record...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
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
                    Console.WriteLine($"Time record for '{currentDate}' created successfully.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static bool IsEmployeeRecordExists(string currentDate, string id)
        {
            bool exists = false;

            var tableName = $"record_{currentDate}";
            try
            {
                InitializeTimeRecordTable(tableName);

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string countQuery = $"SELECT COUNT(*) FROM {tableName} WHERE id = @id";
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

        public static void UpdateEmployeeTimeRecord(string currentDate, string id, string amIn, string amOut, string pmIn, string pmOut, string otIn, string otOut)
        {
            var tableName = $"record_{currentDate}";
            try
            {
                InitializeTimeRecordTable(tableName);

                Console.WriteLine($"Updating time record for: [{tableName}]...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string updateTimeRecordQuery = $@"UPDATE {tableName} set amIn = @amIn, amOut = @amOut, pmIn = @pmIn, pmOut = @pmOut, otIn = @otIn, otOut = @otOut WHERE id = @id";
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

        public static TimeRecordDataClass ReadEmployeeTimeRecord(string currentDate, string id)
        {
            try
            {
                var tableName = $"record_{currentDate}";
                bool employeeExists = false;
                TimeRecordDataClass timeRecord;

                Console.WriteLine($"Reading employee [{id}] record for [{currentDate}]...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    //string countQuery = $"SELECT COUNT(*) FROM {tableName} WHERE id = @id;";
                    //using (var command = new SQLiteCommand(countQuery, connection))
                    //{
                    //    command.Parameters.AddWithValue("@id", id);

                    //    long count = (long)command.ExecuteScalar();
                    //    employeeExists = count > 0;
                    //}

                    //if (!employeeExists)
                    //{
                    //    var employee = DBEmployee.GetEmployeeDetails(id);
                    //    // insert to time record table
                    //    CreateEmployeeTimeRecord(currentDate: currentDate, id: id, name: employee.Name,
                    //        currentProject: employee.CurrentProject, amIn: "-", amOut: "-", pmIn: "-", pmOut: "-", otIn: "-", otOut: "-");
                    //}


                    string query = $@"SELECT name, currentProject, amIn, amOut, pmIn, pmOut, otIn, otOut FROM {tableName} WHERE @id = id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        Console.WriteLine("Reading contents...");
                        using (var reader = command.ExecuteReader())
                        {
                            timeRecord = new TimeRecordDataClass
                            {
                                // ID = id,
                                // EmployeeName = reader.GetString(1),
                                // CurrentProject = reader.GetString(2),
                                // AmTimeIn = reader.GetString(3),
                                // AmTimeOut = reader.GetString(4),
                                // PmTimeIn = reader.GetString(5),
                                // PmTimeOut = reader.GetString(6),
                                // OtTimeIn = reader.GetString(7),
                                // OtTimeOut = reader.GetString(0),
                                // RecordDate = currentDate
                                ID = id,
                                EmployeeName = reader["name"].ToString(),
                                CurrentProject = reader["currentProject"].ToString(),
                                AmTimeIn = reader["amIn"].ToString(),
                                AmTimeOut = reader["amOut"].ToString(),
                                PmTimeIn = reader["pmIn"].ToString(),
                                PmTimeOut = reader["pmOut"].ToString(),
                                OtTimeIn = reader["otIn"].ToString(),
                                OtTimeOut = reader["otOut"].ToString(),
                                RecordDate = currentDate
                            };
                        }
                    }
                    Console.WriteLine($"Records. ID: {id}, name: {timeRecord.EmployeeName}, currentProject: {timeRecord.CurrentProject}, amTimeIn: {timeRecord.AmTimeIn}, amTimeout: {timeRecord.AmTimeOut}, pmTimeIn: {timeRecord.PmTimeIn}, pmTimeOut: {timeRecord.PmTimeOut}, otTimeIn: {timeRecord.OtTimeIn}, otTimeOut: {timeRecord.OtTimeOut}");
                    Console.WriteLine("Done reading.");
                }
                return timeRecord;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new TimeRecordDataClass();
            }
        }

        public static List<TimeRecordDataClass> FetchAllTimeRecords(string currentDate)
        {
            Console.WriteLine($"Reading record for: {currentDate}");
            List<TimeRecordDataClass> timeRecords = new List<TimeRecordDataClass>();
            timeRecords.Clear();

            /* TODO:
             * if table is empty, display something like: No record for today.
             */
            try
            {
                Console.WriteLine($"Reading time record for: {currentDate}");
                var tableName = $"record_{currentDate}";
                InitializeTimeRecordTable(tableName);

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string fetchQuery = $"SELECT id, name, currentProject, amIn, amOut, pmIn, pmOut, otIn, otOut FROM {tableName}";
                    using (var command = new SQLiteCommand(fetchQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TimeRecordDataClass record = new TimeRecordDataClass
                                {
                                    ID = reader["id"].ToString(),
                                    EmployeeName = reader["name"].ToString(),
                                    CurrentProject = reader["currentProject"].ToString(),
                                    AmTimeIn = reader["amIn"].ToString(),
                                    AmTimeOut = reader["amOut"].ToString(),
                                    PmTimeIn = reader["pmIn"].ToString(),
                                    PmTimeOut = reader["pmOut"].ToString(),
                                    OtTimeIn = reader["otIn"].ToString(),
                                    OtTimeOut = reader["otOut"].ToString()
                                };
                                timeRecords.Add(record);

                                // printing values we've got
                                Console.WriteLine($"id: {record.ID}, name: {record.EmployeeName}, currentProject: {record.CurrentProject}, amIn: {record.AmTimeIn}, amOut: {record.AmTimeOut}, pmIn: {record.PmTimeIn}, pmOut: {record.PmTimeOut}, otIn: {record.OtTimeIn}, otOut: {record.OtTimeOut}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return timeRecords;
        }
    }
}
