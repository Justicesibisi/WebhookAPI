var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger ALWAYS (not just development)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebhookTask API V1");
    c.RoutePrefix = string.Empty; // Makes Swagger open at root URL
});

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
