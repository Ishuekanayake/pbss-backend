namespace CompanyDetailsManagementBackend.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string? Fax { get; set; }
        public string Email { get; set; }
        public string? Web { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
