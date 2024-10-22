namespace MyApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
namespace MyApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}


