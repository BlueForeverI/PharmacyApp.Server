using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmacyApp.Server.DataContext;

namespace PharmacyApp.Server.Repositories
{
    public abstract class BaseRepository<T> where T:class 
    {
        public virtual List<T> FindAll()
        {
            using(var context = new PharmacyContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public virtual T FindById(int id)
        {
            using (var context = new PharmacyContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public virtual void Add(T entry)
        {
            using (var context = new PharmacyContext())
            {
                context.Set<T>().Add(entry);
                context.SaveChanges();
            }
        }

        public virtual void AddRange(IEnumerable<T> entries)
        {
            using(var context = new PharmacyContext())
            {
                context.Set<T>().AddRange(entries);
                context.SaveChanges();
            }
        }

        public abstract void Update(T entry);

        public virtual void Delete(T entry)
        {
            using (var context = new PharmacyContext())
            {
                context.Set<T>().Remove(entry);
                context.SaveChanges();
            }
        }
    }
}
