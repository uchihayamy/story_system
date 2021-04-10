using System;

namespace Store_system_list.Store
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Storelist storeList = new Storelist();

            Console.WriteLine("Products-\n");
            storeList.Print2();

            Console.WriteLine("\n Clients -\n");
            storeList.Print();

            Console.WriteLine("\n Sales-\n");
            storeList.Print3();

            Console.WriteLine("\n Total sales-\n");

            float totalSales = storeList.getTotalSales();
            Console.WriteLine("Total sales amount: " + totalSales);

            Console.WriteLine("\n Highest purchase-\n");

            Sales hpurch = storeList.Hightpurch();
            Console.WriteLine("Name of client with the highest purchase: " + hpurch.Clients.name);

            Console.WriteLine("\n Top selling product-\n");

            Sales topp = storeList.topProduct();
            Console.WriteLine($"Top sold product: { topp.Products.name} - Amount:{ topp.Amount}");

            Console.WriteLine("\n Avarage-\n");

            float avarage = storeList.Avarage();
            Console.WriteLine("Total sales amount: " + avarage);

            Console.WriteLine("\n Sotck products-\n");
            storeList.Print4();

            Console.WriteLine("\n Insert client c4 after c1-\n");
            storeList.insertClient(c4, c1);
            storeList.Print();

            Console.WriteLine("\n Delete client-\n");
            storeList.deleteClient();
            storeList.Print();

            Console.WriteLine("\n  Insert tv box after pendrive-\n");
            storeList.insertProduct(tvbox, pendrive);
            storeList.Print2();

            Console.WriteLine("\n Delete product-\n");
            storeList.deleteClient();
            storeList.Print2();

            Console.WriteLine("\n Insert sale s4 after s1-\n");
            storeList.insertSale(s4, s1);
            storeList.Print3();
        }
    }
}
