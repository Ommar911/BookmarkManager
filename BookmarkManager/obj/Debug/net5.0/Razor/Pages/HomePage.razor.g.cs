#pragma checksum "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Pages\HomePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c80ae2368cff5fb86f44b4e963a4862b11c9d4b"
// <auto-generated/>
#pragma warning disable 1591
namespace BookmarkManager.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using BookmarkManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using BookmarkManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using BookmarkManager.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using BookmarkManager.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using BookmarkManager.Components.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using BookmarkManager.Components.BookmarkFolder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\_Imports.razor"
using BookmarkManager.Components.PageComponents;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class HomePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "home-component-medium");
            __builder.OpenComponent<BookmarkManager.Components.PageComponents.HeaderComponent>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<BookmarkManager.Components.PageComponents.NavBarComponent>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenComponent<BookmarkManager.Components.Collections.CollectionContainerComponent>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
