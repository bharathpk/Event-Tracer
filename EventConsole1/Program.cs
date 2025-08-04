// See https://aka.ms/new-console-template for more information
using DAL.Model;
using DAL.Repository;

var e = new Event
{
    Name = "Sample Event",
    Date = DateTime.Now,
    Location = "Sample Location",
    Type = "Sample Type",
    Budget = 1000
};

