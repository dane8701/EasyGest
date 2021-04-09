using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EASYGEST.Models
{
    public class Article
    {
        public int Id { get; set; }
        public int Qte { get; set; }

        public Article(int id)
        {
            Id = id;
            Qte = 1;
        }
    }
}