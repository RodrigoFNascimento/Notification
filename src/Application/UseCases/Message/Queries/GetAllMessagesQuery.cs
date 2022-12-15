using Application.UseCases.Message.Responses;
using MediatR;

namespace Application.UseCases.Message.Queries;
public class GetAllMessagesQuery : IRequest<GetAllMessagesResponse>
{
}
