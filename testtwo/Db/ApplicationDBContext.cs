using Microsoft.EntityFrameworkCore;
using testtwo.Models;

namespace testtwo.Db
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        //fghf
        public DbSet<AttendenceModel> StudentAttendenuuuuces { get; set; }

    }
}
