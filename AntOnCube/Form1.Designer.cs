namespace AntOnCube
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Simulate = new System.Windows.Forms.Button();
            this.numOfAnts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numOfThreads = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StepMean = new System.Windows.Forms.Label();
            this.StepVar = new System.Windows.Forms.Label();
            this.ProbOfStepRes = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.validNumAnt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProbOfStep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Compute_Prob = new System.Windows.Forms.Button();
            this.GenerateDistribution = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Simulate
            // 
            this.Simulate.Location = new System.Drawing.Point(136, 151);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(152, 30);
            this.Simulate.TabIndex = 1;
            this.Simulate.Text = "Simulate";
            this.Simulate.UseVisualStyleBackColor = true;
            this.Simulate.Click += new System.EventHandler(this.Simulate_Click);
            // 
            // numOfAnts
            // 
            this.numOfAnts.Location = new System.Drawing.Point(208, 41);
            this.numOfAnts.Name = "numOfAnts";
            this.numOfAnts.Size = new System.Drawing.Size(130, 24);
            this.numOfAnts.TabIndex = 2;
            this.numOfAnts.TextChanged += new System.EventHandler(this.numOfAnts_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of ants";
            // 
            // numOfThreads
            // 
            this.numOfThreads.Location = new System.Drawing.Point(208, 101);
            this.numOfThreads.Name = "numOfThreads";
            this.numOfThreads.Size = new System.Drawing.Size(130, 24);
            this.numOfThreads.TabIndex = 9;
            this.numOfThreads.TextChanged += new System.EventHandler(this.numOfThreads_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Time";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number of thread";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mean Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Variance";
            // 
            // StepMean
            // 
            this.StepMean.AutoSize = true;
            this.StepMean.Location = new System.Drawing.Point(218, 41);
            this.StepMean.Name = "StepMean";
            this.StepMean.Size = new System.Drawing.Size(17, 18);
            this.StepMean.TabIndex = 15;
            this.StepMean.Text = "0";
            this.StepMean.Click += new System.EventHandler(this.StepMean_Label);
            // 
            // StepVar
            // 
            this.StepVar.AutoSize = true;
            this.StepVar.Location = new System.Drawing.Point(218, 75);
            this.StepVar.Name = "StepVar";
            this.StepVar.Size = new System.Drawing.Size(17, 18);
            this.StepVar.TabIndex = 16;
            this.StepVar.Text = "0";
            this.StepVar.Click += new System.EventHandler(this.StepVar_Label);
            // 
            // ProbOfStepRes
            // 
            this.ProbOfStepRes.AutoSize = true;
            this.ProbOfStepRes.Location = new System.Drawing.Point(218, 147);
            this.ProbOfStepRes.Name = "ProbOfStepRes";
            this.ProbOfStepRes.Size = new System.Drawing.Size(17, 18);
            this.ProbOfStepRes.TabIndex = 17;
            this.ProbOfStepRes.Text = "0";
            this.ProbOfStepRes.Click += new System.EventHandler(this.ProbOfStep_Label);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(19, 44);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Probability \\n of time";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(402, 338);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.validNumAnt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numOfAnts);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numOfThreads);
            this.groupBox1.Controls.Add(this.Simulate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(31, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 197);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation Input";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // validNumAnt
            // 
            this.validNumAnt.AutoSize = true;
            this.validNumAnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validNumAnt.Location = new System.Drawing.Point(345, 44);
            this.validNumAnt.Name = "validNumAnt";
            this.validNumAnt.Size = new System.Drawing.Size(0, 15);
            this.validNumAnt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "(Automatic Parallel if empty)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProbOfStep);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Compute_Prob);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.StepMean);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ProbOfStepRes);
            this.groupBox2.Controls.Add(this.StepVar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 231);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulation Result";
            // 
            // ProbOfStep
            // 
            this.ProbOfStep.Location = new System.Drawing.Point(221, 107);
            this.ProbOfStep.Name = "ProbOfStep";
            this.ProbOfStep.Size = new System.Drawing.Size(100, 24);
            this.ProbOfStep.TabIndex = 20;
            this.ProbOfStep.TextChanged += new System.EventHandler(this.ProbOfStep_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "has probability";
            // 
            // Compute_Prob
            // 
            this.Compute_Prob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compute_Prob.Location = new System.Drawing.Point(159, 187);
            this.Compute_Prob.Name = "Compute_Prob";
            this.Compute_Prob.Size = new System.Drawing.Size(154, 38);
            this.Compute_Prob.TabIndex = 18;
            this.Compute_Prob.Text = "Compute Probability";
            this.Compute_Prob.UseVisualStyleBackColor = true;
            this.Compute_Prob.Click += new System.EventHandler(this.Compute_Prob_Click);
            // 
            // GenerateDistribution
            // 
            this.GenerateDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateDistribution.Location = new System.Drawing.Point(132, 397);
            this.GenerateDistribution.Name = "GenerateDistribution";
            this.GenerateDistribution.Size = new System.Drawing.Size(153, 45);
            this.GenerateDistribution.TabIndex = 21;
            this.GenerateDistribution.Text = "Generate Distribution";
            this.GenerateDistribution.UseVisualStyleBackColor = true;
            this.GenerateDistribution.Click += new System.EventHandler(this.GenerateDistribution_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Controls.Add(this.GenerateDistribution);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(473, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 448);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Distribution";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 544);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ant on cube";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Simulate;
        private System.Windows.Forms.TextBox numOfAnts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numOfThreads;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StepMean;
        private System.Windows.Forms.Label StepVar;
        private System.Windows.Forms.Label ProbOfStepRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Compute_Prob;
        private System.Windows.Forms.Button GenerateDistribution;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProbOfStep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label validNumAnt;
    }
}

