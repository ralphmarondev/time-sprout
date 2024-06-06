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

                    string createTimeRecordQuery = $@"INSERT INTO {tableName} (id, name, currentProject, amIn, amOut, pmIn, pmOut, otIn, otOut) VALUES 
                                (@id, @name, @currentProject, @amIn, @amOut, @pmIn, @pmOut, @otIn, @otOut)";
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

        public static TimeRecordDataClass ReadEmployeeTimeRecord(string currentDate, string id)
        {
            try
            {
                var tableName = $"record_{currentDate}";
                bool employeeExists = false;
                TimeRecordDataClass timeRecord;

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string countQuery = $"SELECT COUNT(*) FROM {tableName} WHERE id = @id;";
                    using (var command = new SQLiteCommand(countQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        long count = (long)command.ExecuteScalar();
                        employeeExists = count > 0;
                    }

                    if (!employeeExists)
                    {
                        var employee = DBEmployee.GetEmployeeDetails(id);
                        // insert to time record table
                        CreateEmployeeTimeRecord(currentDate: currentDate, id: id, name: employee.Name,
                            currentProject: employee.CurrentProject, amIn: "-", amOut: "-", pmIn: "-", pmOut: "-", otIn: "-", otOut: "-");
                    }


                    string query = $@"SELECT * FROM {tableName} WHERE id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (var reader = command.ExecuteReader())
                        {
                            timeRecord = new TimeRecordDataClass
                            {
                                ID = id,
                                EmployeeName = reader.GetString(1),
                                CurrentProject = reader.GetString(2),
                                AmTimeIn = reader.GetString(3),
                                AmTimeOut = reader.GetString(4),
                                PmTimeIn = reader.GetString(5),
                                PmTimeOut = reader.GetString(6),
                                OtTimeIn = reader.GetString(7),
                                OtTimeOut = reader.GetString(8),
                                RecordDate = currentDate
                            };
                        }
                    }
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

            timeRecords.Add(
                new TimeRecordDataClass(
                date: "2024-06-04",
                id: "2024-01",
                employeeName: "Ralph Maron Eda",
                currentProject: "Earth 2.0",
                amTimeIn: "8:10",
                amTimeOut: "12:00",
                pmTimeIn: "1:20",
                pmTimeOut: "6:00",
                otTimeIn: "7:30",
                otTimeOut: "10:50")
                );
            timeRecords.Add(
                new TimeRecordDataClass(
                date: "2024-06-04",
                id: "2024-02",
                employeeName: "Jackie Ferreras",
                currentProject: "Earth 2.1",
                amTimeIn: "8:00",
                amTimeOut: "12:00",
                pmTimeIn: "1:00",
                pmTimeOut: "6:00",
                otTimeIn: "7:00",
                otTimeOut: "10:00")
                );
            return timeRecords;
        }
    }
}
