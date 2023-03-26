using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Application.Client;
using Task_Application.Dto;
using Task_Application.Product;

namespace Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientApi : ControllerBase
    {
        [HttpPost]
        public Boolean register([FromForm] ClientDto request)
        {
            var result = Clientregister.addregister(request);
            return result;
        }
        [HttpDelete]
        public Boolean DeleteClient([FromBody] int Id)
        {
            var result = ClientRemove.RemoveClient(Id);
            return result;
        }
    }
}
