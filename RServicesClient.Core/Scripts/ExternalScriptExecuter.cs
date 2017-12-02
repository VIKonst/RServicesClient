using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace RServicesClient.Core.Scripts
{
    public class ExternalScriptExecuter : IDisposable
    {
        private SqlConnection _connection;
        private SqlCommand _sqlCommand;
        private String _language;

        private const String EXEC_SP_SCRIPT =
@"execute sp_execute_external_script
        @language = @lang,
        @script = @scriptText,
        @input_data_1 = @input1
";

        public ExternalScriptExecuter(SqlConnection connection, ScriptLanguage scriptLanguage)
        {
            _connection = connection;
            _sqlCommand = _connection.CreateCommand();
            
            _language = scriptLanguage.ToString();
        }

        public String Script { get; set; }
        public String Input { get; set; }

        public Int32 TimeOut 
        {
            get => _sqlCommand.CommandTimeout;
            set => _sqlCommand.CommandTimeout = value;
        }

        private void SetComandParams()
        {
            _sqlCommand.CommandText = EXEC_SP_SCRIPT;

            _sqlCommand.Parameters.Clear();
            _sqlCommand.Parameters.AddWithValue("lang", _language);
            _sqlCommand.Parameters.AddWithValue("scriptText", Script);
            _sqlCommand.Parameters.AddWithValue("input1", Input);
        }

        public SqlDataReader ExecuteDataReader()
        {
            SetComandParams();

            return _sqlCommand.ExecuteReader();
        }

        public Task<SqlDataReader> ExecuteDataReaderAsync()
        {
            SetComandParams();

            return _sqlCommand.ExecuteReaderAsync();
        }

        public ReadOnlyCollection<Byte[]> ExecuteBinaryData()
        {
            List<Byte[]> binaryCollection = new List<Byte[]>();

            using (SqlDataReader reader = ExecuteDataReader())
            {
                while (reader.Read())
                {
                    binaryCollection.Add(reader.GetSqlBinary(0).Value);
                }
            }

            return binaryCollection.AsReadOnly();
        }

        public async Task<ReadOnlyCollection<Byte[]>> ExecuteBinaryDataAsync()
        {
            List<Byte[]> binaryCollection = new List<Byte[]>();

            using (SqlDataReader reader = await ExecuteDataReaderAsync().ConfigureAwait(false))
            {
                while (await reader.ReadAsync().ConfigureAwait(false))
                {
                    binaryCollection.Add(reader.GetSqlBinary(0).Value);
                }
            }

            return binaryCollection.AsReadOnly();
        }


         public static async Task<ReadOnlyCollection<Byte[]>> ExecuteBinaryDataAsync(
            String connectionString,
            String inputSql,
            String script,
            ScriptLanguage language,
            Int32 timeOut = 30
         )
            {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                ExternalScriptExecuter scriptExecuter = new ExternalScriptExecuter(connection, ScriptLanguage.R)
                {
                    Script = script,
                    Input = inputSql,
                    TimeOut = timeOut
                };

                return await scriptExecuter.ExecuteBinaryDataAsync();
            }
        }

        public void Dispose()
        {
            _sqlCommand.Dispose();
        }
    }
}
