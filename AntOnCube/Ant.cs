using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AntOnCube
{
    /// <summary>
    /// Ant class.
    /// </summary>
    public class Ant
    {
        // start and end position are fixed nodes, 0 and 7
        private const int start_ = 0;
        private const int end_ = 7;

        // number of steps/seconds from start to the end
        private int steps_ = 0;
        /// <summary>
        /// Number of steps/seconds from start node to end node.
        /// </summary>
        public int steps
        {
            get { return steps_; }
            set { steps_ = value; }
        }

        public Ant()
        {
        }

        /// <summary>
        /// Simulate the ant walking on the cube.
        /// </summary>
        public void Run()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());

            int curPosition = start_;
            while (curPosition != end_)
            {
                // Generate a random number from 0, 1, 2, and use it to 
                // randomly choose an adjacent node to move to.
                int randAdjNode = rand.Next(3);
                // choose a random adjacent node to go
                curPosition = GlobalData.CubeEdges[curPosition,randAdjNode];
                steps++;
            }
        }
    }
}
