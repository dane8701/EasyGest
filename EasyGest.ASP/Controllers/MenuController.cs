using EASYGEST.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EASYGEST.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Menu()
        {
            TESTEASYEntities db1 = new TESTEASYEntities();
            TESTEASYEntities1 db2 = new TESTEASYEntities1();

            var produitList = db1.PRODUITS.ToList();
            var categorieList = db2.CATEGORIES.ToList();

            Produits_Categories panier = new Produits_Categories(produitList, categorieList);
            return View(panier);
        }

        public ActionResult addCart(int z)
        {
            int i = 0;
            TESTEASYEntities db1 = new TESTEASYEntities();
            TESTEASYEntities1 db2 = new TESTEASYEntities1();

            var produitList = db1.PRODUITS.ToList();
            var categorieList = db2.CATEGORIES.ToList();
            Article art = new Article(z);

            Produits_Categories panier = new Produits_Categories(produitList, categorieList);
            if(Produits_Categories.panier.Count ==0)
            {
                Produits_Categories.panier.Add(art);
            }
            else
            {
                while(i != Produits_Categories.panier.Count())
                {
                    i++;
                    if(Produits_Categories.panier[i-1].Id == z)
                    {
                        Produits_Categories.panier[i-1].Qte++;
                        
                        break;
                    }
                    else
                    {
                        Produits_Categories.panier.Add(art);
                        
                        break;
                    }
                }
            }
            return View("Menu", panier);
        }
    }
}