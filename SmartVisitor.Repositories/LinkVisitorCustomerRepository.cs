using SmartVisitor.Entities.Links;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Repositories
{
    public class LinkVisitorCustomerRepository : BaseRepository, IBaseRepository<LinkVisitorCustomer, int>, ILinkVisitorCustomerRepository
    {
        public LinkVisitorCustomerRepository(string IMEI)
            : base(IMEI)
        {

        }

        public bool Create(LinkVisitorCustomer item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LinkVisitorCustomer> Get()
        {
            return Db.GetAsEnumerable<LinkVisitorCustomer>("GetLinkVisitorCustomer", new { IMEI = this.IMEI });
        }

        public LinkVisitorCustomer Get(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
