using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApplication.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method returns a strings when receiving a get request 
        /// <example>GET api/Hostingcost</example>
        ///</summary>
        /// <returns> { "Hosting Cost" } </returns>
        public IEnumerable<string> GET()
        {
            return new string[] { "Hosting Cost" };
        }

        /// <summary>
        /// This method returns one array of strings when receiving a get request 
        /// <example>GET api/hostingcost/{id}</example>
        ///</summary>
        /// <returns>  {days + " fortnights at $5.50 " + "/FN = " + baseChargeRounded + " CAD ",
        /// "HST 13%  = " + hstRounded + "CAD","Total = " + roundedTotal}
        /// </returns>

        public string[] GET(double id)
        {
            double FORT_NIGHT = 5.50;
            double TAX = 13;
            double days = calcElapsedDays(id);
            double hst = (FORT_NIGHT / 100) * TAX * days;
            double hstRounded = Math.Round(hst, 2);
            double totalCharged = calcTotalCharged(id, FORT_NIGHT, hst);
            double roundedTotal = Math.Round(totalCharged, 2);
            double baseCharge = FORT_NIGHT * days;
            string baseChargeRounded = string.Format("{0:C}", Convert.ToDecimal(baseCharge));

            return new string[]
            {
             days + " fortnights at $5.50 " + "/FN = " + baseChargeRounded + " CAD ",
             "HST 13%  = " + hstRounded + "CAD",
             "Total = " + roundedTotal
            };
        }

        private double calcElapsedDays(double id)
        {
            double days = 0;
            if (id == 0 || id <= 13)
            {
                days = 1;
            }
            else if (id >= 14 && id <= 27)
            {
                days = 2;
            }
            else if (id >= 28)
            {
                days = 3;
            }

            return days;
        }

        private double calcTotalCharged(double id, double forNight, double hst)
        {
            double total = 0;
            if (id == 0 && id <= 13)
            {
                total = (1 * forNight) + hst;
            }
            else if (id >= 14 && id <= 27)
            {
                total = (2 * forNight) + hst;
            }
            else if (id >= 28)
            {
                total = (3 * forNight) + hst;
            }
            return total;
        }
    }
}
