using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Model
{
    internal class Booking
    {
        public Project Project { get; set; }
        public Timeline Timeline { get; set; }
        public Booking(Project project, Timeline timeline)
        {
            Project = project;
            Timeline = timeline;
        }
    }
}
