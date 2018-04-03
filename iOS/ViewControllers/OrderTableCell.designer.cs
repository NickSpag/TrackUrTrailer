// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TrackUrTrailer.iOS
{
    [Register ("OrderTableCell")]
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

        void ReleaseDesignerOutlets ()
        {
            if (deliveryLocationLabel != null) {
                deliveryLocationLabel.Dispose ();
                deliveryLocationLabel = null;
            }

            if (orderNumberLabel != null) {
                orderNumberLabel.Dispose ();
                orderNumberLabel = null;
            }

            if (productTypeIcon != null) {
                productTypeIcon.Dispose ();
                productTypeIcon = null;
            }

            if (progress != null) {
                progress.Dispose ();
                progress = null;
            }

            if (statusLabel != null) {
                statusLabel.Dispose ();
                statusLabel = null;
            }
        }
    }
}