using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Model
{
    internal class Employee
    {
        public string Name { get; set; }
        public List<Booking> Bookings { get; set; }
        public Employee(string name)
        {
            Name = name;
            Bookings = new List<Booking>();
        }
        public void AddBooking(Project project, DateTime start, DateTime end)
        {
            Bookings.Add(new Booking(project, new Timeline(start, end)));
        }
    }
}
