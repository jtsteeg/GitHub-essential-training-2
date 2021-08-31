using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;


namespace EssentialTrainingApp
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static List<string> Words;
        static void Main(string[] args)
        {
            logger.Trace("the program started");
            Words = new List<string>();
            Words.Add("bread");
            Words.Add("Milk");
            Words.Add("Cheese");


            CrazyMathProblem();
            ReadTextFile();
        }

        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("could not find the directory, error: ");
                logger.Error("The directory was not found: " + ex.Message);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("could not find the file, error: ");
                logger.Error(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unkown error: " + ex);
            }
            finally
            {
                Console.WriteLine("thanks for playing!");
            }
        }
        private static int CrazyMathProblem()
        {
            var income = 1000;
            for(var i =10; i > 0; i--)
            {
                income = income = (income / i);
            }
            return income;
        }
    }
}
