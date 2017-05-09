using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystemApplication.Models.Entity
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Location { get; set; }
        public List<Branch> Branches { get; set; } 
    }
}
