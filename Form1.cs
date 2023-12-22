using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        private Point currentPoint;
        private Point oldPoint;
        private Pen drawingPen;
        private Graphics graphics;
        private bool isDrawing;
        private Bitmap drawingBitmap;
        private int brushSize = 2;
        private Color originalColor;

        public Form1()
        {
            InitializeComponent();
            InitializeDrawing();
        }

        private void InitializeDrawing()
        {
            drawingPen = new Pen(Color.Black, brushSize);
            isDrawing = false;
            drawingBitmap = new Bitmap(canvasPictureBox.Width, canvasPictureBox.Height);
            graphics = Graphics.FromImage(drawingBitmap);
            graphics.Clear(Color.White);
            originalColor = drawingPen.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvasPictureBox.Image = drawingBitmap;
            brushSizeTrackBar.Value = brushSize;
            brushSizeTrackBar.Scroll += brushSizeTrackBar_Scroll;
            eraserButton.Click += eraserButton_Click;
        }

        private void canvasPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            oldPoint = e.Location;
        }

        private void canvasPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentPoint = e.Location;
                graphics.DrawLine(drawingPen, oldPoint, currentPoint);
                canvasPictureBox.Invalidate();
                oldPoint = currentPoint;
            }
        }

        private void canvasPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                drawingPen.Color = colorDialog.Color;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            canvasPictureBox.Invalidate();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Bitmap Image|*.bmp|JPEG Image|*.jpg|PNG Image|*.png";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveDialog.FileName;
                drawingBitmap.Save(fileName);
            }
        }

        private void brushSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            brushSize = brushSizeTrackBar.Value;
            drawingPen.Width = brushSize;
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            if (drawingPen.Color == originalColor)
            {
                drawingPen.Color = Color.White;
            }
            else
            {
                drawingPen.Color = originalColor;
            }
        }


    }
}
