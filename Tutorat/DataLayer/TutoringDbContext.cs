using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class TutoringDbContext : DbContext
    {
        public DbSet<Tutor> tutors { get; set; }
        public DbSet<HelpedStudent> helpedStudent { get; set; }
        public DbSet<TutoringSession> tutoringSession { get; set; }
    }
}
