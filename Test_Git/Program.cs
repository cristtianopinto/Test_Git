using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Git
{
    class Program
    {

        // public char a;
        //public string _chemin;
        public static void Entrer2()
        {
            string _chemain2 = "";
            int t;
            Random rnd;
            while (true)
            {
                rnd = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    t = rnd.Next(0, 5);
                    if (t == 0)
                    {
                        _chemain2 = _chemain2 + "          ";
                    }
                    if (t == 1)
                    {
                        _chemain2 = _chemain2 + "REFD";
                    }
                    if (t >= 2)
                    {
                        _chemain2 = _chemain2 + "çè_'(";
                    }
                }
                Console.WriteLine(_chemain2);
                //System.Threading.Thread.Sleep(10); //wait for 1 sec
            }
               
        }
        public static void Entrer1()
        {
            char a='c';
            string _chemain="";
            while (a!='e')
            {
                Console.WriteLine(_chemain+"X");
                a = Console.ReadKey().KeyChar;
                if (a == 'd')
                {
                    _chemain = _chemain + " ";
                }
                if (a == 's')
                {
                    _chemain = "\n"+ _chemain ;
                }
                if (a == 'q')
                {
                    if (_chemain.Length > 0)
                    {
                        _chemain = _chemain.Remove(_chemain.Length - 1, 1);
                    }
                    
                }
                if (a == 'z')
                {
                    if (_chemain.Length > 0)
                    {
                        _chemain = _chemain.Remove(0, 1);
                    }
                }
                Console.Clear();
            } 
        }//*/
        static void Main(string[] args)
        {
            // Entrer1();
            Entrer2();
        }
    }
}
