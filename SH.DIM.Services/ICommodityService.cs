
using SH.DIM.DataAccess.Entities;

namespace SH.DIM.Services;

public class CommodityService : ICommodityService
{
    public IEnumerable<Commodity> GetCommodities()
    {
        throw new NotImplementedException();
    }
}
public interface ICommodityService
{
    IEnumerable<Commodity> GetCommodities();
}
