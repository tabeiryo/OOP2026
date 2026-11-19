using Microsoft.EntityFrameworkCore;
using SelfOrderSystem.Data;
using SelfOrderSystem.Services;
using SelfOrderSystem.Hubs; // Hub の名前空間
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using SelfOrderSystem.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// 追加
builder.Services.AddDbContext<AppDbContext>(
        options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );
/////////

builder.Services.AddDistributedMemoryCache(); // Session の保存領域としてアプリのメモリを使う
builder.Services.AddSession(options => // Session 機能を登録 
{
    options.IdleTimeout = TimeSpan.FromHours(2);    // 2 時間操作がなければ期限切れ
    options.Cookie.HttpOnly = true;                 // JavaScript からSession ID を読めないようにする
    options.Cookie.IsEssential = true;              // Session ID 用Cookie を必須Cookie として扱う
});
builder.Services.AddHttpContextAccessor(); // Controller 以外のクラスからHttpContext を取得できるようにする
builder.Services.AddScoped<CartService>(); // CartService をDI へ登録しControllerで受け取れるようにする


// builder.Services.AddScoped<CartService>(); の近くに追加 
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddSignalR(); // builder.Build()より前 

// スタッフのパスワード照合用のサービス 
builder.Services.AddScoped<IPasswordHasher<StaffUser>,
PasswordHasher<StaffUser>>();
// Cookie を使ったログイン方式を登録 
builder.Services.AddAuthentication(
CookieAuthenticationDefaults.AuthenticationScheme)
.AddCookie(options =>
{
    options.LoginPath = "/Account/Login";
    // 未ログイン時の遷移先 
    options.AccessDeniedPath = "/Account/Denied"; // 権限不足時の遷移先 
    options.Cookie.HttpOnly = true;
    // JavaScript から読み取り不可 
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // HTTPS 限定 
    options.ExpireTimeSpan = TimeSpan.FromHours(8); // 認証チケットの有効期間 
});
builder.Services.AddAuthorization();

var app = builder.Build();
// 既存の例外処理・HTTPS設定・静的ファイル設定は維持 
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
// 既存のカートSessionを有効にする 
app.UseAuthentication(); // 認証Cookie からログイン状態を復元 
app.UseAuthorization();  // Staff 権限などを検査 
// 既存のMapControllerRouteとMapHubは維持 
// app.MapControllerRoute(...); 
// app.MapHub<StaffOrdersHub>("/staffOrdersHub");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapHub<StaffOrdersHub>("/staffOrdersHub"); // app.Run()より前

// 初回だけスタッフアカウントを登録 
await StaffAccountSeeder.InitializeAsync(app.Services);

app.Run();
