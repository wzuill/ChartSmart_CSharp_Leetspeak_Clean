using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChartSmart
{
    public partial class ChartSingleCompareOrig : Form
    {
        private const int CHART_TYPE_BAR = 406;
        private const string DISPLAY_TYPE_LARGE = "rpfll";
        private const string DISPLAY_TYPE_SMALL = "splitdisplay";
        private string _displayType;
        private int _chartType;
        private Bitmap drawArea;

        public ChartSingleCompareOrig()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(380, 380);
        }

        public void ShowChart(int chartType, string displayType, bool shouldShowDialog)
        {
            this._chartType = chartType;
            this._displayType = displayType;
            drawArea = new Bitmap(this.ClientRectangle.Width,
                this.ClientRectangle.Height,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            InitializeDrawArea();
            DrawChart();
            if (shouldShowDialog)
            {
                this.ShowDialog();
            }
        }

        private void InitializeDrawArea()
        {
            var g = Graphics.FromImage(drawArea);
            SolidBrush brush = new SolidBrush(Color.LightYellow);
            g.Clear(Color.LightYellow);
            brush.Dispose();
            g.Dispose();
        }

        private void ChartSingleCompareOrig_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawImage(drawArea, 0, 0, drawArea.Width, drawArea.Height);
        }

        private void DrawChart()
        {
            var g = GetGraphics();
            RenderChartBackground(g);
            ChartData chartData; 
            chartData = GetChartData();
            RenderChart(g, chartData);
            InvalidateIfNecessary(g, chartData);
        }

        private void InvalidateIfNecessary(Graphics g, ChartData chartData)
        {
            try
            {
                if (!(g.DpiX == 300) ||
                    g != null && (chartData.otherData.Length > 20 || chartData.otherData.Length < 5) &&
                    (chartData.data == null || !chartData.data.StartsWith("hold")))
                {
                    this.Invalidate();
                }
            }
            catch (ArgumentException ex)
            {
                this.Invalidate();
            }
        }

        private Graphics GetGraphics()
        {
            Graphics g = Graphics.FromImage(drawArea);
            g.Clear(Color.LightYellow);
            return g;
        }

        private void RenderChart(Graphics g, ChartData chartData)
        {
            if (_chartType == CHART_TYPE_BAR)
            {
                Brush brush2 = new SolidBrush(Color.Black);

                if (_displayType == DISPLAY_TYPE_SMALL)
                {
                    var parTop = 170;
                    var barLeft = 33;
                    var barWidth = 25;
                    g.FillRectangle(brush2, barLeft, parTop - 92, barWidth, 92);
                    g.FillRectangle(brush2, barLeft + barWidth, parTop - 225 / 2, barWidth, 225 / 2);
                    g.FillRectangle(brush2, barLeft + barWidth * 2, parTop - 205 / 2, barWidth, 205 / 2);
                    g.FillRectangle(brush2, barLeft + barWidth * 3, parTop - 260 / 2, barWidth, 260 / 2);
                    g.FillRectangle(brush2, barLeft + barWidth * 4, parTop - 85, barWidth, 170 / 2);
                    g.DrawString(chartData.data, new Font("Arial Black", 16), new SolidBrush(Color.White),
                        new PointF(barLeft + 5, 85));
                }
                else
                {
                    var chartBottom = 312;
                    g.FillRectangle(brush2, 45, chartBottom - 185, 50, 185);
                    g.FillRectangle(brush2, 45 + 50, chartBottom - 225, 50, 225);
                    g.FillRectangle(brush2, 45 + 100, chartBottom - 205, 50, 205);
                    g.FillRectangle(brush2, 45 + 150, chartBottom - 260,
                        50, 260);
                    g.FillRectangle(brush2, 45 + 200,
                        chartBottom - 170, 50, 170);
                    g.DrawString(
                        chartData.data, new Font("Arial Black", 30), new
                            SolidBrush(Color.White),
                        new PointF(60, 170));
                }
            }
            else
            {
                StringFormat stringFormat = new StringFormat();
                RectangleF boundingRect;

                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                if (chartData.otherData != "")
                {
                    boundingRect = new RectangleF(20, 30, 320, 320);
                    g.DrawString(chartData.otherData, new Font("Cooper Black", 40), new SolidBrush(Color.White),
                        boundingRect, stringFormat);
                }
                else
                {
                    boundingRect = new RectangleF(20, 30, 160, 160);
                    g.DrawString(chartData.someOtherDataObject, new Font("Cooper Black", 20), new SolidBrush(Color.White),
                        boundingRect, stringFormat);
                }

                g.Dispose();
            }
        }

        private ChartData GetChartData()
        {
            ChartData chartData;
            chartData = new ChartData();
            if (_chartType == CHART_TYPE_BAR)
            {
                if (_displayType == DISPLAY_TYPE_LARGE)
                    chartData.data = "Bar Data\nLarge";
                else
                {
                    chartData.data = "Bar Data\nSmall";
                }
            }
            else
            {
                if (_displayType == DISPLAY_TYPE_LARGE)
                {
                    chartData.otherData = "Pie Data\nLarge";
                }
                else
                {
                    chartData.someOtherDataObject = "Pie Data\nSmall";
                }
            }

            return chartData;
        }

        private void RenderChartBackground(Graphics g)
        {
            if (_chartType == CHART_TYPE_BAR)
            {
                RenderBarChartBackground(g);
            }
            else
            {
                RenderPieChartBackground(g);
            }

            
        }

        private void RenderPieChartBackground(Graphics g)
        {
            SolidBrush brush;

            if (_displayType != DISPLAY_TYPE_LARGE)
            {
                brush = new SolidBrush(Color.Blue);
                g.FillEllipse(brush, 20, 30, 160, 160);
            }
            else
            {
                brush = new SolidBrush(Color.Blue);
                g.FillEllipse(brush, 20, 30, 320, 320);
            }

            brush.Dispose();
        }

        private void RenderBarChartBackground(Graphics g)
        {
            SolidBrush brush;

            if (_displayType == DISPLAY_TYPE_LARGE)
            {
                brush = new SolidBrush(Color.Red);

                g.FillRectangle(brush, 20, 30, 300, 300);
            }
            else
            {
                brush = new SolidBrush(Color.Red);


                g.FillRectangle(brush, 20, 30, 150, 150);
            }

            brush.Dispose();
        }
    }
}