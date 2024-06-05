using MediatR;
using Policy.Domain.API.Model;

namespace Policy.Domain.API.Query
{
    public class GetPolicybyIdQuery : IRequest<JMPolicy>
    {
        public string? Id { get; set; }
    }
}
