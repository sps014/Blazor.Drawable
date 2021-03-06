#pragma checksum "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Polygon.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "143fe73a51582b4d1e2e713bfd58ef9286a09430"
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
    public partial class Polygon : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 75 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Polygon.razor"
 
    [Parameter]
    public double[] Points { get; set; }

    [Parameter]
    public double Opacity { get; set; } = 1;
    [Parameter]
    public bool NoFill { get; set; }
    [Parameter]
    public System.Drawing.Color Color { get; set; } = Color.Black;
    [Parameter]
    public bool NoStroke { get; set; }
    [Parameter]
    public Color StrokeColor { get; set; }
    [Parameter]
    public double StrokeWidth { get; set; } = 1;
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
    [Parameter]
    public EventCallback<MouseEventArgs> OnMouseOut { get; set; }
    public EventCallback<MouseEventArgs> OnMouseOver { get; set; }

    private string GetPoints()
    {
        string points="";
        for (int i=0;i<Points.Length;i++)
        {
            points += Points[i];
            if (i != 0)
                points += i % 2 == 0 ? "," : " ";
            else
                points += ",";
        }
        return points;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
