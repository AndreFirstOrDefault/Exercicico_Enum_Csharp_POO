using ExercicioDeFixacao_Aula132.Entities;
using ExercicioDeFixacao_Aula132.Entities.Enums;
using System.Globalization;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            string birthDate = Console.ReadLine();
            DateTime dateBirth = DateTime.Parse(birthDate);
            

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            string txt = Console.ReadLine();
            OrderStatus status = Enum.Parse<OrderStatus>(txt);
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            DateTime moment = DateTime.Now;
            Client client = new Client(nameClient, email, dateBirth);
            Order order = new Order(moment,status,client);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter #" + (i + 1) + " item data:");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(pName, pPrice);
                Console.Write("Quantity: ");
                int pQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(pQuantity,pPrice,product);
                order.addItem(orderItem);
                
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
            
            


        }
    }
}
