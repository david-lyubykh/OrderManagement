// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.App.Pages.Supplier
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
#nullable restore
#line 2 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
using Models.SupplierDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/suppliers")]
    public partial class Suppliers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
       
    public IEnumerable<SupplierDto> suppliers { get; set; } = new List<SupplierDto>();

    private bool IsLoading { get; set; } = false;

    public int? SupplierIdToDelete { get; set; }

    protected override async Task OnInitializedAsync()
    {
        IsLoading = true;
        try
        {
            await LoadSuppliers();
        }
        catch (Exception e)
        {
            await jsRuntime.ToastrError(e.Message);
            IsLoading = false;
        }
    }

    private async Task LoadSuppliers()
    {
        suppliers = await supplierService.GetSuppliers();
        IsLoading = false;
    }

    private async Task HandelDelete(int supplierId)
    {
        SupplierIdToDelete = supplierId;
        await jsRuntime.InvokeVoidAsync("ShowConfirmationModal");
    }

    private async Task ConfirmDelete_Click(bool isConfirmed)
    {
        if (isConfirmed && SupplierIdToDelete.HasValue)
        {
            try
            {
                await supplierService.DeleteSupplier(SupplierIdToDelete.Value);
                await jsRuntime.ToastrSuccess("Supplier deleted successfully");
                suppliers = suppliers.Where(x => x.Id != SupplierIdToDelete.Value);
            }
            catch (Exception e)
            {
                await jsRuntime.ToastrError(e.Message);
            }
            await jsRuntime.InvokeVoidAsync("HideConfirmationModal");

        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISupplierService supplierService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
