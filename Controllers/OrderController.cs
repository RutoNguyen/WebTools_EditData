using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web.Http;
using System.Web.Services.Description;
using TPF.FFTools.Data;
using TPF.FFTools.Models;

namespace TPF.FFTools.Controllers
{
    [RoutePrefix("orderRoute")]
    public class OrderController : ApiController
    {
        [HttpPost]
        [Route("changeOrderAddress")]
        public List<Order.OrderChangeAddressResponse> ChangeOrderAddress(Order.OrderChangeAddressRequest data)
        {
            using (var dbContext = new Csversion1Entities())
            {
                var sql = new StringBuilder();
                sql.Append("EXEC dbo.OPS_Order_ChangeAddress @ClubCode,");
                sql.Append("@OrderID,@Street1,@Street2,@Suburb,@State,");
                sql.Append("@Postcode,@Country,@CompanyName,@Phone,@Note,@IsRun");
                if (!data.IsRun)
                {
                    dbContext.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
                    var returnData = dbContext.Database.SqlQuery<Order.OrderChangeAddressResponse>(sql.ToString(),
                                                                                new SqlParameter("ClubCode", data.ClubCode),
                                                                                new SqlParameter("OrderID", data.OrderID),
                                                                                new SqlParameter("Street1", string.IsNullOrEmpty(data.Street1) ? DBNull.Value : (object)data.Street1),
                                                                                new SqlParameter("Street2", string.IsNullOrEmpty(data.Street2) ? DBNull.Value : (object)data.Street2),
                                                                                new SqlParameter("Suburb", string.IsNullOrEmpty(data.Suburb) ? DBNull.Value : (object)data.Suburb),
                                                                                new SqlParameter("State", string.IsNullOrEmpty(data.State) ? DBNull.Value : (object)data.State),
                                                                                new SqlParameter("Postcode", string.IsNullOrEmpty(data.Postcode) ? DBNull.Value : (object)data.Postcode),
                                                                                new SqlParameter("Country", string.IsNullOrEmpty(data.Country) ? DBNull.Value : (object)data.Country),
                                                                                new SqlParameter("CompanyName", string.IsNullOrEmpty(data.CompanyName) ? DBNull.Value : (object)data.CompanyName),
                                                                                new SqlParameter("Phone", string.IsNullOrEmpty(data.Phone) ? DBNull.Value : (object)data.Phone),
                                                                                new SqlParameter("Note", data.Note),
                                                                                new SqlParameter("IsRun", data.IsRun)).ToList();
                    return returnData;
                }
                else
                {
                    var cmd = dbContext.Database.Connection.CreateCommand();
                    cmd.CommandText = "dbo.OPS_Order_ChangeAddress";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("ClubCode", data.ClubCode),
                        new SqlParameter("OrderID", data.OrderID),
                        new SqlParameter("Street1", string.IsNullOrEmpty(data.Street1) ? DBNull.Value : (object)data.Street1),
                        new SqlParameter("Street2", string.IsNullOrEmpty(data.Street2) ? DBNull.Value : (object)data.Street2),
                        new SqlParameter("Suburb", string.IsNullOrEmpty(data.Suburb) ? DBNull.Value : (object)data.Suburb),
                        new SqlParameter("State", string.IsNullOrEmpty(data.State) ? DBNull.Value : (object)data.State),
                        new SqlParameter("Postcode", string.IsNullOrEmpty(data.Postcode) ? DBNull.Value : (object)data.Postcode),
                        new SqlParameter("Country", string.IsNullOrEmpty(data.Country) ? DBNull.Value : (object)data.Country),
                        new SqlParameter("CompanyName", string.IsNullOrEmpty(data.CompanyName) ? DBNull.Value : (object)data.CompanyName),
                        new SqlParameter("Phone", string.IsNullOrEmpty(data.Phone) ? DBNull.Value : (object)data.Phone),
                        new SqlParameter("Note", data.Note),
                        new SqlParameter("IsRun", data.IsRun)
                    });

                    //var adapter = new SqlDataAdapter();
                    //adapter.SelectCommand = cmd;

                    // execute your command
                    dbContext.Database.Connection.Open();
                    // move to next result set
                    var reader = cmd.ExecuteReader();
                    reader.NextResult();
                    // Read second model --> Bar
                    var ret = ((IObjectContextAdapter)dbContext)
                        .ObjectContext
                        .Translate<Order.OrderChangeAddressResponse>(reader);
                    return ret.ToList();
                }
            }
        }
        [Route("changeOrderEnvelope")]
        public List<Order.OrderChangeEnvelopeResponse> ChangeOrderEnvelope(Order.OrderChangeEnvelopeRequest data)
        {
            using (var dbContext = new Csversion1Entities())
            {
                var sql = new StringBuilder();
                sql.Append("EXEC dbo.OPS_Order_ChangeEnvelope @ClubCode,");
                sql.Append("@OrderID,@FromEnvelopeID,@ToEnvelopeID,@IsAllowFullyDelivered,");
                sql.Append("@Note,@IsRun");
                if (!data.IsRun)
                {
                    dbContext.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
                    var returnData = dbContext.Database.SqlQuery<Order.OrderChangeEnvelopeResponse>(sql.ToString(),
                                                                                new SqlParameter("ClubCode", data.ClubCode),
                                                                                new SqlParameter("OrderID", data.OrderID),
                                                                                new SqlParameter("FromEnvelopeID", data.FromEnvelopeID),
                                                                                new SqlParameter("ToEnvelopeID", data.ToEnvelopeID),
                                                                                new SqlParameter("IsAllowFullyDelivered",data.IsAllowFullyDelivered),
                                                                                new SqlParameter("Note", data.Note),
                                                                                new SqlParameter("IsRun", data.IsRun)).ToList();
                    return returnData;
                }
                else
                {
                    var cmd = dbContext.Database.Connection.CreateCommand();
                    cmd.CommandText = "dbo.OPS_Order_ChangeEnvelope";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("ClubCode", data.ClubCode),
                        new SqlParameter("OrderID", data.OrderID),
                        new SqlParameter("FromEnvelopeID", data.FromEnvelopeID),
                        new SqlParameter("ToEnvelopeID",data.ToEnvelopeID),
                        new SqlParameter("IsAllowFullyDelivered", data.IsAllowFullyDelivered),
                        new SqlParameter("Note", data.Note),
                        new SqlParameter("IsRun", data.IsRun)
                    });

                    //var adapter = new SqlDataAdapter();
                    //adapter.SelectCommand = cmd;

                    // execute your command
                    dbContext.Database.Connection.Open();
                    
                    var reader = cmd.ExecuteReader();
                    // move to next result set
                    //reader.NextResult();
                    // Read second model --> Bar
                    var ret = ((IObjectContextAdapter)dbContext)
                        .ObjectContext
                        .Translate<Order.OrderChangeEnvelopeResponse>(reader);
                    return ret.ToList();
                }
            }
        }
    }
}
