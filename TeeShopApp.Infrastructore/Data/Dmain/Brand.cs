using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeeShopApp.Infrastructure.Data.Dmain
{
    internal class Brand
    {
        public int Id { get; set; }
        [Required]
        [MaxLength]
        public string BrandName { get; set; } = null!;
        public virtual IEnumerable<Product> Products { get; set; } = new List<Product>();

    }
}
