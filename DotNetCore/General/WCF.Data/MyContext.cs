using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WCF.Data
{
    public class MyContext : DbContext
    {
        static MyContext()
        {
            var options = new DbContextOptionsBuilder<MyContext>()
                .UseInMemoryDatabase(databaseName: "Add_writes_to_database")
                .Options;
            Instance = new MyContext(options);
        }

        public MyContext (DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public static MyContext Instance { get; set; }

        public DbSet<MyTable> MyTable { get; set; }
    }

    public class MyTable
    {
        [Key]
        public long Id { get; set; }
        
       
        public string Name { get; set; }
    }
}
