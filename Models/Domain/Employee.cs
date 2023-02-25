namespace ASPNETMVCCRUD.Models.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Department { get; set; }
    }
}
