using SmartVisitor.Entities.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Repositories
{
    public class PriceListRepository : BaseRepository, IBaseRepository<PriceList, int>, IPriceListRepository
    {
        public PriceListRepository( string IMEI)
            :base(IMEI)
        {

        }

        public bool Create(PriceList item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PriceList> Get()
        {
            return Db.GetMasterDetailsEnumerable<PriceList, PriceListDetail, int>("GetPriceListWithDetail" ,new { IMEI = this.IMEI });
        }

        public PriceList Get(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
