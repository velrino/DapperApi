using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiDapper.Models;
using ApiDapper.Respositories.Interfaces;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace ApiDapper.Respositories
{
    public class RawLogDatamiRepository : IRawLogDatamiRepository
    {
        //private IDbConnection _db = new Npgsql.NpgsqlConnection(ConfigurationManager.ConnectionStrings["PostgresSQLMUV"].ConnectionString);

        private IDbConnection _db;

        public RawLogDatamiRepository()
        {
            _db = new Npgsql.NpgsqlConnection(ConfigurationManager.ConnectionStrings["PostgresSQLMUV"].ConnectionString);
        }

        public List<dynamic> ListarTodos(int page = 1)
        {
            var teste = _db.Query("SELECT * FROM datami.cliente", page, 3).ToList();
            return teste;
        }

        public List<RawLogDatami> Obter(string campanha_id)
        {
            return _db.Query<RawLogDatami>("SELECT * FROM datami.raw_log_datami where campanha_id = '"+ campanha_id + "' LIMIT 5").ToList();
        }
    }

    public static class DbConnectionExtensions
    {
        public static IEnumerable<dynamic> Query(this IDbConnection cnn, string sql, int page, int limit, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return cnn.Query<dynamic>(string.Format(@"{0} OFFSET {1} LIMIT {2}", sql, (page - 1) * limit, limit), param, transaction, buffered, commandTimeout, commandType);
        }
    }
}