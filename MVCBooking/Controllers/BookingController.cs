using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        private static readonly List<HotelBooking> _bookings = new();

        public IActionResult Index()
        {
            return View(_bookings);
        }

        public IActionResult Create()
        {
            HotelBooking hotelBooking = new();
            return View(hotelBooking);
        }

        public IActionResult CreateBooking(HotelBooking hotelBookingModel)
        {
            hotelBookingModel.Id = _bookings.Count + 1;
            _bookings.Add(hotelBookingModel);
            return RedirectToAction("Index");
        }
    }
}
