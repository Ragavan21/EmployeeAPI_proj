namespace EmployeeAPI_proj.Models
{
    public class Designation
    {
        public int Id { get; set; }
        public string Title { get; set; }        // e.g. Senior Developer
        public string Level { get; set; }        // e.g. Mid, Senior, Lead
        public int DepartmentId { get; set; }
    }
}
