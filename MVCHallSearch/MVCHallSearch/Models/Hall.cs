using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHallSearch.Models
{
    public class Hall
    {
		private string _hallName;
		private string _ownerName;
		private double _costPerDay;
		private string _mobileNumber;
		private string _address;

		public Hall()
		{
		}

		public string HallName { get => _hallName; set => _hallName = value; }
		public string OwnerName { get => _ownerName; set => _ownerName = value; }
		public double CostPerDay { get => _costPerDay; set => _costPerDay = value; }
		public string MobileNumber { get => _mobileNumber; set => _mobileNumber = value; }
		public string Address { get => _address; set => _address = value; }


		public Hall(string hallName, string ownerName, double costPerDay, string mobileNumber, string address)
		{
			HallName = hallName;
			OwnerName = ownerName;
			CostPerDay = costPerDay;
			MobileNumber = mobileNumber;
			Address = address;
		}
	}
}