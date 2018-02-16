using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrackUrTrailer.Standard
{
    public interface IDataStore<T>
    {
        Task<bool> AddOrderAsync(T item);
        Task<bool> UpdateOrderAsync(T item);
        Task<bool> DeleteOrderAsync(string id);
        Task<T> GetOrderAsync(string id);

        IEnumerable<T> GetCachedOrders();

        Task<IEnumerable<T>> GetOrdersAsync(bool forceRefresh = false);
    }
}
