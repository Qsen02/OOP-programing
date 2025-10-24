using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class ContractEmployee: BaseEmployee
    {
        public string employeeTask { get; set; }
        public string employeeDepartment { get; set; }
        public ContractEmployee(string id, string name, string address, string task, string department)
           : base(id, name, address)
        {
            this.employeeTask = task;
            this.employeeDepartment = department;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Task: {employeeTask}\nDepartment: {employeeDepartment}");
        }
        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20;
        }
        public override string GetDepartment()
        {
            return employeeDepartment;
        }
    }
}
