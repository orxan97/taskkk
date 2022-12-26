using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionReflection
{
    internal class StoreClass
    {
        ProductClass[] products;
        public StoreClass()
        {
            products = new ProductClass[0];
        }

        public void AddProducty()
        {
            Console.WriteLine("Zehmet olmasa mehsulun adini daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("zehmet olmasa mehsulun qiymetini daxil edin");
            double price = Convert.ToDouble(Console.ReadLine());
            Enum type;
            restarttype:
            Console.WriteLine("Zehmet olmasa mehsulun novunu daxil edin");
            string typestr = Console.ReadLine();
            switch (typestr)
            {
                case "meat":
                    type = Enum.Meat;
                    break;
                case "bakery":
                    type = Enum.Bakery;
                    break;
                case "drink":
                    type = Enum.Drink;
                    break;
                default:
                    Console.WriteLine("Please enter valid type");
                    goto restarttype;
                    break;
            }
            ProductClass product = new ProductClass(name, price, type);
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
                Console.WriteLine("Mehsul elave olundu");

        }
        public void RemoveProductByNo()
        {


        }

        public void FilterProductByType()
        {


        }
        public void FilterProductByName()
        {
            Console.WriteLine("Mehsulun adini daxil edin:");
            string name = Console.ReadLine();
            foreach (var item in products)
            {
                if (item.Name == name)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
