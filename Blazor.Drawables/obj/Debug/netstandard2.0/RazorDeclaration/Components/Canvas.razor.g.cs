#pragma checksum "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Canvas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0afacf1048e2d34928b789fac4f92ce921b75e19"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Drawables.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\_Imports.razor"
using System.Drawing;

#line default
#line hidden
    public partial class Canvas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 22 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Canvas.razor"
 
    [Parameter]
    public int Height { get; set; }
    [Parameter]
    public int Width { get; set; }
    [Parameter]
    public System.Drawing.Color BackgroundColor { get; set; }
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnDoubleClick { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnMouseMove { get; set; }
    [Parameter]
    public EventCallback<WheelEventArgs> OnMouseWheel { get; set; }
    [Parameter]
    public EventCallback<DragEventArgs> OnDrag { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnMousePressed { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnMouseReleased { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnMouseOut { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnMouseOver { get; set; }



#line default
#line hidden
    }
}
#pragma warning restore 1591
