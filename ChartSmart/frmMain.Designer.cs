namespace ChartSmart
{
    partial class frmMain
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
            this.btnShowChart = new System.Windows.Forms.Button();
            this.btnShowBarChartCompare = new System.Windows.Forms.Button();
            this.btnWithPie = new System.Windows.Forms.Button();
            this.btnShowPieChartCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowChart
            // 
            this.btnShowChart.Location = new System.Drawing.Point(109, 87);
            this.btnShowChart.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.Size = new System.Drawing.Size(662, 120);
            this.btnShowChart.TabIndex = 1;
            this.btnShowChart.Text = "Show Chart";
            this.btnShowChart.UseVisualStyleBackColor = true;
            this.btnShowChart.Click += new System.EventHandler(this.btnShowChart_Click);
            // 
            // btnShowBarChartCompare
            // 
            this.btnShowBarChartCompare.Location = new System.Drawing.Point(109, 384);
            this.btnShowBarChartCompare.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnShowBarChartCompare.Name = "btnShowBarChartCompare";
            this.btnShowBarChartCompare.Size = new System.Drawing.Size(656, 114);
            this.btnShowBarChartCompare.TabIndex = 7;
            this.btnShowBarChartCompare.Text = "Show Compare Bar Chart";
            this.btnShowBarChartCompare.UseVisualStyleBackColor = true;
            this.btnShowBarChartCompare.Click += new System.EventHandler(this.btnShowSingleCompare_Click);
            // 
            // btnWithPie
            // 
            this.btnWithPie.Location = new System.Drawing.Point(112, 243);
            this.btnWithPie.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnWithPie.Name = "btnWithPie";
            this.btnWithPie.Size = new System.Drawing.Size(656, 114);
            this.btnWithPie.TabIndex = 6;
            this.btnWithPie.Text = "Show Chart with Pie";
            this.btnWithPie.UseVisualStyleBackColor = true;
            this.btnWithPie.Click += new System.EventHandler(this.btnWithPie_Click);
            // 
            // btnShowPieChartCompare
            // 
            this.btnShowPieChartCompare.Location = new System.Drawing.Point(109, 539);
            this.btnShowPieChartCompare.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnShowPieChartCompare.Name = "btnShowPieChartCompare";
            this.btnShowPieChartCompare.Size = new System.Drawing.Size(656, 114);
            this.btnShowPieChartCompare.TabIndex = 8;
            this.btnShowPieChartCompare.Text = "Show Compare Pie Chart";
            this.btnShowPieChartCompare.UseVisualStyleBackColor = true;
            this.btnShowPieChartCompare.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 789);
            this.Controls.Add(this.btnShowPieChartCompare);
            this.Controls.Add(this.btnShowBarChartCompare);
            this.Controls.Add(this.btnWithPie);
            this.Controls.Add(this.btnShowChart);
            this.Name = "frmMain";
            this.Text = "ChartSmart - the better way to do charts";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowChart;
        private System.Windows.Forms.Button btnShowBarChartCompare;
        private System.Windows.Forms.Button btnWithPie;
        private System.Windows.Forms.Button btnShowPieChartCompare;
    }
}

