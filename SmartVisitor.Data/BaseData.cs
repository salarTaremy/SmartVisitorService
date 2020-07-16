using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SmartVisitor.Data
{
    public abstract class BaseData
    {
        protected  SqlConnection GetConnection()
        {
            var cn =  new SqlConnection("Server=192.168.200.220; Database=SmartVisitor; user id=sa; password=Ba2015th2; Application Name=SmartVisitor;");
            cn.Open();
            return cn;
        }
    }
}
