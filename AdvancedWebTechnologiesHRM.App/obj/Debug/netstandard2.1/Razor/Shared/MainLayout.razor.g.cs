#pragma checksum "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77074a4d104b1ae6e56c2af9ba2ea35e4d25c9f9"
// <auto-generated/>
#pragma warning disable 1591
namespace AdvancedWebTechnologiesHRM.App.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\_Imports.razor"
using AdvancedWebTechnologiesHRM.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\_Imports.razor"
using AdvancedWebTechnologiesHRM.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\_Imports.razor"
using AdvancedWebTechnologiesHRM.App.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\_Imports.razor"
using AdvancedWebTechnologiesHRM.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\_Imports.razor"
using AdvancedWebTechnologiesHRM.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex");
            __builder.AddAttribute(2, "id", "wrapper");
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenComponent<AdvancedWebTechnologiesHRM.App.Shared.NavMenu>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "id", "page-content-wrapper");
            __builder.AddMarkupContent(8, "\r\n\r\n        ");
            __builder.AddMarkupContent(9, @"<nav class=""navbar navbar-expand-lg navbar-light border-bottom"">
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <h3 class=""title"">Advanced Web Technologies HRM </h3>
                <ul class=""navbar-nav ml-auto mt-2 mt-lg-0"">
                </ul>
            </div>
        </nav>

        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "container-fluid");
            __builder.AddMarkupContent(12, "\r\n\r\n            ");
#nullable restore
#line 18 "C:\Users\user\source\repos\AdvancedWebTechnologiesHRM.App\AdvancedWebTechnologiesHRM.App\Shared\MainLayout.razor"
__builder.AddContent(13, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
