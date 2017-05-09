using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTrackingSystemApplication.Models.Entity;

namespace AssetTrackingSystemApplication.Models
{
    public class ATSAContext:DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<GeneralCategory> GeneralCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<DetailCategory> DetailCategories { get; set; }
        
    
    }
}
