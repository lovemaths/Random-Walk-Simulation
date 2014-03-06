using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Threading;

namespace AntAnimation
{
    public class Ant
    {
        public static int curPosition = 0;
        static int count = 0;
        public static int steps_ = 0;
        
        public static int moves = 30;
        static Vector2 onestep = new Vector2(0, 0);
        static Random rand = new Random(Guid.NewGuid().GetHashCode());
        
        public static void Run()
        {
            if(Data.running == false)
                return;

            if (curPosition == 7 && count == moves)
            {
                Data.running = false;
                Data.steps.Add(steps_);
                Data.totalsteps += steps_;
                steps_ = 0;
                count = 0;
                onestep = new Vector2(0, 0);
                curPosition = 0;
                Data.antPosition = Data.pos[0];
                rand = new Random(Guid.NewGuid().GetHashCode());
                Data.numAnts++;
                Data.average = (float)Data.totalsteps / (float)Data.numAnts;
                Thread.Sleep(1500);
                return;
            }          
            if ((steps_==0&&count==0)||count == moves)
            {
                int nextnode =Data.topology[curPosition,rand.Next(3)];
                onestep = (Data.pos[nextnode] - Data.pos[curPosition]) / moves;
                count = 0;
                steps_++;
                curPosition = nextnode;
                return;
            }else if (count < moves)
            {
                Data.antPosition += onestep;
                count++;
                return;
            }          
        }
    }
}
