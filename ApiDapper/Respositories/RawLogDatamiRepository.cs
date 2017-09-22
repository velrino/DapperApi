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

        public List<RawLogDatami> ListarTodos()
        {
            return _db.Query<RawLogDatami>("SELECT * FROM datami.raw_log_datami LIMIT 50").Skip(0).Take(15).ToList();
        }

        public List<RawLogDatami> Obter(string campanha_id)
        {
            return _db.Query<RawLogDatami>("SELECT * FROM datami.raw_log_datami where campanha_id = '"+ campanha_id + "' LIMIT 5").ToList();
        }
    }
}