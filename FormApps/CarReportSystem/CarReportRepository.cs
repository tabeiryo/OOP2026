using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem
{
    public class CarReportRepository
    {
        public List<CarReport> GetALL()
        {
            var carReports = new List<CarReport>();
            using var connection = Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                """
SELECT  Id,Date,Author,Maker,CarName,Report,Picture
FROM    CarReports
ORDER   BY  Id;
""";
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                carReports.Add(new CarReport
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Price = reader.GetInt32(2)
                });
            }
            return products;
        }
        //登録
        public int Add(string name, int price)
        {
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
            var result = command.ExecuteScalar();

            if (result is null)
            {
                throw new InvalidOperationException("登録した商品のIDを取得できませんでした。");
            }
            return Convert.ToInt32((long)result);
        }
        //修正
        public void Update(Product product)
        {
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
            command.Parameters.AddWithValue("$name", product.Name);
            command.Parameters.AddWithValue("$price", product.Price);
            command.Parameters.AddWithValue("$id", product.Id);

            if (command.ExecuteNonQuery() == 0)
                throw new InvalidOperationException("修正対象が見つかりませんでした。");
        }
        public void Delete(int id)
        {
            using var connection = Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                """
DELETE  FROM Products
WHERE   Id =$id;
""";
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }
    }
}
