using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TimeSprout.Core.DB
{
    internal static class DBExport
    {
        public static void ExportAllDataFromDatabase()
        {

            string excelPath = "..\\full_record.xlsx";

            try
            {
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string query = "SELECT name FROM sqlite_master WHERE type = 'table'";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            var tables = new DataTable();
                            adapter.Fill(tables);

                            using (var workbook = new XLWorkbook())
                            {
                                foreach (DataRow row in tables.Rows)
                                {
                                    string tableName = row["name"].ToString();
                                    string getAllDataQuery = $"SELECT * FROM {tableName}";

                                    using (var _command = new SQLiteCommand(getAllDataQuery, connection))
                                    {
                                        using (var _adapter = new SQLiteDataAdapter(_command))
                                        {
                                            DataTable _dataTable = new DataTable();
                                            _adapter.Fill(_dataTable);

                                            workbook.Worksheets.Add(_dataTable, tableName);
                                        }
                                    }
                                }
                                workbook.SaveAs(excelPath);
                            }
                        }
                    }
                }
                Console.WriteLine("All tables exported to excel successfully.");
                MessageBox.Show("All tables exported to excel successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void ExportFromDatabaseByDate(string _date)
        {
            string excelPath = $"..\\{_date}_record.xlsx";

            try
            {
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM record_{_date}";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // excel workbook
                            using (var workbook = new XLWorkbook())
                            {
                                workbook.Worksheets.Add(dataTable, "Sheet1");
                                workbook.SaveAs(excelPath);
                            }
                        }
                    }
                    var message = $"Data on '{_date}' exported to excel successfully.";
                    Console.WriteLine(message);
                    MessageBox.Show(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // HACK: THIS CAN BE USED IN EXPORTING EMPLOYEES AND USERS
        public static void ExportFromDatabaseByTable(string _tableName)
        {
            string excelPath = $"..\\{_tableName}_record.xlsx";

            try
            {
                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM {_tableName}";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // excel workbook
                            using (var workbook = new XLWorkbook())
                            {
                                workbook.Worksheets.Add(dataTable, "Sheet1");
                                workbook.SaveAs(excelPath);
                            }
                        }
                    }
                    var message = $"Data from '{_tableName}' exported to excel successfully.";
                    Console.WriteLine(message);
                    MessageBox.Show(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
