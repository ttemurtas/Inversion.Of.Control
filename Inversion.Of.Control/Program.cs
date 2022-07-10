using Inversion.Of.Control.Services;
using Inversion.Of.Control.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Function add's default is Singleton

//builder.Services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog()));
//builder.Services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));

//builder.Services.AddSingleton<ConsoleLog>();

// If our concrete class wants parameters on their constructor, then we should use container like below.
// You can check below basic using the containers. Main using is often doing with Interfaces and Concretes.

//builder.Services.AddSingleton<ConsoleLog>(p => new ConsoleLog(6));
//builder.Services.AddSingleton<TextLog>();

//builder.Services.AddScoped<ConsoleLog>();
//builder.Services.AddScoped<ConsoleLog>(p => new ConsoleLog(3));

//builder.Services.AddTransient<ConsoleLog>(p => new ConsoleLog(4));
builder.Services.AddScoped<ILog, TextLog>();
//Here is if you add other service after upper line service, the compiler will give you bottom service. WARNING!!
builder.Services.AddScoped<ILog, ConsoleLog>(p => new ConsoleLog(5));

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

app.Run();
