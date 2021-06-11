using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProductReviewManagement_LINQ
{
    class ProductReviewDatatable
    {
        public void AddToDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("UserID");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("isLike");

            table.Rows.Add("1", "1","5","Good","True");
            table.Rows.Add("2", "1","5", "Nice", "True");
            table.Rows.Add("3", "1","5", "Not Good", "False");
            table.Rows.Add("3", "1","5", "Bad", "False");

        }
    }
}
