using System.ComponentModel;

namespace SQLiteProductSample;

public class Product
{
    [DisplayName("è§ïiID")]
    public int Id { get; set; }
    [DisplayName("è§ïiñº")]
    public string Name { get; set; }= string .Empty;
    [DisplayName("âøäi")]
    public int price { get; set; }
}
