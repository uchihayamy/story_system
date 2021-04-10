using System;

namespace Store_system_list.Store
{
    public class Sales
    {
        public Products Products;
        public Clients Clients;
        public int Amount;

        public float totalAmount()
        {
            return Amount;
        }

    }
    public static void Main(String[] args)
    {
        Storelist storeList = new Storelist();

        Sales s1 = new Sales();
        Sales s1a = new Sales();
        s1.Clients = c1;
        s1.Products = Usb;
        s1.Amount = 2;
        storeList.AddSale(s1);
        storeList.Addsl(s1);

        Sales s2 = new Sales();
        s2.Clients = c2;
        s2.Products = PcGamer;
        s2.Amount = 3;
        storeList.AddSale(s2);
        storeList.Addsl(s2);

        Sales s3 = new Sales();
        s3.Clients = c3;
        s3.Products = Mouse;
        s3.Amount = 5;
        storeList.AddSale(s3);
        storeList.Addsl(s3);

        Sales s4 = new Sales();
        s4.Clients = c4;
        s4.Products = VrGlasses;
        s4.Amount = 3;

    }
}