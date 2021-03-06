using Gnarly.dl;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gnarly.bl
{
    public class ManageProduct
    {
        public List<Product> ProductInfo = new List<Product>()
        {
            new Product ("BIOHAZARD","39.99", new DateTime(2021,6,26)),
        };

        public void ProductView()
        {
            foreach (Product product in ProductInfo)
            {
                Console.WriteLine("Shirt Brand:{0}|Price: {1}|Date: {2}", product.ShirtBrand, product.Price, product.Date);
            }
        }
        public void ProductAdd()
        {
            foreach (Product product in ProductInfo)
            {
                Console.WriteLine("Shirt Brand:{0}|Price: {1}| Date Time:{2}", product.ShirtBrand, product.Price, product.Date);
            }

            Console.WriteLine("Enter Shirt Brand: ");
            string addProduct = Console.ReadLine();
            Console.WriteLine("Enter Price:$ ");
            string addPrice = Console.ReadLine();
            DateTime addDate = DateTime.Now;


            ProductInfo.Add(new Product(addProduct, addPrice, addDate));
            Console.WriteLine("Shirt brand:{0} | Price:${1} |Date: {2}| Successfully Added", addProduct, addPrice, addDate);

            foreach (Product product in ProductInfo)
            {
                Console.WriteLine("Shirt Brand:{0}|Price: {1}| Date:{2}", product.ShirtBrand, product.Price, product.Date);
            }
        }
        public void ProductRemoved()
        {
            Console.WriteLine("Enter Index Position:");
            int indexPosition = int.Parse(Console.ReadLine());

            ProductInfo.RemoveAt(indexPosition);

            foreach (Product product in ProductInfo)
            {
                Console.WriteLine("Shirt Brand:{0}|Price: {1}| Date:{2}", product.ShirtBrand, product.Price, product.Date);
            }
        }
    }
}

