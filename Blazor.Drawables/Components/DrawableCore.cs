using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Blazor.Drawables.Components
{
    public class Fillable
    {
        public bool NoFill { get; set; }
        [Parameter]
        public System.Drawing.Color Color { get; set; }
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
        public enum FillRule
        {
            NonZero,
            EvenOdd
        }
    }
    
    public enum StrokeLineJoin
    {
        Bevel,
        Miter,
        Round
    }
    public enum StrokeLineCap
    {
        Butt,
        Round,
        Square
    }
}
