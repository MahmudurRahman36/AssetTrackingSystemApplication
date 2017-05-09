using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystemApplication.Models.Entity
{
    public class Branch
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public Organization Organization { get; set; }
        public List<Asset> Assets { get; set; }
    }
}
