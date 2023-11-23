namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 50, 60, 70 };
            sayilar1 = sayilar2;
            sayilar2[0] = 30000;

            Console.WriteLine(sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Test";
            person2 = person1;
            person1.FirstName = "John";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName= "Test";
            Employee employee = new Employee();

            Person person3 = customer;
            person3.FirstName = "Jack";
            Console.WriteLine(person3.FirstName);


        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string CreditNumber { get; set; }
        }

        class Employee : Person
        {
            public string EmployeeNumber { get; set; }
        }

    }
}