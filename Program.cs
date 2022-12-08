using Microsoft.EntityFrameworkCore;
using Tazaker.Data;
using Tazaker.Data.Services.ActorService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
#region DbContext Configuration
builder.Services.AddDbContext<AppDbContext>(
    options=>options.UseSqlServer(
        builder.Configuration.GetConnectionString("conn")
        ).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
builder.Services.AddScoped<AppDbContext>();
#endregion

#region adding services
builder.Services.AddScoped<IActorService,ActorServices>();
#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); 
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//seed Database
AppDbInitializer.Seed(app);
app.Run();
