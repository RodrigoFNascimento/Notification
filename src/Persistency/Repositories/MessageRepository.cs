using Application.Repositories;
using Dapper;
using Domain.Entities;
using Persistency.Persistency;

namespace Persistency.Repositories;
public class MessageRepository : IMessageRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public MessageRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<IEnumerable<Message>> GetMessagesAsync()
    {
        using var connection = await _connectionFactory.CreateConnectionAsync();
        return await connection.QueryAsync<Message>("SELECT * FROM message");
    }
}
