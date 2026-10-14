using SelfOrderSystem.Models;

namespace SelfOrderSystem.ViewModels;

public class MenuViewModel
{
    public List<Category> Categories { get; set; } = new();
    public List<Product> Products { get; set; } = new();
    public int? SelectedCategoryId { get; set; }
}
