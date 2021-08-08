using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ITBusinessManagement.Repositories
{
    // Hazırlanmış metodları buraya iskelet yapısı şeklinde oluşturulacak.Benzer yapı aşağıdaki gibidir.
    // T table class'ı ifade ediyor.

    public class GenericRepositories<T> where T:class, new()
    {
        //List 
        /*
         Context c = new Context();

        public list<T> DepartmentsList()
        {
           return c.Set<T>().ToList();
        }
        //Insert
        public void DevicesAdd(T p)
        {
           c.Set<T>().Add(p);
           c.SaveChanges();
        }

        //Delete
        public void DevicesDelete(T p)
        {
           c.Set<T>().Remove(p);
           c.SaveChanges();
        }
        //Update
        public void DevicesUpdate(T p)
        {
           c.Set<T>().Update(p);
           c.SaveChanges();
        }
         */

    }
}
