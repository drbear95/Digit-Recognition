using FANNCSharp;
using FANNCSharp.Float;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    //Convert.ToUInt32(txtNumLayers.Text)
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
                        net.ActivationSteepnessHidden = 1.0F;
                        net.ActivationSteepnessOutput = 1.0F;
                        string momentum = txtMomentum.Text.ToString();
                        if (momentum.Contains('.'))
                            momentum = momentum.Replace('.', ',');
                        if (float.Parse(momentum) > 1)
                        {
                            MessageBox.Show("Zbyt wysokie momentum, powinno być z zakresu od 0 do 1 (ustawiam standardowe)");
                            net.LearningMomentum = 0.8f;
                        }
                        else
                            net.LearningMomentum = float.Parse(momentum);
                        string lr = txtLearningRate.Text.ToString();
                        if (lr.Contains('.'))
                            lr = lr.Replace('.', ',');
                        if (float.Parse(momentum) > 1)
                        {
                            MessageBox.Show("Zbyt wysoki współczynnik trenowania, powinno być z zakresu od 0 do 1 (ustawiam standardowe)");
                            net.LearningRate = 0.8f;
                        }
                        else
                            net.LearningRate = float.Parse(lr);
                        txtReport.AppendText("\r\n" + "Inicjalizuje wagi");
                        net.InitWeights(data);
                        txtReport.AppendText("\r\n" + "Rozpoczynam trening");
                        _algorithm = (TrainingAlgorithm)cmbTrainAlgorithm.SelectedItem;
                        int count = 0;
                        string err = txtDesiredError.Text.ToString();
                        if (err.Contains('.'))
                            err = err.Replace('.', ',');
                        if (_algorithm == TrainingAlgorithm.TRAIN_BATCH)
                            do
                            {
                                count++;
                                net.TrainEpochBatchParallel(data, 4);
                                txtReport.AppendText("\r\n" + $"Epoka {count} zakończona, Błąd {net.MSE}"); 
                            } while (net.MSE > float.Parse(err));
                        if (_algorithm == TrainingAlgorithm.TRAIN_INCREMENTAL)
                            do
                            {
                                count++;
                                net.TrainEpochIncrementalMod(data);
                                txtReport.AppendText("\r\n" + $"Epoka {count} zakończona, Błąd {net.MSE}"); 
                            } while (net.MSE > float.Parse(err));
                        if (_algorithm == TrainingAlgorithm.TRAIN_QUICKPROP)
                            do
                            {
                                count++;
                                net.TrainEpochQuickpropParallel(data, 4);
                                txtReport.AppendText("\r\n" + $"Epoka {count} zakończona, Błąd {net.MSE}"); 
                            } while (net.MSE > float.Parse(err));
                        if (_algorithm == TrainingAlgorithm.TRAIN_RPROP)
                            do
                            {
                                count++;
                                net.TrainEpochIrpropmParallel(data, 4);
                                txtReport.AppendText("\r\n" + $"Epoka {count} zakończona, Błąd {net.MSE}"); 
                            } while (net.MSE > float.Parse(err));
                        if (_algorithm == TrainingAlgorithm.TRAIN_SARPROP)
                            do
                            {
                                count++;
                                net.TrainEpochSarpropParallel(data, 4);
                                txtReport.AppendText("\r\n" + $"Epoka {count} zakończona, Błąd {net.MSE}"); 
                            } while (net.MSE > float.Parse(err));
                        txtReport.AppendText("\r\n" + "\n Sieć wytrenowana, trwa zapisywanie...");
                        net.Save(@"..\..\Network\sampledigits_float.net");
                        decimal_point = net.SaveToFixed(@"..\..\Network\sampledigits_fixed.net");
                        data.SaveTrainToFixed(@"..\..\Network\sampledigits_fixed.data", (uint)decimal_point);
                        txtReport.AppendText("\r\n" + "Sieć zapisana");
                        MessageBox.Show("Sieć wytrenowana i zapisana");
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
