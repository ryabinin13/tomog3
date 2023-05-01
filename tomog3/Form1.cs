//сканируем эллипсы и прямоугольники внутри заданной области
//каждая фигура имеет коэффициент поглощения
//выводим график зависимости каждого датчика от эффективности излучения в конце
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomog3
{
    public partial class Form1 : Form
    {    
        public Form1()
        {
            InitializeComponent();
        }
        List<Ellipse> ellipses = new List<Ellipse>()
        {
            new Ellipse(160,100,20,20, 0.255),
            new Ellipse(180,120,30,30, 0.1),
            new Ellipse(120,60,40,40, 0.01)
        };

        List<Rectangle> rectangles = new List<Rectangle>()
        {
            new Rectangle(200,330,20,20, 0.2),
            new Rectangle(320,170,30,30, 0.15),
            new Rectangle(85,100,60,40, 0.05)
        };


        double I0 = 1;
        
        
        Pen pBlack = new Pen(Color.Black);
        Pen pRed = new Pen(Color.Red);
        Pen pGreen = new Pen(Color.Green);

        public void Draw(IEnumerable<Ellipse> ellipses, IEnumerable<Rectangle> rectangles)
        {

            Graphics g = CreateGraphics();
            foreach (var item in ellipses)
            {
                Pen P = new Pen(Color.FromArgb(0,0, Convert.ToInt32(item.Coefficient * 1000)));
                var brush = new SolidBrush(Color.FromArgb(Convert.ToInt32(item.Coefficient * 1000), Convert.ToInt32(item.Coefficient * 1000), Convert.ToInt32(item.Coefficient * 1000)));
                g.DrawEllipse(pBlack, item.X0 - item.A, item.Y0 - item.B, item.A * 2, item.B * 2);
                g.FillEllipse(brush, item.X0 - item.A, item.Y0 - item.B, item.A * 2, item.B * 2);
            }
            foreach (var item in rectangles)
            {
                Pen P = new Pen(Color.FromArgb(0, 0, Convert.ToInt32(item.Coefficient * 1000)));
                var brush = new SolidBrush(Color.FromArgb(Convert.ToInt32(item.Coefficient * 1000), Convert.ToInt32(item.Coefficient * 1000), Convert.ToInt32(item.Coefficient * 1000)));
                g.DrawRectangle(pBlack, item.X0, item.Y0, item.A, item.B);
                g.FillRectangle(brush, item.X0, item.Y0, item.A, item.B);
            }
        }
        public double Ellipse(int x0, int y0, int a, int b, double phiC, double s)
        {
            
            double phi = Math.PI / 180 * phiC;


            double k = -(Math.Cos(phi) / Math.Sin(phi));
            double m = s / Math.Sin(phi);
            double h = m - y0;

            double A = (b * b) + (a * a) * (k * k);
            double B = -2 * (b * b) * x0 + 2 * (a * a) * k * h;
            double C = (b * b) * (x0 * x0) + (a * a) * (h * h) - (a * a) * (b * b);

            double D = B * B - 4 * A * C;

            if (D <= 0)
            {
                return 0;
            }
            else
            {

                int _x1 = Convert.ToInt32((-B + Math.Sqrt(D)) / (2 * A));
                int _y1 = Convert.ToInt32((s - _x1 * Math.Cos(phi)) / Math.Sin(phi));


                int _x2 = Convert.ToInt32((-B - Math.Sqrt(D)) / (2 * A));
                int _y2 = Convert.ToInt32((s - _x2 * Math.Cos(phi)) / Math.Sin(phi));

                double l = Math.Sqrt((_x1 - _x2) * (_x1 - _x2) + (_y1 - _y2) * (_y1 - _y2));
                
                return l;
            }

        }
        public double Rectangle(int x0, int y0, int a, int b, double phiC, int s)
        {

            double phi = Math.PI / 180 * phiC;

            double tDown = (y0 - s * Math.Sin(phi)) / Math.Cos(phi);
            double tUp = (y0 + b - s * Math.Sin(phi)) / Math.Cos(phi);

            double tLeft = (s * Math.Cos(phi) - x0 - a) / Math.Sin(phi);
            double tRight = (s * Math.Cos(phi) - x0) / Math.Sin(phi);

            double t1 = Min(tUp, tDown);
            double t2 = Max(tUp, tDown);
            double t3 = Min(tLeft, tRight);
            double t4 = Max(tLeft, tRight);

            


            if ((t3 > t2) | (t4 < t1))
            {
                return 0;
            }
            else if (s == 800 & phiC == 0)
            {
                return 0;
            }
            else
            {
                double t0 = Max(t1, t3);
                double tl = Min(t2, t4);

                int _x = Convert.ToInt32(s * Math.Cos(phi) - t0 * Math.Sin(phi));
                int _y = Convert.ToInt32(s * Math.Sin(phi) + t0 * Math.Cos(phi));

                int xl = Convert.ToInt32(s * Math.Cos(phi) - tl * Math.Sin(phi));
                int yl = Convert.ToInt32(s * Math.Sin(phi) + tl * Math.Cos(phi));

                double l = Math.Sqrt((_x - xl) * (_x - xl) + (_y - yl) * (_y - yl));

                return l;
            }


        }

        public void DrawParallelNormal(int R, int mMax, int h, double phiC, int s)
        {
            int xi;
            int yi;
            int xd;
            int yd;
            double phi = Math.PI / 180 * phiC;
            Pen pBlack = new Pen(Color.Black);
            Pen pRed = new Pen(Color.Red);
            Graphics g = CreateGraphics();

            
            g.DrawEllipse(pBlack, 0, 0, 2 * R, 2 * R);

            for (int m = -mMax; m <= mMax; m++)
            {

                xi = Convert.ToInt32((s + m * h) / Math.Cos(phi)) ;
                xd = 0 ;
                yi = 0 ;
                yd = Convert.ToInt32((s + m * h) / Math.Sin(phi)) ;

                g.DrawLine(pRed, xi, yi, xd, yd);
            }



        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        List<double> Imass = new List<double>();
        List<int> sources = new List<int>();
        private void buttonScan_Click(object sender, EventArgs e)
        {
            Imass.Clear();
            sources.Clear();

            

            Graphics g = CreateGraphics();
            g.Clear(Color.White);
            
            Draw(ellipses, rectangles);
            
            DrawParallelNormal(200,Convert.ToInt32(numericUpDownN.Value), Convert.ToInt32(numericUpDownH.Value), 
                Convert.ToDouble(numericUpDownPhi.Value), Convert.ToInt32(numericUpDownS.Value));
            

            for (int m = -Convert.ToInt32(numericUpDownN.Value); m <= Convert.ToInt32(numericUpDownN.Value); m++)
            {
                double l;
                double coeffR = 0;
                foreach (var item in ellipses)
                {
                    l = Ellipse(item.X0, item.Y0, item.A, item.B,
                        Convert.ToDouble(numericUpDownPhi.Value), Convert.ToInt32(numericUpDownS.Value + m * Convert.ToInt32(numericUpDownH.Value)));
                    coeffR += item.Coefficient * l;
                }
                foreach (var item in rectangles)
                {
                    l = Rectangle(item.X0, item.Y0, item.A, item.B, 
                        Convert.ToDouble(numericUpDownPhi.Value), Convert.ToInt32(numericUpDownS.Value + m * Convert.ToInt32(numericUpDownH.Value)));
                    coeffR += item.Coefficient * l;
                }
                double Im = I0 * Math.Pow(Math.E, -coeffR);
                Imass.Add(Im);
                sources.Add(m);
            }
            
            
            
        }
        public void DrawGrafic()
        {
            this.chart1.Series[0].Points.Clear();
            

            for (int i = 0; i < Imass.Count; i++)
            {
                chart1.Series[0].Points.AddXY(sources[i], Imass[i]);
            }
            
        }
        public void ClearGrafic()
        {
            this.chart1.Series[0].Points.Clear();
        }

        private void buttonClearGrafic_Click(object sender, EventArgs e)
        {
            ClearGrafic();
        }

        private void buttonGraficAdd_Click(object sender, EventArgs e)
        {
            DrawGrafic();
        }


        public double Max(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public double Min(double a, double b)
        {
            if (a < b)
                return a;
            else
                return b;
        }
    }
}
