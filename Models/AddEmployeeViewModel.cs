namespace ASPNETMVCCRUD.Models
{
    public class AddEmployeeViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Department { get; set; }
    }
}
