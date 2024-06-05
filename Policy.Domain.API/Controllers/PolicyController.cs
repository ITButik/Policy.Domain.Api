using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Policy.Domain.API.Model;
using Policy.Domain.API.Query;

namespace Policy.Domain.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PolicyController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public ActionResult<JMPolicy> GetPolicy(string id)
        {
            var query = new GetPolicybyIdQuery { Id = id };
            var policy = _mediator.Send(query);
            if (policy == null)
            {
                return NotFound();
            }
            return Ok(policy.Result);
        }

        [HttpPost("{id}")]
        public ActionResult<JMPolicy> UpdatePolicy(string id, JMPolicy pol)
        {
            var query = new GetPolicybyIdQuery { Id = id };

            var policy = _mediator.Send(query);
            
            if (policy == null)
            {
                return NotFound();
            }
            return Ok(policy.Result);
        }
    }
}
