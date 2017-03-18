using SampleMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVVM.Service
{
    class Service
    {
        public  static IEnumerable<Customer> GetAllCustomers()
        {
            var customerRecords = default(IEnumerable<Customer>);

            try
            {
                string[] names = new string[] { "Steve", "Zones", "Ram", "RaOne", "Chacha", "GOne", "Subhen", "Mithilesh", "Annapurna" };
                Random ranomizer = new Random();

                customerRecords = new List<Customer>(
                    from index in Enumerable.Range(1, names.Length)
                    select new Customer
                    {
                        CustomerId = index.ToString(),
                        Customername = names[index-1],
                        CustomerAddress = "World,Peace"
                    }
                    );
            }
            catch (Exception exception)
            {

                Console.WriteLine("Exception: ",exception.Message);
            }

            return customerRecords;
        }
    }
}
