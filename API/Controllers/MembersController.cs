using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class MembersController(ApiDbContext context) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AppUser>>> Get()
        {
            return await context.Users.ToListAsync();
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<AppUser>> GetById([FromRoute]Guid id)
        {
            var member = await context.Users.SingleOrDefaultAsync(p=>p.Id == id);
            if(member == null) return NotFound();
            return member;
        }
    }
}
