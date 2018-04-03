using System;
using Foundation;
using UIKit;
using System.Collections.Generic;
using System.Linq;
using TrackUrTrailer.Standard;

namespace TrackUrTrailer.iOS
{
    public class TUTTableViewDataSource<T> : NSObject, IUITableViewDataSource
        where T : TUTOrder
    {
        private bool registered = false;
        private IList<T> items;

        public TUTTableViewDataSource(IList<T> items)
        {
            this.items = items;
        }

        #region IUITableViewDataSource-Required Methods
        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            //if (!registered) tableView.RegisterClassForCellReuse(typeof(OrderTableCell), "OrderCell");

            var item = items[(int)indexPath.Item];

            var cell = tableView.DequeueReusableCell("OrderCell", indexPath) as OrderTableCell;
            cell.UpdateItem(item);

            return cell;
        }
        #endregion

        public nint RowsInSection(UITableView tableView, nint section) => items?.Count<T>() ?? 0;
    }
}
