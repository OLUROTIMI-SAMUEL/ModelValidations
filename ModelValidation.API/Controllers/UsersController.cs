using Microsoft.AspNetCore.Mvc;
using ModelValidation.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModelValidation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //So we only use one end point becuase we are just get from the client only
        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<Users> Post([FromBody] Users user)
        {
            //Some Operation
            return Ok(user);
        }

       
    }
}
