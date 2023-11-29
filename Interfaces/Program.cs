using System.Security.Cryptography;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager pm = new ProjectManager(new CustomerManager());
            pm.Add();
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

        class InternManager : IPersonManager
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
            IPersonManager _personManager;
            public ProjectManager(IPersonManager personManager)
            {
                _personManager = personManager;
            }
            public void Add()
            {
                _personManager.Add();
            }
        }
    }
}