var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapControllers();

// Routing

// "/shirts"
//app.MapGet("/shirts", () =>
//{
//    return "Reading all the shirts";
//});

//app.MapGet("/shirts/{id}", (int id) =>
//{
//    return $"Reading shirt  with ID: {id}";
//});

//app.MapPost("/shirts", () =>
//{
//    return "Creating a new shirt";
//});

//app.MapPut("/shirts/{id}", (int id) =>
//{
//    return $"Updating a shirt with ID: {id}";
//});

//app.MapDelete("/shirts/{id}", (int id) =>
//{
//    return $"Deleting a shirt with the ID: {id}";
//});

app.Run();
