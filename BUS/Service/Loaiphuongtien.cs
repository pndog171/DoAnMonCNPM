using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS.Service
{
    public class Loaiphuongtien
    {
        public List<LoaiXe> GetAll()
        {
            Model1 context = new Model1();
            return context.LoaiXes.ToList();
        }
    }
}
