using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EASYGEST.Models
{
    public class Produits_Categories
    {
        public IEnumerable<PRODUITS> produits { get; set; }
        public IEnumerable<CATEGORIES> categories { get; set; }

        public static List<Article> panier = new List<Article>();

        public static int total { get; set; }
        
        public Produits_Categories()
        {
            Produits_Categories.panier.Clear();
            total = 0;
        }
        public Produits_Categories(IEnumerable<PRODUITS> produits, IEnumerable<CATEGORIES> categories)
        {
            this.produits = produits;
            this.categories = categories;
            total = 0;
        }
    }
}