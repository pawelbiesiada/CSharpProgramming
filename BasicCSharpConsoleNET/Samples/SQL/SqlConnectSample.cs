using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BasicCSharpConsoleNET.Samples.SQL
{
    public class ConnectionStringProvider
    {
        public string GetConnectionSting()
        {
            var connStr = string.Empty;
            try
            {
                connStr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return connStr;
        }
    }

    public class SqlConnectSample
    {
        private readonly ConnectionStringProvider _connectionStringProvider;

        public SqlConnectSample()
        {
            _connectionStringProvider = new ConnectionStringProvider();
        }

        public static void Main()
        {
            var sqlConnectionSample = new SqlConnectSample();
            sqlConnectionSample.Execute();
        }

        public void Execute()
        {
            GetRecordsWithSelect("10");
            ExecuteProcedure();
        }

        private void GetRecordsWithSelect(string id)
        {
            var connStr = _connectionStringProvider.GetConnectionSting();
            if (string.IsNullOrEmpty(connStr))
            {
                return;
            }

            try
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM  Users WHERE Id > @idPar";
                    //command.CommandText = "SELECT * FROM  Users WHERE Id > " + id;
                    // id = "10"    id="10; DROP DATABASE EFTestDb"


                    var sql = @"SELECT u.Name 'UserName', g.Name 'GroupName' FROM Users u 
                                JOIN UserGroups ug
                                    ON ug.UserId = u.Id
                                JOIN Groups g
                                    ON ug.GroupId = g.Id";

                    var isActiveParameter = command.CreateParameter();
                    isActiveParameter.DbType = DbType.Int32;
                    isActiveParameter.ParameterName = "@idPar";
                    isActiveParameter.Value = id;

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var idCol = (int)reader["Id"];
                        var nameCol = reader.GetString("Name");
                        Console.WriteLine($"{idCol} : {nameCol}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        private void ExecuteProcedure()
        {
            var connStr = _connectionStringProvider.GetConnectionSting();
            if (string.IsNullOrEmpty(connStr))
            {
                return;
            }

            try
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "pGetUsers";

                    var isActiveParameter = command.CreateParameter();
                    isActiveParameter.DbType = DbType.Boolean;
                    isActiveParameter.ParameterName = "@IsActive";
                    isActiveParameter.Value = true;

                    command.Parameters.Add(isActiveParameter);

                    var reader = command.ExecuteReader();
                    Console.WriteLine();
                    while (reader.Read())
                    {
                        var idCol = (int)reader["Id"];
                        var nameCol = (string)reader["Name"];
                        Console.WriteLine($"{idCol}\t{nameCol}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        private async Task ExecuteNonQueryAsyncProcedure()
        {
            var connStr = _connectionStringProvider.GetConnectionSting();
            if (string.IsNullOrEmpty(connStr))
            {
                return;
            }

            try
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "pDeleteUser";

                    var idPar = command.CreateParameter();
                    idPar.DbType = DbType.Int32;
                    idPar.ParameterName = "@Id";
                    idPar.Value = 1;

                    command.Parameters.Add(idPar);

                    await command.ExecuteNonQueryAsync();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
