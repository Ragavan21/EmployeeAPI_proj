namespace EmployeeAPI_proj.Models
{
    public class LeaveRequest
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string LeaveType { get; set; }    // Sick, Casual, Earned
        public string Reason { get; set; }
        public string Status { get; set; }       // Pending, Approved, Rejected
        public DateTime AppliedOn { get; set; }
    }
}
