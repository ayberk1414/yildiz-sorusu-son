using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine("satir sayisiniz giriniz");
            counter = Convert.ToInt32(Console.ReadLine());
            string text = "";
            for (int i = 0; i <=counter ; i++)
            {
                int bosluk = counter - i;
                for (int j = 0; j < bosluk; j++)
                {
                    text += " ";
                }
                int yildiz = 2 * i - 1;
                for (int j=0; j  < yildiz; j++)
                {
                    text += "*";
                }
                text += "\n";
                Console.WriteLine(text);
                for (int l = counter - 1; l <= 0; l--)
                {
                    int boslukk = counter - l;
                    for (int j = 0; j < boslukk; j++)
                    {
                        text += "";
                    }
                    int yildizz = 2 * l - 1;
                    for (int j = 0; j < yildizz; j++)
                    {
                        text += "*";
                    }
                    text += "\n";
                    Console.WriteLine(text);
                    Console.ReadLine();

                }
          
            }
                
        }
    }
}
