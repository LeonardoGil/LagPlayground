using System.Drawing.Drawing2D;

namespace LagPlaygroundForms.Basketball
{
    public partial class BasketballControl : UserControl
    {
        public BasketballControl()
        {
            MinimumSize = new Size(24, 24);
            
            InitializeComponent();
        }

        private void GetFigurePath()
        {
            int arcSize = Height - 2;

            var leftArc = new Rectangle(0, 0, arcSize, arcSize);
            var rightArc = new Rectangle(arcSize, 0, arcSize, arcSize);

            var path = new GraphicsPath();


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //e.Graphics.DrawEllipse(new Pen(Color.Black, 2), new Rectangle(0, 0, Width >= 20 ? 20 : Width, Height >= 20 ? 20 : Height));

            /*
             * 400
             * (1 * 2) - 400
             * 3 + 400 = 403
             * 
             * 
            */

            e.Graphics.DrawEllipse(new Pen(Color.Black, 3), new Rectangle(1, 1, Width - 3, Height - 3));
            e.Graphics.FillEllipse(new SolidBrush(Color.Orange), new Rectangle(3, 3, Width - 7, Height - 7));

            // Linha Horizontal
            e.Graphics.DrawLine(new Pen(Color.Black, 3), new Point(1, Height / 2), new Point(Width - 1, Height / 2));
            // Linha Vertical
            e.Graphics.DrawLine(new Pen(Color.Black, 3), new Point(Width / 2, 1), new Point(Width / 2, Height - 1));
        }

        protected override void OnResize(EventArgs e)
        {
            if (Size.Height != Size.Width)
            {
                Size = new Size(Size.Width, Size.Width);
            }

            base.OnResize(e);
        }
    }

}