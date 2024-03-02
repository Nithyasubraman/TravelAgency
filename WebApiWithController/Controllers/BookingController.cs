using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiWithController.Models;

namespace WebApiWithController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private static List<BookingModel> bookinglist = new List<BookingModel> { };

        // GET: api/<bookingController>
        [HttpGet]
        public IEnumerable<BookingModel> Getbookinglist()
        {
            return bookinglist;
        }

        [HttpPost]
        public IActionResult Postbookinglist(BookingModel booking)
        {
            bookinglist.Add(booking);
            return Ok(booking);
        }

    }
}
