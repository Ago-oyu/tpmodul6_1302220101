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
            SayaTubeVideo video1 = new SayaTubeVideo("");
            SayaTubeVideo video2 = new SayaTubeVideo("Kg6N4TQsHpP9bMYYfr667YNFgvmczjJDFcvraJqQwwxvAwJu3kwBsyTqpH4TcE4PC7dkXJvEEykrh9tAzDQJHAqrSu6DH7ttkDgWy");
            SayaTubeVideo video3 = new SayaTubeVideo("Tutorial Design By Contract - [Yoga Fikri_Praktikan]");

            video3.PrintVideoDetails();
            video3.IncreasePlayCount(10000001);
            video3.IncreasePlayCount(100);
            video3.PrintVideoDetails();

            for (int i = 0;i < 215;i++)
            {
                video3.IncreasePlayCount(10000000);
            }
            video3.PrintVideoDetails();
        }
    }
}