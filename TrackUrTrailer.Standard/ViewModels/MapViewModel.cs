using System;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Linq;

namespace TrackUrTrailer.Standard
{
    public class MapViewModel : BaseViewModel
    {
        IDataStore<TUTOrder> dataStore;

        public (double longitude, double lattidue) CenteringCoordinates
        {
            get
            {
                if (dataStore?.GetCachedOrders().FirstOrDefault() is TUTOrder order)
                {
                    return (order.DeliveryVehicle.CurrentLocation.Latitude,
                            order.DeliveryVehicle.CurrentLocation.Longitude);
                }
                else return (0, 0);
            }
        }

        public ObservableCollection<IMapAnnotation> Annotations = new ObservableCollection<IMapAnnotation>();

        public MapViewModel()
        {
            dataStore = Help.Dependencies.GetInstance<IDataStore<TUTOrder>>();

            ConfigureDataStore();
        }

        public async Task GetData()
        {
            await dataStore.GetOrdersAsync();
            await CreateAnnotations();
        }

        private void ConfigureDataStore()
        {
            if (Help.Dependencies.GetInstance<IDataStore<TUTOrder>>() is IDataStore<TUTOrder> data)
            {
                this.dataStore = data;
            }
            else
                throw new Exception("Failure: IDataStore<TUTOrder> not registered at time of MapVM construction");
        }

        private async Task CreateAnnotations()
        {
            var orders = await dataStore.GetOrdersAsync(true);

            foreach (var order in orders)
            {
                var annotation = Help.Dependencies.GetInstance<IMapAnnotation>();
                await annotation.FromLocation(order.DeliveryAddress);

                Annotations.Add(annotation);
            }

            //add one delivery vehicle annotation, from the first order. for test purposes. will fix api later
            //var vehicleAnnotation = Help.Dependencies.GetInstance<IMapAnnotation>();
            //vehicleAnnotation.FromVehicle(orders.FirstOrDefault().DeliveryVehicle);

            //Annotations.Add(vehicleAnnotation);
        }
    }
}
