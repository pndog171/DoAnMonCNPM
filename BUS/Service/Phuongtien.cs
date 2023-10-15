using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS.Service
{
    public class Phuongtien
    {
       public List<Xe> GetAll()
        {
            Model1 context = new Model1();
            return context.Xes.ToList();
        }
       public Xe FindByName(string name)
        {
            Model1 context = new Model1(); 
            return context.Xes.FirstOrDefault(x => x.TenXe == name);
        }
        public void InsertUpdate(Xe xe)
        {
            Model1 context = new Model1();   
            context.Xes.AddOrUpdate(xe);
            context.SaveChanges();

        }

    }
}
