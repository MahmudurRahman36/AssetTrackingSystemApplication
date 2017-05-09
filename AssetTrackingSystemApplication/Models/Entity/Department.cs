using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystemApplication.Models.Entity
{
    public class Department
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Branch Branch { get; set; } 
    }
}
