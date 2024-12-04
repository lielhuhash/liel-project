using Microsoft.EntityFrameworkCore;
using liel_project.Model;
using System.Net.Sockets;

namespace liel_project.Data
{
    public class findingJobsContext : DbContext
    {
        public findingJobsContext(DbContextOptions<findingJobsContext> options) : base(options)
        {
        }
        public DbSet<job> jobs { get; set; }
        public DbSet<employer> employers { get; set; }
        public DbSet<user> users { get; set; }
   
    }
}
