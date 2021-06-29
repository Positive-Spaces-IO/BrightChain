namespace BrightChain.Interfaces
{
    public interface IApplicationWriteDbConnection : IApplicationReadDbConnection
    {
        //Task<int> ExecuteAsync(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default);
    }
}
