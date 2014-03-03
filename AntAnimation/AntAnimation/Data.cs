using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace AntAnimation
{
    public class Data
    {
        public static Vector2[] pos = new Vector2[8]
            {new Vector2(61,520),new Vector2(61,202),new Vector2(382,520),new Vector2(184,397),
            new Vector2(184,78),new Vector2(382,202),new Vector2(506,397),new Vector2(506,78)};
        public static int cubeL = 321;
        public static int cubeH = 318;
        public static int[,] topology = {{1,2,3},{0,4,5},{0,5,6},{0,4,6},{1,3,7},
                                        {1,2,7},{2,3,7},{4,5,6}};
        public static Vector2 antPosition = pos[0];
        public static int numAnts = 0;
        public static List<int> steps = new List<int>();
        public static bool running = false;
        public static float average = 0;
        public static int totalsteps = 0;
    }
}
