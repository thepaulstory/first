using PaulStoryCylanceCodingTest.Models;
using System.Data.Entity.ModelConfiguration;

namespace PaulStoryCylanceCodingTest.Data.Configurations
{
    public class SupplierConfiguration : EntityTypeConfiguration<Supplier>
    {
        public SupplierConfiguration()
        {
            Property(p => p.SupplierID).IsRequired();
            Property(p => p.CompanyName).IsRequired().HasMaxLength(40);
            Property(p => p.ContactName).HasMaxLength(30);
            Property(p => p.ContactTitle).HasMaxLength(30);
            Property(p => p.Address).HasMaxLength(60);
            Property(p => p.City).HasMaxLength(15);
            Property(p => p.Region).HasMaxLength(15);
            Property(p => p.PostalCode).HasMaxLength(10);
            Property(p => p.Country).HasMaxLength(15);
            Property(p => p.Phone).HasMaxLength(24);
            Property(p => p.Fax).HasMaxLength(24);
        }
    }
}
