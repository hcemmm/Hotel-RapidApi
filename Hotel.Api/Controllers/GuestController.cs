using Hotel.BusinessLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _guestService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddService(Guest guest)
        {
            _guestService.TInsert(guest);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var values = _guestService.TGetById(id);
            _guestService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Guest guest)
        {
            _guestService.TUpdate(guest);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _guestService.TGetById(id);
            return Ok(values);
        }
    }
}
