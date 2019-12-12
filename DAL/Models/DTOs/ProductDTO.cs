using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DTOs
{
    public class ProductDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public bool IsSold { get; set; }

    }
}
