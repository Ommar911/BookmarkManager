#pragma checksum "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\PageComponents\NavBarComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c4267af8f58e0e45cb7db16c7f642a38d5d5d70"
// <auto-generated/>
#pragma warning disable 1591
namespace BookmarkManager.Components.PageComponents
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
    public partial class NavBarComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-options-navbar");
            __builder.AddAttribute(2, "b-bo87738ftp");
            __builder.AddMarkupContent(3, @"<div class=""options-navbar"" b-bo87738ftp><button b-bo87738ftp>DRAG & DROP</button>
        <button b-bo87738ftp>TAG FILTER</button>
        <button b-bo87738ftp>VIEW</button>
        <button b-bo87738ftp>EXPAND</button>
        <button b-bo87738ftp>COLLAPSE</button></div>
    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "button-navbar");
            __builder.AddAttribute(6, "b-bo87738ftp");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\PageComponents\NavBarComponent.razor"
                          Open

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "b-bo87738ftp");
            __builder.AddContent(10, "ADD COLLECTION");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\PageComponents\NavBarComponent.razor"
 if (isOpened)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BookmarkManager.Components.Collections.CreateCollectionComponent>(11);
            __builder.AddAttribute(12, "onResult", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 15 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\PageComponents\NavBarComponent.razor"
                                         CloseCreate

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 16 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\PageComponents\NavBarComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\PageComponents\NavBarComponent.razor"
      
    private bool isOpened = false;

    private void Open()
    {
        this.isOpened = true;
    }

    private void CloseCreate(bool var)
    {
        this.isOpened = var;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
