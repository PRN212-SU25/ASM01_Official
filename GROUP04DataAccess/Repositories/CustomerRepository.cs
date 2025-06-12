using GROUP04DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GROUP04DataAccess.Repositories
{
    public class CustomerRepository
    {
        private static CustomerRepository instance;
        private List<Customer> customers;

        private CustomerRepository()
        {
            customers = new List<Customer>
            {
                new Customer { CustomerID = 3, CustomerFullName = "William Shakespeare", Telephone = "0903939393", EmailAddress = "WilliamShakespeare@FUMiniHotel.org", CustomerBirthday = new DateTime(1990, 2, 2), CustomerStatus = 1, Password = "123@" },
                new Customer { CustomerID = 5, CustomerFullName = "Elizabeth Taylor", Telephone = "0903939377", EmailAddress = "ElizabethTaylor@FUMiniHotel.org", CustomerBirthday = new DateTime(1991, 3, 3), CustomerStatus = 1, Password = "144@" },
                new Customer { CustomerID = 8, CustomerFullName = "James Cameron", Telephone = "0903946582", EmailAddress = "JamesCameron@FUMiniHotel.org", CustomerBirthday = new DateTime(1992, 11, 10), CustomerStatus = 1, Password = "443@" },
                new Customer { CustomerID = 9, CustomerFullName = "Charles Dickens", Telephone = "0903955633", EmailAddress = "CharlesDickens@FUMiniHotel.org", CustomerBirthday = new DateTime(1991, 12, 5), CustomerStatus = 1, Password = "563@" },
                new Customer { CustomerID = 10, CustomerFullName = "George Orwell", Telephone = "0913933493", EmailAddress = "GeorgeOrwell@FUMiniHotel.org", CustomerBirthday = new DateTime(1993, 12, 24), CustomerStatus = 1, Password = "177@" },
                new Customer { CustomerID = 11, CustomerFullName = "Victoria Beckham", Telephone = "0983246773", EmailAddress = "VictoriaBeckham@FUMiniHotel.org", CustomerBirthday = new DateTime(1990, 9, 9), CustomerStatus = 1, Password = "654@" }
            };
        }

        public static CustomerRepository Instance => instance ?? (instance = new CustomerRepository());

        public List<Customer> GetAll() => customers;
        public Customer GetById(int id) => customers.FirstOrDefault(c => c.CustomerID == id);
        public void Add(Customer customer) => customers.Add(customer);
        public void Update(Customer customer)
        {
            var existing = GetById(customer.CustomerID);
            if (existing != null)
            {
                existing.CustomerFullName = customer.CustomerFullName;
                existing.Telephone = customer.Telephone;
                existing.EmailAddress = customer.EmailAddress;
                existing.CustomerBirthday = customer.CustomerBirthday;
                existing.CustomerStatus = customer.CustomerStatus;
                existing.Password = customer.Password;
            }
        }
        public void Delete(int id) => customers.RemoveAll(c => c.CustomerID == id);
        public List<Customer> Search(string keyword) => customers.Where(c => c.CustomerFullName.Contains(keyword, StringComparison.OrdinalIgnoreCase) || c.EmailAddress.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}