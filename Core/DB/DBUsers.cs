﻿using System;
using System.Data.SQLite;
using System.Windows.Forms;
using TimeSprout.Core.Model;

namespace TimeSprout.Core.DB
{
    internal static class DBUsers
    {
        private static void InitializeUsersTable()
        {
            try
            {
                Console.WriteLine("Initializing users table...");
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
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
                Console.WriteLine("Done.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed! Error: {ex.Message}");
            }
        }

        public static bool IsUserExists(string username, string password)
        {
            try
            {
                InitializeUsersTable();

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string checkUserQuery = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                    using (var command = new SQLiteCommand(checkUserQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        long userCount = (long)command.ExecuteScalar();
                        return userCount > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }


        public static void CreateNewUser(string username, string password, string fullName)
        {
            try
            {
                Console.WriteLine("Creating new user...");
                InitializeUsersTable();

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string insertUserQuery = "INSERT INTO users (username, password, fullName) VALUES (@username, @password, @fullName)";
                    using (var command = new SQLiteCommand(insertUserQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@fullName", fullName);

                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine("Done.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed! Error: {ex.Message}");
            }
        }

        public static void UpdateUser(string username, string password, string fullName)
        {
            try
            {
                Console.WriteLine("Updating user...");
                InitializeUsersTable();

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    Console.WriteLine($"UPDATE users SET password = {password}, fullName = {fullName} WHERE username = {username};");
                    string updateUserQuery = "UPDATE users SET password = @password, fullName = @fullName WHERE username = @username ";

                    using (var command = new SQLiteCommand(updateUserQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@fullName", fullName);

                        command.ExecuteNonQuery();
                    }
                }
                Console.WriteLine("Done.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void DeleteUser(string username)
        {
            long totalUserCount = 0;
            try
            {
                InitializeUsersTable();

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    // count total user. if only 1 left, send error
                    string countAllUsersQuery = "SELECT COUNT(*) FROM users";
                    using (var command = new SQLiteCommand(countAllUsersQuery, connection))
                    {
                        totalUserCount = (long)command.ExecuteScalar();
                    }

                    if (totalUserCount > 1)
                    {
                        string deleteUserQuery = "DELETE FROM users WHERE username = @username";
                        using (var command = new SQLiteCommand(deleteUserQuery, connection))
                        {
                            command.Parameters.AddWithValue("@username", username);

                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cannot delete the only user.");
                        MessageBox.Show("Cannot delete the only user.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        public static UserModel ReadUserWhereUsername(string _username)
        {
            Console.WriteLine($"Reading User where username like '{_username}'");

            UserModel userModel = null;
            try
            {
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string readUserQuery = "SELECT username, password, fullName from users WHERE username = @username;";
                    using (var command = new SQLiteCommand(readUserQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", _username);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userModel = new UserModel(
                                    _username: reader["username"].ToString(),
                                    _password: reader["password"].ToString(),
                                    _fullName: reader["fullName"].ToString()
                                    );
                            }
                        }
                    }
                }
                Console.WriteLine("Done.");
                return userModel;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed. Error: {ex.Message}");
                return userModel;
            }
        }
    }
}