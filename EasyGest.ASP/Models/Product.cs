namespace EASYGEST.Models
{
    public class Product
    {
        public int IdProduit { get; set; }
        public string NomProduit { get; set; }
        public string Description { get; set; }
        public int Prix_ht { get; set; }
        public int Prix_ttc { get; set; }
        public int IdCategorie { get; set; }
    }
}