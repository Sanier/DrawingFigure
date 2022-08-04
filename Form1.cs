using System.Drawing;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        private IFigure _selectedFigure;
        private bool _IsDrawing;

        public Form1()
        {
            InitializeComponent();

            SetDataToListBox();

            listBoxFigur.SelectedIndexChanged += ListBoxFigur_SelectedIndexChanged;
            panelCanvas.Paint += PanelCanvas_Paint;
            panelCanvas.MouseClick += PanelCanvas_MouseClick;

            this.CenterToScreen();
        }

        private void ListBoxFigur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFigur.SelectedItems == null) return;

            _selectedFigure = (IFigure)listBoxFigur.SelectedItem;
        }

        //Заполнение списка
        private void SetDataToListBox()
        {
            listBoxFigur.DataSource = new List<IFigure>
            {
                new Triangle(FigureType.Triangle, "Треугольник"),
                new Rectangle(FigureType.Rectangle, "Прямоугольник"),
                new Circle(FigureType.Circle, "Окружность"),
            };
            listBoxFigur.DisplayMember = nameof(IFigure.Name);
        }

        private void PanelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedFigure == null) return;

            _selectedFigure.FirstPoint = new Point(e.X, e.Y);
        }

        private void PanelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (_selectedFigure == null) return;

            _selectedFigure.SecondPoint = new Point(e.X, e.Y);

            //_IsDrawing = true;
            //panelCanvas.Refresh();
        }

        private void PanelCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!_IsDrawing) return;

            switch (_selectedFigure.Type)
            {
                case FigureType.Circle:
                    
                    //Circle.DrawCircle(e.Graphics, _selectedFigure.FirstPoint, _selectedFigure.SecondPoint);
                    Circle.DrawCircle(e.Graphics, _selectedFigure.FirstPoint, Radius);
                    RectangleSideA.Visible = false;
                    RectangleSideB.Visible = false;
                    TriangleSize.Visible = false;
                    Radius.Visible = true;
                    break;

                case FigureType.Triangle:
                    //Triangle.DrawTriangle(e.Graphics, _selectedFigure.FirstPoint, _selectedFigure.SecondPoint);
                    Triangle.DrawTriangle(e.Graphics, _selectedFigure.FirstPoint, TriangleSize);
                    RectangleSideA.Visible = false;
                    RectangleSideB.Visible = false;
                    Radius.Visible = false;
                    TriangleSize.Visible = true;
                    _IsDrawing = true;
                    break;

                case FigureType.Rectangle:
                    Rectangle.DrawRectangle(e.Graphics, _selectedFigure.FirstPoint, RectangleSideA, RectangleSideB);
                    RectangleSideA.Visible = true;
                    RectangleSideB.Visible = true;
                    Radius.Visible = false;
                    TriangleSize.Visible = false;
                    break;
            }

            _IsDrawing = false;
        }

        private void PanelCanvas_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void RectangleSideA_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedFigure == null) return;

            _selectedFigure.FirstPoint = new Point(50, 50);

            _IsDrawing = true;
            panelCanvas.Refresh();
        }

        private void RectangleSideB_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedFigure == null) return;

            _selectedFigure.FirstPoint = new Point(50, 50);

            _IsDrawing = true;
            panelCanvas.Refresh();
        }

        private void Radius_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedFigure == null) return;

            _selectedFigure.FirstPoint = new Point(50, 50);

            _IsDrawing = true;
            panelCanvas.Refresh();
        }

        private void TriangleSize_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedFigure == null) return;

            _selectedFigure.FirstPoint = new Point(100, 500);

            _IsDrawing = true;
            panelCanvas.Refresh();
        }
    }
}