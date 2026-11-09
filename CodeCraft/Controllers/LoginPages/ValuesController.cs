using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeCraft.Controllers.LoginPages
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public IActionResult get()
        {
            return Ok("Hello from CodeCraft api ");

           //ahmed morsi mohamed

        }
    }
}
