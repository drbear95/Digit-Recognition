using System;
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
            DataType[] calc_out;
            const uint num_input = 20000;               //Ilość wejść
            const uint num_output = 4;              //Ilość wyjść
            const uint num_layers = 3;              //Ilość warstw
            const uint num_neurons_hidden = 3;      //Ilość warst ukrytych
            const float desired_error = 0;          //Błąd pożądany
            const uint max_epochs = 10000000;           //Maksymalna ilość epok
            const uint epochs_between_reports = 10; //Ilość epok między którymi będzie raport
            int decimal_point;
            Console.WriteLine("Creating network.");
            using (NeuralNet net = new NeuralNet(NetworkType.LAYER, num_layers, num_input, num_neurons_hidden, num_output))// Tworzenie sieci
            using (TrainingData data = new TrainingData(@"H:\GitHub\Digits-recognition-V1\Digits_Recognition_V1\Program\Training Data\sampledigits.data"))// Ładowanie pliku danych uczących
            {
                
                net.ActivationFunctionHidden = ActivationFunction.SIGMOID_SYMMETRIC; //Funkcja aktywacji warstwy ukrytej

                net.ActivationFunctionOutput = ActivationFunction.SIGMOID_SYMMETRIC; //Funkcja aktywacji wyjścia

                net.TrainStopFunction = StopFunction.STOPFUNC_BIT; 

                net.BitFailLimit = 0.1F;

                net.TrainingAlgorithm = TrainingAlgorithm.TRAIN_RPROP;

                net.InitWeights(data);

                Console.WriteLine("Training network.");
                net.TrainOnData(data, max_epochs, epochs_between_reports, desired_error); //Rozpoczącie treningu

                Console.WriteLine("Testing network");                 //Test wytrenowanej sieci
                DataType[][] input = data.Input;                      //Ładowanie wejść (z pliku wytrenowanej sieci)
                DataType[][] output = data.Output;                    //Ładowanie wyjść (z pliku wytrenowanej sieci)
                for (int i = 0; i < data.TrainDataLength; i++)
                {
                    calc_out = net.Run(input[i]);
                    Console.WriteLine("XOR test ({0},{1}) -> {2}, should be {3}, difference={4}",
                                        input[i][0], input[i][1], calc_out[0], output[i][0],
                                        FannAbs(calc_out[0] - output[i][0]));
                }
                Console.WriteLine("Saving network.\n");

                net.Save(@"sampledigits_float.net");       //Zapis wytrenowanej sieci

                decimal_point = net.SaveToFixed(@"sampledigits_fixed.net");
                data.SaveTrainToFixed(@"sampledigits_fixed.data", (uint)decimal_point);

                Console.ReadKey();
            }
        }

        static float FannAbs(float value)
        {
            return (((value) > 0) ? (value) : -(value));
        }

    }
}

