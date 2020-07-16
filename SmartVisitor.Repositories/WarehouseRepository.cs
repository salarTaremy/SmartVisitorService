using SmartVisitor.Entities.Products;
using System;
using System.Collections.Generic;

namespace SmartVisitor.Repositories
{
    public class WarehouseRepository : BaseRepository, IBaseRepository<Warehouse, short>, IWarehouseRepository
    {
        public WarehouseRepository(string IMEI)
        : base(IMEI)
        {

        }

        public bool Create(Warehouse item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Warehouse> Get()
        {
            return Db.GetAsEnumerable<Warehouse>("GetWarehouses", new { IMEI = this.IMEI });
        }
        public Warehouse Get(short ID)
        {
            throw new NotImplementedException();
        }
    }
}
