using SmartVisitor.Entities.Customer;
using SmartVisitor.Entities.Links;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Repositories
{
    public class LinkPriceListCustomerRepository : BaseRepository, IBaseRepository<LinkPriceListCustomer, int>, ILinkPriceListCustomerRepository
    {
        public LinkPriceListCustomerRepository(string IMEI)
            : base(IMEI)
        {

        }

        public bool Create(LinkPriceListCustomer item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LinkPriceListCustomer> Get()
        {
            return Db.GetAsEnumerable<LinkPriceListCustomer>("GetLinkPriceListCustomer", new { IMEI = this.IMEI });
        }

        public LinkPriceListCustomer Get(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
