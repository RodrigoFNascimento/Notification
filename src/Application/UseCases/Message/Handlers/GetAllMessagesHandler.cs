using Application.Repositories;
using Application.UseCases.Message.Queries;
using Application.UseCases.Message.Responses;
using MediatR;

namespace Application.UseCases.Message.Handlers;
public class GetAllMessagesHandler : IRequestHandler<GetAllMessagesQuery, Domain.Entities.Message>
{
    private readonly IMessageRepository _mensagemRepository;

    public GetAllMessagesHandler(IMessageRepository mensagemRepository)
    {
        _mensagemRepository = mensagemRepository;
    }

    public async Task<Domain.Entities.Message> Handle(GetAllMessagesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
