#pragma checksum "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\Collections\EditCollectionComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16b30e1c8f216b13cc915fc76b316e04dd20c2f1"
// <auto-generated/>
#pragma warning disable 1591
namespace BookmarkManager.Components.Collections
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
    public partial class EditCollectionComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "edit-collection" + " " + (
#nullable restore
#line 1 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\Collections\EditCollectionComponent.razor"
                             CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "b-h3fg69dfxe");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-edit");
            __builder.AddAttribute(5, "b-h3fg69dfxe");
            __builder.AddMarkupContent(6, "<span b-h3fg69dfxe>Title Collection:</span>\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\Collections\EditCollectionComponent.razor"
                      Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Title = __value, Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(10, "b-h3fg69dfxe");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "buttons");
            __builder.AddAttribute(14, "b-h3fg69dfxe");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\Collections\EditCollectionComponent.razor"
                              () => IsOpened = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "b-h3fg69dfxe");
            __builder.AddContent(18, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\Collections\EditCollectionComponent.razor"
                              EditCollection

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "b-h3fg69dfxe");
            __builder.AddContent(23, "Save");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\OMMAR\Desktop\PROYECTO BLAZOR\proyecto 2\BookmarkManager\BookmarkManager\Components\Collections\EditCollectionComponent.razor"
       
    [Parameter] public bool IsOpened { get; set; } = false;
    [Parameter] public int IdCollection { get; set; }
    
    private string CssClass => IsOpened ? "show" : "hide";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591