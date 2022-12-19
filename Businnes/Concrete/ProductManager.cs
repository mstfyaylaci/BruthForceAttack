using Businnes.Abstract;
using DataAcces.Abstract;
using DataAcces.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDao _productDao;
        
        public ProductManager(IProductDao productDao)
        {
            _productDao = productDao;
        }

        public List<Product> GetAll()
        {
            return _productDao.GetAll();
        }
    }
}
