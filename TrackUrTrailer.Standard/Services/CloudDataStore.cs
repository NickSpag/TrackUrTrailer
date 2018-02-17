using System;
using System.Net.Http;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.Connectivity.Abstractions;
using Plugin.Connectivity;
using Newtonsoft.Json;

namespace TrackUrTrailer.Standard
{
    public class CloudDataStore : IDataStore<TUTOrder>
    {
        private HttpClient client;
        private IEnumerable<TUTOrder> cachedOrders;

        private bool isConnected => CrossConnectivity.Current.IsConnected;

        private bool hasCached = false;

        public CloudDataStore()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri($"{Help.API.BackEndUrl}");

            cachedOrders = new List<TUTOrder>();
        }

        public async Task<bool> AddOrderAsync(TUTOrder item)
        {
            //if (!isConnected) return false;

            throw new NotImplementedException();
        }

        public async Task<bool> DeleteOrderAsync(string id)
        {
            //if (!isConnected) return false;

            throw new NotImplementedException();
        }

        public async Task<TUTOrder> GetOrderAsync(string id)
        {
            if (!isConnected || string.IsNullOrEmpty(id)) return null;

            var json = await client.GetStringAsync($"api/order/{id}");
            return await Task.Run(() => JsonConvert.DeserializeObject<TUTOrder>(json));
        }

        public async Task<IEnumerable<TUTOrder>> GetOrdersAsync(bool forceRefresh = false)
        {
            if (isConnected && forceRefresh && !hasCached)
            {
                var json = await client.GetStringAsync($"api/orders");
                cachedOrders = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<TUTOrder>>(json));
                hasCached = true;
            }

            return cachedOrders;
        }

        public async Task<bool> UpdateOrderAsync(TUTOrder item)
        {
            //if (!isConnected) return false;

            throw new NotImplementedException();
        }

        public IEnumerable<TUTOrder> GetCachedOrders() => cachedOrders;
    }
}
