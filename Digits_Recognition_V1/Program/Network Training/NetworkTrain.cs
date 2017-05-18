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

        private void HelpClick(object sender, EventArgs e)
        {
            Size = new Size(825, 470);
            string operation = ((sender as System.Windows.Forms.Button).Name).ToString();
            Dictionary<string, string[]> operations = new Dictionary<string, string[]>()
                {
                    { "btnInputHelp",new string[]{ $"Ilość wejść sieci neuronowej {txtNumInputs.Text}", "ponieważ matryca to 25px na 50px co daje nam 1250px" } },
                    { "btnOutputHelp",new string[]{$"Ilość wyjść sieci neronowej {txtNumOutputs.Text}","wynika to z założenia projektowego, na wyjściu miały pojawiać się liczby zapisane binarnie" } },
                    { "btnLayersHelp",new string[]{$"Ilość warstw sieci neuronowej {txtNumLayers.Text}","warstwa neuronów wejściowych +", "warstwa neuronów ukrytych +", "warstwa neuronów wyjściowych" ,"daję nam liczbę 3" } },
                    { "btnErrorHelp",new string[]{$"Błąd pożądany {txtDesiredError.Text}", "im mniejszy ustawimy błąd tym dokładniejsza będzie nasza sieć"} },
                    { "btnNeuronsQuantityHelp",new string[]{$"Ilość neuronów w warstwie ukrytej {txtNumNeurHidden.Text}", "nie ma dobrej recepty na dobór właściwej ilości neuronów w warstwie ukrytej","można spróbować wartości równej","pierwiastkowi z iloczynu liczby neuronów wejściowych i neuronów wyjściowych" } },
                    { "btnMomentumHelp",new string[]{"Kiedy stosowane jest momentum","korekta wag neuronu zależy nie tylko od sygnału wejściowego i błędu","jaki neuron popełnił, ale również od tego","jak duża była korekta wag w poprzednim kroku uczenia.","W ten sposób szybkość uczenia (wielkość korekty wag) automatycznie maleje w miarę zbliżania się do właściwego rozwiązania", "a proces uczenia staje się płynniejsz"} },
                    { "btnTrainRateHelp",new string[]{ "Współczynnik uczenia (w angielskiej literaturze learning rate)","można porównać do nauczyciela: zbyt wysoka wartość odpowiada nauczycielowi surowemu","który nawet za małe pomyłki stosuje wysoką karę.","Uczeń (czyli sieć) pełen frustracji miota się","od jednej skrajności do drugiej i nie może trafić na właściwe rozwiązanie."," Zbyt niski współczynnik z kolei to nauczyciel zbyt łagodny","przy którym uczeń uczy się bardzo powoli","gdyż jego błędy są tolerowane."} },
                    { "btnActivationFunctionHiddenHelp",new string[]{ "Funkcja według której obliczana jest wartość wyjścia warstwy ukrytej", Environment.NewLine, "LINEAR => Liniowa y(x)=ax+b", "Treshold => Funkcja progowa y(x)=0 dla x<a 1 dla x>a", Environment.NewLine, "Sigmoid => Funkcja sigmoidalna y(x)=1/1+e^-betax", Environment.NewLine, "Gaussian => Funkcja gaussa y(x)=ae^-(x-b)^2/2c^2", Environment.NewLine, "Elliot  funkcja Elliota (zaprojektowana przez Davida Elliota na bazie sigmoidalnej funkcji aktywacji)", Environment.NewLine, "Sin|Cos funkcja typu Sinus | Cosinus" } },
                    { "btnActivationFunctionOutHelp",new string[]{"Funkcja według której obliczana jest wartość wyjścia warstwy ukrytej", Environment.NewLine, "LINEAR => Liniowa y(x)=ax+b", "Treshold => Funkcja progowa y(x)=0 dla x<a 1 dla x>a", Environment.NewLine, "Sigmoid => Funkcja sigmoidalna y(x)=1/1+e^-betax", Environment.NewLine, "Gaussian => Funkcja gaussa y(x)=ae^-(x-b)^2/2c^2", Environment.NewLine, "Elliot  funkcja Elliota (zaprojektowana przez Davida Elliota na bazie sigmoidalnej funkcji aktywacji)", Environment.NewLine, "Sin|Cos funkcja typu Sinus | Cosinus" } },
                    { "btnTrainAlgorithmRate",new string[]{ "TRAIN_INCREMENTAL => Standardowy algorytm backpropagowania, w którym wagi są aktualizowane po każdym wzorcu szkolenia. Oznacza to, że wagi są wielokrotnie aktualizowane podczas jednej epoki. Z tego powodu niektóre problemy będą trenować bardzo szybko z tym algorytmem, podczas gdy inne bardziej zaawansowane problemy nie będą szkolone bardzo dobrze ", Environment.NewLine, "TRAIN_BATCH => Standardowy algorytm, w którym wagi są aktualizowane po obliczeniu średniego kwadratu błąd dla całego zestawu treningowego. Oznacza to, że wagi są aktualizowane tylko raz w epoce. Z tego powodu niektóre problemy będą trenować wolniej przy użyciu tego algorytmu. Ale ponieważ średni błąd kwadratowy jest obliczany bardziej poprawnie niż w szkoleniach przyrostowych, niektóre problemy osiągną lepsze rozwiązania z tym algorytmem.", Environment.NewLine, "TRAIN_RPROP => Bardziej zaawansowany algorytm szkoleń wsadowych, który zapewnia wiele dobrych wyników. Algorytm szkolenia RPROP jest adaptacyjny i dlatego nie wykorzystuje wartości uczenia się. Niektóre inne parametry mogą być ustawione tak, aby zmienić algorytm RPROP, ale jest zalecane tylko dla użytkowników z wiedzą na temat pracy algorytmu szkolenia RPROP.", Environment.NewLine, "TRAIN_QUICKPROP => Bardziej zaawansowany algorytm szkoleń wsadowych, który zapewnia wiele dobrych wyników. Algorytm szybkiego szkolenia wykorzystuje parametr learning_rate wraz z innymi bardziej zaawansowanymi parametrami, ale zaleca się tylko zmianę tych zaawansowanych parametrów dla użytkowników, którzy mają wiedzę na temat pracy algorytmu szybkiego szkolenia.", Environment.NewLine, "TRAIN_SARPROP => Symulowane wyżarzanie i rozkład wag w adaptacyjnym uczeniu się sieci neuronowej" } }
                };
            txtHelp.Lines = operations[operation];
        }

        private void btnHideHelp_Click(object sender, EventArgs e)
        {
            Size = new Size(565, 470);
        }
    }
}
