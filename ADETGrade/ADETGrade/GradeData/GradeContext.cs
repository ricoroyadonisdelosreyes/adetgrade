using Microsoft.EntityFrameworkCore;
using ADETGrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADETGrade.GradeData
{
    public class GradeContext : DbContext
    {
        public GradeContext(DbContextOptions<GradeContext> options) : base(options)
        {

        }
        public DbSet<ADETGrades> Grades { get; set; }




    }
}