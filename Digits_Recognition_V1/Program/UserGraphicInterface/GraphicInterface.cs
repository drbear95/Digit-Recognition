using FANNCSharp.Float;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataType = System.Single;

namespace Program.UserGraphicInterface
{
    public partial class GraphicInterface : Form
    {
        public GraphicInterface()
        {
            InitializeComponent();
            cmbFontSize.Items.AddRange(new object[]
            {
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12,
                13,
                14,
                15,
            });
            cmbFontSize.SelectedIndex = 0;
        }
        Point lastPoint = Point.Empty;
        bool isMouseDown = new Boolean();
        private void Matrix_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
        }
        private void Matrix_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                if (lastPoint != null)
                {
                    if (matrix.Image == null)
                    {
                        Bitmap btm = new Bitmap(matrix.Width, matrix.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        matrix.Image = btm;
                    }
                    using (Graphics g = Graphics.FromImage(matrix.Image))
                    {
                        g.DrawLine(new Pen(Color.White, (int)cmbFontSize.SelectedItem), lastPoint, e.Location);
                        g.SmoothingMode = SmoothingMode.HighQuality;
                    }
                    matrix.Invalidate();
                    lastPoint = e.Location;
                }
            }
        }
        private void Matrix_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            lastPoint = Point.Empty;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            if (matrix.Image != null)
            {
                matrix.Image = null;
                Invalidate();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            using (NeuralNet net = new NeuralNet(@"..\..\Network\sampledigits_float.net"))
            {
                string[] temp = new string[matrix.Image.Width * matrix.Image.Height];
                float[] entrydata = new float[temp.Length];
                temp = Data_Collector.DataAppender.GetMatrix((Bitmap)matrix.Image, temp);
                for (int i = 0; i < temp.Length-1; i++)
                {
                    entrydata[i] = float.Parse(temp[i]);
                }
                DataType[] calc_out = net.Run(entrydata);
                txtOut1.Text = calc_out[0].ToString();
                txtOut2.Text = calc_out[1].ToString();
                txtOut3.Text = calc_out[2].ToString();
                txtOut4.Text = calc_out[3].ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (matrix.Image != null)
            {
                matrix.Image = null;
                Invalidate();
            }
            txtOut1.Text = String.Empty;
            txtOut2.Text = String.Empty;
            txtOut3.Text = String.Empty;
            txtOut4.Text = String.Empty;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Hide();
        }
    }
}


