using System.Security.Cryptography;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();
            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
        }

        interface IPersonManager
        {
            //unimplement operation
            void Add();
            void Update();
        }

        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Added");
            }

            public void Update()
            {
                Console.WriteLine("Updated");
            }
        }

        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Added");
            }

            public void Update()
            {
                Console.WriteLine("Updated");
            }
        }

        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                personManager.Add();
            }
        }
    }
}