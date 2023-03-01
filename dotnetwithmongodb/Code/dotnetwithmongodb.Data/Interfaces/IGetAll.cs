using System.Collections.Generic;

namespace dotnetwithmongodb.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
