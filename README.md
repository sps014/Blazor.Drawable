# Blazor.Drawable
 1. SVG Components (HTML C#) only 
 2. Mix with existing HTML SVG elements
 
 ### Components
 1. Arc
 2. Bezier
 3. Canvas
 4. Circle
 5. Ellipse
 6. Line
 7. Point
 8. Polygon
 9. Rect
 10. Triangle

#### Demo
![Capture](https://user-images.githubusercontent.com/45932883/74080043-bd853f00-4a65-11ea-8b7b-bbb8b8acd865.PNG)

#### Code example 

```XML
<div style="background-color:black;width:100%">
    <Canvas BackgroundColor="Color.DodgerBlue" Width="Width" Height="Height" OnMouseMove="KeyDown">
        <!--Pipes-->
        @for(int i=0;i<Pipes.Count;i++)
        {
            <Rect X="Pipes[i].X" Y="0" 
                  Height="Pipes[i].LowerY" Width="Pipes[i].Width"
                  Color="Pipes[i].Color"></Rect>
            <Rect X="Pipes[i].X" Y="Pipes[i].UpperY"
                  Height="Height" Width="Pipes[i].Width"
                  Color="Color.Green"></Rect>
        }
        <!--Super Bird-->
        <Circle X="player.X" Y="player.Y" Radius="25" Color="Color.DeepPink"/>
    </Canvas>
    <p style="color:yellow">DeltaTime:@DeltaTime ms   ->> @data</p>
</div>

```
