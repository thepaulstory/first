using System.Configuration;
using System.Data.Entity;
using PaulStoryCylanceCodingTest.Models;
using PaulStoryCylanceCodingTest.Data.Configurations;

namespace PaulStoryCylanceCodingTest.Data
{
    public class DataContext : DbContext
    {
        #region Properties
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set;}
        public static string ConnectionStringName
        {
            get
            {
                if(ConfigurationManager.AppSettings["ConnectionStringName"] != null)
                {
                    return ConfigurationManager.AppSettings["ConnectionStringName"];
                }
                else
                {
                    return "DefaultConnection";
                }
            }
        }

        #endregion

        #region Methods
        static DataContext()
        {
            Database.SetInitializer(new CustomDatabaseInitializer());
        }

        public DataContext()
            : base(nameOrConnectionString: DataContext.ConnectionStringName)
        { }
        #endregion

        #region Event Handlers
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
        }
        #endregion
    }
}