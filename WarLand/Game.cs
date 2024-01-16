using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voronoi2;
using static System.Runtime.InteropServices.JavaScript.JSType;
using CSPoint = System.Drawing.Point;

namespace WarLand
{
    public partial class Game : Form
    {
        Bitmap bitmap;
        Bitmap background;
        Graphics g;
        Random seeder;
        Voronoi voroObject;
        static int siteCount = 60;

        int width;
        int height;

        private const double VerySmallThreshold = 200.0;
        private const double SmallThreshold = 500.0;
        private const double MediumThreshold = 650.0;
        private const double BigThreshold = 925.0;

        public Game()
        {
            InitializeComponent();


        }

        public class VoronoiCell
        {
            public Site Site { get; set; }
            public List<GraphEdge> Edges { get; set; }

            public VoronoiCell()
            {
                Edges = new List<GraphEdge>();
            }
        }

        List<VoronoiCell> voronoiCells = new List<VoronoiCell>();

        void spreadPoints()
        {
            g.Clear(Color.DarkGray);

            List<PointF> sites = new List<PointF>();
            int seed = seeder.Next();
            Random rand = new Random(seed);

            for (int i = 0; i < siteCount; i++)
            {
                PointF point1 = new PointF((float)(rand.NextDouble() * panel1.Width), (float)(rand.NextDouble() * panel1.Height));
                sites.Add(point1);
            }

            List<GraphEdge> ge;
            ge = MakeVoronoiGraph(sites, bitmap.Width, bitmap.Height);

            // Draw a border around the bitmap
            Pen borderPen = new Pen(Color.Black, 3); // Border color and thickness
            g.DrawRectangle(borderPen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);

            // Populate Voronoi cells
            voronoiCells.Clear();
            foreach (var site in voroObject.Sites)
            {
                var cell = new VoronoiCell { Site = site };
                foreach (var edge in ge.Where(e => e.site1 == site.sitenbr || e.site2 == site.sitenbr))
                {
                    cell.Edges.Add(edge);
                }
                voronoiCells.Add(cell);
            }

            for (int i = 0; i < ge.Count; i++)
            {
                try
                {
                    CSPoint p1 = new CSPoint((int)ge[i].x1, (int)ge[i].y1);
                    CSPoint p2 = new CSPoint((int)ge[i].x2, (int)ge[i].y2);
                    Pen thickPen = new Pen(Color.Black, 2.0f); // 3.0f is the thickness of the line
                    g.DrawLine(thickPen, p1.X, p1.Y, p2.X, p2.Y);
                }
                catch
                {
                    string s = "\nP " + i + ": " + ge[i].x1 + ", " + ge[i].y1 + " || " + ge[i].x2 + ", " + ge[i].y2;
                }
            }

            foreach (var cell in voronoiCells)
            {
                double perimeter = CalculatePerimeter(cell);
                string category = CategorizeCell(perimeter);
                int boxSize = GetBoxSize(category);
                float fontSize = GetFontSize(category);

                // Check if cell.Edges contains elements before calculating the centroid
                if (cell.Edges.Count > 0)
                {
                    // Calculate the approximate centroid of the cell
                    float centroidX = cell.Edges.Average(e => (float)(e.x1 + e.x2) / 2);
                    float centroidY = cell.Edges.Average(e => (float)(e.y1 + e.y2) / 2);

                    // Calculate the top-left corner of the box
                    float boxX = centroidX - boxSize / 2;
                    float boxY = centroidY - boxSize / 2;

                    // Draw the blue box
                    SolidBrush color = new SolidBrush(Color.FromArgb(64, 105, 105, 105));
                    g.FillRectangle(color, boxX, boxY, boxSize, boxSize);

                    // Determine the text to draw based on the category
                    string textToDraw = category switch
                    {
                        "Very Small" => "1",
                        "Small" => "2",
                        "Medium" => "3",
                        "Big" => "4",
                        "Very Big" => "5",
                        _ => "0"
                    };

                    // Draw the text with the appropriate font size
                    StringFormat stringFormat = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    using (Font font = new Font("Verdana", fontSize, FontStyle.Bold))
                    {
                        g.DrawString(textToDraw, font, Brushes.White, centroidX, centroidY, stringFormat);
                    }
                }
            }

            panel1.Image = bitmap;
        }

        private double CalculatePerimeter(VoronoiCell cell)
        {
            double perimeter = 0;
            for (int i = 0; i < cell.Edges.Count; i++)
            {
                var edge = cell.Edges[i];
                double distance = Math.Sqrt(Math.Pow(edge.x2 - edge.x1, 2) + Math.Pow(edge.y2 - edge.y1, 2));
                perimeter += distance;
            }
            return perimeter;
        }

        private string CategorizeCell(double perimeter)
        {
            if (perimeter < VerySmallThreshold)
                return "Very Small";
            else if (perimeter < SmallThreshold)
                return "Small";
            else if (perimeter < MediumThreshold)
                return "Medium";
            else if (perimeter < BigThreshold)
                return "Big";
            else
                return "Very Big";
        }



        List<GraphEdge> MakeVoronoiGraph(List<PointF> sites, int width, int height)
        {
            double[] xVal = new double[sites.Count];
            double[] yVal = new double[sites.Count];
            for (int i = 0; i < sites.Count; i++)
            {
                xVal[i] = sites[i].X;
                yVal[i] = sites[i].Y;
            }
            return voroObject.generateVoronoi(xVal, yVal, 0, width, 0, height);

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var cell in voronoiCells)
            {
                double perimeter = CalculatePerimeter(cell);
                string category = CategorizeCell(perimeter);
                int boxSize = GetBoxSize(category);

                float centroidX = cell.Edges.Average(edge => (float)(edge.x1 + edge.x2) / 2);
                float centroidY = cell.Edges.Average(edge => (float)(edge.y1 + edge.y2) / 2);

                float boxX = centroidX - boxSize / 2;
                float boxY = centroidY - boxSize / 2;

                RectangleF boxRect = new RectangleF(boxX, boxY, boxSize, boxSize);
                if (boxRect.Contains(e.Location))
                {
                    MessageBox.Show($"Cell clicked: {cell.Site.sitenbr}, Category: {category}");
                    break;
                }
            }
        }

        private int GetBoxSize(string category)
        {
            switch (category)
            {
                case "Very Small":
                    return 15; // Smaller size for "Very Small"
                case "Small":
                    return 27; // Current size for "Small"
                case "Medium":
                    return 38; // Double the size for "Medium"
                case "Big":
                    return 55; // Even larger size for "Big"
                case "Very Big":
                    return 68;
                default:
                    return 27; // Default to "Small" size
            }
        }

        private float GetFontSize(string category)
        {
            switch (category)
            {
                case "Very Small":
                    return 10f; // Smaller font size for "Very Small"
                case "Small":
                    return 13f; // Standard font size for "Small"
                case "Medium":
                    return 18f; // Larger font size for "Medium"
                case "Big":
                    return 23f; // Even larger font size for "Big"
                case "Very Big":
                    return 29f;
                default:
                    return 13f; // Default to "Small" font size
            }
        }

        private bool IsPointInCell(System.Drawing.Point point, VoronoiCell cell)
        {
            var polygon = cell.Edges.SelectMany(e => new[] { new PointF((float)e.x1, (float)e.y1), new PointF((float)e.x2, (float)e.y2) }).Distinct().ToList();
            int count = polygon.Count;
            int j = count - 1;
            bool inside = false;

            for (int i = 0; i < count; i++)
            {
                var pi = polygon[i];
                var pj = polygon[j];

                if (((pi.Y > point.Y) != (pj.Y > point.Y)) &&
                    (point.X < (pj.X - pi.X) * (point.Y - pi.Y) / (pj.Y - pi.Y) + pi.X))
                {
                    inside = !inside;
                }

                j = i;
            }

            return inside;
        }


        void Button1_Click(object sender, EventArgs e)
        {
            spreadPoints();
            //background = Clone32BPPBitmap ( bitmap );
        }

        void panel1MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X + ", " + e.Y;
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            width = panel1.Width;
            height = panel1.Height;

            seeder = new Random();
            // MessageBox.Show($"{panel1.Width} + {panel1.Height}");
            bitmap = new Bitmap(width, height);

            background = new Bitmap(width, height);
            Graphics g2 = Graphics.FromImage(background);
            g2.Clear(Color.DarkGray);
            g2 = null;

            g = Graphics.FromImage(bitmap);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.DarkGray);
            panel1.Image = bitmap;

            voroObject = new Voronoi(0.1);
        }
    }
}