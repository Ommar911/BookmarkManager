#pragma checksum "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\CreateBookmarkComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be335b3ef82b1beccf7c3cf1c16944b600985ce2"
// <auto-generated/>
#pragma warning disable 1591
namespace BookmarkManager.Components.BookmarkFolder
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
    public partial class CreateBookmarkComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "create-bookmark" + " " + (
#nullable restore
#line 1 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\CreateBookmarkComponent.razor"
                             CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "b-3vstgt2oyv");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-create");
            __builder.AddAttribute(5, "b-3vstgt2oyv");
            __builder.AddMarkupContent(6, "<span b-3vstgt2oyv>Name page:</span>\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\CreateBookmarkComponent.razor"
                      NamePage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NamePage = __value, NamePage));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(10, "b-3vstgt2oyv");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<span b-3vstgt2oyv>Path: </span>\r\n        ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\CreateBookmarkComponent.razor"
                      Path

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Path = __value, Path));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(16, "b-3vstgt2oyv");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "buttons");
            __builder.AddAttribute(20, "b-3vstgt2oyv");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\CreateBookmarkComponent.razor"
                              () => IsOpened = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "b-3vstgt2oyv");
            __builder.AddContent(24, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\CreateBookmarkComponent.razor"
                              CreateBookmark

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "b-3vstgt2oyv");
            __builder.AddContent(29, "Create");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\CreateBookmarkComponent.razor"
       
    [Parameter] public bool IsOpened { get; set; } = false;
    [Parameter] public int IdCollection { get; set; }

    private string CssClass => IsOpened ? "show" : "hide";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591