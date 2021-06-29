using BrightChain.Interfaces;
using System;

namespace BrightChain.Connections
{
    public class ApplicationReadDbConnection : IApplicationReadDbConnection, IDisposable
    {
        private readonly IApplicationDbContext context;
        public ApplicationReadDbConnection(IApplicationDbContext context) => this.context = context;

        //public async Task<IReadOnlyList<T>> QueryAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default) => (await this.dbContext.Connection.QueryAsync<T>(sql, param, transaction)).AsList();
        //public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default) => await this.connection.QueryFirstOrDefaultAsync<T>(sql, param, transaction);
        //public async Task<T> QuerySingleAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default) => await this.connection.QuerySingleAsync<T>(sql, param, transaction);
        public void Dispose() { }
    }
}
