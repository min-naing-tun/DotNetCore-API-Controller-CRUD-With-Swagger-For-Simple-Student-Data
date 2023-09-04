using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student_API.Model;

namespace Student_API.Data
{
    public class Student_APIContext : DbContext
    {
        public Student_APIContext (DbContextOptions<Student_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Student_API.Model.StudentModel> StudentModel { get; set; } = default!;
    }
}
