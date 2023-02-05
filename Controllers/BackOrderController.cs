﻿using System;
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
    //[Authorize]
    [RoutePrefix("backOrderRoute")]
    public class BackOrderController : ApiController
    {
        [HttpPost]
        [Route("changeBackOrderAddress")]
        public List<BackOrder.BackOrderChangeAddressResponse> ChangeBackOrderAddress(BackOrder.BackOrderChangeAddressRequest data)
        {
            using (var dbContext = new Csversion1Entities())
            {
                var sql = new StringBuilder();
                sql.Append("EXEC dbo.OPS_BackOrder_ChangeAddress @ClubCode,");
                sql.Append("@UploadID,@RecordIDList,@Street1,@Street2,@Suburb,@State,");
                sql.Append("@Postcode,@Country,@CompanyName,@Phone,@Email,@Note,@IsRun");
                if (!data.IsRun)
                {
                    dbContext.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
                    var returnData = dbContext.Database.SqlQuery<BackOrder.BackOrderChangeAddressResponse>(sql.ToString(),
                                                                                new SqlParameter("ClubCode", data.ClubCode),
                                                                                new SqlParameter("UploadID", data.UploadID),
                                                                                new SqlParameter("RecordIDList", data.RecordIDList),
                                                                                new SqlParameter("Street1", string.IsNullOrEmpty(data.Street1) ? DBNull.Value : (object)data.Street1),
                                                                                new SqlParameter("Street2", string.IsNullOrEmpty(data.Street2) ? DBNull.Value : (object)data.Street2),
                                                                                new SqlParameter("Suburb", string.IsNullOrEmpty(data.Suburb) ? DBNull.Value : (object)data.Suburb),
                                                                                new SqlParameter("State", string.IsNullOrEmpty(data.State) ? DBNull.Value : (object)data.State),
                                                                                new SqlParameter("Postcode", string.IsNullOrEmpty(data.Postcode) ? DBNull.Value : (object)data.Postcode),
                                                                                new SqlParameter("Country", string.IsNullOrEmpty(data.Country) ? DBNull.Value : (object)data.Country),
                                                                                new SqlParameter("CompanyName", string.IsNullOrEmpty(data.CompanyName) ? DBNull.Value : (object)data.CompanyName),
                                                                                new SqlParameter("Phone", string.IsNullOrEmpty(data.Phone) ? DBNull.Value : (object)data.Phone),
                                                                                new SqlParameter("Email", string.IsNullOrEmpty(data.Email) ? DBNull.Value : (object)data.Email),
                                                                                new SqlParameter("Note", data.Note),
                                                                                new SqlParameter("IsRun", data.IsRun)).ToList();
                    return returnData;
                }
                else
                {
                    var cmd = dbContext.Database.Connection.CreateCommand();
                    cmd.CommandText = "dbo.OPS_BackOrder_ChangeAddress";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("ClubCode", data.ClubCode),
                        new SqlParameter("UploadID", data.UploadID),
                        new SqlParameter("RecordIDList", data.RecordIDList),
                        new SqlParameter("Street1", string.IsNullOrEmpty(data.Street1) ? DBNull.Value : (object)data.Street1),
                        new SqlParameter("Street2", string.IsNullOrEmpty(data.Street2) ? DBNull.Value : (object)data.Street2),
                        new SqlParameter("Suburb", string.IsNullOrEmpty(data.Suburb) ? DBNull.Value : (object)data.Suburb),
                        new SqlParameter("State", string.IsNullOrEmpty(data.State) ? DBNull.Value : (object)data.State),
                        new SqlParameter("Postcode", string.IsNullOrEmpty(data.Postcode) ? DBNull.Value : (object)data.Postcode),
                        new SqlParameter("Country", string.IsNullOrEmpty(data.Country) ? DBNull.Value : (object)data.Country),
                        new SqlParameter("CompanyName", string.IsNullOrEmpty(data.CompanyName) ? DBNull.Value : (object)data.CompanyName),
                        new SqlParameter("Phone", string.IsNullOrEmpty(data.Phone) ? DBNull.Value : (object)data.Phone),
                        new SqlParameter("Email", string.IsNullOrEmpty(data.Email) ? DBNull.Value : (object)data.Email),
                        new SqlParameter("Note", data.Note),
                        new SqlParameter("IsRun", data.IsRun)
                    });

                    //var adapter = new SqlDataAdapter();
                    //adapter.SelectCommand = cmd;

                    // execute your command
                    dbContext.Database.Connection.Open();
                    var reader = cmd.ExecuteReader();

                    // move to next result set
                    reader.NextResult();
                    reader.NextResult();
                    reader.NextResult();

                    // Read second model --> Bar
                    var ret = ((IObjectContextAdapter)dbContext)
                        .ObjectContext
                        .Translate<BackOrder.BackOrderChangeAddressResponse>(reader);
                    return ret.ToList();
                }
            }
        }
        
        [Route("changeBackOrderReplaceItem")]
        public List<BackOrder.BackOrderChangeReplaceItemResponse> ChangeBackOrderReplaceItem(BackOrder.BackOrderChangeReplaceItemRequest data)
        {
            using (var dbContext = new Csversion1Entities())
            {
                var sql = new StringBuilder();
                sql.Append("EXEC dbo.OPS_BackOrder_ReplaceItem @ClubCode,");
                sql.Append("@UploadID,@GroupIDList,@RecordIDList,@ItemType,@FromItemID,@ToItemID,@Note,@IsRun");
                if (!data.IsRun)
                {
                    dbContext.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
                    var returnData = dbContext.Database.SqlQuery<BackOrder.BackOrderChangeReplaceItemResponse>(sql.ToString(),
                                                                                new SqlParameter("ClubCode", data.ClubCode),
                                                                                new SqlParameter("UploadID", data.UploadID),
                                                                                new SqlParameter("GroupIDList", data.GroupIDList),
                                                                                new SqlParameter("RecordIDList", data.RecordIDList),
                                                                                new SqlParameter("ItemType", data.ItemType),
                                                                                new SqlParameter("FromItemID", data.FromItemID),
                                                                                new SqlParameter("ToItemID", data.ToItemID),
                                                                                //new SqlParameter("Street1", string.IsNullOrEmpty(data.Street1) ? DBNull.Value : (object)data.Street1),
                                                                                //new SqlParameter("Street2", string.IsNullOrEmpty(data.Street2) ? DBNull.Value : (object)data.Street2),
                                                                                //new SqlParameter("Suburb", string.IsNullOrEmpty(data.Suburb) ? DBNull.Value : (object)data.Suburb),
                                                                                //new SqlParameter("State", string.IsNullOrEmpty(data.State) ? DBNull.Value : (object)data.State),
                                                                                //new SqlParameter("Postcode", string.IsNullOrEmpty(data.Postcode) ? DBNull.Value : (object)data.Postcode),
                                                                                //new SqlParameter("Country", string.IsNullOrEmpty(data.Country) ? DBNull.Value : (object)data.Country),
                                                                                //new SqlParameter("CompanyName", string.IsNullOrEmpty(data.CompanyName) ? DBNull.Value : (object)data.CompanyName),
                                                                                //new SqlParameter("Phone", string.IsNullOrEmpty(data.Phone) ? DBNull.Value : (object)data.Phone),
                                                                                //new SqlParameter("Email", string.IsNullOrEmpty(data.Email) ? DBNull.Value : (object)data.Email),
                                                                                new SqlParameter("Note", data.Note),
                                                                                new SqlParameter("IsRun", data.IsRun)).ToList();
                    //@ClubCode = 'ITT',     --varchar(20)
                    //@UploadID = 34513,      --int
                    //@GroupIDList = '',  --varchar(max)
                    //@RecordIDList = '20246186', --varchar(max)
                    //@ItemType = 'Product',     --varchar(50)
                    //@FromItemID = '57',   --varchar(50)
                    //@ToItemID = '55',     --varchar(50)
                    //@Note = N'IT-Test',        --nvarchar(500)
                    //@IsRun = 0-- bit
                    return returnData;
                }
                else
                {
                    var cmd = dbContext.Database.Connection.CreateCommand();
                    cmd.CommandText = "dbo.OPS_BackOrder_ReplaceItem";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("ClubCode", data.ClubCode),
                        new SqlParameter("UploadID", data.UploadID),
                        new SqlParameter("GroupIDList", data.GroupIDList),
                        new SqlParameter("RecordIDList", data.RecordIDList),
                        new SqlParameter("ItemType",data.ItemType),
                        new SqlParameter("FromItemID",data.FromItemID),
                        new SqlParameter("ToItemID",data.ToItemID),
                                         
                        //new SqlParameter("Street1", string.IsNullOrEmpty(data.Street1) ? DBNull.Value : (object)data.Street1),
                        //new SqlParameter("Street2", string.IsNullOrEmpty(data.Street2) ? DBNull.Value : (object)data.Street2),
                        //new SqlParameter("Suburb", string.IsNullOrEmpty(data.Suburb) ? DBNull.Value : (object)data.Suburb),
                        //new SqlParameter("State", string.IsNullOrEmpty(data.State) ? DBNull.Value : (object)data.State),
                        //new SqlParameter("Postcode", string.IsNullOrEmpty(data.Postcode) ? DBNull.Value : (object)data.Postcode),
                        //new SqlParameter("Country", string.IsNullOrEmpty(data.Country) ? DBNull.Value : (object)data.Country),
                        //new SqlParameter("CompanyName", string.IsNullOrEmpty(data.CompanyName) ? DBNull.Value : (object)data.CompanyName),
                        //new SqlParameter("Phone", string.IsNullOrEmpty(data.Phone) ? DBNull.Value : (object)data.Phone),
                        //new SqlParameter("Email", string.IsNullOrEmpty(data.Email) ? DBNull.Value : (object)data.Email),
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
                    //reader.NextResult();
                    reader.NextResult();

                    // Read second model --> Bar
                    var ret = ((IObjectContextAdapter)dbContext)
                        .ObjectContext
                        .Translate<BackOrder.BackOrderChangeReplaceItemResponse>(reader);
                    return ret.ToList();
                }
            }
        }

        [Route("changeBackOrderAddItem")]
        public List<BackOrder.BackOrderAddItemResponse> ChangeBackOrderAddItem(BackOrder.BackOrderAddItemRequest data)
        {
            using (var dbContext = new Csversion1Entities())
            {
                var sql = new StringBuilder();
                sql.Append("EXEC dbo.OPS_BackOrder_AddItem @ClubCode,");
                sql.Append("@UploadID,@GroupIDList,@RecordIDList,@ItemType,@ItemID,@Note,@IsRun");
                if (!data.IsRun)
                {
                    dbContext.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
                    var returnData = dbContext.Database.SqlQuery<BackOrder.BackOrderAddItemResponse>(sql.ToString(),
                                                                                new SqlParameter("ClubCode", data.ClubCode),
                                                                                new SqlParameter("UploadID", data.UploadID),
                                                                                new SqlParameter("GroupIDList", data.GroupIDList),
                                                                                new SqlParameter("RecordIDList", data.RecordIDList),
                                                                                new SqlParameter("ItemType", data.ItemType),
                                                                                new SqlParameter("ItemID", data.ItemID),
                                                                                new SqlParameter("Note", data.Note),
                                                                                new SqlParameter("IsRun", data.IsRun)).ToList();
                    return returnData;
                }
                else
                {
                    var cmd = dbContext.Database.Connection.CreateCommand();
                    cmd.CommandText = "dbo.OPS_BackOrder_AddItem";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("ClubCode", data.ClubCode),
                        new SqlParameter("UploadID", data.UploadID),
                        new SqlParameter("GroupIDList", data.GroupIDList),
                        new SqlParameter("RecordIDList", data.RecordIDList),
                        new SqlParameter("ItemType", data.ItemType),
                        new SqlParameter("ItemID", data.ItemID),
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
                    //reader.NextResult();
                    reader.NextResult();

                    // Read second model --> Bar
                    var ret = ((IObjectContextAdapter)dbContext)
                        .ObjectContext
                        .Translate<BackOrder.BackOrderAddItemResponse>(reader);
                    return ret.ToList();
                }
            }
        }

        [Route("changeBackOrderRemoveItem")]
        public List<BackOrder.BackOrderRemoveItemResponse> ChangeBackOrderRemoveItem(BackOrder.BackOrderRemoveItemRequest data)
        {
            using (var dbContext = new Csversion1Entities())
            {
                var sql = new StringBuilder();
                sql.Append("EXEC dbo.OPS_BackOrder_RemoveItem @ClubCode,");
                sql.Append("@UploadID,@GroupIDList,@RecordIDList,@ItemType,@ItemIDList,@Note,@IsRun");
                if (!data.IsRun)
                {
                    dbContext.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
                    var returnData = dbContext.Database.SqlQuery<BackOrder.BackOrderRemoveItemResponse>(sql.ToString(),
                                                                                new SqlParameter("ClubCode", data.ClubCode),
                                                                                new SqlParameter("UploadID", data.UploadID),
                                                                                new SqlParameter("GroupIDList", data.GroupIDList),
                                                                                new SqlParameter("RecordIDList", data.RecordIDList),
                                                                                new SqlParameter("ItemType", data.ItemType),
                                                                                new SqlParameter("ItemIDList", data.ItemIDList),
                                                                                new SqlParameter("Note", data.Note),
                                                                                new SqlParameter("IsRun", data.IsRun)).ToList();
                    return returnData;
                }
                else
                {
                    var cmd = dbContext.Database.Connection.CreateCommand();
                    cmd.CommandText = "dbo.OPS_BackOrder_RemoveItem";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("ClubCode", data.ClubCode),
                        new SqlParameter("UploadID", data.UploadID),
                        new SqlParameter("GroupIDList", data.GroupIDList),
                        new SqlParameter("RecordIDList", data.RecordIDList),
                        new SqlParameter("ItemType", data.ItemType),
                        new SqlParameter("ItemIDList", data.ItemIDList),
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
                    //reader.NextResult();
                    reader.NextResult();

                    // Read second model --> Bar
                    var ret = ((IObjectContextAdapter)dbContext)
                        .ObjectContext
                        .Translate<BackOrder.BackOrderRemoveItemResponse>(reader);
                    return ret.ToList();
                }
            }
        }

    }
}
