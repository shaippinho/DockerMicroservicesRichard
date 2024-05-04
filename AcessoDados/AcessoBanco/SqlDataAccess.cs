using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace AcessoDados.AcessoBanco
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> CarregarDados<T, U>(
            string consulta,
            U parameters,
            string connectionName = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionName));


            return await connection.QueryAsync<T>(consulta, parameters, commandType: CommandType.Text);
        }

        public async Task SalvarDados<T>(
            string consulta,
            T parameters,
            string connectionName = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionName));

            await connection.ExecuteAsync(consulta, parameters, commandType: CommandType.Text);
        }

    }
}
