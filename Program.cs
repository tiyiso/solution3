using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File name  
            string fileName = @"C:\Users\PC\Desktop\Projects\AxisSolution.txt";
            FileStream stream = null;

            try
            {
                // this code snippet will create a FileStream with mode CreateNew  
                Console.WriteLine("creating a file wait a moment!!! ");
                Console.WriteLine("********************************************");                                                
                Console.WriteLine("Almost done !!!!!!!");
                Console.WriteLine("********************************************");
                stream = new FileStream(fileName, FileMode.OpenOrCreate);
                Console.WriteLine("Done the File is created !!!! ");

                Console.WriteLine("**************************************************");


                // this code snippet will create a StreamWriter from FileStream  
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine("C# Axis Solutions three Statements");
                    writer.WriteLine("======================================");
                    writer.WriteLine("My name is Ropafadzo");
                    writer.WriteLine("I come from Harare"); 
                    writer.WriteLine("I am a software developer.");
                    
                }
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
            // this code snippet will Read a file  
            string readText = File.ReadAllText(fileName);
            Console.WriteLine(readText);
            Console.ReadKey();
        }
    }
}
    

