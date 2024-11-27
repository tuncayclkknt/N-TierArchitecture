using CSharkEgitimKampi301.DataAccessLayer.Abstract;
using CSharkEgitimKampi301.DataAccessLayer.Repositories;
using CSharkEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharkEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal:GenericRepository<Customer>, ICustomerDal
    {

    }
}
