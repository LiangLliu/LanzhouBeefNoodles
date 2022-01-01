using LanzhouBeefNoodles.Models;

var builder = WebApplication.CreateBuilder(args);

// add service to the the container
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<INoodleRepository, MockNoodleRepository>();
builder.Services.AddTransient<IFeedbackRepository, MockFeedbackRepository>();


var app = builder.Build();

app.UseRouting();

app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}"
);

app.Run();