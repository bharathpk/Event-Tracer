using DAL.Model;
using DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EventMVC.Controllers
{
    public class EventController : Controller
    {
        IEventRepository repo;
        public EventController()
        {
            repo = new EventRepository();
        }
        public IActionResult GetEvents()
        {
            List<Event> events = new List<Event>();
            events = repo.GetEvents();
            return View(events);
        }
        public IActionResult GetEventById()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetEventById(int id)
        {
            Event e = new Event();
            e = repo.GetEventById(id);
            return View(e);
        }
        public IActionResult AddEvent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEvent(Event e)
        {
            repo.AddEvent(e);
            return RedirectToAction("GetEvents");
        }
        public IActionResult UpdateEvent()
        {
            return View();
        }
        [HttpPut]
        public IActionResult UpdateEvent(int id)
        {
            Event e = new Event();
            e= repo.UpdateEvent(id);
            return View(e);
        }
        public IActionResult DeleteEvent()
        {
            return View();
        }
        [HttpDelete]
        public IActionResult DeleteEvent(int id)
        {
            Event e = new Event();
            e=repo.DeleteEvent(id);
            return View(e);
        }
    }
}
