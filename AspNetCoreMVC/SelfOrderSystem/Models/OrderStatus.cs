namespace SelfOrderSystem.Models;

public enum OrderStatus
{
    New = 0, // 新規注文
    Accepted =1, // 受付済み
    Cooking =2, // 調理中
    Served = 3  // 提供済み 
}
