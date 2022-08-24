using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PMS.Model
{
    internal class Project
    {
        public string Name { get; set; }
        public Timeline Timeline { get; set; }
        public SolidColorBrush Color { get; set; }
        public Project(string name, Timeline timeline, Color color)
        {
            Name = name;
            Timeline = timeline;
            Color = new SolidColorBrush(color);

        }
    }
}
