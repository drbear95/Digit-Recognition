using System;
using System.Windows.Forms;
using FANNCSharp;
#if FANN_FIXED
using FANNCSharp.Fixed;
using DataType = System.Int32;
#elif FANN_DOUBLE
using FANNCSharp.Double;
using DataType = System.Double;
#else
using FANNCSharp.Float;
using DataType = System.Single;
#endif

namespace Program.Network_Training
{
    class Network_Training
    {
        public void Train()
        {
            const uint num_input = 20000;               //Ilość wejść (100x200 pixeli daje 20000pixeli więc 20000 wejść)
            const uint num_output = 4;                  //Ilość wyjść (4 wyjścia bo cyfry 0-9 zapisujemy binarnie w 4 bitach)
            const uint num_layers = 3;                  //Ilość warstw
            const uint num_neurons_hidden = 200;
            const float desired_error = 0;              //Błąd pożądany
            const uint max_epochs = 10000;              //Maksymalna ilość epok
            const uint epochs_between_reports = 10;     //Ilość epok między którymi będzie raport
            int decimal_point;
            Console.WriteLine("Creating network.");
            using (NeuralNet net = new NeuralNet(NetworkType.LAYER, num_layers, num_input, num_neurons_hidden, num_output))  // Tworzenie sieci
            using (TrainingData data = new TrainingData(@"..\..\Training Data\sampledigits.data"))                           // Ładowanie pliku danych uczących
            {
                //net.CascadeActivationFunctions = ActivationFunction.SIGMOID;
                //net.CascadetrainOnFile()
                net.InitWeights(data);                                                       //Inicjacja wag
                net.TrainOnData(data, max_epochs, epochs_between_reports, desired_error);    //Rozpoczącie treningu
                net.Save(@"..\..\Network\sampledigits_float.net");                           //Zapis wytrenowanej sieci
                decimal_point = net.SaveToFixed(@"..\..\Network\sampledigits_fixed.net");
                data.SaveTrainToFixed(@"..\..\Network\sampledigits_fixed.data", (uint)decimal_point);
            }
            MessageBox.Show("Sieć wytrenowana i zapisana");
        }
        static float FannAbs(float value)
        {
            return (((value) > 0) ? (value) : -(value));
        }
    }
}

