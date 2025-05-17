using AuthService.Database;
using AuthService.Domain;
using Microsoft.AspNetCore.Identity;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<AuthDbContext>(s =>
    new AuthDbContext(builder.Configuration.GetConnectionString("Postgres")!));

builder.Services.AddIdentity<User, IdentityRole<Guid>>()
    .AddEntityFrameworkStores<AuthDbContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.User.RequireUniqueEmail = true;
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options =>
    {
        options.RouteTemplate = "/openapi/{documentName}.json";
    });
    app.MapScalarApiReference(opt =>
    {
        opt.Theme = ScalarTheme.Moon;
        opt.DefaultHttpClient = new(ScalarTarget.Http, ScalarClient.Http11);
    });
}

app.Run();