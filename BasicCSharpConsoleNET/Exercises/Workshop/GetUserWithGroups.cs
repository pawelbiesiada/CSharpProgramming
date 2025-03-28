using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class GetUserWithGroups
    {
        public List<(string, string)> GetUsersWithGroups()
        {
            var connStr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            if (string.IsNullOrEmpty(connStr))
            {
                return null;
            }
            var result = new List<(string, string)>();

            try
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = @"SELECT u.Name 'UserName', g.Name 'GroupName' FROM Users u 
                        JOIN UserGroups ug
                            ON ug.UserId = u.Id
                        JOIN Groups g
                            ON ug.GroupId = g.Id";
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var nameCol = (string)reader["UserName"];
                        var groupNameCol = (string)reader["GroupName"];

                        result.Add((nameCol, groupNameCol));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            return result;
        }
    }
}
