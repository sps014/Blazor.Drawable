using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Test.Components.Pages
{
    public class Bird
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ML5.NeuralNetwork network;
        public bool IsAlive { get; set; } = true;
        public Bird(IJSRuntime runtime)
        {
            X = 0;
            network = new ML5.NeuralNetwork(runtime,4,1);
            network.OnClassification += Network_OnPredict;
        }

        private void Network_OnPredict(string error, ML5.CResult[] result)
        {
            if(result[0].confidence>0.5)
            {
                MoveTo(5);
            }
            else
            {
                MoveTo(-5);
            }
        }

        public Bird(IJSRuntime runtime,ML5.NeuralNetwork net)
        {
            X = 0;
            network = net;
        }
        public void MoveTo(int amountDir)
        {
            if(Y-amountDir>0 && Y-amountDir<700)
            {
                Y -= amountDir;
            }
        }
    }
}
