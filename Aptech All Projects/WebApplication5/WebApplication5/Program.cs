var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
//app.MapGet("/", () => "Hello World!");

//app.Use(async (contact, next)  =>
//{
//    await contact.Response.WriteAsync("Hello \n");
//    await next(contact);
//});
//app.Use(async (contact, next) =>
//{
//    await contact.Response.WriteAsync("world \n");
//    await next(contact);
//});
//app.Use(async (contact, next) =>
//{
//    await contact.Response.WriteAsync("Syed \n");
//    await next(contact);
//});
//app.Use(async (contact, next) =>
//{
//    await contact.Response.WriteAsync("Abdul \n");
//    await next(contact);
//});
//app.Run(async (contact) =>
//{
//    await contact.Response.WriteAsync("sami \n");
//});


app.MapControllers();
app.Run();
