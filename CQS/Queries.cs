using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQS
{
    class Queries
    {
        IList<Employee> GetAllEmployees(int employeeId)
        {
            return new List<Employee>();
        }

        Employee Create(string name, string address, int age)
        {
            return new Employee();
        }
    }
}
