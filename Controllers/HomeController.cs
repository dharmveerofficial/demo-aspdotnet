using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult empData(int id)
        {
            return new JsonResult(DtoMapping.MapPersonToNewDto(id));
        }
        [HttpGet]
        public IActionResult empsData()
        {
            return new JsonResult(DtoMapping.MapPersonsToNewDto());
        }
    }
}
