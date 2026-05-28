namespace EmployeeAPI_proj.DTO
{
    public class createEmpDto
    {
        public string EmpName { get; set; }
        public string Email { get; set;}
        public string Phno { get; set; }
        public string AddressId { get; set; }
        public Decimal Salary { get; set; }
        public int DepartmentID { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime createdDate { get; set; }

    }
}
