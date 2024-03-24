using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
            try
            {
                if (String.IsNullOrEmpty(title))
                {
                    throw new ArgumentNullException();
                } else if (title.Length > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.title = title;
                playCount = 0;
                Random rd = new Random();
                id = rd.Next(10000, 99999);

            }
            
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message + " (title tidak boleh null atau kosong)\n");
            }
            
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + " (title tidak boleh lebih dari 100 karakter)\n");
            }
           
        }

        public void IncreasePlayCount(int playCount)
        {

            try
            {
                if (playCount > 10000000)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.playCount = checked(this.playCount + playCount);
            }
            
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + " (input playCount tidak boleh lebih dari 10.000.000)\n");
            }

            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
            
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("id         : " + id);
            Console.WriteLine("title      : " + title);
            Console.WriteLine("play count : " + playCount + "\n");
        }
    }
}
