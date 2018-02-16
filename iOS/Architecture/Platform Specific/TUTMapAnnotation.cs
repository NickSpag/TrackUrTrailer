using CoreLocation;
using MapKit;
using TrackUrTrailer.Standard;
using System.Threading.Tasks;
using System.Linq;

namespace TrackUrTrailer.iOS
{
    public class TUTMapAnnotation : MKAnnotation, IMapAnnotation
    {
        private CLLocationCoordinate2D _coordinate;
        private string _title;
        private string _subtitle;

        #region MKAnnotation Requirements
        public override CLLocationCoordinate2D Coordinate => _coordinate;
        public override void SetCoordinate(CLLocationCoordinate2D value) => _coordinate = value;

        public override string Title => _title;
        public override string Subtitle => _subtitle;
        #endregion

        #region Constructors
        public TUTMapAnnotation()
        {

        }

        public void FromVehicle(DeliveryVehicle vehicle)
        {
            _coordinate = new CLLocationCoordinate2D(vehicle.CurrentLocation.Latitude,
                                                     vehicle.CurrentLocation.Longitude);

            _title = "Vehicle";

        }

        public async Task FromLocation(DeliveryAddress address)
        {
            //geocode address string
            var geocoder = new CLGeocoder();

            var placemark = await geocoder.GeocodeAddressAsync($"{address.Line1}, {address.City}, {address.State}");

            if (placemark.FirstOrDefault() is CLPlacemark topResult)
            {
                _coordinate = topResult.Location.Coordinate;
                _title = "Delivery";
                _subtitle = $"{address}";
            }
        }

        //public static TUTMapAnnotation FromLocationAndDetail(CLLocationCoordinate2D coordinate, string title, string subtitle)
        //{
        //    return new TUTMapAnnotation()
        //    {
        //        _coordinate = coordinate,
        //        _title = title,
        //        _subtitle = subtitle
        //    };
        //}
        #endregion



    }
}
