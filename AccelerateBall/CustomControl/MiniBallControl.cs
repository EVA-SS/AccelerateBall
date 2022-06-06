using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AccelerateBall
{
    public partial class MainBallControl : Control
    {
        public MainBallControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Brush brush = new SolidBrush(Color.FromArgb(78, 78, 78));
            Rectangle rect = new Rectangle(0, 0, 95, 38);
            GraphicsPath path = CreateRoundedRectanglePath(rect, 19);
            g.FillPath(brush, path);

            brush = new SolidBrush(Color.WhiteSmoke);
            rect = new Rectangle(0, 0, 95, 38);
            path = CreateRoundedRectanglePath(rect, 19);
            g.FillPath(brush, path);

            brush = new SolidBrush(Color.FromArgb(51, 154, 56));
            g.FillEllipse(brush, 2, 2, 34, 34);

            brush = new SolidBrush(Color.FromArgb(132, 209, 179));//填充的颜色         
            g.FillEllipse(brush, 4, 4, 30, 30);

            g.Dispose();
        }

        public static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
        {
            int diameter = cornerRadius * 2;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            // 左上角
            path.AddArc(arcRect, 180, 90);

            // 右上角
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // 右下角
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//闭合曲线
            return path;
        }
    }
}
