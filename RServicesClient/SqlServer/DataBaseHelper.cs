using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAnalyzer.SqlServer
{
    public class DataBaseHelper
    {
        public async Task<List<String>> GteDbNamesAsync(String connectionString, CancellationToken cancellationToken)
        {
            List<String> result = new List<String>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand()) 
            {
                command.CommandText = "SELECT name FROM sys.databases";
                await connection.OpenAsync(cancellationToken).ConfigureAwait(false);

                using (SqlDataReader dataReader = await command.ExecuteReaderAsync(cancellationToken).ConfigureAwait(false))
                {                   
                    while(!cancellationToken.IsCancellationRequested && dataReader.Read())
                    {
                        result.Add(dataReader.GetString(0));
                    }
                 
                }
              
            }

            cancellationToken.ThrowIfCancellationRequested();

            return result;
        }

        internal async Task TestConnectionAsync(String connectionString, CancellationToken cancellationToken)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync(cancellationToken);
            }            
        }
    }
}
