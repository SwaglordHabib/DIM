
using MongoDB.Driver;
using SH.DIM.DataAccess.Entities;
using SH.DIM.Models.Contracts;

namespace SH.DIM.Services;

public class CommodityService : ICommodityService
{
    private readonly IMongoCollection<Commodity> _commodities;

    public CommodityService(IDatabaseSettings databaseSettings)
    {
        var client = new MongoClient(databaseSettings.ConnectionString);
        var database = client.GetDatabase(databaseSettings.DatabaseName);

        _commodities = database.GetCollection<Commodity>(databaseSettings.CollectionName);

    }
    public Commodity Create(Commodity commodity)
    {
        _commodities.InsertOne(commodity);
        return commodity;
    }

    public Commodity Get(string id)
    {
        return _commodities.Find(c => c.Id == id).FirstOrDefault();
    }

    public IEnumerable<Commodity> GetAll()
    {
        return _commodities.Find(c => true).ToList();
    }

    public void Remove(string id)
    {
        _commodities.DeleteOne(c => c.Id == id);
    }

    public void Remove(Commodity commodity)
    {
        _commodities.DeleteOne(c => c.Id == commodity.Id);
    }

    public void Update(string id, Commodity commodity)
    {
        _commodities.ReplaceOne(c => c.Id == id, commodity);
    }
}
public interface ICommodityService
{
    IEnumerable<Commodity> GetAll();
    Commodity Get(string id);
    Commodity Create(Commodity commodity);
    void Update(string id, Commodity commodity);
    void Remove(string id);
    void Remove(Commodity commodity);
}
