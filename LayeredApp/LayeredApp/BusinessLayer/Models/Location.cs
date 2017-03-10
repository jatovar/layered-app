using LayeredApp.BL.Contracts;
using SQLite.Net.Attributes;

namespace LayeredApp.BL.Models
{
	public class Location : IBusinessEntity
	{
		public Location()
		{

		}
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public short Type { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }

	}
}
