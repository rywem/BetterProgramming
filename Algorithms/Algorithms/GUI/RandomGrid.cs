using Algorithms.DataClasses;
using Algorithms.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms.GUI
{
    public partial class RandomGrid : Form
    {

        List<PLACE> places;
        List<Graphics> activePlaces = new List<Graphics>();
        List<Graphics> activeLines = new List<Graphics>();
        List<Label> activeLabels = new List<Label>();
        public RandomGrid()
        {
            InitializeComponent();
        }

        private void RandomGrid_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;

        }
        /// <summary>
        /// Generate a list of places and draw them in the picture box.
        /// </summary>
        private void GeneratePlaces()
        {            
            System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 2F);
                        
            Algorithms.DataClasses.PLACE p = new Algorithms.DataClasses.PLACE();
            places = p.RandomPoints(pictureBox1.Width - 3, pictureBox1.Height - 3);
            
            foreach (PLACE place in places)
            {
                Graphics g = this.CreateGraphics();
                g = pictureBox1.CreateGraphics();
                g.DrawRectangle(pen1, place.x, place.y, place.width, place.height);
                activePlaces.Add(g); //Add the graphics to a list of active graphics so we can remove them later.
            }
        }

        private void generateRandomPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        
            Reset();
            GeneratePlaces();
        }

        private void RandomGrid_Resize(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void RandomGrid_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void AddLabel(Point point, string text)
        {
            /*
            Label l = new Label();
            l.Text = text;
            l.Location = point;
            l.AutoSize = true;
            //l.BringToFront();
            l.Visible = true;
            
            pictureBox1.Controls.Add(l);*/
        }

        private void DrawLine(Pen pen, LINE lin)
        {
            AddLabel(Algorithms.Functions.Helpers.Helper.HalfwayPoint(lin), lin.position.ToString());
            DrawLine(pen, lin.startPlace, lin.endPlace);
        }

        private void DrawLine(Pen pen, PLACE p1, PLACE p2)
        {
            DrawLine(pen, p1.point, p2.point);
        }

        private void DrawLine(Pen pen, Point p1, Point p2)
        {
            // Create pen.
            //Pen blackPen = new Pen(Color.Coral, 2);
            Graphics g = this.CreateGraphics();
            g = pictureBox1.CreateGraphics();
            
            g.DrawLine(pen, p1, p2);
            if (!(activeLines.Exists(c => c == g)))
            {
                activeLines.Add(g);
            }
        }

        private void DrawLine(int x1, int y1, int x2, int y2)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Coral, 2);
            // Draw line to screen.
            Graphics g = this.CreateGraphics();
            g = pictureBox1.CreateGraphics();
            
            g.DrawLine(blackPen, x1, y1, x2, y2);
            activeLines.Add(g);
        }

        private void clearPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to clear?", "Confirm Clear", MessageBoxButtons.YesNo);
            if(confirm == DialogResult.Yes)
            {
                Reset(); //If yes, clear the result.
            }
            
        }

        /// <summary>
        /// Reset the picture box and data.
        /// </summary>
        private void Reset()
        {
            if (activePlaces.Count > 0 || activePlaces != null)
            {
                foreach (var g in activePlaces)
                {
                    g.Clear(Color.White);
                }
            }

            if (activeLines.Count > 0 || activeLines != null)
            {
                foreach (var g in activeLines)
                {
                    g.Clear(Color.White);
                }
            }

            if (places != null)
            {
                places = null;
                places = new List<PLACE>();
            }

            if(activeLabels.Count > 0 )
            {
                foreach (var l in activeLabels)
                {
                    pictureBox1.Controls.Remove(l);
                    activeLabels.Remove(l);
                }                
            }
        }
        #region Algorithms
        private void nearestNeighborToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pre-checks
            if(places == null || (places != null && places.Count == 0))
            {
                GeneratePlaces();
            }
            
            PathRequest request = new PathRequest(places);
            Algorithms.Functions.RobotOptimization.TourOptimization nn = new Algorithms.Functions.RobotOptimization.TourOptimization();
            Algorithms.Response.PathResponse response = nn.NearestNeighbor(request);

            Pen pen = new Pen(Color.Coral, 2);
            foreach (LINE lin in response.lines)
            {
                DrawLine(pen, lin);
            }

        }
        
        private void closestPairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pre-checks
            if (places.Count == 0 || places == null)
            {
                GeneratePlaces();
            }

            PathRequest request = new PathRequest(places);
            Algorithms.Functions.RobotOptimization.TourOptimization nn = new Algorithms.Functions.RobotOptimization.TourOptimization();
            Algorithms.Response.PathResponse response = nn.ClosestPair(request);

            Pen pen = new Pen(Color.Coral, 2);
            foreach (LINE lin in response.lines)
            {
                DrawLine(pen, lin);
            }
        }
        #endregion

        private void showOutputLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputLogGUI o = new OutputLogGUI();
            o.Show();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(activeLines.Count > 0)
            {
                Graphics g = e.Graphics;
                foreach (var item in activeLines)
                {
                    // Get the graphics object 

                    //TODO Continue here: http://www.geekpedia.com/tutorial50_Drawing-with-Csharp.html
                    //g.Draw
                }
            }
        }
    }
}
