using TPF.FFTools.Data;
using WIP.Data.Infrastructure.Abstract;

namespace WIP.Data.Infrastructure
{
	public class DbFactory : Disposable, IDbFactory
	{
		Tpf2003Entities tpf2003DbContext;

		public Tpf2003Entities InitTpf2003DbContext()
		{
			return tpf2003DbContext ?? (tpf2003DbContext = new Tpf2003Entities());
		}

		Csversion1Entities csVesrion1DbContext;
		public Csversion1Entities InitCsversion1DbContext()
		{
			return csVesrion1DbContext ?? (csVesrion1DbContext = new Csversion1Entities());
		}

		//TpfsystemEntities tpfSystemDbContext;
		//public TpfsystemEntities InitTpfSystemDbContext()
		//{
		//	return tpfSystemDbContext ?? (tpfSystemDbContext = new TpfsystemEntities());
		//}

		//WarehouseEntities whDbContext;
		//public WarehouseEntities InitWhDbContext()
		//{
		//	return whDbContext ?? (whDbContext = new WarehouseEntities());
		//}

		protected override void DisposeCore()
		{
			if (tpf2003DbContext != null)
				tpf2003DbContext.Dispose();

			if (csVesrion1DbContext != null)
				csVesrion1DbContext.Dispose();

			//if (tpfSystemDbContext != null)
			//	tpfSystemDbContext.Dispose();

			//if (whDbContext != null)
			//	whDbContext.Dispose();
		}
	}
}
