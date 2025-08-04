// See https://aka.ms/new-console-template for more information

using DAL.Model;
using DAL.Repository;

EventRepository eventRepository = new EventRepository();
eventRepository.GetEvents();