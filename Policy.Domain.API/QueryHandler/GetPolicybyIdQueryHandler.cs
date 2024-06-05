using MediatR;
using Policy.Domain.API.Model;
using Policy.Domain.API.Query;

namespace Policy.Domain.API.QueryHandler
{
    public class GetPolicybyIdQueryHandler : IRequestHandler<GetPolicybyIdQuery, JMPolicy>
    {
        public async Task<JMPolicy> Handle(GetPolicybyIdQuery request, CancellationToken cancellationToken)
        {
            return new JMPolicy() { PolicyId = request.Id, SumInsured = "100000", PolicyHolder = "Shashi Kumar" };
        }
    }
}
