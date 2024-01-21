using System.Drawing.Drawing2D;

namespace LagPlaygroundForms.Components
{
    public partial class PanelArcControl : Control
    {
        public PanelArcControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var myPath = new GraphicsPath();

            var margin = 1;

            var angleW = (int)(Width * 0.25) - margin;
            var angleH = (int)(Height * 0.25) - margin;

            // Left
            myPath.StartFigure();
            myPath.AddArc(new Rectangle(0, 0, angleW, angleH), 270, -90);
            myPath.AddArc(new Rectangle(0, Height - angleH, angleW, angleH), 180, -90);
            
            myPath.AddArc(new Rectangle(Width - angleW, Height - angleH, angleW, angleH), 90, -90);
            myPath.AddArc(new Rectangle(Width - angleW, 0, angleW, angleH), 0, -90);
            myPath.CloseFigure();

            e.Graphics.FillPath(new SolidBrush(Color.Red), myPath);
        }
    }
}
