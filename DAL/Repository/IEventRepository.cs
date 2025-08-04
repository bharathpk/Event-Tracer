using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IEventRepository
    {
        public List<Event> GetEvents();
        public Event GetEventById(int id);
        public void AddEvent(Event e);
        public Event UpdateEvent(int id);
        public Event DeleteEvent(int id);
    }
}
