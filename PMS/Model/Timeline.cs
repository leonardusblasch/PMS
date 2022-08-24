using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Model
{
    internal class Timeline
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public TimeSpan Reference { get { return Start - DateTime.Parse((string)(App.Current.Properties[Constant.ReferenceDateID] ?? Constant.ReferenceDate)); } }
        public TimeSpan Duration { get { return (End - Start); } }
        public Timeline(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }
    }
}
