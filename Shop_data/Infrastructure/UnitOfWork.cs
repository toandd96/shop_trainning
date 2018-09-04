using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_data.Infrastructure
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private ShopTrainingDbcontext dbcontext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public ShopTrainingDbcontext Dbcontext => dbcontext ?? (dbcontext = dbFactory.Init());

        public void Commit()
        {
            dbcontext.SaveChanges();
        }
    }
}
