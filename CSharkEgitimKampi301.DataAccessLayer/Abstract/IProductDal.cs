using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharkEgitimKampi301.EntityLayer.Concrete;
using System.Threading.Tasks;

namespace CSharkEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Object> GetProductsWithCategory();
    }
}
