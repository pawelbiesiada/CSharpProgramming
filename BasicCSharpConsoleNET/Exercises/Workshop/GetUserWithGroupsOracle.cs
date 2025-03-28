using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class GetUserWithGroupsOracle
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
                using (var connection = new OracleConnection(connStr))
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
