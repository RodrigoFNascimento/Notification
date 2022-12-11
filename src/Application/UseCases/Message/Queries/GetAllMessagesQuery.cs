using MediatR;

namespace Application.UseCases.Message.Queries;
public class GetAllMessagesQuery : IRequest<Domain.Entities.Message>
{
}
