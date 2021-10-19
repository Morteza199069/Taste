using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taste.DataAccess.Data.Repository.IRepository;
using Taste.Models;

namespace Taste.DataAccess.Data.Repository
{
    public class MenuItemRepository : Repository<MenuItem>, IMenuItemRepository
    {
        private readonly ApplicationDbContext _db;

        public MenuItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(MenuItem menuItem)
        {
            var menuItemFromDb = _db.MenuItem.FirstOrDefault(m => m.Id == menuItem.Id);
            menuItemFromDb.Name = menuItem.Name;
            menuItemFromDb.Description = menuItem.Description;
            menuItemFromDb.Price = menuItem.Price;
            menuItemFromDb.CategoryId = menuItem.CategoryId;
            menuItemFromDb.FoodTypeId = menuItem.FoodTypeId;
            if(menuItem.Image!=null)
            {
                menuItemFromDb.Image = menuItem.Image;
            }
            _db.SaveChanges();
        }
    }
}
