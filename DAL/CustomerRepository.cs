using System.Collections.Generic;

namespace DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            return new List<Customer>(){
                new Customer { CustomerId = 1, City = "Jaipur", CustomerName = "Ram" },
                new Customer { CustomerId = 2, City = "Delhi", CustomerName = "Shyam" },
                new Customer { CustomerId = 3, City = "Ajmer", CustomerName = "Seeta" },
                new Customer { CustomerId = 4, City = "Mumbai", CustomerName = "Geeta" },
            };
        }
    }
}
