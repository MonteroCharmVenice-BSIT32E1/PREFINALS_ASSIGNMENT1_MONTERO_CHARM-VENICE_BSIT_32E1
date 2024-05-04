using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProtectedApi.Controller
    {
        [Authorize]
        [ApiController]
        [Route("api/[controller]")]
        public class ValuesController : ControllerBase
        {
            private readonly string _ownerName = "Montero Charm Venice"; 

            [HttpGet("about/me")]
            public IActionResult GetAboutMe()
            {
                var random = new Random();
                var funFacts = new List<string>
            {
                "I love cats",
                "I do love painting",
                "I play badmninton",
                "I love watching anime",
                "One Piece is my number 1 favorite anime",
                "I have 10 cats",
                "I do play online games like codm, ml, farlight",
                "I love watching horror movies",
                "I'm 20 y/o",
                "Currently taking BSIT",
                // Add more fun facts here
            };

                // Randomly select a fun fact
                var randomFunFact = funFacts[random.Next(funFacts.Count)];

                return Ok(new { FunFact = randomFunFact });
            }

            [HttpGet("about")]
            public IActionResult GetOwnerName()
            {
                return Ok(new { Name = _ownerName });
            }

            [HttpPost("about")]
            public IActionResult PostName([FromBody] NameRequest nameRequest)
            {
                if (string.IsNullOrWhiteSpace(nameRequest?.Name))
                    return BadRequest("Name cannot be empty");

                var greeting = $"Hi {nameRequest.Name} from {_ownerName}";
                return Ok(new { Greeting = greeting });
            }
        }

        public class NameRequest
        {
            public string Name { get; set; }
        }
    }
