using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyXamarinApp
{
    public class ProductViewModel
    {
        public ObservableCollection<Product> ItemList { get; set; }
        public ProductViewModel()
        {
            ItemList = new ObservableCollection<Product>();
            ItemList.Add(new Product() {ProductId=1, ProductName="Computer", Price=5000, ImageUrl="" });
            ItemList.Add(new Product() { ProductId = 2, ProductName = "Mouse", Price = 200, ImageUrl = "" });
            ItemList.Add(new Product() { ProductId = 3, ProductName = "Pen Drive", Price = 50, ImageUrl = "" });
            ItemList.Add(new Product() { ProductId = 1, ProductName = "KeyBoard", Price = 1500, ImageUrl = "" });
            ItemList.Add(new Product() { ProductId = 1, ProductName = "Monitor", Price =400, ImageUrl = "" });
            ItemList.Add(new Product() { ProductId = 1, ProductName = "Laptop", Price = 15000, ImageUrl = "" });
        }
    }
}
