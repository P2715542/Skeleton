using System;

namespace ClassLibrary
{
    public class clsSofa
    {
        public int SofaId { get; set; }
        public int SupplierId { get; set; }
        public DateTime DateAdded { get; set; }
        public string SofaDescription { get; set; }
        public string Colour { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
    }
}