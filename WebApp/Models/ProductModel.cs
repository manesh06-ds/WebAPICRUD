﻿namespace WebApp.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

      //  public virtual Category Category { get; set; }
    }
}
