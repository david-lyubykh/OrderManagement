// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using Client.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using Client.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using Client.App.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using Client.App.Services.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
