using Cibertec.Repositories.Northwind;
using Cibertec.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Repositories.Dapper.Northwind
{
    public class NorthwindUnitOfWork: IUnitOfWork
    {
        public NorthwindUnitOfWork(string connectionstring)
        {
            Customers = new CustomerRepository(connectionstring);
        }

        public ICustomerRepository Customers { get; private set; }
    }
}
