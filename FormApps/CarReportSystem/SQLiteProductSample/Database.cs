using Microsoft.Data.Sqlite;

namespace SQLiteProductSample;

public static class Database
{
    //DB保存
    private static readonly string DatabesePath = Path.Combine(AppContext.BaseDirectory, "products.db");
    //接続文字列
    private static readonly string ConnectionString = $"Data Source={DatabesePath}";
    //外部空確認
    public static string FilePath => DatabesePath;

    public static SqliteConnection GetConnection() {
    return new SqliteConnection(ConnectionString);
    }

    public static void Initialize() {
        using var connection = GetConnection() ;
        connection.Open();
        //実行するためのコマンドオブジェクト
        using var command = connection.CreateCommand();
        //producttableをつくるsql
        command.CommandText =
            """
CREATE TABLE IF NOT EXISTS Products(
Id   INTEGER PRIMARY KEY AUTOINCREMENT,
Name TEXT NOT NULL,
Price INTEGER NOT NULL CHECK (Price >= 0)
);
""";
        command.ExecuteNonQuery();
    }
    

}
