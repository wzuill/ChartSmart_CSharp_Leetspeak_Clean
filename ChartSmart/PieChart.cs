using System.Drawing;

namespace ChartSmart
{
    internal class PieChart : Chart
    {
     
        public override void RenderBackground(string displayType, Graphics g)
        {
            SolidBrush brush;

            if (displayType != ChartSingleCompareOrig.DISPLAY_TYPE_LARGE)
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
    }
}