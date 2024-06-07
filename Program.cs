using BlazorApp;

var builder = WebApplication.CreateBuilder(args);

//Services added
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

//HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
