#pragma checksum "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\BookmarkComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9a7cadf7b3322727dda8682bc4d4d09a98a98c2"
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
    public partial class BookmarkComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BookmarkManager.Components.BookmarkFolder.EditBookmarkComponent>(0);
            __builder.AddAttribute(1, "IsOpened", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\BookmarkComponent.razor"
                                 isOpened

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "IdCard", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 1 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\BookmarkComponent.razor"
                                                   Bookmark.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "bookmarks-container");
            __builder.AddAttribute(6, "b-ziozmveasl");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "bookmark-name");
            __builder.AddAttribute(9, "b-ziozmveasl");
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "b-ziozmveasl");
            __builder.AddContent(12, 
#nullable restore
#line 4 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\BookmarkComponent.razor"
               Bookmark.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "options-bookmark");
            __builder.AddAttribute(16, "b-ziozmveasl");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\BookmarkComponent.razor"
                          () => isOpened = true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "b-ziozmveasl");
            __builder.AddContent(20, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\BookmarkComponent.razor"
                          DeleteBookmark

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "b-ziozmveasl");
            __builder.AddContent(25, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "bookmark-path");
            __builder.AddAttribute(29, "b-ziozmveasl");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 11 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\BookmarkComponent.razor"
                  Bookmark.Path

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "b-ziozmveasl");
            __builder.AddContent(33, 
#nullable restore
#line 11 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\BookmarkComponent.razor"
                                  Bookmark.Path

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\BookmarkFolder\BookmarkComponent.razor"
       
    [Parameter] public Bookmark Bookmark { get; set; }

    private bool isOpened = false;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591