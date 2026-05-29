namespace EmployeeAPI_proj.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal HRA { get; set; }          // House Rent Allowance
        public decimal DA { get; set; }           // Dearness Allowance
        public decimal TaxDeduction { get; set; }
        public decimal NetSalary { get; set; }
        public DateTime EffectiveFrom { get; set; }
    }
}
