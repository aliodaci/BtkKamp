using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext tradeContext = new ETradeContext())
            {
                return tradeContext.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            using (ETradeContext tradeContext = new ETradeContext())
            {
                return tradeContext.Products.Where(p=>p.Name.Contains(key)).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext tradeContext = new ETradeContext())
            {
                return tradeContext.Products.Where(p => p.UnitPrice>=price).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext tradeContext = new ETradeContext())
            {
                return tradeContext.Products.Where(p => p.UnitPrice >= min&&p.UnitPrice<=max).ToList();
            }
        }

        public Product GetById(int id)
        {
            using (ETradeContext tradeContext = new ETradeContext())
            {
                var result= tradeContext.Products.FirstOrDefault(p => p.Id == id);
                return result;
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext tradeContext = new ETradeContext())
            {
                //tradeContext.Products.Add(product);
                var entity = tradeContext.Entry(product);
                entity.State = EntityState.Added;
                tradeContext.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext tradeContext = new ETradeContext())
            {
                var entity = tradeContext.Entry(product);
                entity.State = EntityState.Modified;
                tradeContext.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext tradeContext = new ETradeContext())
            {
                var entity = tradeContext.Entry(product);
                entity.State = EntityState.Deleted;
                tradeContext.SaveChanges();
            }
        }
    }
}
