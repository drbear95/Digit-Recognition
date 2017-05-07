﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Data_Collector
{
    public static class DataAppender
    {
        private static List<string> numbers = new List<string>()
        {
            "0 0 0 0",
            "0 0 0 1",
            "0 0 1 0",
            "0 0 1 1",
            "0 1 0 0",
            "0 1 0 1",
            "0 1 1 0",
            "0 1 1 1",
            "1 0 0 0",
            "1 0 0 1",
        };
        public static void GetMatrix(Bitmap image,int number)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    if (image.GetPixel(x, y)==Color.Black || image.GetPixel(x, y).R>0 || image.GetPixel(x, y).B>0 || image.GetPixel(x, y).B>0)
                    {
                        sb.Append("1 ");
                    }
                    else
                    {
                        sb.Append("0 ");
                    }
                }
            }
            sb.Append("\n");
            sb.Append(numbers[number]);
            File.AppendAllText(@"..\..\Training Data\sampledigits.data", sb.ToString());
        }
        public static string[] GetMatrix(Bitmap image, string[] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    if (image.GetPixel(x, y) == Color.Black || image.GetPixel(x, y).R > 0 || image.GetPixel(x, y).B > 0 || image.GetPixel(x, y).B > 0)
                    {
                        sb.Append("1 ");
                    }
                    else
                    {
                        sb.Append("0 ");
                    }
                }
            }
            return matrix = sb.ToString().Split(' ').ToArray();
        }
    }
}
