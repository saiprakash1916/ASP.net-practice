using MVCDisplayStall.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDisplayStall.Controllers
{
    public class StallController : Controller
    {
        // GET: Stall
        public ActionResult Index()
        {
            string url = "https://app.e-box.co.in/uploads/stallxml.xml";
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(url);
            List<Stall> stalls = new List<Stall>();
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                stalls.Add(new Stall() { Name = dataRow["Name"].ToString(), Type = dataRow["Type"].ToString() });
            }
            return View(stalls);
        }
    }
}