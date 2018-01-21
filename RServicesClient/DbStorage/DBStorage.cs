using Dapper;
using DataAnalyzer.DbStorage.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnalyzer.DbStorage
{
    class DBStorage
    {
        private String _connectionString;

        public DBStorage(String connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task CreateStructureAsync()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(Scripts.CREATE_TABLES);
            }
        }

        public async Task<Boolean> CheckDbStructure()
        {
            HashSet<String> expectedRecords = new HashSet<String> {
                 "__DaytaAnalyseCategories ID",
                 "__DaytaAnalyseCategories Name",
                 "__DaytaAnalyseCategories ParentId",
                 "__DaytaAnalyseScripts ID",
                 "__DaytaAnalyseScripts Name",
                 "__DaytaAnalyseScripts Script",
                 "__DaytaAnalyseScripts SqlInput",
                 "__DaytaAnalyseScripts CategoryId"
            };

            List<String> result;
        
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                result = (await connection.QueryAsync<String>(Scripts.SELECT_STRUCTURE)).ToList();
            }

            if (result.Count != expectedRecords.Count)
            {
                return false;
            }

            foreach (var item in result)
            {
                if(!expectedRecords.Contains(item))
                {
                    return false;
                }
            }

            return true;
        }


        public async Task<List<CategoryModel>> GetCategories(Int32 parentId)
        {
            String query;

            if(parentId == 0)
            {
                query = Scripts.SELECT_TOP_CATEGORIES;
            }
            else
            {
                query = Scripts.SELECT_CATEGORIES_BY_PARENT;
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                return ( await connection.QueryAsync<CategoryModel>(query, new { parentId }) ).ToList();
            }
        }

        public async Task AddCategory(Int32 parentId, String name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(Scripts.INSTER_CATEGORY, new { name, parentId });
            }
        }

        public async Task AddScript(Int32 categoryId, String name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(Scripts.INSTER_SCRIPT, new { name, categoryId });
            }
        }

        public async Task<List<ScriptModel>> GetScripts(Int32 categoryId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                return ( await connection.QueryAsync<ScriptModel>(Scripts.SELECT_SCRIPTS, new { categoryId }) ).ToList();
            }
        }

        public async Task UpdateScript(ScriptModel script)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                 await connection.ExecuteAsync(Scripts.UPDATE_SCRIPT, script);
            }
        }
    }
}
