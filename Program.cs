namespace CSharp_OrderManagementSystem
{


    internal class Program

    {



        static void Main(string[] args)

        {

            Order customer1 = new Order(524, "Branzy Jim", 54.68M);

            Order customer2 = new Order(573, "KIM KURI", 108.12M);

            customer1.DisplayOrderinfo();



            customer2.DisplayOrderinfo();

            Order.DisplayTotalOrdersCreated();

        }

        class Order

        {

            int OrderId;

            string CustomerName;

            decimal Amount;

            static int TotalOrders = 0;

            public Order(int OrderId, string CustomerName, decimal Amount)

            {

                this.OrderId = OrderId;

                this.CustomerName = CustomerName;

                this.Amount = Amount;

                TotalOrders++;

            }

            public void DisplayOrderinfo()

            {

                Console.WriteLine("OrderInformation:");

                Console.WriteLine($"OrderId: {OrderId}");

                Console.WriteLine($"CustomerName: {CustomerName}");

                Console.WriteLine($"Amount: ${Amount}");

                Console.WriteLine();

                Console.WriteLine();

                Console.WriteLine();





            }

            public static void DisplayTotalOrdersCreated()

            {

                Console.WriteLine($"TotalOrdersCreated: {TotalOrders}");



            }

        }

    }


}
