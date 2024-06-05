using System;
using System.Collections.Generic;
using System.Data.SQLite;
using TimeSprout.Forms.Employees.Model;

namespace TimeSprout.Core.DB
{
    internal class DBEmployee
    {
        public static void InitializeEmployeeTable()
        {
            try
            {
                Console.WriteLine("Initializing employee table...");

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

        public static void CreateNewEmployee(string id, string name, string password, string currentProject)
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
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@currentProject", currentProject);

                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine($"Employee [{id}] with values: name: '{name}', password: '{password}', currentProject: '{currentProject}' was added to database successfully.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void UpdateEmployee(string id, string name, string password, string currentProject)
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
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@currentProject", currentProject);

                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine($"Employee ['{id}'] updated information to [name: '{name}', password: '{password}', currentProject: '{currentProject}'] succesfully.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void DeleteEmployee(int id)
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
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine($"Employee [{id}] was deleted from database successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static List<EmployeeDataClass> FetchEmployees()
        {
            List<EmployeeDataClass> employees = new List<EmployeeDataClass>();

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
                                EmployeeDataClass employee = new EmployeeDataClass
                                {
                                    ID = reader["id"].ToString(),
                                    Name = reader["name"].ToString(),
                                    Password = reader["password"].ToString(),
                                    CurrentProject = reader["currentProject"].ToString()
                                };
                                employees.Add(employee);
                            }
                        }
                    }
                    return employees;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return employees;
            }
        }

    }
}
