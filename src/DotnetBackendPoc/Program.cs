using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services required for the application.
builder.Services.AddControllers(); // Adds support for controllers.
builder.Services.AddAWSLambdaHosting(LambdaEventSource.RestApi); // Configures AWS Lambda hosting.
builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();
builder.Services.ConfigureOptions<JwtBearerPostConfigureOptions>();
var app = builder.Build();

// Enable the developer exception page in the development environment.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS.
app.UseRouting(); // Enables routing.
app.UseAuthentication();
app.UseAuthorization(); // Enables authorization middleware.
app.UseResponseCaching();


app.MapControllers();
// app.UseEndpoints(endpoints =>
// {
//     endpoints.MapControllers(); // Maps attribute-routed controllers.
// });

// Optionally, map a specific route directly.
// app.MapGet("/", () => "Welcome to running ASP.NET Core Minimal API on AWS Lambda");

app.Run(); // Runs the application.