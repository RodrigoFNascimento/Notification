using System.Data;

namespace Persistency.Persistency;
public interface IDbConnectionFactory
{
    Task<IDbConnection> CreateConnectionAsync();
}
