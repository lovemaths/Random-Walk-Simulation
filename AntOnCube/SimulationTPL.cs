using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AntOnCube
{
    /// <summary>
    /// Provide simulation method using Task Parallel Library.
    /// </summary>
    public class SimulationTPL
    {
        /// <summary>
        /// Simulate the ants, using Task Parallel Library.
        /// </summary>
        public static void Simuluation()
        {
            // Create and initilize ants.
            //Ant[] ants = new Ant[GlobalData.numAnts];
            //for (int i = 0; i < GlobalData.numAnts; i++)
            //    ants[i] = new Ant();

            //// Simulate each ants.
            //Parallel.For(0, GlobalData.numAnts, i =>
            //    {
            //        //int local = i;
            //        //ants[local].Run();
            //        ants[i].Run();
            //    });

            //// Count how many ants using how many steps, and store the 
            //// result in the dictionary frequency.
            //foreach (Ant ant in ants)
            //{
            //    if (!GlobalData.frequency.ContainsKey(ant.steps))
            //    {
            //        GlobalData.frequency.Add(ant.steps, 1);
            //    }
            //    else
            //        GlobalData.frequency[ant.steps]++;
            //}

            // test

            Parallel.ForEach(Partitioner.Create(0,GlobalData.numAnts), () => new Dictionary<int, int>(),
                (range, loop, localDict) =>
                {
                    for (int i = range.Item1; i < range.Item2; i++)
                    {
                        Ant A = new Ant();
                        A.Run();
                        if (localDict.ContainsKey(A.steps))
                            localDict[A.steps]++;
                        else
                            localDict.Add(A.steps, 1);
                    }
                    return localDict;
                },
                    (localDict) =>
                    {
                        lock (GlobalData.frequency)
                        {
                            foreach (KeyValuePair<int, int> item in localDict)
                            {
                                if (GlobalData.frequency.ContainsKey(item.Key))
                                    GlobalData.frequency[item.Key] += item.Value;
                                else
                                    GlobalData.frequency.Add(item.Key, item.Value);
                            }
                        }
                    });

        }
    }
}
