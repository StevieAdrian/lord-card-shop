using lord_card_shop.Dataset;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Customer
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        LocalDatabaseEntities db = new LocalDatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionReport report = new TransactionReport();
            CrystalReportViewer.ReportSource = report;
        }

        TransactionDataset GetData()
        {
            TransactionDataset dataset = new TransactionDataset();
            var header = dataset.TransactionHeader;
            var detail = dataset.TransactionDetail;

            db.TransactionHeaders.ToList().ForEach(x =>
            {
                var headerRow = header.NewRow();
                headerRow[0] = x.TransactionID;
                headerRow[1] = x.TransactionDate;
                headerRow[2] = x.CustomerID;
                headerRow[3] = x.Status;

                header.Rows.Add(headerRow);
            });

            db.TransactionDetails.ToList().ForEach(x =>
            {
                var detailRow = header.NewRow();
                detailRow[0] = x.TransactionID;
                detailRow[1] = x.CardID;
                detailRow[2] = x.Quantity;
                detailRow[3] = x.Card.CardPrice;
                detailRow[4] = x.Quantity * x.Card.CardPrice;

                header.Rows.Add(detailRow);
            });

            return dataset;
        }
    }
}