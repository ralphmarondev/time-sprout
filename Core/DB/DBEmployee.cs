using System;
using System.Collections.Generic;
using System.Data.SQLite;
using TimeSprout.Core.Model;

namespace TimeSprout.Core.DB
{
    internal static class DBEmployee
    {
        private static void InitializeEmployeeTable()
        {
            try
            {
                Console.WriteLine("Initializing employees table...");

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string createEmployeeTableQuery = @"CREATE TABLE IF NOT EXISTS employees(id TEXT NOT NULL, name TEXT NOT NULL, password TEXT NOT NULL, currentProject TEXT NOT NULL);";
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

        public static void CreateNewEmployee(EmployeeModel employee)
        {
            try
            {
                InitializeEmployeeTable();

                Console.WriteLine("Creating new employee...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string insertNewEmployeeQuery = "INSERT INTO employees (id, name, password, currentProject) VALUES (@id, @name, @password, @currentProject);";
                    using (var command = new SQLiteCommand(insertNewEmployeeQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", employee.id);
                        command.Parameters.AddWithValue("@name", employee.name);
                        command.Parameters.AddWithValue("@password", employee.password);
                        command.Parameters.AddWithValue("@currentProject", employee.currentProject);
                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine($"Employee [{employee.id}] with values: name: '{employee.name}', password: '{employee.password}', currentProject: '{employee.currentProject}' was added to database successfully.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void UpdateEmployeeDetails(EmployeeModel employee)
        {
            try
            {
                InitializeEmployeeTable();

                Console.WriteLine("Updating employee...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string updateEmployeeQuery = "UPDATE employees SET name = @name, password = @password, currentProject = @currentProject WHERE id = @id";
                    using (var command = new SQLiteCommand(updateEmployeeQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", employee.id);
                        command.Parameters.AddWithValue("@name", employee.name);
                        command.Parameters.AddWithValue("@password", employee.password);
                        command.Parameters.AddWithValue("@currentProject", employee.currentProject);

                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine($"Employee ['{employee.id}'] updated information to [name: '{employee.name}', password: '{employee.password}', currentProject: '{employee.currentProject}'] succesfully.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void DeleteEmployeeDetails(string _id)
        {
            try
            {
                InitializeEmployeeTable();

                Console.WriteLine("Deleting employee from database...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string deleteEmployeeQuery = "DELETE FROM employees WHERE id = @id";
                    using (var command = new SQLiteCommand(deleteEmployeeQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", _id);
                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine($"Employee [{_id}] was deleted from database successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static EmployeeModel ReadEmployeeDetails(string _id)
        {
            EmployeeModel employee = null;
            try
            {
                InitializeEmployeeTable();

                Console.WriteLine($"Fetching employee [{_id}] details...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string fetchQuery = "SELECT name, password, currentProject FROM employees WHERE @id = id";
                    using (var command = new SQLiteCommand(fetchQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", _id);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                employee = new EmployeeModel
                                {
                                    id = reader["id"].ToString(),
                                    name = reader["name"].ToString(),
                                    password = reader["password"].ToString(),
                                    currentProject = reader["currentProject"].ToString()
                                };

                                Console.WriteLine($"Employee details...");
                                Console.WriteLine($"ID: {employee.id}, name: {employee.name}, password: {employee.password}, currentProject: {employee.currentProject}");
                                return employee;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return employee;
        }

        public static List<EmployeeModel> FetchAllEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            employees.Clear();

            try
            {
                InitializeEmployeeTable();

                Console.WriteLine("Fetching all employees...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string fetchQuery = "SELECT id, name, password, currentProject FROM employees";
                    using (var command = new SQLiteCommand(fetchQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeModel employee = new EmployeeModel
                                {
                                    id = reader["id"].ToString(),
                                    name = reader["name"].ToString(),
                                    password = reader["password"].ToString(),
                                    currentProject = reader["currentProject"].ToString()
                                };
                                employees.Add(employee);
                                Console.WriteLine($"ID: {employee.id}, name: {employee.name}, password: {employee.password}, currentProject: {employee.currentProject}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return employees;
        }


        public static bool IsEmployeeExists(string _id, string _password)
        {
            try
            {
                InitializeEmployeeTable();

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM employees WHERE id = @id AND password = @password";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", _id);
                        command.Parameters.AddWithValue("@password", _password);

                        long count = (long)command.ExecuteScalar();

                        Console.WriteLine($"Employee Id taken: {count > 0}");
                        return (count > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }
        public static bool IsEmployeeIdTaken(string _id)
        {
            try
            {
                bool exists;

                InitializeEmployeeTable();

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM employees WHERE id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", _id);
                        long count = (long)command.ExecuteScalar();

                        exists = (count > 0);
                        Console.WriteLine($"Employee Id taken: {exists}");
                    }
                }
                return exists;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
