﻿namespace betaSahif.Data.Entityes
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string ImageUlr { get; set; } = string.Empty;
        public List<Product> Products { get; set; } = new List<Product>();

    }
}
