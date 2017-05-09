using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystemApplication.Models.Entity
{
    public class Subcategory
    {
        public int Id { get; set; }
        public int GeneralCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public List<DetailCategory> DetailCategories { get; set; }
    }
}
