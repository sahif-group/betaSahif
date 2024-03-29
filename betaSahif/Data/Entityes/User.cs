﻿namespace betaSahif.Data.Entityes
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Parol { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
