using Microsoft.EntityFrameworkCore;
using testtwo.Models;

namespace testtwo.Db
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        //asdadasasSD
        public DbSet<AttendenceModel> StudentAttendenuuuuces { get; set; }

    }
}
