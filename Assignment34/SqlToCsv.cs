using System;
using System.Data.SqlClient;
using System.IO;

class Program
{
    static void Main()
    {
        // Database connection string
        string connectionString = "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;";

        // Path to the output CSV file
        string csvFilePath = "employees_report.csv";

        // SQL query to fetch employee records
        string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";

        // Create a connection to the database
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Open the connection
            connection.Open();

            // Create a command to execute the query
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Execute the query and get the data reader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Write the data to a CSV file
                    WriteToCsv(reader, csvFilePath);
                }
            }
        }

        Console.WriteLine("CSV report has been generated at: " + csvFilePath);
    }

    static void WriteToCsv(SqlDataReader reader, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // Write the CSV header
            writer.WriteLine("Employee ID,Name,Department,Salary");

            // Write each record to the CSV file
            while (reader.Read())
            {
                string employeeId = reader["EmployeeID"].ToString();
                string name = reader["Name"].ToString();
                string department = reader["Department"].ToString();
                string salary = reader["Salary"].ToString();

                // Write the record as a CSV line
                writer.WriteLine($"{employeeId},{name},{department},{salary}");
            }
        }
    }
}