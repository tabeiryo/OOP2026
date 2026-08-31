using Microsoft.Data.Sqlite;

namespace SQLiteProductSample;

public class ProductRepository
{
    public List<Product> GetALL() {
        var products = new List<Product>();
    using var connection = Database.GetConnection();
        connection.Open();

    using var command = connection.CreateCommand();
        command.CommandText =
            """
SELECT  Id, Name,   Price
FROM    Products
ORDER   BY  Id;
""";
        using var reader = command.ExecuteReader();

        while (reader.Read()) { 
        products.Add(new Product{ 
            Id=reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Price=reader.GetInt32(2)
            });
        }
        return products;
    }
}
