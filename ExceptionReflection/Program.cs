using System.Data;

namespace ExceptionReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StoreClass storeclass = new StoreClass();

           restart:
            Console.WriteLine("Salam Xos gelifsiz");
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.Remove Product By No");
            Console.WriteLine("3.Find Product By Type");
            Console.WriteLine("4.FInd Product By Name");
            string result = Console.ReadLine();

            switch (result)
            {
                case "1":
                    storeclass.AddProducty();
                    goto restart;
                    break;
                case "2":
                    storeclass.RemoveProductByNo();
                    break;
                case "3":
                    storeclass.FilterProductByType();
                    break;
                case "4":
                    storeclass.FilterProductByName();
                    break;
                default:
                    Console.WriteLine("Xais olunur duzgun nomre daxil edin");
                    break;
            }
        }
    }
}