using SQLite.Net.Interop;

namespace CrudSQLite
{
	public interface IConfig
	{
		string SQLiteDirectory { get; }
		ISQLitePlatform Platform { get; }
	}
}
