using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCart.Models
{
    public class Product
    {
        [Key]
        [DisplayName("ID")]
        public int ProdID { get; set; }

        [Required]
        [DisplayName("Name")]
        public string ProdName { get; set; }

        [DisplayName("Image Name")]
        public string ProdImageName { get; set; }

        [Required]
        [DisplayName("Price")]
        public double ProdPrice { get; set; }

        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImageFile { get; set; }
      
    }
}
