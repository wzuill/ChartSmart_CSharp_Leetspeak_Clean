using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartSmart
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(270, 270);
        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            LaunchChart(406, "rpfll", true);
        }

        public ChartSingleCompareOrig LaunchChart(int chartType, string displayType, bool asDialog)
        {
            ChartSingleCompareOrig chartSingleCompareOrig = new ChartSingleCompareOrig();
            chartSingleCompareOrig.iniDS(chartType, displayType, asDialog);
            return chartSingleCompareOrig;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnWithPie_Click(object sender, EventArgs e)
        {
            LaunchChart(712, "rpfll", true);
        }

        private void btnShowSingleCompare_Click(object sender, EventArgs e)
        {
            LaunchChart(406, "splitdisplay", true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LaunchChart(712, "splitdisplay", true);
        }
    }
}
