using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {
                Id = 1, 
                FirstName = "A.G.", 
                LastName = "A.", 
                NationalityId = "123213123", 
                DateOfBirth = new DateTime(1999, 04,20) };

            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());


            customerManager.Save(customer1);
        }
    }
}