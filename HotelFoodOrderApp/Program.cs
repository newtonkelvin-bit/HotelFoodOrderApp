using HotelFoodOrderApp;
using HotelFoodOrderApp.Components;

var builder = WebApplication.CreateBuilder(args);
// Register the MenuService so both Home and Admin can use it
builder.Services.AddSingleton<HotelFoodOrderApp.MenuService>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
// Add this line to make the service available everywhere in the app
builder.Services.AddSingleton<MenuService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
