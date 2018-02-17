// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TrackUrTrailer.iOS
{
    [Register("OrderTableCell")]
    partial class OrderTableCell
    {
        [Outlet]
        UIKit.UILabel deliveryLocationLabel { get; set; }

        [Outlet]
        UIKit.UILabel orderNumberLabel { get; set; }

        [Outlet]
        UIKit.UIImageView productTypeIcon { get; set; }

        [Outlet]
        UIKit.UIProgressView progress { get; set; }

        [Outlet]
        UIKit.UILabel statusLabel { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (orderNumberLabel != null)
            {
                orderNumberLabel.Dispose();
                orderNumberLabel = null;
            }

            if (statusLabel != null)
            {
                statusLabel.Dispose();
                statusLabel = null;
            }

            if (deliveryLocationLabel != null)
            {
                deliveryLocationLabel.Dispose();
                deliveryLocationLabel = null;
            }

            if (progress != null)
            {
                progress.Dispose();
                progress = null;
            }

            if (productTypeIcon != null)
            {
                productTypeIcon.Dispose();
                productTypeIcon = null;
            }
        }
    }
}
