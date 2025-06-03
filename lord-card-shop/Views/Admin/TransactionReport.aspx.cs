
using lord_card_shop.Dataset;
using lord_card_shop.Model;
using lord_card_shop.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Admin
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        LocalDatabaseEntities db = new LocalDatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            DataSet1 ds = GetAllData();
            report.SetDataSource(ds);
        }

        public DataSet1 GetAllData()
        {
            DataSet1 dataset = new DataSet1();
            var headertable = dataset.TransactionHeader;
            var detailtable = dataset.TransactionDetail;

            List<TransactionHeader> transaction;
            transaction = db.TransactionHeaders.ToList();

            foreach (TransactionHeader mst in transaction)
            {
                var hrow = headertable.NewRow();
                hrow["TransactionId"] = mst.TransactionID;
                hrow["TransactionDate"] = mst.TransactionDate;
                hrow["CustomerId"] = mst.CustomerID;
                hrow["Status"] = mst.Status;
                headertable.Rows.Add(hrow);

                foreach (TransactionDetail mstd in mst.TransactionDetails)
                {
                    var drow = detailtable.NewRow();
                    drow["TransactionId"] = mstd.TransactionID;
                    drow["CardID"] = mstd.CardID;
                    drow["Quantity"] = mstd.Quantity;
                    detailtable.Rows.Add(drow);
                }
            }

            return dataset;
        }
    }
}