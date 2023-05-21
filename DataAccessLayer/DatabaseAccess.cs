using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace InteractiveMap.DataAccessLayer
{
    public class DatabaseAccess
    {
        private readonly string _connectionString;
        public DatabaseAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<MarkerInfo>> GetMarkers()
        {
            var result = new List<MarkerInfo>();
            SqlDataReader reader = null;
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(_connectionString);
                await connection.OpenAsync();
                var command = new SqlCommand("SELECT * FROM Markers", connection);
                reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    result.Add(new MarkerInfo
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Description = reader.GetString(2),
                        Latitude = reader.GetDouble(3),
                        Longitude = reader.GetDouble(4),
                        ColorNum = reader.GetInt32(5)
                    });
                }
            }
            catch (Exception e)
            {
                throw new Exception($"{e.Message}\r\n{e.StackTrace}");
            }
            finally
            {
                reader?.Close();
                connection?.Close();
                connection?.Dispose();
            }
            return result;
        }
    }
}

