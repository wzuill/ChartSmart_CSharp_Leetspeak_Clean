using System.Drawing;

namespace ChartSmart
{
    internal class BarChart : Chart
    {
        public override void RenderBackground(string displayType, Graphics g)
        {
            SolidBrush brush;

            if (displayType == ChartSingleCompareOrig.DISPLAY_TYPE_LARGE)
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