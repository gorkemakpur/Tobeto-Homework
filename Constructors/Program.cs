namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1,"test","test","test");
            Customer customer2 = new Customer { Id=2,FirstName="2test",LastName="2test",City="2test"};
        }
    
    }

    class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}