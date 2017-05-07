using FANNCSharp;
using FANNCSharp.Float;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Network_Training
{
    public partial class NetworkTrain : Form
    {
        private ActivationFunction _activation { get; set; }
        private TrainingAlgorithm _algorithm { get; set; }
        public NetworkTrain()
        {
            InitializeComponent();
            cmbActivationFunctionHidden.DataSource = Enum.GetValues(typeof(ActivationFunction));
            cmbActivationFunctionOutput.DataSource = Enum.GetValues(typeof(ActivationFunction));
            cmbTrainAlgorithm.DataSource = Enum.GetValues(typeof(TrainingAlgorithm));
        }
        private void Train()
        {
            Invoke(new Action(() =>
            {
                txtReport.AppendText("Tworzenie sieci...");
                using (NeuralNet net = new NeuralNet(NetworkType.LAYER,
                    Convert.ToUInt32(txtNumLayers.Text),
                    Convert.ToUInt32(txtNumInputs.Text),
                    Convert.ToUInt32(txtNumNeurHidden.Text),
                    Convert.ToUInt32(txtNumOutputs.Text)))
                {
                    int decimal_point;
                    txtReport.AppendText("\r\n" + $"Ilość warstw {Convert.ToUInt32(txtNumLayers.Text)}");
                    txtReport.AppendText("\r\n" + $"Ilość wejść  {Convert.ToUInt32(txtNumInputs.Text)}");
                    txtReport.AppendText("\r\n" + $"Ilość neuronów w warstwie ukrytej {Convert.ToUInt32(txtNumNeurHidden.Text)}");
                    txtReport.AppendText("\r\n" + $"Ilość wyjść  {Convert.ToUInt32(txtNumOutputs.Text)}");
                    txtReport.AppendText("\r\n" + "Przygotowuje trening...");
                    txtReport.AppendText("\r\n" + $"Funkcja aktywacji warstwy ukrytej {cmbActivationFunctionHidden.SelectedItem.ToString()}");
                    txtReport.AppendText("\r\n" + $"Funkcja aktywacji wyjścia {cmbActivationFunctionOutput.SelectedItem.ToString()}");
                    txtReport.AppendText("\r\n" + $"Algorytm trenowania {cmbTrainAlgorithm.SelectedItem.ToString()}");
                    using (TrainingData data = new TrainingData(@"..\..\Training Data\sampledigits.data"))
                    {
                        _activation = (ActivationFunction)cmbActivationFunctionHidden.SelectedItem;
                        net.ActivationFunctionHidden = _activation;
                        _activation = (ActivationFunction)cmbActivationFunctionOutput.SelectedItem;
                        net.ActivationFunctionOutput = _activation;
                        _algorithm = (TrainingAlgorithm)cmbTrainAlgorithm.SelectedItem;
                        net.TrainingAlgorithm = _algorithm;
                        net.TrainStopFunction = StopFunction.STOPFUNC_BIT;
                        net.BitFailLimit = 0.001F;
                        txtReport.AppendText("\r\n" + "Inicjalizuje wagi");
                        net.InitWeights(data);
                        txtReport.AppendText("\r\n" + "Rozpoczynam trening");
                        net.TrainOnData(data, Convert.ToUInt32(txtNumEpoch.Text), 10, Convert.ToUInt32(txtDesiredError.Text));
                        txtReport.AppendText("\r\n" + "\n Sieć wytrenowana, trwa zapisywanie...");
                        net.Save(@"..\..\Network\sampledigits_float.net");
                        decimal_point = net.SaveToFixed(@"..\..\Network\sampledigits_fixed.net");
                        data.SaveTrainToFixed(@"..\..\Network\sampledigits_fixed.data", (uint)decimal_point);
                        txtReport.AppendText("\r\n" + "Sieć zapisana");
                    }
                }
            }));
        }
        private void btnTrain_Click(object sender, EventArgs e)
        {
            btnTrain.Enabled = false;
            Thread t = new Thread(Train);
            t.Start();
            btnTrain.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
