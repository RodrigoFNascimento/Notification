using Application.Repositories;
using Application.UseCases.Message.Queries;
using Application.UseCases.Message.Responses;
using MediatR;

namespace Application.UseCases.Message.Handlers;
public class GetAllMessagesHandler : IRequestHandler<GetAllMessagesQuery, GetAllMessagesResponse>
{
    private readonly IMessageRepository _messageRepository;

    public GetAllMessagesHandler(IMessageRepository messageRepository)
    {
        _messageRepository = messageRepository;
    }

    public async Task<GetAllMessagesResponse> Handle(GetAllMessagesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
