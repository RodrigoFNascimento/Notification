using Domain.Entities;

namespace Application.Repositories;
public interface IMessageRepository
{
    Task<IEnumerable<Message>> GetMessagesAsync();
}
