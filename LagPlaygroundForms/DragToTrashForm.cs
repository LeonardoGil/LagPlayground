namespace LagPlaygroundForms
{
    public partial class DragToTrashForm : Form
    {
        private Point PointMouseDown;

        public DragToTrashForm()
        {
            InitializeComponent();

            pictureBoxTrash.BackgroundImage = ResizeImage(Properties.Resources.Lixeira, new Size(pictureBoxTrash.Size.Width, pictureBoxTrash.Size.Height));
        }

        private Image ResizeImage(Image image, Size size)
        {
            return new Bitmap(image, size);
        }

        private void CreateControl_ClickEvent(object sender, EventArgs e)
        {
            var control = new Panel();

            control.MouseMove += MoveForm_MouseMoveEvent;
            control.MouseDown += SetPoint_MouseDownEvent;
            control.MouseUp += MoveToTrash_MouseUpEvent;

            control.BackColor = Color.Red;

            Controls.Add(control);
        }

        private void SetPoint_MouseDownEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointMouseDown = e.Location;
            }
        }

        private void MoveForm_MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (sender is Control control)
            {
                if (e.Button == MouseButtons.Left)
                {
                    control.Left += e.X - PointMouseDown.X;
                    control.Top += e.Y - PointMouseDown.Y;
                }
            }
        }

        private void MoveToTrash_MouseUpEvent(object sender, MouseEventArgs e)
        {
            if (sender is Control control)
            {
                var formLocationX = e.Location.X + control.Location.X;
                var formLocationY = e.Location.Y + control.Location.Y;

                var validateX = formLocationX >= pictureBoxTrash.Location.X && formLocationX <= (pictureBoxTrash.Location.X + pictureBoxTrash.Size.Width);
                var validateY = formLocationY >= pictureBoxTrash.Location.Y && formLocationY <= (pictureBoxTrash.Location.Y + pictureBoxTrash.Size.Height);

                if (validateX && validateY)
                {
                    Controls.Remove(control);
                }
            }
        }
    }
}