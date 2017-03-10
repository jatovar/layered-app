using SQLite.Net.Attributes;

namespace LayeredApp.BL.Contracts
{
	public abstract class BusinessEntityBase : IBusinessEntity
	{
		public BusinessEntityBase() { }
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
	}
}
