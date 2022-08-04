using System.Drawing;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        private IFigure _selectedFigure;

        private readonly Rectangle _selectedRectangle;
        private readonly Triangle _selectedTriangle;
        private readonly Circle _selectedCircle;

        private bool _IsDrawing;

        public Form1()
        {
            InitializeComponent();

            SetDataToListBox();
        }

        private void listBoxFigur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFigur.SelectedItems == null) return;

            _selectedFigure = listBoxFigur.SelectedItem as IFigure;
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

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedFigure == null) return;

            _selectedFigure.FirstPoint = new Point(e.X, e.Y);
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (_selectedFigure == null) return;

            _selectedFigure.SecondPoint = new Point(e.X, e.Y);

            _IsDrawing = true;
            panelCanvas.Refresh();
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!_IsDrawing) return;

            switch (_selectedFigure.Type)
            {
                case FigureType.Circle:

                    break;

                case FigureType.Triangle:
                    break;

                case FigureType.Rectangle:
                    _selectedRectangle.DrawRectangle(e.Graphics, _selectedFigure.FirstPoint, _selectedFigure.SecondPoint);
                    break;

                default:
                    break;
            }
        }
    }
}