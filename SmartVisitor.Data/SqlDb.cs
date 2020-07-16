using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using Dapper;
using Microsoft.Extensions.Configuration;
using SmartVisitor.Entities;
using SmartVisitor.Entities.Common;
using SmartVisitor.Entities.Order;

namespace SmartVisitor.Data
{

    class test :BaseEntity<int>  {
    }


    public class SqlDb : BaseData
    {

        public IEnumerable< THeader> GetMasterDetailsEnumerable <THeader , TDetail, TKeyHeader> (string Query,object param = null, CommandType commandType = CommandType.StoredProcedure)
            where THeader : BaseEntity<TKeyHeader>  ,  IDetail<TDetail>
            //where TDetail : BaseEntity<null>
        {
            var Dic = new Dictionary<TKeyHeader, THeader>();
            var cnn = this.GetConnection();
            cnn.Query<THeader, TDetail, THeader>(Query, (Header, Detail) =>
            {
                if (!Dic.TryGetValue(Header.ID, out THeader header))
                    Dic.Add(Header.ID, header = Header);
                header.Details.Add(Detail);
                return header;
            }  ,param,
            commandType: commandType);
            List<THeader> Lst = new List<THeader>();
            foreach (KeyValuePair<TKeyHeader, THeader> entry in Dic)
            {
                Lst.Add(entry.Value);
            }
            return Lst.AsEnumerable();
        }

        public IEnumerable<TResult> GetAsEnumerable<TResult>( string Query  , object param = null,CommandType commandType = CommandType.StoredProcedure) {
             IEnumerable<TResult> Result;
            using (var cn = this.GetConnection())
            {
                Result = cn.Query<TResult>(Query, param,
                commandType: commandType);
            }
            return Result;
        }
        public bool CreateEntity<TEntity>(string Query , TEntity Entity, object param = null, CommandType commandType = CommandType.StoredProcedure) {
            using (var cn = this.GetConnection())
            {
                var result = cn
                .Query(Query,param,
                commandType: commandType);
            }

            return false;
        }



    }
}


