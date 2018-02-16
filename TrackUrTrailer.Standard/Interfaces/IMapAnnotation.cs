using System;
using System.Threading.Tasks;

namespace TrackUrTrailer.Standard
{
    public interface IMapAnnotation
    {
        void FromVehicle(DeliveryVehicle title);

        Task FromLocation(DeliveryAddress address);

    }
}
