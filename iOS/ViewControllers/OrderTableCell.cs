// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using TrackUrTrailer.Standard;

namespace TrackUrTrailer.iOS
{
    public partial class OrderTableCell : UITableViewCell
    {


        public OrderTableCell(IntPtr handle) : base(handle)
        {

        }

        public void UpdateItem(TUTOrder order)
        {
            deliveryLocationLabel.Text = order.DeliveryAddress.Line1;
            statusLabel.Text = order.Status;
            orderNumberLabel.Text = $"#{order.Id}";
            productTypeIcon.Image = UIImage.FromFile("gas.png");
        }
    }
}
