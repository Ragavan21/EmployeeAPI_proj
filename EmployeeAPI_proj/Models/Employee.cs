namespace EmployeeAPI_proj.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string Phno { get; set; }
        public string AddressId { get; set; }
        public Decimal Salary { get; set; }
        public int DepartmentID { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime createdDate { get; set; }
    }
}
