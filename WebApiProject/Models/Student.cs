using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }

    }
}
