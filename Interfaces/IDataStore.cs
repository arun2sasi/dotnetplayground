using System.Collections.Generic;

namespace Interfaces
{
    public interface IDataStore
    {
        IEnumerable<T> All<T>() where T : class;
        long Insert<T>(T entity) where T : class;
        bool Update<T>(T entity) where T : class;
        bool Delete<T>(T entity) where T : class;
        T Execute<T>(string query, object @params) where T : class;
        T Query<T>(string query, object @params) where T : class;
        T QueryFirst<T>(string query, object @params) where T : class;
        T QueryFirstOrDefault<T>(string query, object @params) where T : class;
        T QuerySingle<T>(string query, object @params) where T : class;
        T QuerySingleOrDefault<T>(string query, object @params) where T : class;
        T QueryMultiple<T>(string query, object @params) where T : class;
    }
}
