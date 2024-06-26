using FootballManager_SoftuniProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppDbContext(builder.Configuration);
builder.Services.AddAppIdentity(builder.Configuration);

builder.Services.AddControllersWithViews();
builder.Services.AddAppService();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // app.UseStatusCodePagesWithRedirects("/Home/Error?statusCode={0}");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "Player Details",
        pattern: "TransferMarketPlayer/Details/{id}/{information}",
        defaults: new { Controller = "TransferMarketPlayer", Action = "Details" }
        );
    endpoints.MapDefaultControllerRoute();
    endpoints.MapRazorPages();
});

using (var scope = app.Services.CreateScope())
{
    var roleManager =
        scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    var roles = new[] { "Admin", "Member" };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}

using (var scope = app.Services.CreateScope())
{
    var userManager =
        scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

    string email = "admin@admin.com";

    var hasher = new PasswordHasher<IdentityUser>();

    if (await userManager.FindByEmailAsync(email) == null)
    {
        var user = new IdentityUser()
        {
            UserName = email,
            Email = email,
        };

        user.PasswordHash =
            hasher.HashPassword(user, "admin");

        await userManager.CreateAsync(user);

        await userManager.AddToRoleAsync(user, "Admin");

    }
}

app.Run();
