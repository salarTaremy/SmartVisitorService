using SmartVisitor.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Repositories
{
    public class InventoryRepository : BaseRepository, IBaseRepository<Inventory, int>, IInventoryRepository
    {
        public InventoryRepository(string IMEI)
            :base(IMEI)
        {

        }

        public bool Create(Inventory item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inventory> Get()
        {
            return Db.GetAsEnumerable<Inventory>("GetInventory", new {IMEI = this.IMEI});
        }

        public Inventory Get(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
