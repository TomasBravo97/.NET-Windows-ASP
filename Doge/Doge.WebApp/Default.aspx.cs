using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Doge.Model;

namespace Doge.WebApp
{
    public partial class _Default : Page
    {
        public List<Order> ordersList = new List<Order>();
        protected void Page_Load(object sender, EventArgs e)
        {
            var baseDate = new DateTime(1970, 01, 01);
            var toDate = new DateTime(2023, 05, 2);
            var numberOfSeconds = toDate.Subtract(baseDate).TotalSeconds;
            ordersList.Add(new Order("ORD- 123827918346128", (long)(numberOfSeconds), "1285 Oviedo Mall Blvd Oviedo FL 32765"));

            baseDate = new DateTime(1970, 01, 01);
            toDate = new DateTime(2023, 06, 2);
            numberOfSeconds = toDate.Subtract(baseDate).TotalSeconds;
            ordersList.Add(new Order("ORD- 12382791834120", (long)(numberOfSeconds), "8731 West 95th Street Overland Park KS 66212"));


            baseDate = new DateTime(1970, 01, 01);
            toDate = new DateTime(2023, 06, 15);
            numberOfSeconds = toDate.Subtract(baseDate).TotalSeconds;
            ordersList.Add(new Order("ORD- 123827918346189", (long)(numberOfSeconds), "201 East Bay State Street Alhambra CA 91801"));


        }
    }
}