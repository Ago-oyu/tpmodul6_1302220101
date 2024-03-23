using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302220101
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            playCount = 0;
            Random rd = new Random();
            id = rd.Next(10000, 99999);
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("id         : " + id);
            Console.WriteLine("title      : " + title);
            Console.WriteLine("play count : " + playCount);
        }
    }
}
