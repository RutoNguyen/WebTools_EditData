using WIP.Data.Infrastructure.Abstract;
using WIP.Data.Infrastructure.Abstract.Shipping.Data.Infrastructure.Abstract;

using TPF.FFTools.App.Infrastructure;
using TPF.FFTools.Data;

namespace TPF.FFTools.App.Infrastructure
{
	public class UnitOfWork : IUnitOfWork
	{
		readonly IDbFactory dbFactory;
		Tpf2003Entities tpf2003DbContext;
		//TpfsystemEntities tpfSystemDbContext;
		//WarehouseEntities whDbContext;

		public UnitOfWork(IDbFactory dbFactory)
		{
			this.dbFactory = dbFactory;
		}

		public Tpf2003Entities Tpf2003DbContext
		{
			get { return tpf2003DbContext ?? (tpf2003DbContext = dbFactory.InitTpf2003DbContext()); }
		}

		//public WarehouseEntities WhDbContext
		//{
		//	get { return whDbContext ?? (whDbContext = dbFactory.InitWhDbContext()); }
		//}

		//public TpfsystemEntities TpfSystemDbContext
		//{
		//	get { return tpfSystemDbContext ?? (tpfSystemDbContext = dbFactory.InitTpfSystemDbContext()); }
		//}


		//public void Commit()
		//{
		//	TpfSystemDbContext.SaveChanges();
		//}
		public void Commit()
		{
            Tpf2003DbContext.SaveChanges();

        }
	}
}
