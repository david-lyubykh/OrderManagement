// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.App.Pages.Supplier.Components
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
#line 13 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\_Imports.razor"
using Client.App.Services.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Components\SupplierUpsert - Copy.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Components\SupplierUpsert - Copy.razor"
using Models.SupplierDtos;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/supplier/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/supplier/update/{id:int}")]
    public partial class SupplierUpsert___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Components\SupplierUpsert - Copy.razor"
       

    [Parameter]
    public int? Id { get; set; } 

    private CreateSupplierDto SupplierModel{get;set;}=new CreateSupplierDto();
    public string Title { get; set; } = "Create";

    protected override Task OnInitializedAsync()
    {
        if (Id.HasValue)
        {
            Title = "Update";
            SupplierModel=
        }
    }

    private async Task HandleSupplierUpsert()
    {
        try
        {
            var supplier=await supplierService.CreateSupplier(SupplierModel);
            navigationManager.NavigateTo("suppliers");
        }
        catch (Exception e)
        {
             await jsRuntime.ToastrError(e.Message);
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISupplierService supplierService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
