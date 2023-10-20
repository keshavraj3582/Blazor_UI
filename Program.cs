using Blazored.Modal;
using Blazored.Toast;
using BlazorUI;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//
//https://localhost:7124/api/StudentApi
builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredModal();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7078/api/Student/GetAllStudents") });

await builder.Build().RunAsync();

