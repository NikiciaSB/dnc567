using Microsoft.EntityFrameworkCore;

namespace DNC567.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    }
}