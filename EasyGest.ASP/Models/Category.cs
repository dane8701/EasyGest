using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EASYGEST.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int IdCategorie { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string NomCategorie { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}