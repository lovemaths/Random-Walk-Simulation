using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AntOnCube
{
    /// <summary>
    /// Provide simulation method, using the number of threads 
    /// manually provided by user.
    /// </summary>
    public class SimulationMan
    {
        /// <summary>
        /// Simulate the ants in a single thread.
        /// </summary>
        /// <param name="i">The specific thread.</param>
        private static void SimulationThread(int i)
        {
            // The number of ants in the thread.
            int numInThread = GlobalData.numAnts / GlobalData.threads;
            
            // Create and initilize the ants.
            List<Ant> ants = new List<Ant>();
            for (int j = 0; j < numInThread; j++)
                ants.Add(new Ant());

            // Count how many ants walked how many steps.
            Dictionary<int, int> countAntBySteps = GlobalData.frequencyThread[i];

            for (int j = 0; j < numInThread; j++)
            {
                ants[j].Run();
                if (!countAntBySteps.ContainsKey(ants[j].steps))
                    countAntBySteps.Add(ants[j].steps, 1);
                else
                    countAntBySteps[ants[j].steps]++;
            }
        }

        /// <summary>
        /// Simulate the ants, using multithreading.
        /// </summary>
        public static void Simulation()
        {
            // Initilize the frequency for each thread.
            for (int i = 0; i < GlobalData.threads; i++)
                GlobalData.frequencyThread.Add(new Dictionary<int, int>());

            Thread[] myThreads = new Thread[GlobalData.threads];

            // Initialized the threads.
            for (int i = 0; i < GlobalData.threads; i++)
            {
                int local = i;
                myThreads[i] = new Thread(() => SimulationThread(local));
            }

            // Run each thread.
            for (int i = 0; i < GlobalData.threads; i++)
            {
                int local = i;
                myThreads[local].Start();
            }

            for (int i = 0; i < GlobalData.threads; i++)
            {
                int local = i;
                myThreads[local].Join();
            }

            // Combine the frequency in each thread to a global frequency.
            foreach (var dict in GlobalData.frequencyThread)
            {
                foreach (var pair in dict)
                {
                    if (GlobalData.frequency.ContainsKey(pair.Key))
                        GlobalData.frequency[pair.Key] += pair.Value;
                    else
                        GlobalData.frequency.Add(pair.Key, pair.Value);
                }
            }
        }
    }
}
