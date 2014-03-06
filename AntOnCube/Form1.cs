using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AntOnCube
{
    public partial class Form1 : Form
    {
        #region Edited functions

        /// <summary>
        /// When the Simulate button is clicked, the program makes the calculation
        /// and display the mean and standard deviation on the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Simulate_Click(object sender, EventArgs e)
        {

            // Clean up the history from previous calculation
            GlobalData.frequencyThread.Clear();
            GlobalData.frequency.Clear();

            try
            {
                // Try to parse the string for num of threads to int.
                GlobalData.threads = int.Parse(numOfThreads.Text);
                if(GlobalData.threads<=0)
                    throw new FormatException();

                // Use the manual parallel instead of using Task Parallel Library.
                GlobalData.useTPL = false;
            }
            catch (FormatException)
            {
                // If the number of threads are not provided, or provided
                // in a wrong format, than use Task Parallel Library.
                GlobalData.useTPL = true;
            }

            try
            {
                // Try to parse the string for num of ants into int.
                GlobalData.numAnts = int.Parse(numOfAnts.Text);
                if (GlobalData.numAnts <= 0)
                    throw new FormatException();

                // If there are more threads than ants, reduce the number of the 
                // threads to the number of ants.
                GlobalData.threads = Math.Min(GlobalData.threads, GlobalData.numAnts);

                // Choose which simulation method to use.
                if (GlobalData.useTPL)
                    SimulationTPL.Simuluation();
                else
                    SimulationMan.Simulation();

                // Calculate the mean and standard deviation.
                GlobalData.mean = StatisticsCal.findMean();
                GlobalData.deviation = StatisticsCal.findDeviation();

                // Display the mean and variable on the screen.
                StepMean.Text = GlobalData.mean.ToString();
                StepVar.Text = GlobalData.deviation.ToString();
            }
            catch (FormatException)
            {
                // If fail to parse or wrong input, clear history and wait for a valid input.
                this.chart1.Series.Clear();
                StepMean.Text = "";
                StepVar.Text = "";
            }
        }

        /// <summary>
        /// Generate the bar chart of the number of steps vs. the probability that
        /// an ant uses exactly that many steps.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateDistribution_Click(object sender, EventArgs e)
        {
            // Draw the chart only after the simulation runs.
            // Check if the simulation runs by checking the frequency size.
            if (GlobalData.frequency.Count == 0)
                return;

            // Clear the bar chart.
            this.chart1.Series.Clear();
            this.chart1.Series.Add("Probability \n of time");

            // Set up the x and y axis.
            this.chart1.ChartAreas[0].AxisX.Minimum = 0;
            this.chart1.ChartAreas[0].AxisX.Maximum = GlobalData.maxAxisX;
            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.chart1.ChartAreas[0].AxisY.Maximum = 
                (int)(((double)GlobalData.frequency.Values.Max()/GlobalData.numAnts*100)/5+1)*5;

            // Set up the axis title.
            this.chart1.ChartAreas[0].AxisX.Title = "Time (in seconds)";
            this.chart1.ChartAreas[0].AxisY.Title = "Percentage";

            // Calculate the probability of an ant using exactly 1, 2, 3, ... , 50 steps.
            int prob = 0;
            for (int i = 1; i <= GlobalData.maxAxisX; i++)
            {
                if (!GlobalData.frequency.ContainsKey(i))
                    prob = 0;
                else
                    prob = GlobalData.frequency[i] * 100 / GlobalData.numAnts;

                // Show the pair (steps, probability) on the bar chart.
                this.chart1.Series["Probability \n of time"].Points.AddXY(i, prob.ToString());
            }
        }

        /// <summary>
        /// Compute the probability that an ant uses exactly the specified steps, and
        /// display the probability on the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Compute_Prob_Click(object sender, EventArgs e)
        {
            // Calculate the probability of an ant walking to the diagonal, using
            // exact the number of steps specified by user. 
            try
            {
                // Try to parse string for steps to int.
                int steps = int.Parse(ProbOfStep.Text);
                ProbOfStepRes.Text = StatisticsCal.probOfStep(steps).ToString();
            }
            catch (FormatException)
            {
                // If fail to parse, do nothing and wait for a valid input.
            }
        }

        #endregion

        #region Un-edited functions

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numOfAnts_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numOfThreads_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProOfStep_TexChanged(object sender, EventArgs e)
        {

        }

        private void StepMean_Label(object sender, EventArgs e)
        {

        }

        private void StepVar_Label(object sender, EventArgs e)
        {

        }

        private void ProbOfStep_Label(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProbOfStep_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        #endregion               
    }
}
