using Dapper.Contrib.Extensions;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class DataStore : IDataStore
    {
        private readonly string _connectionString;

        public DataStore(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<T> All<T>() where T : class
        {
            using (var connection = GetSqlConnection(_connectionString))
            {
                var result = connection.GetAll<T>();
                return result;
            }
        }

        public long Insert<T>(T entity) where T : class
        {
            using (var connection = GetSqlConnection(_connectionString))
            {
                var result = connection.Insert<T>(entity);
                return result;
            }
        }

        public bool Update<T>(T entity) where T : class
        {
            using (var connection = GetSqlConnection(_connectionString))
            {
                var result = connection.Update<T>(entity);
                return result;
            }
        }

        public bool Delete<T>(T entity) where T : class
        {
            using (var connection = GetSqlConnection(_connectionString))
            {
                var result = connection.Delete<T>(entity);
                return result;
            }
        }

        public T Execute<T>(string query, object @params) where T : class
        {
            throw new NotImplementedException();
        }

        public T Query<T>(string query, object @params) where T : class
        {
            throw new NotImplementedException();
        }

        public T QueryFirst<T>(string query, object @params) where T : class
        {
            throw new NotImplementedException();
        }

        public T QueryFirstOrDefault<T>(string query, object @params) where T : class
        {
            throw new NotImplementedException();
        }

        public T QueryMultiple<T>(string query, object @params) where T : class
        {
            throw new NotImplementedException();
        }

        public T QuerySingle<T>(string query, object @params) where T : class
        {
            throw new NotImplementedException();
        }

        public T QuerySingleOrDefault<T>(string query, object @params) where T : class
        {
            throw new NotImplementedException();
        }

        private SqlConnection GetSqlConnection(string connectionString)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
            return new SqlConnection(connectionString);
        }
    }
}
