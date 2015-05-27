
namespace SingleResponsibility_After
{
    
    public class Employee
    {
        public void Insert(Employee employee)
        {
            //saves employee object
        }
        public void Update(Employee employee)
        {
            //updates employee object
        }
        
    }

    public class EmployeeExport
    {
        public byte[] ExportToPdf(long employeeId)
        {
            var pdf = new byte[1024];
            //export employee object
            return pdf;
        }
        public byte[] ExportToCsv(long employeeId)
        {
            var csv = new byte[1024];
            //export employee object
            return csv;
        }
    }
}
