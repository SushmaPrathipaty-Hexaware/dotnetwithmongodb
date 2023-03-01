using MongoDB.Driver;

namespace dotnetwithmongodb.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
