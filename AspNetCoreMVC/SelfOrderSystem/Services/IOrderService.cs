using SelfOrderSystem.Models;

namespace SelfOrderSystem.Services;

public interface IOrderService
{
    Task<PlaceOrderResult> PlaceAsync(      // 注文を確認してDBへ保存する 
    List<CartItem> cartItems,           // Sessionから取得したカート 
    int tableNumber);                   // 入力されたテーブル番号 
}
