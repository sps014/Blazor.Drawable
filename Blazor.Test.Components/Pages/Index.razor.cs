using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace Blazor.Test.Components.Pages
{
    public partial class Index
    {
        public List<Pipe> Pipes = new List<Pipe>();
        public List<Bird> Birds = new List<Bird>();

        public int PipeCount = 6;
        public int BirdCount = 6;

        private Timer Timer = new Timer(1000 / 60.0);
        private int PipeSpacing = 300;
        private int Height=700, Width = 1024;
        private int VSpace = 200;
        private string data;
        private Bird player;
        private DateTime LastFrame =DateTime.Now;

        protected override void OnInitialized()
        {
            player = new Bird(Runtime);
            base.OnInitialized();
            Timer.Elapsed += Update;
            CreatePipes();
            Timer.Start();
        }
        private void CreatePipes()
        {
            for(int i=0;i<PipeCount;i++)
            {
                Pipe p = new Pipe();
                p.X = i==0?600:Pipes.Last().X+PipeSpacing;
                p.RandomY(VSpace);
                Pipes.Add(p);
            }

        }
        private void CreateBird()
        {
            for (int i = 0; i < BirdCount; i++)
            {
                Bird p = new Bird(Runtime);
                p.X = 0;
                Birds.Add(p);
            }

        }

        private void Update(object sender, ElapsedEventArgs e)
        {
            var pipeInfo = PipeInfo();
            CollistionHandle(pipeInfo.Item1);
            PipeMover(pipeInfo.Item2);

            base.StateHasChanged();
            LastFrame = DateTime.Now;
        }
        private void PipeMover(int lastPipeIndex)
        {

            var lastPipe = Pipes[lastPipeIndex];
            foreach (var pipe in Pipes)
            {
                pipe.Move(3, lastPipe.X + PipeSpacing, VSpace);
            }

        }
        private void MoveBirds(Pipe p)
        {
            for (int i = 0; i < Birds.Count; i++)
            {
                if(Birds[i].IsAlive)
                {
                    Birds[i].network.Predict(new double[] {Birds[i].Y,p.LowerY,p.UpperY,p.X});

                }
            }
        }
        private void CollistionHandle(int minPipe)
        {
            if (CollidingCheck(player, Pipes[minPipe]))
            {
                Pipes[minPipe].Color = Color.FromArgb(Pipe.RandomNumber(0, 255), Pipe.RandomNumber(0, 255), Pipe.RandomNumber(0, 255));
            }

        }
        private (int,int) PipeInfo()
        {
            int maxPipe = 0;
            int minPipe = 0;


            for (int i = 0; i < Pipes.Count; i++)
            {
                if(Pipes[maxPipe].X<Pipes[i].X)
                {
                    maxPipe = i;
                }

                if (Pipes[i].X >= player.X)
                {
                    if (Pipes[i].X < Pipes[minPipe].X)
                        minPipe = i;
                }

            }

                     
            return (minPipe,maxPipe);
        }
        private bool CollidingCheck(Bird b,Pipe p)
        {
            if(p.X>=-25 && p.X<25)
            {
                if (b.Y > p.LowerY && b.Y < p.UpperY)
                    return false;
                else 
                    return true;
            }
            return false;
        }
        private void KeyDown(MouseEventArgs e)
        {
           
        }

        private long DeltaTime
        {
            get
            {
                return (long)(DateTime.Now-LastFrame).TotalMilliseconds;
            }
        }
    }
}

