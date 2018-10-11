using ApprovalTests.Reporters;
using ApprovalTests.WinForms;
using ChartSmart;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChartSmartTest
{
    [TestClass]
    [UseReporter(typeof(ClipboardReporter), typeof(DiffReporter))]
    public class ChartSmartTests
    {
        [TestMethod]
        public void ItsAlive()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestThatApprovalsIsWorking()
        {
            ApprovalTests.Approvals.Verify("Test");
        }

        [TestMethod]
        public void TestMainForm()
        {
            frmMain main = new frmMain();
            main.Show();
            ApprovalTests.WinForms.WinFormsApprovals.Verify(main);
        }

        [TestMethod]
        public void TestBarChartSingle()
        {
            frmMain main = new frmMain();
            ChartSingleCompareOrig chart = main.LaunchChart(406, "rpfll", false);
            chart.Show();
            WinFormsApprovals.Verify(chart);
        }

        [TestMethod]
        public void TestBarChartCompare()
        {
            frmMain main = new frmMain();
            ChartSingleCompareOrig chart = main.LaunchChart(406, "splitdisplay", false);
            chart.Show();
            WinFormsApprovals.Verify(chart);
        }


        [TestMethod]
        public void TestPieChartWindow()
        {
            frmMain main = new frmMain();
            ChartSingleCompareOrig chart = main.LaunchChart(712, "rpfll", false);
            chart.Show();
            WinFormsApprovals.Verify(chart);
        }

        [TestMethod]
        public void TestPieChartCompareWindow()
        {
            frmMain main = new frmMain();
            ChartSingleCompareOrig chart = main.LaunchChart(712, "splitdisplay", false);
            chart.Show();
            WinFormsApprovals.Verify(chart);
        }
    }
}