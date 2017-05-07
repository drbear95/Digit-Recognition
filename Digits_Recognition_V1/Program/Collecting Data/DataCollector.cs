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

namespace Program.Collecting_Data
{
    public partial class DataCollector : Form
    {

        public int _FontSize { get; set; }
        public DataCollector()
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
                    if (Matrix.Image == null)
                    {
                        Bitmap btm = new Bitmap(Matrix.Width, Matrix.Height,System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        Matrix.Image = btm;
                    }
                    using (Graphics g = Graphics.FromImage(Matrix.Image))
                    {
                        g.DrawLine(new Pen(Color.White, (int)cmbFontSize.SelectedItem), lastPoint, e.Location);
                        g.SmoothingMode = SmoothingMode.HighQuality;
                    }
                    Matrix.Invalidate();
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
            if (Matrix.Image != null)
            {
                Matrix.Image = null;
                Invalidate();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(@"..\..\Training Data\sampledigits.data"))
                {
                    DataAppender.GetMatrix((Bitmap)Matrix.Image, Convert.ToInt32(txtNumber.Text));
                    string[] content = File.ReadAllLines(@"..\..\Training Data\sampledigits.data");
                    content[0] = $"{(content.Count()-1) / 2} 20000 4";
                    File.Delete(@"..\..\Training Data\sampledigits.data");
                    WriteAllLinesBetter(@"..\..\Training Data\sampledigits.data", content);
                }
                else
                {
                    File.WriteAllText(@"..\..\Training Data/sampledigits.data", "1 1000 4");
                    DataAppender.GetMatrix((Bitmap)Matrix.Image, Convert.ToInt32(txtNumber.Text));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie podałeś jaka to jest liczba!", "Błąd!", MessageBoxButtons.OK);
            }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
