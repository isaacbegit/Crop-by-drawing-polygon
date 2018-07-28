
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// Image Crop by drag and drop polygon points on image 
/// Copyright :www.th3brainware.com
/// </summary>
namespace MovableGrid
{
    public partial class Form1 : Form
    {
        List<Point> LstCalibratedPrev = new List<Point>();
        private const int object_radius = 4;
        private const int object_radius2 = 8;
        private const int over_dist_squared = object_radius * object_radius;
        private Point[] Poly1;
        private Point[] Poly2;
      
        string FilePath = Application.StartupPath + @"\Config";
        List<Point> FilPoints = new List<Point>();

        // The polygon and index of the corner we are moving.
        private List<Point> MovingPolygon = null;
        private int MovingPoint = -1;
        private int OffsetX, OffsetY;
        Form Frm = new Form();
        PictureBox Resultbox = new PictureBox();

        public Form1()
        {
            InitializeComponent();
        }
        // Calculate the distance squared between two points.
        private float FindDistanceToPointSquared(PointF pt1, Point pt2)
        {
            float dx = pt1.X - pt2.X;
            float dy = pt1.Y - pt2.Y;
            return dx * dx + dy * dy;
        }
        // See if the mouse is over a corner point.
        private bool MouseIsOverCornerPoint(Point mouse_pt, out List<Point> hit_polygon, out int hit_pt)
        {
            // See if we're over a corner point.

            // See if we're over one of the polygon's corner points.
            for (int i = 0; i < LstCalibratedPrev.Count; i++)
            {
                // See if we're over this point.
                if (FindDistanceToPointSquared(new Point(LstCalibratedPrev[i].X, LstCalibratedPrev[i].Y), mouse_pt) < over_dist_squared)
                {
                    // We're over this point.
                    hit_polygon = LstCalibratedPrev;
                    hit_pt = i;
                    return true;
                }
            }


            hit_polygon = null;
            hit_pt = -1;
            return false;
        }

        private void pictureBox2_MouseMove_MovingCorner(object sender, MouseEventArgs e)
        {
            // Move the point.
            int Mpoint = (int)MovingPoint;
            MovingPolygon[Mpoint] = new Point(e.X + OffsetX, e.Y + OffsetY);
            LstCalibratedPrev[Mpoint] = new Point(e.X + OffsetX, e.Y + OffsetY);


            Poly1[0] = new Point(0, 0);
            Poly1[1] = new Point(720, 0);
            Poly1[2] = LstCalibratedPrev[2];
            Poly1[3] = LstCalibratedPrev[1];
            Poly1[4] = LstCalibratedPrev[0];
            Poly1[5] = LstCalibratedPrev[7];
            Poly1[6] = LstCalibratedPrev[6];
            Poly1[7] = new Point(0, 576);
            Poly2[0] = new Point(720, 0);
            Poly2[1] = LstCalibratedPrev[2];
            Poly2[2] = LstCalibratedPrev[3];
            Poly2[3] = LstCalibratedPrev[4];
            Poly2[4] = LstCalibratedPrev[5];
            Poly2[5] = LstCalibratedPrev[6];
            Poly2[6] = new Point(0, 576);
            Poly2[7] = new Point(720, 576);



            // Redraw.
            boxImg.Invalidate();
        }

        private void boxImg_MouseMove_MovingCorner(object sender, MouseEventArgs e)
        {
            // Move the point.
            int Mpoint = (int)MovingPoint;
            MovingPolygon[Mpoint] = new Point(e.X + OffsetX, e.Y + OffsetY);
            LstCalibratedPrev[Mpoint] = new Point(e.X + OffsetX, e.Y + OffsetY);


            Poly1[0] = new Point(0, 0);
           Poly1[1] = new Point(720, 0);
           Poly1[2] = LstCalibratedPrev[2];
            Poly1[3] = LstCalibratedPrev[1];
            Poly1[4] = LstCalibratedPrev[0];
            Poly1[5] = LstCalibratedPrev[7];
            Poly1[6] = LstCalibratedPrev[6];
            Poly1[7] = new Point(0, 576);
            Poly2[0] = new Point(720, 0);
            Poly2[1] = LstCalibratedPrev[2];
           Poly2[2] = LstCalibratedPrev[3];
           Poly2[3] = LstCalibratedPrev[4];
            Poly2[4] = LstCalibratedPrev[5];
           Poly2[5] = LstCalibratedPrev[6];
            Poly2[6] = new Point(0, 576);
           Poly2[7] = new Point(720, 576);



            // Redraw.
            boxImg.Invalidate();
        }

        private void boxImg_MouseUp_MovingCorner(object sender, MouseEventArgs e)
        {
         //   boxImg.MouseMove += boxImg_MouseMove_NotDrawing;
            boxImg.MouseMove -= boxImg_MouseMove_MovingCorner;
            boxImg.MouseUp -= boxImg_MouseUp_MovingCorner;
            Resultbox.Refresh();
        }

        private void boxImg_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.High;
            if ( LstCalibratedPrev.Count != 0)
            {
                Pen thikpen = new Pen(Color.FromArgb(30, 144, 255), 3);
                e.Graphics.DrawPolygon(thikpen, LstCalibratedPrev.ToArray());
                Polygon pgon = new Polygon(LstCalibratedPrev.ToArray());
                Point pt = pgon.FindCentroid();
                Rectangle rect_centroid = new Rectangle((int)pt.X - 8, (int)pt.Y - 8, 16, 16);
                e.Graphics.FillEllipse(Brushes.WhiteSmoke, rect_centroid);
                e.Graphics.DrawEllipse(Pens.White, rect_centroid);


                foreach (PointF corner in LstCalibratedPrev)
                {



                    Rectangle rect = new Rectangle((int)corner.X - object_radius, (int)corner.Y - object_radius, 2 * object_radius + 1, 2 * object_radius + 1);
                    Rectangle rect2 = new Rectangle((int)corner.X - object_radius2, (int)corner.Y - object_radius2, 2 * object_radius2 + 1, 2 * object_radius2 + 1);
                    e.Graphics.FillEllipse(Brushes.WhiteSmoke, rect);
                    Pen Circle = new Pen(Color.FromArgb(30, 144, 255), 1);
                    e.Graphics.DrawEllipse(Circle, rect2);
                    e.Graphics.DrawLine(Pens.WhiteSmoke, corner, pt);


                }
            }

        }
        public string ReadFromConfig(string FilePath, int LineNo)
        {
            string[] lines = System.IO.File.ReadAllLines(FilePath);
            return lines[LineNo];
        }

        //Wtite to config
        public void WriteToConfig(string filePath, int LineNo, string Opttrg)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            lines[LineNo] = Opttrg.ToString();
            System.IO.File.WriteAllLines(filePath, lines);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 20;
            Frm.Width = 750;
            Frm.Height = 560;
            Frm.FormBorderStyle = FormBorderStyle.Sizable;
            Frm.Text = "Drawing Result";
            Frm.ControlBox = false;
            Frm.StartPosition = FormStartPosition.Manual;
            Frm.Left = this.Left + this.Width;
            Frm.Top = this.Top;
            Resultbox.Top = 0;
            Resultbox.Left = 0;
            Resultbox.Width = 750;
            Resultbox.Height = 550;



            Resultbox.BackColor = Color.Yellow;
            Resultbox.BackgroundImageLayout = ImageLayout.Stretch;
            Resultbox.Paint += new PaintEventHandler(RsultBox_Paint);

            Frm.Controls.Add(Resultbox);

            Frm.Show();

            // load Poly1
            Poly1 = new Point[8];
            Poly2 = new Point[8];

            string str_poly1 = ReadFromConfig(FilePath, 5).Trim();
            string[] Poly1Arry;
            char[] Poly1sep = new char[] { ' ' };
            Poly1Arry = str_poly1.Split(Poly1sep);
            int Polyindex = 0;
            for (int x = 0; x < Poly1Arry.Length; x++)
            {
                Poly1[Polyindex] = new Point(Int32.Parse(Poly1Arry[x]), Int32.Parse(Poly1Arry[x + 1]));
                Polyindex += 1;
                x += 1;
            }

            //load Poly2
            string str_poly2 = ReadFromConfig(FilePath, 7).Trim();
            string[] Poly2Arry;
            char[] Poly2sep = new char[] { ' ' };
            Poly2Arry = str_poly2.Split(Poly2sep);
            int Polyindex2 = 0;
            for (int x = 0; x < Poly2Arry.Length; x++)
            {
                Poly2[Polyindex2] = new Point(Int32.Parse(Poly2Arry[x]), Int32.Parse(Poly2Arry[x + 1]));
                Polyindex2 += 1;
                x += 1;
            }




            // load old polygon
            LstCalibratedPrev = new List<Point>();
            string PrevCalibratedPoints = ReadFromConfig(FilePath, 3).Trim();
            string[] strSplitArr;
            char[] separator = new char[] { ' ' };
            strSplitArr = PrevCalibratedPoints.Split(separator);
            for (int x = 0; x < strSplitArr.Length - 1; x++)
            {

                LstCalibratedPrev.Add(new Point(Int32.Parse(strSplitArr[x]), Int32.Parse(strSplitArr[x + 1])));
                x += 1;
            }
            boxImg.Refresh();
        }
        // transperent Color
        int T = 10;
        private Color Color2Transparent(int T, Color c)
        {
            return Color.FromArgb(T, c.R, c.G, c.B);
        }

        private void RsultBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.High;
            if (Poly1.Length != 0)
                {
                    e.Graphics.FillPolygon(new SolidBrush(Color2Transparent(T,Color.Black)), Poly1);
                }
                if (Poly2.Length != 0)
                {
                    e.Graphics.FillPolygon(new SolidBrush(Color2Transparent(T, Color.Black)), Poly2);
                }
            
            if (FilPoints.Count != 0)
            {
                for (int x = 0; x < FilPoints.Count; x++)
                {
                    Rectangle Rec3 = new Rectangle(FilPoints[x].X - 5, FilPoints[x].Y - 5, 11, 11);
                    e.Graphics.DrawEllipse(Pens.Green, Rec3);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_selectImg_Click(object sender, EventArgs e)
        {
           
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox PictureBox1 = new PictureBox();

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    boxImg.BackgroundImage  = new Bitmap(dlg.FileName);
                    Resultbox.BackgroundImage = new Bitmap(dlg.FileName);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int Curval=trackBar1.Value;
            T = Curval;
            Resultbox.Refresh();
        }

        private void boxImg_MouseDown(object sender, MouseEventArgs e)
        {
            List<Point> hit_polygon;
            int hit_point;
            if (MouseIsOverCornerPoint(e.Location, out hit_polygon, out hit_point))
            {
                // Start dragging this corner.
               // boxImg.MouseMove -= boxImg_MouseMove_NotDrawing;
                boxImg.MouseMove += boxImg_MouseMove_MovingCorner;
                boxImg.MouseUp += boxImg_MouseUp_MovingCorner;

                // Remember the polygon and point number.
                MovingPolygon = hit_polygon;
                MovingPoint = hit_point;

                // Remember the offset from the mouse to the point.
                int hpoint = (int)hit_point;
                OffsetX = hit_polygon[hpoint].X - e.X;
                OffsetY = hit_polygon[hpoint].Y - e.Y;


            }
        }
    }
}
