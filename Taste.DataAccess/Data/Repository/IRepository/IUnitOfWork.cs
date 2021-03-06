using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taste.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository Category { get; }
        IFoodTypeRepository FoodType { get; }
        IMenuItemRepository MenuItem { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IOrderHeaderRepository OrderHeader { get; }
        IOrderDetailsRepository OrderDetails { get; }
        void Save();
    }
}
