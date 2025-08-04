using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DAL.Repository
{
    public class EventRepository:IEventRepository
    {
        EventDAL context;
        public EventRepository()
        {
            context = new EventDAL();
        }

        public List<Event> GetEvents()
        {
            List<Event> events = new List<Event>();
            foreach (Event e in context.Events)
            {
                events.Add(e);
            }
            return events;
        }
        public Event GetEventById(int id)
        {
            Event e = new Event();
            try
            {
                e = context.Events.Find(id); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return e;
        }
        public void AddEvent(Event e)
        {
            try
            {
                context.Add(e);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public Event UpdateEvent(int id)
        {
            Event updatedEvent=new Event();
            //updatedEvent = context.Events.Find(id);
            if (updatedEvent == null || updatedEvent.EventId <= 0)
                throw new ArgumentException("Invalid event data.");

            var existingEvent = context.Events.Find(updatedEvent.EventId);
            if (existingEvent == null)
                throw new InvalidOperationException("Event not found.");

            existingEvent.Name = updatedEvent.Name;
            existingEvent.Date = updatedEvent.Date;
            existingEvent.Location = updatedEvent.Location;
            existingEvent.Type = updatedEvent.Type;
            existingEvent.Budget = updatedEvent.Budget;

            context.SaveChanges();
            return existingEvent;
        }
        public Event DeleteEvent(int id)
        {
            var e = context.Events.Find(id);
            if (e == null)
                throw new InvalidOperationException("Event not found.");

            context.Events.Remove(e);
            context.SaveChanges();
            return e;
        }
    }
}
