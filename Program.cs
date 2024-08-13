using Task1LINQ.Models;

namespace Task1LINQ
{
    internal class Program
    {
        public static void printListOfCstomers(List<Customer> list)
        {
            foreach (var customer in list)
            {
                Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, PhoneNumber: {customer.PhoneNumber}, City: {customer.City}\n");
            }
        }
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    Name = "John Doe",
                    Email = "john.doe@example.com",
                    PhoneNumber = "123-456-7890",
                    City = "Nablus",
                    PurchasedProducts = new List<Product>()
                    {
                        new Product() { Id = 1, Name = "Laptop", Price = 999.99m, Category = "Electronics", Stock = 10 },
                        new Product() { Id = 2, Name = "Smartphone", Price = 499.99m, Category = "Electronics", Stock = 20 }
                    }
                },
                new Customer()
                {
                    Id = 2,
                    Name = "Jane Smith",
                    Email = "jane.smith@example.com",
                    PhoneNumber = "987-654-3210",
                    City = "Los Angeles",
                    PurchasedProducts = new List<Product>()
                    {
                        new Product() { Id = 3, Name = "Tablet", Price = 299.99m, Category = "Electronics", Stock = 15 },
                        new Product() { Id = 4, Name = "Headphones", Price = 99.99m, Category = "Electronics", Stock = 30 }
                    }
                },
                new Customer()
                {
                    Id = 3,
                    Name = "Robert Johnson",
                    Email = "robert.johnson@example.com",
                    PhoneNumber = "555-123-4567",
                    City = "Chicago",
                    PurchasedProducts = new List<Product>()
                    {
                        new Product() { Id = 5, Name = "Camera", Price = 699.99m, Category = "Electronics", Stock = 5 },
                        new Product() { Id = 6, Name = "Microphone", Price = 199.99m, Category = "Electronics", Stock = 25 }
                    }
                },
                new Customer()
                {
                    Id = 4,
                    Name = "Emily Davis",
                    Email = "emily.davis@example.com",
                    PhoneNumber = "222-333-4444",
                    City = "Houston",
                    PurchasedProducts = new List<Product>()
                    {
                        new Product() { Id = 7, Name = "Printer", Price = 149.99m, Category = "Office Supplies", Stock = 12 },
                        new Product() { Id = 8, Name = "Monitor", Price = 249.99m, Category = "Electronics", Stock = 8 }
                    }
                },
                new Customer()
                {
                    Id = 5,
                    Name = "Michael Brown",
                    Email = "michael.brown@example.com",
                    PhoneNumber = "777-888-9999",
                    City = "Nablus",
                    PurchasedProducts = new List<Product>()
                    {
                        new Product() { Id = 9, Name = "Desk", Price = 199.99m, Category = "Furniture", Stock = 6 },
                        new Product() { Id = 10, Name = "Chair", Price = 89.99m, Category = "Furniture", Stock = 14 }
                    }
                },
                new Customer()
                {
                    Id = 6,
                    Name = "Sarah Wilson",
                    Email = "sarah.wilson@example.com",
                    PhoneNumber = "444-555-6666",
                    City = "Philadelphia",
                    PurchasedProducts = new List<Product>()
                    {
                        new Product() { Id = 11, Name = "Router", Price = 79.99m, Category = "Networking", Stock = 22 },
                        new Product() { Id = 12, Name = "Switch", Price = 129.99m, Category = "Networking", Stock = 18 }
                    }
                },
                new Customer()
                {
                    Id = 7,
                    Name = "James Miller",
                    Email = "james.miller@example.com",
                    PhoneNumber = "333-444-5555",
                    City = "San Antonio",
                    PurchasedProducts = new List<Product>()
                    {
                        new Product() { Id = 13, Name = "Speaker", Price = 59.99m, Category = "Audio", Stock = 40 },
                        new Product() { Id = 14, Name = "Subwoofer", Price = 99.99m, Category = "Audio", Stock = 12 }
                    }
                },
                new Customer()
                {
                    Id = 8,
                    Name = "Patricia Taylor",
                    Email = "patricia.taylor@example.com",
                    PhoneNumber = "111-222-3333",
                    City = "San Diego",
                    PurchasedProducts = new List<Product>()
                    {
                        new Product() { Id = 15, Name = "Graphics Card", Price = 399.99m, Category = "Computer Components", Stock = 5 },
                        new Product() { Id = 16, Name = "CPU", Price = 299.99m, Category = "Computer Components", Stock = 8 }
                    }
                },
                new Customer()
                {
                    Id = 9,
                    Name = "Christopher Moore",
                    Email = "christopher.moore@example.com",
                    PhoneNumber = "999-888-7777",
                    City = "Dallas",
                    PurchasedProducts = new List<Product>()
                    {
                        new Product() { Id = 17, Name = "Gaming Console", Price = 499.99m, Category = "Gaming", Stock = 10 },
                        new Product() { Id = 18, Name = "Game Controller", Price = 59.99m, Category = "Gaming", Stock = 25 }
                    }
                },
                new Customer()
                {
                    Id = 10,
                    Name = "Barbara Anderson",
                    Email = "barbara.anderson@example.com",
                    PhoneNumber = "666-555-4444",
                    City = "San Jose",
                    PurchasedProducts = new List<Product>()
                    {
                        new Product() { Id = 19, Name = "Television", Price = 799.99m, Category = "Home Entertainment", Stock = 3 },
                        new Product() { Id = 20, Name = "Blu-ray Player", Price = 149.99m, Category = "Home Entertainment", Stock = 10 }
                    }
                }
            };
            var result1 = customers.Where(c => c.City == "Nablus").ToList();
            printListOfCstomers(result1);

            var result2 = customers.Select(c => c.Name);
            foreach(var name in result2)
            {
                Console.WriteLine(name+" ");
            }


            var result3 = customers.OrderBy(c=>c.Name).ToList();
            printListOfCstomers(result3);


            var result4 = customers.First();
            Console.WriteLine($"ID: {result4.Id}, Name: {result4.Name}, PhoneNumber: {result4.PhoneNumber}, City: {result4.City}\n");


            var result5 = customers.Find(c => c.Id == 1);
            Console.WriteLine(result5.Name);

            var result6 = customers.Sum(c => c.PurchasedProducts.Sum(p=>p.Price));
            Console.WriteLine(result6);

            var result7 = customers.Any(c => c.City == "Qalqilia");
            Console.WriteLine("Does Any One Live In Qalqilia ? " + result7);

            var result8=customers.GroupBy(c => c.City);
            foreach(var City in result8)
            {
                Console.WriteLine("________________________\n");
                foreach (var cust in City)
                {
                    Console.WriteLine($"ID: {cust.Id}, Name: {cust.Name}, PhoneNumber: {cust.PhoneNumber}, City: {cust.City}\n");
                }
                Console.WriteLine("________________________\n");
            }



            var result9 = customers.Take(3).ToList();
            printListOfCstomers(result9);
        }
    }
}
