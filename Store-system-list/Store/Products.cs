using System;

namespace Store_system_list.Store
{
    public class Products
    {
        public string name;
        public float price;
        public int amount;

        public float totalSales()
        {
            return price;
        }

    }
    public static void Main(String[] args)
    {
        Storelist storeList = new Storelist();

        Products Usb = new Products();
        Usb.name = "Usb";
        Usb.price = 50;
        Usb.amount = 130;
        storeList.Addproduct(Usb);

        Products PcGamer = new Products();
        PcGamer.name = "PcGamer";
        PcGamer.price = 350;
        PcGamer.amount = 680;
        storeList.Addproduct(PcGamer);

        Products Mouse = new Products();
        Mouse.name = "Mouse";
        Mouse.price = 80;
        Mouse.amount = 98;
        storeList.Addproduct(Mouse);

        Products VrGlasses = new Products();
        VrGlasses.name = "VrGlasses";
        VrGlasses.price = 550;
        VrGlasses.amount = 200;
        storeList.Addproduct(VrGlasses);

        Products Nootebook = new Products();
        Nootebook.name = "Nootebook";
        Nootebook.price = 845;
        Nootebook.amount = 550;
        storeList.Addproduct(Nootebook);

        Products CellPhone = new Products();
        CellPhone.name = "CellPhone";
        CellPhone.price = 910;
        CellPhone.amount = 300;
        storeList.Addproduct(CellPhone);

        Products Monitor = new Products();
        Monitor.name = "Monitor";
        Monitor.price = 540;
        Monitor.amount = 250;
        storeList.Addproduct(Monitor);

        Products RamMemory = new Products();
        RamMemory.name = "RamMemory";
        RamMemory.price = 440;
    }
}
