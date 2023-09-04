using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Student_API.Model
{
    public class StudentModel
    {
        [Required]
        [Key]
        public int StudentId { get; set; }

        public string? StudentName { get; set; }

        public string? StudentEmail { get; set; }

        public string? StudentPhone { get; set; }

        public DateTime StudentBirthDate { get; set; }

        public string? StudentAddress { get; set; }
    }
}
