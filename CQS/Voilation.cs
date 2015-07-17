using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQS
{
    class FileStore
    {
        // which methods are Query and whcih ones are commands???
        // this class is voilating CQS principle
        public string WorkingDirectory { get; set; }
        public string Save(int id, string message)
        {
            var path = Path.Combine(this.WorkingDirectory, id + ".txt");
            File.WriteAllText(path, message);
            return path;
        }

        public event EventHandler<MessageEventArgs> MessageRead;
        public void Read(int id)
        {
            var path = Path.Combine(this.WorkingDirectory, id + ".txt");
            var msg = File.ReadAllText(path);
            this.MessageRead(this, new MessageEventArgs { Message = msg });
            
        }
    }
    class Employee
    {
        // commands mutate objects
        // save empolyee
        void Save(Employee emplyee)
        { 
        }
        
        void Send(Employee employee)
        {
            // sends a message 
        }

        // queries DO NOT mutate objects
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
