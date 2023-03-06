using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext // dbset ile girdigimiz proptileri sql e tablo olarak yansıtıyoruz
    {
        public DbSet <About> Abouts  { get; set; }
        public DbSet <Category> Categories  { get; set; } // ingilizceden dolayı ies takası
        public DbSet <Contact> Contacts  { get; set; }
        public DbSet <Content> Contents  { get; set; }
        public DbSet <Heading> Headings  { get; set; }
        public DbSet <Writer> Writers  { get; set; }
    }
}
