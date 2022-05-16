using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Takip.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
