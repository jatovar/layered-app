using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredApp.BL.Models;
using SQLite.Net.Interop;

using SQLite;
using SQLite.Net.Async;

namespace LayeredApp.DL
{
	class LocationDatabase : SQLiteAsyncConnection
	{

		/// <summary>
		/// Location database builds on SQLite.Net and represents our Location Database 
		/// It contains methods for retrival and persistance as well as db creation,
		/// all based on the underlying ORM
		/// </summary>
		/// <param name="path">Path</param>
		/// <param name="platform">Platform</param>
		public LocationDatabase (ISQLitePlatform sqLitePlatform, string applicationPath, string databaseName) :
			base (createSQLiteConnectionWithLock(sqLitePlatform, applicationPath, databaseName))
		{
			CreateTableAsync<Location>();	
		}

		private static Func<SQLiteConnectionWithLock> createSQLiteConnectionWithLock(ISQLitePlatform sqLitePlatform, string applicationPath, string databaseName)
		{
			return () => new SQLiteConnectionWithLock(sqLitePlatform,
				new SQLiteConnectionString(
					System.IO.Path.Combine(applicationPath, databaseName), storeDateTimeAsTicks: false));
		}

	}
}
