#pragma checksum "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6686a411baab94c342088f6690b29343e5657dc9"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-4 mb-4 clearfix");
            __builder.AddMarkupContent(2, "<div class=\"col-6\"><h4 class=\"card-title primary\">Suppliers</h4></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", "/supplier/create");
            __builder.AddAttribute(7, "class", "btn btn-outline-primary float-right");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "<i class=\"fa fa-plus mr-2\"></i>New Supplier");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
 if (!IsLoading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<SupplierDto>>(10);
            __builder.AddAttribute(11, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "AllowColumnResize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "FilterMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 20 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                FilterMode.Advanced

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "PageSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                                                   5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "PagerHorizontalAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.HorizontalAlign>(
#nullable restore
#line 20 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                                                                                               HorizontalAlign.Left

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ShowPagingSummary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                                                                                                                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SupplierDto>>(
#nullable restore
#line 21 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
               suppliers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ColumnWidth", "300px");
            __builder.AddAttribute(21, "LogicalFilterOperator", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 21 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                                                         LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SupplierDto>>(23);
                __builder2.AddAttribute(24, "Property", "Id");
                __builder2.AddAttribute(25, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                                                false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Title", "ID");
                __builder2.AddAttribute(27, "Frozen", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Width", "70px");
                __builder2.AddAttribute(29, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 23 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                                                                                                        TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SupplierDto>>(31);
                __builder2.AddAttribute(32, "Property", "Name");
                __builder2.AddAttribute(33, "Title", "Name");
                __builder2.AddAttribute(34, "Frozen", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Width", "140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SupplierDto>>(37);
                __builder2.AddAttribute(38, "Property", "AddressLine1");
                __builder2.AddAttribute(39, "Title", "Address Line 1");
                __builder2.AddAttribute(40, "Width", "200px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SupplierDto>>(42);
                __builder2.AddAttribute(43, "Property", "AddressLine2");
                __builder2.AddAttribute(44, "Title", "Address Line 2");
                __builder2.AddAttribute(45, "Width", "200px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SupplierDto>>(47);
                __builder2.AddAttribute(48, "Property", "City");
                __builder2.AddAttribute(49, "Title", "City");
                __builder2.AddAttribute(50, "Width", "150px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SupplierDto>>(52);
                __builder2.AddAttribute(53, "Property", "PostalCode");
                __builder2.AddAttribute(54, "Title", "Postal Code");
                __builder2.AddAttribute(55, "Width", "100px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SupplierDto>>(57);
                __builder2.AddAttribute(58, "Property", "State.Name");
                __builder2.AddAttribute(59, "Title", "State");
                __builder2.AddAttribute(60, "Width", "150px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, " \r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SupplierDto>>(62);
                __builder2.AddAttribute(63, "Property", "Id");
                __builder2.AddAttribute(64, "Title", "Action");
                __builder2.AddAttribute(65, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                                                               false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                                                                                false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "Width", "125px");
                __builder2.AddAttribute(68, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SupplierDto>)((data) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(69);
                    __builder3.AddAttribute(70, "class", "btn btn-primary");
                    __builder3.AddAttribute(71, "href", 
#nullable restore
#line 32 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                             $"supplier/update/{data.Id}"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(73, "Edit");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\r\n                    ");
                    __builder3.OpenElement(75, "button");
                    __builder3.AddAttribute(76, "class", "btn btn-danger");
                    __builder3.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                                             ()=>HandelDelete(data.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(78, "Delete");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 38 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(79, @"<div class=""text-center mt-5""><div class=""spinner-grow text-primary"" role=""status""><span class=""sr-only"">Loading...</span></div>
        <div class=""spinner-grow text-secondary"" role=""status""><span class=""sr-only"">Loading...</span></div>
        <div class=""spinner-grow text-success"" role=""status""><span class=""sr-only"">Loading...</span></div></div>");
#nullable restore
#line 52 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"

}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Client.App.Shared.Confirmation>(80);
            __builder.AddAttribute(81, "ConfirmationChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 54 "E:\Upwork\OrderManagementSystem\OrderManagement\Client.App\Pages\Supplier\Suppliers.razor"
                                   ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
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
