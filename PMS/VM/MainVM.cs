using PMS.Model;
using PMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PMS.VM
{
    internal class MainVM : ViewModelBase
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public MainVM()
        {
            App.Current.Properties[Constant.TimeLineFactorID] = Constant.TimeLineFactor;
            App.Current.Properties[Constant.ReferenceDateID] = Constant.ReferenceDate;

            Employees = new ObservableCollection<Employee>();

            Project projectA = new Project("projectA", new Timeline(new DateTime(2022, 1, 1), new DateTime(2022, 5, 1)), Color.FromArgb(100, 255, 0, 0));
            Project projectB = new Project("projectB", new Timeline(new DateTime(2022, 6, 1), new DateTime(2022, 9, 1)), Color.FromArgb(100, 0, 255, 0));
            Project projectC = new Project("projectC", new Timeline(new DateTime(2022, 3, 1), new DateTime(2022, 10, 1)), Color.FromArgb(100, 0, 0, 255));

            Employee employeeA = new Employee("employeeA");
            Employee employeeB = new Employee("employeeB");
            Employee employeeC = new Employee("employeeC");

            employeeA.AddBooking(projectA, new DateTime(2022, 3, 1), new DateTime(2022, 5, 1));
            employeeA.AddBooking(projectB, new DateTime(2022, 6, 1), new DateTime(2022, 8, 1));
            employeeB.AddBooking(projectB, new DateTime(2022, 7, 1), new DateTime(2022, 9, 1));
            employeeB.AddBooking(projectC, new DateTime(2022, 3, 1), new DateTime(2022, 6, 1));
            employeeC.AddBooking(projectC, new DateTime(2022, 5, 1), new DateTime(2022, 10, 1));

            AddEmployee(employeeA);
            AddEmployee(employeeB);
            AddEmployee(employeeC);
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}
