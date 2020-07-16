using SmartVisitor.Entities.Order;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace SmartVisitor.Repositories
{
    public class OrderRepository : BaseRepository, IBaseRepository<Order, int>, IOrderRepository
    {
        public OrderRepository(string IMEI)
        : base(IMEI)
        {

        }





        public class CollectionHelper
        {
            private CollectionHelper()
            {
            }

            // this is the method I have been using
            public static DataTable ConvertTo<T>(ICollection<T> list)
            {
                DataTable table = CreateTable<T>();
                Type entityType = typeof(T);
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

                foreach (T item in list)
                {
                    DataRow row = table.NewRow();

                    foreach (PropertyDescriptor prop in properties)
                    {
                        row[prop.Name] = prop.GetValue(item);
                    }

                    table.Rows.Add(row);
                }

                return table;
            }

            public static DataTable CreateTable<T>()
            {
                Type entityType = typeof(T);
                DataTable table = new DataTable(entityType.Name);
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

                foreach (PropertyDescriptor prop in properties)
                {
                    // HERE IS WHERE THE ERROR IS THROWN FOR NULLABLE TYPES
                    //table.Columns.Add(prop.Name, prop.PropertyType);
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }

                return table;
            }
        }





        public bool Create(Order item)
        {
            Order ord = new Order { ID_Customer = 10100036, Description = "test"  , ID_Visitor = 1 };
            ord.OrderItems = new List<OrderItem>();
            ord.OrderItems.Add(new OrderItem { Id_Product = 1, Offer = 0, Qty = 10 });


            DataTable x = CollectionHelper.ConvertTo<OrderItem>(ord.OrderItems);
            Db.CreateEntity<Order>("CreateOrder", ord, new { ID_Customer = ord.ID_Customer,ID_Visitor = ord.ID_Visitor,ID_OrderType = 1,  Detail  = x}
            
            );

            return true;
                
                
        }

        public IEnumerable<Order> Get()
        {
            throw new NotImplementedException();
        }

        public Order Get(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
