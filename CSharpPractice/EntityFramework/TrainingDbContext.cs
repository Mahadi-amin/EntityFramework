using Microsoft.EntityFrameworkCore;


namespace EntityFramework
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString;
        public TrainingDbContext()
        {
            //DESKTOP - N8A2ENF\SQLEXPRESS
            _connectionString = "Server=DESKTOP-N8A2ENF\\SQLEXPRESS;Database=CSharpB15;User Id=csharpb15;Password=12345; Trust Server Certificate = True;";        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
                optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
