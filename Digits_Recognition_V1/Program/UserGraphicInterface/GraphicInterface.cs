using FANNCSharp.Float;
using Program.Data_Collector;
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
                        Bitmap btm = new Bitmap(25, 50, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        matrix.Image = btm;
                        matrix.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    using (Graphics g = Graphics.FromImage(matrix.Image))
                    {
                        g.DrawEllipse(new Pen(Brushes.White, 3), e.Location.X / 4, e.Location.Y / 4, 1, 1);
                        g.CompositingQuality = CompositingQuality.HighQuality;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                    }
                    matrix.Invalidate();
                    lastPoint = new Point(e.Location.X / 4, e.Location.Y / 4);
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
                try
                {
                    string[] temp = new string[matrix.Image.Width * matrix.Image.Height];
                    float[] entrydata = new float[temp.Length];
                    temp = DataAppender.GetMatrix((Bitmap)matrix.Image, temp);
                    for (int i = 0; i < temp.Length - 1; i++)
                    {
                        entrydata[i] = float.Parse(temp[i]);
                    }
                    DataType[] calc_out = net.Run(entrydata);
                    txtOut1.Text = String.Format("{0:F4}", calc_out[0]);
                    txtOut2.Text = String.Format("{0:F4}", calc_out[1]);
                    txtOut3.Text = String.Format("{0:F4}", calc_out[2]);
                    txtOut4.Text = String.Format("{0:F4}", calc_out[3]);
                    string binary = string.Empty;
                    for (int i = 0; i < 4; i++)
                    {
                        if (calc_out[i] > 0.5)
                        {
                            binary += 1;
                        }
                        else
                        {
                            binary += 0;
                        }
                    }
                    txtCheckedValue.Text = Convert.ToInt32(binary, 2).ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie narysowałeś liczby");
                }
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
            txtCheckedValue.Text = string.Empty;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnAddNewData_Click(object sender, EventArgs e)
        {
            try
            {
                DataAppender.GetMatrix((Bitmap)matrix.Image, Convert.ToInt32(txtCheckedValue.Text));
                string[] content = File.ReadAllLines(@"..\..\Training Data\sampledigits.data");
                content[0] = $"{(content.Count() - 1) / 2} 1250 4";
                File.Delete(@"..\..\Training Data\sampledigits.data");
                WriteAllLinesBetter(@"..\..\Training Data\sampledigits.data", content);
            }
            catch (Exception)
            {
                MessageBox.Show("Nie Sprawdziłeś Liczby");
            }
            btnClear.PerformClick();
        }
        public void WriteAllLinesBetter(string path, params string[] lines)
        {
            if (path == null)
                throw new ArgumentNullException("path");
            if (lines == null)
                throw new ArgumentNullException("lines");

            using (var stream = File.OpenWrite(path))
            {
                stream.SetLength(0);
                using (var writer = new StreamWriter(stream))
                {
                    if (lines.Length > 0)
                    {
                        for (var i = 0; i < lines.Length - 1; i++)
                        {
                            writer.WriteLine(lines[i]);
                        }
                        writer.Write(lines[lines.Length - 1]);
                    }
                }
            }
        }
    }
}


