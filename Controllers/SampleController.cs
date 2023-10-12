using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        public void  Getmethod()
        {
            Console.WriteLine("It is a get method");
        }
    }
}
