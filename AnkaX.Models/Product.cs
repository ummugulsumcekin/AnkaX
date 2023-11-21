using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnkaX.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Seller { get; set; }
        [Required]
        public string Description { get; set; }
       
        [Required]
        public string SiteAge { get; set; }
        [Required]
        public string Industry { get; set; }


        public string Location { get; set; }

        
        [Required]
        [Display(Name = "MonthlyNetProfit")]
        public double MonthlyNetProfit { get; set; }

        [Required]
        [Display(Name = "Price")]
        [Range(1, 1000000)]
        public double Price { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public  Category Category { get; set; }
        public string ImageUrl { get; set; }
    }
}
