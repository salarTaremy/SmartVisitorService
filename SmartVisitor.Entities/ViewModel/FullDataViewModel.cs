using System;
using System.Collections.Generic;
using System.Text;
using SmartVisitor.Entities.Customer;
using SmartVisitor.Entities.Common;
using SmartVisitor.Entities.Links;
using SmartVisitor.Entities.Order;
using SmartVisitor.Entities.Other;
using SmartVisitor.Entities.Products;
using SmartVisitor.Entities.ViewModel;
using SmartVisitor.Entities.Visitor;


namespace SmartVisitor.Entities.ViewModel
{
    public class FullDataViewModel
    {
        public FullDataViewModel()
        {
            //this.MyCalendars = new List<MyCalendar>();
            //this.Customers = new List<Customer>();
            //this.CustomerTypes = new List<CustomerType>();
            //this.CustomerGroups = new List<CustomerGroup>();
            //this.ProductBrands = new List<ProductBrand>();
            //this.ProductGroups = new List<ProductGroup>();
            //this.Products = new List<Product>();
            //this.Warehouses = new List<Warehouse>();
            //this.inventories = new List<Inventory>();
            //this.PriceLists = new List<PriceList>();
            //this.LinkPriceListCustomer = new List<LinkPriceListCustomer>();
        }
        public IEnumerable<SmartVisitor.Entities.Customer.Customer> Customers { get; set; }
        public IEnumerable<CustomerType> CustomerTypes { get; set; }
        public IEnumerable<CustomerGroup> CustomerGroups { get; set; }
        public IEnumerable<ProductBrand> ProductBrands { get; set; }
        public IEnumerable<ProductGroup> ProductGroups { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Warehouse> Warehouses { get; set; }
        public IEnumerable<Inventory> inventories { get; set; }
        public IEnumerable<PriceList> PriceLists { get; set; }
        public IEnumerable<LinkPriceListCustomer> LinkPriceListCustomer { get; set; }
        public IEnumerable<LinkVisitorCustomer> LinkVisitorCustomer { get; set; }
    }
}
