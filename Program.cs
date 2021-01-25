using System;
using System.IO;

namespace _07_morse_code
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(@"..\..\..\input.txt"))
            {
                Console.WriteLine(" no file 'input.txt' in program folder, hit any key to try again");
                Console.ReadKey();
                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                Environment.Exit(0);
            }
            string inp = File.ReadAllText(@"..\..\..\input.txt").ToString();
            string [] inplet = inp.Split('/');
            char[] outlet = new char[inplet.Length];
            char[] keyA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ".ToCharArray();
            string[] keyB = ".-/-.../-.-./-.././..-./--./..../../.---/-.-/.-../--/-./---/.--./--.-/.-./.../-/..-/...-/.--/-..-/-.--/--../".Split('/');
            for (int i = 0; i < inplet.Length; i++)
                for (int j = 0; j < keyB.Length; j++)
                {
                    if (inplet[i]==keyB[j])
                    {
                        outlet[i] = keyA[j];
                        break;
                    }
                }


            var outp = new string(outlet);
            Console.WriteLine(outp);
            File.WriteAllText(@"..\..\..\output.txt",outp);
            Console.WriteLine("your text is also in 'output.txt'");




            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
