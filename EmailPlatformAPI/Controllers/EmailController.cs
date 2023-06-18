using Microsoft.AspNetCore.Mvc;
using EmailPlatform.Core.Interfaces;
using EmailPlatform.Core.Entities;
using EmailPlatform.Infrastructure.Data;
using EmailPlatform.Infrastructure.Repositories;

namespace EmailPlatform.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IMailRepository _mailRepository;

        public EmailController(IMailRepository mailRepository)
        {

            _mailRepository = mailRepository;

        }

        [HttpGet]
        public async Task<IActionResult> GetMails()
        {
            var posts = await _mailRepository.GetMails();
            return Ok(posts);
        }

        [HttpPost]
        public IActionResult CreateMail(string email)
        {
            return BadRequest();
        }

        [HttpPut]
        public IActionResult EditMail(string email)
        {
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult DeleteMail(string email)
        {
            return BadRequest();
        }
    }
}
