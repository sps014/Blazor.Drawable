#pragma checksum "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5d01f29ba4b568b1284a8e9a4fbd71f1c32630f"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class Line : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "line");
            __builder.AddAttribute(1, "x1", 
#line 2 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
           X1

#line default
#line hidden
            );
            __builder.AddAttribute(2, "y1", 
#line 2 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                    Y1

#line default
#line hidden
            );
            __builder.AddAttribute(3, "x2", 
#line 2 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                             X2

#line default
#line hidden
            );
            __builder.AddAttribute(4, "y2", 
#line 2 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                                      Y2

#line default
#line hidden
            );
            __builder.AddAttribute(5, "r", 
#line 3 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
            StrokeWidth

#line default
#line hidden
            );
            __builder.AddAttribute(6, "fill", "rgba(" + (
#line 4 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                    StrokeColor.R

#line default
#line hidden
            ) + "," + (
#line 4 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                                   StrokeColor.G

#line default
#line hidden
            ) + "," + (
#line 4 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                                                  StrokeColor.B

#line default
#line hidden
            ) + "," + (
#line 4 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                                                                 StrokeColor.A

#line default
#line hidden
            ) + ")");
            __builder.AddAttribute(7, "stroke", "rgba(" + (
#line 5 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                      StrokeColor.R

#line default
#line hidden
            ) + "," + (
#line 5 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                                     StrokeColor.G

#line default
#line hidden
            ) + "," + (
#line 5 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                                                    StrokeColor.B

#line default
#line hidden
            ) + "," + (
#line 5 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                                                                   StrokeColor.A

#line default
#line hidden
            ) + ")");
            __builder.AddAttribute(8, "stroke-dasharray", 
#line 6 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                           StrokeDashArray

#line default
#line hidden
            );
            __builder.AddAttribute(9, "stroke-linejoin", 
#line 6 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                                                              Join.ToString().ToLower()

#line default
#line hidden
            );
            __builder.AddAttribute(10, "stroke-linecap", 
#line 7 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                         Cap.ToString().ToLower()

#line default
#line hidden
            );
            __builder.AddAttribute(11, "stroke-width", 
#line 8 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                       StrokeWidth

#line default
#line hidden
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 9 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                  OnClick

#line default
#line hidden
            ));
            __builder.AddAttribute(13, "ondblclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 10 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                     OnDoubleClick

#line default
#line hidden
            ));
            __builder.AddAttribute(14, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 11 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                      OnMouseMove

#line default
#line hidden
            ));
            __builder.AddAttribute(15, "onmousewheel", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.WheelEventArgs>(this, 
#line 12 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                       OnMouseWheel

#line default
#line hidden
            ));
            __builder.AddAttribute(16, "ondrag", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#line 13 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                 OnDrag

#line default
#line hidden
            ));
            __builder.AddAttribute(17, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                      OnMousePressed

#line default
#line hidden
            ));
            __builder.AddAttribute(18, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 15 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                    OnMouseReleased

#line default
#line hidden
            ));
            __builder.AddAttribute(19, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                     OnMouseOut

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 17 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                      OnMouseOver

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "style", "opacity:" + (
#line 18 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
                        Opacity

#line default
#line hidden
            ));
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 22 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Line.razor"
 
    [Parameter]
    public int X1 { get; set; }
    [Parameter]
    public int Y1 { get; set; }
    [Parameter]
    public int X2 { get; set; }
    [Parameter]
    public int Y2 { get; set; }
    [Parameter]
    public double Opacity { get; set; } = 1;
    [Parameter]
    public Color StrokeColor { get; set; } = Color.Black;
    [Parameter]
    public double StrokeWidth { get; set; } = 2;
    [Parameter]
    public StrokeLineCap Cap { get; set; }
    [Parameter]
    public StrokeLineJoin Join { get; set; }
    [Parameter]
    public int StrokeDashArray { get; set; }

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
    public EventCallback<MouseEventArgs> OnMouseOut { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnMouseOver { get; set; }


#line default
#line hidden
    }
}
#pragma warning restore 1591
