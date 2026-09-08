using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Configuration;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                    
                    Date = reader.GetDateTime(1),
                    Author = reader.GetString(2),
                    Maker = (CarReport.MakerGroup)reader.GetInt32(3),
                    CarName = reader.GetString(4),
                    Report = reader.GetString(5),
                    Picture = BytesToImage(reader.GetByte(6))
                   
                });
            }
            return carReports;
        }

        private Image BytesToImage(byte v)
        {
            
                Byte[] bytes = new Byte[v];
                return BytesToImage(bytes);
            
            }

        //登録
        public int Add( DateTime Date,string Author,CarReport.MakerGroup Maker,string CarName,string Report,Image Picture)
        {
            using var connection = Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                """
INSERT INTO CarReports
(Date,Author,Maker,CarName,Report,Picture)
VALUES  
($date,$author,$maker,$carName,$report,$picture);

SELECT last_insert_rowid();
""";

            command.Parameters.AddWithValue("$date", Date);
            command.Parameters.AddWithValue("$author", Author);
            command.Parameters.AddWithValue("$maker", Maker);
            command.Parameters.AddWithValue("$carName", CarName);
            command.Parameters.AddWithValue("$report", Report);
            command.Parameters.AddWithValue("$picture",Picture);
            var result = command.ExecuteScalar();

            if (result is null)
            {
                throw new InvalidOperationException("登録した商品のIDを取得できませんでした。");
            }
            return Convert.ToInt32((long)result);
        }
        //修正
        public void Update(CarReport carReport)
        {
            using var connection = Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                """
UPDATE CarReports
SET Date = $date,Autor = $author,Maker = $maker,CarName = $carName,
Report = $report,Picture = $picture
WHERE Id =$id;
""";
            command.Parameters.AddWithValue("$date", carReport.Date);
            command.Parameters.AddWithValue("$author", carReport.Author);
            command.Parameters.AddWithValue("$maker", carReport.Maker);
            command.Parameters.AddWithValue("$carName", carReport.CarName);
            command.Parameters.AddWithValue("$report", carReport.Report);
            command.Parameters.AddWithValue("$picture", carReport.Picture);
            command.Parameters.AddWithValue("$id", carReport.Id);

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
DELETE  FROM CarReports
WHERE   Id =$id;
""";
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        // ImageをSQLiteへ保存できるbyte[]へ変換する
        private static byte[]? ImageToBytes(Image? image)
        {
            if (image is null) return null;

            using var stream = new MemoryStream();
            // DBへはPNG形式で保存
            image.Save(stream, ImageFormat.Png);
            return stream.ToArray();
        }

        // SQLiteのBLOB（byte[]）をImageへ変換する
        private static Image BytesToImage(byte[] data)
        {
            using var stream = new MemoryStream(data);
            using var image = Image.FromStream(stream);
            // MemoryStream破棄後も利用できるようBitmapとしてコピーする。
            return new Bitmap(image);
        }
    }
    }
