using System;
using System.Runtime.CompilerServices;
namespace TrackUrTrailer.Standard
{
    public enum Module
    {
        DeliveryList,
        Orders,
        Map,
    }


    public static partial class Extensions
    {
        public static string StoryBoardId(this Module module)
        {
            switch (module)
            {
                case Module.DeliveryList:
                    return "deliveryListVC";
                case Module.Map:
                    return "mapVC";
                case Module.Orders:
                    return "ordersVC";
                default:
                    return "";
            }
        }

        public static string Name(this Module module)
        {
            switch (module)
            {
                case Module.Map:
                    return "Map";
                case Module.Orders:
                    return "Orders";

                case Module.DeliveryList:
                default:
                    return "";
            }
        }
    }
}
