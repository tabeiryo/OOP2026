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
    //ìoò^
    public int Add(string name,int price) {
    using var connection = Database.GetConnection();
        connection.Open();

    using var command = connection.CreateCommand();
        command.CommandText =
            """
INSERT INTO Products(Name,Price)
VALUES  ($name,$price);

SELECT last_insert_rowid();
""";

        command.Parameters.AddWithValue("$name", name);
        command.Parameters.AddWithValue("$price", price);
        var result =command.ExecuteScalar();

        if (result is null)
        {
            throw new InvalidOperationException("ìoò^ÇµÇΩè§ïiÇÃIDÇéÊìæÇ≈Ç´Ç‹ÇπÇÒÇ≈ÇµÇΩÅB");
        }
        return Convert.ToInt32 ((long)result);
    }
    //èCê≥
    public void Update(Product product) {
        using var connection = Database.GetConnection();
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText =
            """
UPDATE Products
SET Name = $name,
    Price = $price
WHERE Id =$id;
""";
        command.Parameters.AddWithValue("$name",product.Name);
        command.Parameters.AddWithValue("$price",product.Price);
        command.Parameters.AddWithValue("$id",product.Id);

        if (command.ExecuteNonQuery() == 0)
            throw new InvalidOperationException("èCê≥ëŒè€Ç™å©Ç¬Ç©ÇËÇ‹ÇπÇÒÇ≈ÇµÇΩÅB");
    }
    public void Delete(int id) {
        using var connection = Database.GetConnection();
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText =
            """
DELETE  FROM Products
WHERE   Id =$id;
""";
        command.Parameters.AddWithValue("$id",id);
        command.ExecuteNonQuery();
    }
}
