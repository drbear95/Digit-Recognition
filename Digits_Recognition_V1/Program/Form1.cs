using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program.Collecting_Data;

namespace Program
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            Network_Training.NetworkTrain nt = new Network_Training.NetworkTrain();
            nt.Show();
        }

        private void btnCollectData_Click(object sender, EventArgs e)
        {
            DataCollector dt = new DataCollector();
            dt.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Network_Test.Network_Test nt = new Network_Test.Network_Test();
            nt.TestNetwork();
        }

        private void btnDigitCheck_Click(object sender, EventArgs e)
        {
            UserGraphicInterface.GraphicInterface g = new UserGraphicInterface.GraphicInterface();
            g.Show();
        }
    }
}
