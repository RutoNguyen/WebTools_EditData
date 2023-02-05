using TPF.FFTools.Data;

namespace WIP.Data.Infrastructure.Abstract
{
	public interface IDbFactory
	{
		Tpf2003Entities InitTpf2003DbContext();
		Csversion1Entities InitCsversion1DbContext();
		//TpfsystemEntities InitTpfSystemDbContext();
		//WarehouseEntities InitWhDbContext();
	}
}
