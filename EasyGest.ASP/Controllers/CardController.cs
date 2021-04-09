using EASYGEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EASYGEST.Controllers
{
    public class CardController : Controller
    {
        // GET: Card
        public ActionResult Card()
        {
            TESTEASYEntities db1 = new TESTEASYEntities();
            TESTEASYEntities1 db2 = new TESTEASYEntities1();

            var produitList = db1.PRODUITS.ToList();
            var categorieList = db2.CATEGORIES.ToList();

            Produits_Categories panier = new Produits_Categories(produitList, categorieList);

            return View(panier);
        }
        public ActionResult WebForm1()
        {
            TESTEASYEntities db1 = new TESTEASYEntities();
            TESTEASYEntities1 db2 = new TESTEASYEntities1();

            var produitList = db1.PRODUITS.ToList();
            var categorieList = db2.CATEGORIES.ToList();

            Produits_Categories panier = new Produits_Categories(produitList, categorieList);

            return View(panier);
        }
        /*public ActionResult cardDelete(Produits_Categories model)
        {
            TESTEASYEntities db1 = new TESTEASYEntities();
            TESTEASYEntities1 db2 = new TESTEASYEntities1();

            var produitList = db1.PRODUITS.ToList();
            var categorieList = db2.CATEGORIES.ToList();

            Produits_Categories panier = new Produits_Categories(produitList, categorieList);

            Produits_Categories.panier.Remove(model.ID);

            return View("Card", panier);
        }*/
    }
}