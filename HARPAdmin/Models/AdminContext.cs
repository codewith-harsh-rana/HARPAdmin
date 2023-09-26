using Microsoft.EntityFrameworkCore;

namespace HARPAdmin.Models
{
    public class AdminContext : DbContext
    {
        public AdminContext(DbContextOptions<AdminContext> options) : base(options) 
       
        {
                 
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Orderstatus> OrderStatuses { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<OrderReceivedDetail> OrderReceivedDetails { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<CompanyMaster> companyMasters { get; set; }

        public DbSet<Shipped> shippeds { get; set; }

        public DbSet<ShippedDetail> shippedDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasQueryFilter(e => !e.IsDeleted);
        }
    }

}
