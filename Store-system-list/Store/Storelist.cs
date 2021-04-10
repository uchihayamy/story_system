using System;

namespace Store_system_list.Store
{
    class Storelist
    {
        public ClientsNode Head;

        public void Addclient(Clients clientstoAdd)
        {
            ClientsNode newClientsNode = new ClientsNode();
            newClientsNode.Clients = clientstoAdd;
            if (Head == null)
            {
                Head = newClientsNode;
            }
            else
            {
                ClientsNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }

                last.Next = newClientsNode;
            }
        }

        public ProductsNode Head2;

        public void Addproduct(Products productstoAdd)
        {
            ProductsNode newProductsNode = new ProductsNode();
            newProductsNode.Products = productstoAdd;
            if (Head2 == null)
            {
                Head2 = newProductsNode;
            }
            else
            {
                ProductsNode last = Head2;
                while (last.Next != null)
                {
                    last = last.Next;
                }

                last.Next = newProductsNode;
            }
        }

        public SalesNode Head3;

        public void AddSale(Sales salesstoAdd)
        {
            SalesNode newNode = new SalesNode();
            newNode.Sales = salesstoAdd;
            if (Head3 == null)
            {
                Head3 = newNode;
            }
            else
            {
                SalesNode last = Head3;
                while (last.Next != null)
                {
                    last = last.Next;
                }

                last.Next = newNode;
            }
        }

        public void Print()
        {
            ClientsNode tmp = Head;
            while (tmp != null)
            {
                Console.WriteLine($"Clients name: {tmp.Clients.name}");
                tmp = tmp.Next;
            }
        }

        public void Print2()
        {
            ProductsNode tmp = Head2;
            while (tmp != null)
            {
                Console.WriteLine($"Product name: {tmp.Products.name} - Product price: {tmp.Products.price}");
                tmp = tmp.Next;
            }
        }

        public void Print3()
        {
            SalesNode tmp = Head3;
            while (tmp != null)
            {
                Console.WriteLine($"Client name: {tmp.Sales.Clients.name}");
                Console.WriteLine($"Product name: {tmp.Sales.Products.name} - Product price: {tmp.Sales.Products.price} - Product amount: {tmp.Sales.Amount}\n");
                tmp = tmp.Next;
            }
        }

        Sales[] Sales = new Sales[15];
        int saleCount = 0;

        public float getAvarageSales()
        {
            float totalAvarageSales = 0;
            for (int i = 0; i < saleCount; i++)
            {
                totalAvarageSales = totalAvarageSales + Sales[i].Products.totalSales() / saleCount;
            }

            return totalAvarageSales;
        }

        public float Avarage()
        {
            float totalSales = 0;
            for (int i = 0; i < saleCount; i++)
            {
                totalSales = totalSales + Sales[i].Products.totalSales() / saleCount;
            }

            return totalSales;
        }

        public void Print4()
        {
            ProductsNode tmp = Head2;
            while (tmp != null)
            {
                Console.WriteLine($"Product name: {tmp.Products.name} Stock product: {tmp.Products.amount}");
                tmp = tmp.Next;
            }
        }

        public void insertClient(Clients newClient, Clients after)
        {
            ClientsNode tmp = Head;

            while (tmp != null && tmp.Clients != after)
            {
                tmp = tmp.Next;
            }

            ClientsNode newNode = new ClientsNode();
            newNode.Clients = newClient;

            newNode.Next = tmp.Next;
            tmp.Next = newNode;
        }

        public void deleteClient()
        {
            ClientsNode last, last2;
            last = Head;
            last2 = Head;

            while (last2.Next != null)
            {
                last = last2;
                last2 = last.Next;
            }
            last.Next = null;
        }

        public void insertProduct(Products newProduct, Products after)
        {
            ProductsNode tmp = Head2;

            while (tmp != null && tmp.Products != after)
            {
                tmp = tmp.Next;
            }

            ProductsNode newNode = new ProductsNode();
            newNode.Products = newProduct;

            newNode.Next = tmp.Next;
            tmp.Next = newNode;
        }

        public void deleteProduct()
        {
            ProductsNode last, last2;
            last = Head2;
            last2 = Head2;

            while (last2.Next != null)
            {
                last = last2;
                last2 = last.Next;
            }
            last.Next = null;
        }

        public void insertSale(Sales newSale, Sales after)
        {
            SalesNode tmp = Head3;

            while (tmp != null && tmp.Sales != after)
            {
                tmp = tmp.Next;
            }

            SalesNode newNode = new SalesNode();
            newNode.Sales = newSale;

            newNode.Next = tmp.Next;
            tmp.Next = newNode;
        }
        public void Addsl(Sales newSeller)
        {
            Sales[saleCount] = newSeller;
            saleCount++;
        }

        public float getTotalSales()
        {
            float totalSales = 0;
            for (int i = 0; i < saleCount; i++)
            {
                totalSales = totalSales + Sales[i].Products.totalSales();
            }

            return totalSales;
        }

        public Sales Hightpurch()
        {
            Sales client = Sales[0];

            for (int i = 1; i < saleCount; i++)
            {
                if (Sales[i].Products.totalSales() > client.Products.totalSales())
                {
                    client = Sales[i];
                }
            }

            return client;

        }

        public float getTotalAmountSales()
        {
            float totalAmount = 0;
            for (int i = 0; i < saleCount; i++)
            {
                totalAmount = totalAmount + Sales[i].totalAmount();
            }

            return totalAmount;
        }

        public Sales topProduct()
        {
            Sales topP = Sales[0];

            for (int i = 1; i < saleCount; i++)
            {
                if (Sales[i].totalAmount() > topP.totalAmount())
                {
                    topP = Sales[i];
                }
            }

            return topP;

        }


    }
}
