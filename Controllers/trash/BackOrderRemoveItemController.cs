//using System;
//using System.Collections.Generic;
//using System.Data.Entity.Core.Objects;
//using System.Data.Entity.Infrastructure;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Web.Http;
//using System.Web.Services.Description;
//using TPF.FFTools.Data;
//using TPF.FFTools.Models;

//namespace TPF.FFTools.Controllers
//{
//    [RoutePrefix("backOrderRemoveItem")]
//    public class BackOrderRemoveItemController : ApiController
//    {
//        [HttpPost]
//        [Route("changeBackOrderRemoveItem")]
//        public List<BackOrder.BackOrderRemoveItemResponse> ChangeBackOrderRemoveItem(BackOrder.BackOrderRemoveItemRequest data)
//        {
//            using (var dbContext = new Csversion1Entities())
//            {
//                var sql = new StringBuilder();
//                sql.Append("EXEC dbo.OPS_BackOrder_RemoveItem @ClubCode,");
//                sql.Append("@UploadID,@GroupIDList,@RecordIDList,@ItemType,@ItemIDList,@Note,@IsRun");
//                if (!data.IsRun)
//                {
//                    dbContext.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
//                    var returnData = dbContext.Database.SqlQuery<BackOrder.BackOrderRemoveItemResponse>(sql.ToString(),
//                                                                                new SqlParameter("ClubCode", data.ClubCode),
//                                                                                new SqlParameter("UploadID", data.UploadID),
//                                                                                new SqlParameter("GroupIDList", data.GroupIDList),
//                                                                                new SqlParameter("RecordIDList", data.RecordIDList),
//                                                                                new SqlParameter("ItemType", data.ItemType),
//                                                                                new SqlParameter("ItemIDList", data.ItemIDList),
//                                                                                new SqlParameter("Note", data.Note),
//                                                                                new SqlParameter("IsRun", data.IsRun)).ToList();
//                    return returnData;
//                }
//                else
//                {
//                    var cmd = dbContext.Database.Connection.CreateCommand();
//                    cmd.CommandText = "dbo.OPS_BackOrder_RemoveItem";
//                    cmd.CommandType = CommandType.StoredProcedure;
//                    cmd.Parameters.AddRange(new SqlParameter[]
//                    {
//                        new SqlParameter("ClubCode", data.ClubCode),
//                        new SqlParameter("UploadID", data.UploadID),
//                        new SqlParameter("GroupIDList", data.GroupIDList),
//                        new SqlParameter("RecordIDList", data.RecordIDList),
//                        new SqlParameter("ItemType", data.ItemType),
//                        new SqlParameter("ItemIDList", data.ItemIDList),
//                        new SqlParameter("Note", data.Note),
//                        new SqlParameter("IsRun", data.IsRun)
//                    });

//                    //var adapter = new SqlDataAdapter();
//                    //adapter.SelectCommand = cmd;

//                    // execute your command
//                    dbContext.Database.Connection.Open();
//                    var reader = cmd.ExecuteReader();

//                    // move to next result set
//                    //reader.NextResult();
//                    //reader.NextResult();
//                    reader.NextResult();

//                    // Read second model --> Bar
//                    var ret = ((IObjectContextAdapter)dbContext)
//                        .ObjectContext
//                        .Translate<BackOrder.BackOrderRemoveItemResponse>(reader);
//                    return ret.ToList();
//                }
//            }
//        }
//    }
//}
