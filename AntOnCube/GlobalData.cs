using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AntOnCube
{
    /// <summary>
    /// Store all the input/ouput variables and all the globally used
    /// variables.
    /// </summary>
    public static class GlobalData
    {
        #region Structure of the cube

        // The nodes on the cube are labelled by 0, 1, 2, 3, .... , 7.
        // CubeEdges_[i] are all the adjacent nodes to node i.  
        private static int[,] CubeEdges_ = new int[,]
            {{1,2,3}, {0,4,5}, {0,5,6}, {0,4,6}, 
            {1,3,7}, {1,2,7}, {2,3,7}, {4,5,6}};
        /// <summary>
        /// CubeEdges[i] is the array of adjacent nodes to node i.
        /// </summary>
        public static int[,] CubeEdges{
            get
            {
                return CubeEdges_;
            }
        }

        // DiagNode[i] is the node off the diagonal of node i. 
        // For example, node 0 and 7 are on the same diagonal,
        // so DiagNode[0] = 7 and DiagNode[7] = 0;
        private static int[] DiagNode_ = new int[8] 
            { 7, 6, 4, 5, 2, 3, 1, 0 };
        /// <summary>
        /// DiagNode[i] is the node off the diagonal of node i.
        /// </summary>
        public static int[] DiagNode
        {
            get
            {
                return DiagNode_;
            }
        }

        #endregion

        #region Input data

        // The input data, number of ants and number of threads
        private static int numAnts_ = 0;
        /// <summary>
        /// Number of ants.
        /// </summary>
        public static int numAnts
        {
            get { return numAnts_;  }
            set { numAnts_ = value; }
        }

        private static int threads_ = 1;
        /// <summary>
        /// Number of threads.
        /// </summary>
        public static int threads
        {
            get { return threads_;  }
            set { threads_=value;  }
        }

        // use TPL parallel or manual parallel
        private static bool useTPL_ = true;
        /// <summary>
        /// If use Task Parallel Library for parallel computing.
        /// </summary>
        public static bool useTPL
        {
            get { return useTPL_; }
            set { useTPL_ = value; }
        }

        #endregion

        #region Statistic variables
        // The statistics data of the simulation

        private static double mean_ = 0;
        /// <summary>
        /// The mean of the steps.
        /// </summary>
        public static double mean
        {
            get { return mean_; }
            set { mean_ = value; }
        }

        private static double deviation_ = 0;
        /// <summary>
        /// The standard deviation of the steps.
        /// </summary>
        public static double deviation
        {
            get { return deviation_; }
            set { deviation_ = value; }
        }
        #endregion

        #region Program variables

        // The ants are grouped in a dictionary, 
        // by the number of steps used from node 0 (start node) to node 7 (end node).
        // The key is the number of steps, and value is number of ants.
        // For example, {{3,5},{7,10}} means 5 ants used 3 steps, and 10 ants 
        // used 7 steps, and in total there are 15 ants.

        /// <summary>
        /// Count how many ants using how many steps, where Key is the number of steps,
        /// and value is the number of ants using Key many steps.
        /// </summary>
        public static Dictionary<int, int> frequency = new Dictionary<int, int>();
        
        /// <summary>
        /// Count how many ants using how many steps, thread by thread.
        /// </summary>
        public static List<Dictionary<int, int>> frequencyThread = new List<Dictionary<int, int>>();
        
        /// <summary>
        /// When we show the distribution bar chart, only show the ants who run at most maxAxisX
        /// steps.
        /// </summary>
        public static int maxAxisX = 35;
       
        #endregion
    }
}
