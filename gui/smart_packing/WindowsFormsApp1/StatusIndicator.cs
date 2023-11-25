using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class StatusIndicator : Control
    {
        private Color statusColor = Color.Red;

        public Color StatusColor
        {
            get { return statusColor; }
            set
            {
                statusColor = value;
                Invalidate(); // Redraw the control when the color changes
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw a filled circle with the specified color
            using (SolidBrush brush = new SolidBrush(statusColor))
            {
                e.Graphics.FillEllipse(brush, ClientRectangle);
            }

            // Optionally, draw a border around the circle
            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawEllipse(pen, ClientRectangle);
            }
        }
    }
}
