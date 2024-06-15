using System;
using System.Collections.Generic;
using System.Data.SQLite;
using TimeSprout.Core.Model;

namespace TimeSprout.Core.DB
{
    internal static class DBTimeRecord
    {
        public static void InitializeDailyTimeRecordTable(string _tableName)
        {
            try
            {
                Console.WriteLine("Initializing time-record table...");

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string createTimeRecordTableQuery = $"CREATE TABLE IF NOT EXISTS {_tableName} (" +
                        $"id TEXT NOT NULL, " +
                        $"name TEXT NOT NULL, " +
                        $"currentProject TEXT NOT NULL, " +
                        $"amTimeIn TEXT NOT NULL, " +
                        $"amTimeOut TEXT NOT NULL, " +
                        $"pmTimeIn TEXT NOT NULL, " +
                        $"pmTimeOut TEXT NOT NULL, " +
                        $"otTimeIn TEXT NOT NULL, " +
                        $"otTimeOut TEXT NOT NULL," +
                        $"workingHour TEXT, " +
                        $"overtime TEXT" +
                        $");";
                    using (var command = new SQLiteCommand(createTimeRecordTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine($"Table '{_tableName}' initialized successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void CreateEmployeeTimeRecord(string _currentDate, TimeRecordModel _record)
        {
            var tableName = $"record_{_currentDate}";
            try
            {
                InitializeDailyTimeRecordTable(tableName);

                Console.WriteLine($"Creating new time record for {_currentDate}...");
                Console.WriteLine($"id: {_record.id}, name: {_record.employeeName}, currentProject: {_record.currentProject}");
                Console.WriteLine($"amIn: {_record.amTimeIn}, amOut: {_record.amTimeOut}, pmIn: {_record.pmTimeIn}, pmOut: {_record.pmTimeIn}, otIn: {_record.otTimeIn}, otOut: {_record.otTimeOut}");
                Console.WriteLine($"workingHour: {_record.workingHour}, overtime: {_record.overtime}");

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string createTimeRecordQuery = $"INSERT INTO {tableName} " +
                        $"(id, name, currentProject, amTimeIn, amTimeOut, pmTimeIn, pmTimeOut, otTimeIn, otTimeOut, workingHour, overtime) " +
                        $"VALUES (@id, @name, @currentProject, @amIn, @amOut, @pmIn, @pmOut, @otIn, @otOut, @workingHour, @overtime);";
                    using (var command = new SQLiteCommand(createTimeRecordQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", _record.id);
                        command.Parameters.AddWithValue("@name", _record.employeeName);
                        command.Parameters.AddWithValue("@currentProject", _record.currentProject);
                        command.Parameters.AddWithValue("@amIn", _record.amTimeIn);
                        command.Parameters.AddWithValue("@amOut", _record.amTimeOut);
                        command.Parameters.AddWithValue("@pmIn", _record.pmTimeIn);
                        command.Parameters.AddWithValue("@pmOut", _record.pmTimeOut);
                        command.Parameters.AddWithValue("@otIn", _record.otTimeIn);
                        command.Parameters.AddWithValue("@otOut", _record.otTimeOut);
                        command.Parameters.AddWithValue("@workingHour", _record.workingHour);
                        command.Parameters.AddWithValue("@overtime", _record.overtime);

                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine($"Time record for '{_currentDate}' created successfully.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void UpdateEmployeeTimeRecord(string _currentDate, TimeRecordModel _record)
        {

            var tableName = $"record_{_currentDate}";
            try
            {
                InitializeDailyTimeRecordTable(tableName);

                Console.WriteLine($"Updating time record for: [{tableName}]...");
                Console.WriteLine($"id: {_record.id}, name: {_record.employeeName}, currentProject: {_record.currentProject}");
                Console.WriteLine($"amIn: {_record.amTimeIn}, amOut: {_record.amTimeOut}, pmIn: {_record.pmTimeIn}, pmOut: {_record.pmTimeIn}, otIn: {_record.otTimeIn}, otOut: {_record.otTimeOut}");
                Console.WriteLine($"amIn: {_record.amTimeIn}, amOut: {_record.amTimeOut}, pmIn: {_record.pmTimeIn}, pmOut: {_record.pmTimeIn}, otIn: {_record.otTimeIn}, otOut: {_record.otTimeOut}");
                Console.WriteLine($"workingHour: {_record.workingHour}, overtime: {_record.overtime}");

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string updateTimeRecordQuery = $"UPDATE {tableName} SET " +
                        $"name = @name, " +
                        $"currentProject = @currentProject, " +
                        $"amTimeIn = @amIn, " +
                        $"amTimeOut = @amOut, " +
                        $"pmTimeIn = @pmIn, " +
                        $"pmTimeOut = @pmOut, " +
                        $"otTimeIn = @otIn, " +
                        $"otTimeOut = @otOut, " +
                        $"workingHour = @workingHour, " +
                        $"overtime = @overtime " +
                        $"WHERE id = @id";
                    using (var command = new SQLiteCommand(updateTimeRecordQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", _record.id);
                        command.Parameters.AddWithValue("@name", _record.employeeName);
                        command.Parameters.AddWithValue("@currentProject", _record.currentProject);
                        command.Parameters.AddWithValue("@amIn", _record.amTimeIn);
                        command.Parameters.AddWithValue("@amOut", _record.amTimeOut);
                        command.Parameters.AddWithValue("@pmIn", _record.pmTimeIn);
                        command.Parameters.AddWithValue("@pmOut", _record.pmTimeOut);
                        command.Parameters.AddWithValue("@otIn", _record.otTimeIn);
                        command.Parameters.AddWithValue("@otOut", _record.otTimeOut);
                        command.Parameters.AddWithValue("@workingHour", _record.workingHour);
                        command.Parameters.AddWithValue("@overtime", _record.overtime);

                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine($"Time record for '{_currentDate}' created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void DeleteEmployeeTimeRecord(string _currentDate, string _id)
        {
            string tableName = $"record_{_currentDate}";
            try
            {
                InitializeDailyTimeRecordTable(_tableName: tableName);

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string deleteQuery = $"DELETE FROM {tableName} WHERE id = @id";
                    using (var command = new SQLiteCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", _id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static TimeRecordModel ReadEmployeeTimeRecord(string _currentDate, string _id)
        {
            string tableName = $"record_{_currentDate}";
            try
            {
                InitializeDailyTimeRecordTable(_tableName: tableName);

                Console.WriteLine($"Reading record for {_id} on {_currentDate}...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string query = $"SELECT id, name, currentProject, " +
                        $"amTimeIn, amTimeOut, " +
                        $"pmTimeIn, pmTimeOut, " +
                        $"otTimeIn, otTimeOut, " +
                        $"workingHour, overtime " +
                        $"FROM {tableName} WHERE id = @id";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", _id);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new TimeRecordModel(

                                    _id: reader["id"].ToString(),
                                    _employeeName: reader["name"].ToString(),
                                    _currentProject: reader["currentProject"].ToString(),
                                    _amTimeIn: reader["amTimeIn"].ToString(),
                                    _amTimeOut: reader["amTimeOut"].ToString(),
                                    _pmTimeIn: reader["pmTimeIn"].ToString(),
                                    _pmTimeOut: reader["pmTimeOut"].ToString(),
                                    _otTimeIn: reader["otTimeIn"].ToString(),
                                    _otTimeOut: reader["otTimeOut"].ToString(),
                                    _workingHour: reader["workingHour"].ToString(),
                                    _overtime: reader["overtime"].ToString()
                                );
                            }
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return new TimeRecordModel();
        }

        public static List<TimeRecordModel> FetchAllEmployeeTimeRecords(string _currentDate)
        {
            List<TimeRecordModel> timeRecords = new List<TimeRecordModel>();
            timeRecords.Clear();
            string tableName = $"record_{_currentDate}";

            try
            {
                InitializeDailyTimeRecordTable(_tableName: tableName);

                Console.WriteLine($"Fetching all records for {_currentDate}...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string fetchQuery = $"SELECT id, name, currentProject, amTimeIn, amTimeOut, pmTimeIn, pmTimeOut, otTimeIn, otTimeOut, workingHour, overtime FROM {tableName}";
                    using (var command = new SQLiteCommand(fetchQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TimeRecordModel record = new TimeRecordModel
                                {
                                    id = reader["id"].ToString(),
                                    employeeName = reader["name"].ToString(),
                                    currentProject = reader["currentProject"].ToString(),
                                    amTimeIn = reader["amTimeIn"].ToString(),
                                    amTimeOut = reader["amTimeOut"].ToString(),
                                    pmTimeIn = reader["pmTimeIn"].ToString(),
                                    pmTimeOut = reader["pmTimeOut"].ToString(),
                                    otTimeIn = reader["otTimeIn"].ToString(),
                                    otTimeOut = reader["otTimeOut"].ToString(),
                                    workingHour = reader["workingHour"].ToString(),
                                    overtime = reader["overtime"].ToString()
                                };
                                Console.WriteLine($"id: {record.id}, name: {record.employeeName}, currentProject: {record.currentProject},");
                                Console.WriteLine($"amTimeIn: {record.amTimeIn}, amTimeOut: {record.amTimeOut}");
                                Console.WriteLine($"pmTimeIn: {record.pmTimeIn}, pmTimeOut: {record.pmTimeOut}");
                                Console.WriteLine($"otTimeIn: {record.otTimeIn}, otTimeOut: {record.otTimeOut}");
                                timeRecords.Add(record);
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

        public static List<TimeRecordModel> FetchAllEmployeeTimeRecordsById(string _currentDate, string _id)
        {
            List<TimeRecordModel> timeRecords = new List<TimeRecordModel>();
            timeRecords.Clear();
            string tableName = $"record_{_currentDate}";

            try
            {
                InitializeDailyTimeRecordTable(_tableName: tableName);

                Console.WriteLine($"Fetching all records for {_currentDate}...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string fetchQuery = $"SELECT id, name, currentProject, amTimeIn, amTimeOut, pmTimeIn, pmTimeOut, otTimeIn, otTimeOut, workingHour, overtime FROM {tableName} WHERE id = @id";
                    using (var command = new SQLiteCommand(fetchQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", _id);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TimeRecordModel record = new TimeRecordModel(
                                    _id: reader["id"].ToString(),
                                    _employeeName: reader["name"].ToString(),
                                    _currentProject: reader["currentProject"].ToString(),
                                    _amTimeIn: reader["amTimeIn"].ToString(),
                                    _amTimeOut: reader["amTimeOut"].ToString(),
                                    _pmTimeIn: reader["pmTimeIn"].ToString(),
                                    _pmTimeOut: reader["pmTimeOut"].ToString(),
                                    _otTimeIn: reader["otTimeIn"].ToString(),
                                    _otTimeOut: reader["otTimeOut"].ToString(),
                                    _workingHour: reader["workingHour"].ToString(),
                                    _overtime: reader["overtime"].ToString()
                                );
                                Console.WriteLine($"id: {record.id}, name: {record.employeeName}, currentProject: {record.currentProject},");
                                Console.WriteLine($"amTimeIn: {record.amTimeIn}, amTimeOut: {record.amTimeOut}");
                                Console.WriteLine($"pmTimeIn: {record.pmTimeIn}, pmTimeOut: {record.pmTimeOut}");
                                Console.WriteLine($"otTimeIn: {record.otTimeIn}, otTimeOut: {record.otTimeOut}");
                                timeRecords.Add(record);
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

        public static bool IsEmployeeTimeRecordExists(string _currentDate, string _id)
        {
            string tableName = $"record_{_currentDate}";

            try
            {
                InitializeDailyTimeRecordTable(tableName);

                Console.WriteLine($"Checking if record for: [id: {_id}] on [currentDate: {_currentDate}] exists...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string query = $"SELECT COUNT(*) FROM {tableName} WHERE id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", _id);

                        long count = (long)command.ExecuteScalar();

                        if (count > 0)
                        {
                            Console.WriteLine($"Record exists: Count: {count}");
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine("Record does not exists...");
            return false;
        }
    }
}
