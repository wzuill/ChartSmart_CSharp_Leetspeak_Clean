using System.Drawing;

namespace ChartSmart
{
    internal abstract class Chart
    {
        public abstract void RenderBackground(string displayType, Graphics g);
    }
}