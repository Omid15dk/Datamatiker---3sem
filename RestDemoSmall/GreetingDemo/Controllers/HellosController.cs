using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreetingDemo.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class HellosController : ControllerBase {

        [HttpGet]
        public ActionResult<string> Index() {
            return Ok("Simple");
        }

        [HttpGet]
        [Route("{name}")]
        public ActionResult<string> Get(string name) {
            return Ok($"Hello {name}");
        }

        [HttpGet]
        [Route("{name}/{times:int}")]
        public ActionResult<string> Get(string name, int times) {
            string returnStr = $"Hello {name} * {times}";
            return Ok(returnStr);
        }

        [HttpGet]
        [Route("{name}/{nickname}")]
        public ActionResult<string> Get(string name, string nickname) {
            string returnStr = $"Hello {name} aka {nickname}";
            return Ok(returnStr);
        }

        [HttpPost]
        public void PostSomething([FromBody] string inVal) { }

    }
}
