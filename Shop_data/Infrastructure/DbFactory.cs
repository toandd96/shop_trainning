using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_data.Infrastructure
{
    public class DbFactory:Dispoable,IDbFactory
    {
        ShopTrainingDbcontext dbcontext;
        public ShopTrainingDbcontext Init()
        {
            return dbcontext ?? (dbcontext = new ShopTrainingDbcontext());
        }

        protected override void DisposeCore()
        {
            dbcontext?.Dispose();
        }
    }
}
