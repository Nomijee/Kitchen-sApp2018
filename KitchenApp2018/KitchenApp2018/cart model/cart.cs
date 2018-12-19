using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenApp2018.cart_model
{
    public class cart
    {
        [PrimaryKey]
        public int id { get; set; }
        public string item { get; set; }
        public int price { get; set; }
    }
}
