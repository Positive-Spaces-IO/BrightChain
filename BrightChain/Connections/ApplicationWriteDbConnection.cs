using BrightChain.Interfaces;

namespace BrightChain.Connections
{
    public class ApplicationWriteDbConnection : IApplicationWriteDbConnection
    {
        private readonly IApplicationDbContext context;
        public ApplicationWriteDbConnection(IApplicationDbContext context) => this.context = context;
        //public async Task<int> ExecuteAsync(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default) => await this.context.Connection.ExecuteAsync(sql, param, transaction);
        //public async Task<IReadOnlyList<T>> QueryAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default) => (await this.context.Connection.QueryAsync<T>(sql, param, transaction)).AsList();
        //public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default) => await this.context.Connection.QueryFirstOrDefaultAsync<T>(sql, param, transaction);
        //public async Task<T> QuerySingleAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default) => await this.context.Connection.QuerySingleAsync<T>(sql, param, transaction);
    }
}
