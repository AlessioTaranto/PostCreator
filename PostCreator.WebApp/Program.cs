using PostCreator.Infrastructure.Services; // Adjust namespace to match your Infrastructure project
using PostCreator.Core.Services; // Adjust namespace to match your Core project

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Create HTTP client
builder.Services.AddHttpClient();

// Register the OpenAI and LinkedIn services
builder.Services.AddScoped<IOpenAIService, OpenAIService>();
builder.Services.AddScoped<ILinkedInService, LinkedInService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();