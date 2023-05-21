using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace InteractiveMap.DataAccessLayer
{
    public class DbAccess
    {
        private readonly string _connectionString;
        public DbAccess(string connectionString)
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

        public async Task UpdateMarker(MarkerInfo markerInfo)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(_connectionString);
                await connection.OpenAsync();
                var command = connection.CreateCommand();

                command.CommandText = @"UPDATE Markers SET MarkerName = @MarkerName, MarkerDescription = @MarkerDescription, Latitude = @Latitude, Longitude = @Longitude, ColorNum = @ColorNum WHERE Id = @Id";
                command.Parameters.AddWithValue("@Id", markerInfo.Id);
                command.Parameters.AddWithValue("@MarkerName", markerInfo.Name);
                command.Parameters.AddWithValue("@MarkerDescription", markerInfo.Description);
                command.Parameters.AddWithValue("@Latitude", markerInfo.Latitude);
                command.Parameters.AddWithValue("@Longitude", markerInfo.Longitude);
                command.Parameters.AddWithValue("@ColorNum", markerInfo.ColorNum);

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"{e.Message}\r\n{e.StackTrace}");
            }
            finally
            {
                connection?.Close();
                connection?.Dispose();
            }
        }
    }
}

