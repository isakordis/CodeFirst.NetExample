using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductsManagement.Models
{
    public class Products
    {
        [Key]
        public int p_id { get; set; }
        public string p_cate { get; set; }
        public int p_prize { get; set; }
        public string p_name { get; set; }
        
    }
}