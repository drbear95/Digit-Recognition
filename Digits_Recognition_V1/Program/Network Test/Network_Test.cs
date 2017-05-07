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

namespace Program.Network_Test
{
    class Network_Test
    {
        public void TestNetwork()
        {
            using (NeuralNet net = new NeuralNet(@"..\..\Network\sampledigits_float.net"))
            {
                MessageBox.Show("Testing network");
                using (TrainingData dt = new TrainingData())
                {
                    dt.ReadTrainFromFile(@"..\..\Test Data\sampledigits.data");
                    for (int i = 0; i < dt.TrainDataLength; i++)
                    {
                        DataType[] calc_out = net.Run(dt.Input[i]);
                        MessageBox.Show($"Podajemy 1 " +
                            $"Powinno być {dt.OutputAccessor[i][0]} {dt.OutputAccessor[i][1]} {dt.OutputAccessor[i][2]} {dt.OutputAccessor[i][3]} " +
                            $"A jest {calc_out[0]} {calc_out[1]} {calc_out[2]} {calc_out[3]}"); 
                    }
                }
            }
        }
    }
}
