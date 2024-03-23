using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302220101
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [Yoga Fikri_Praktikan]");
            video.PrintVideoDetails();
        }
    }
}