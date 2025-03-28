var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApiDocument(configure =>
{
	configure.Title = "Brew404 Words WebApi";
});

var app = builder.Build();
app.MapControllers();

if (app.Environment.IsDevelopment()) {
	app.UseDeveloperExceptionPage();
}
app.UseOpenApi();
app.UseSwaggerUi();

app.MapGet("/", () => "Hello World!");

app.Run();
