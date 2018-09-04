using System;

namespace Shop_data.Infrastructure
{
    public interface IDbFactory:IDisposable
    {
        ShopTrainingDbcontext Init();
    }
}