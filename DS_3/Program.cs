using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_3
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare 
            int a, b;
            string result;
            //Func<in,out>
            Func<int,int, string> SetGrade = (n,m) =>
                {
                    string str;
                    float avg=(n+m) / 2;
                    if ( avg>= 90)
                        str ="A";
                    else str= "B";
                    return str;
                };
            
                //n >= 90 ? 'A' : 'B';  
            //Func<int, int> Square = n => n * n;//lambda function or unannoymous function 
            //input
            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
                b = int.Parse(Console.ReadLine());
            //process
            //total=Square(a);//function calling 
            result = SetGrade(a,b);
            //output
            Console.WriteLine("Grade: "+result);
            //Console.WriteLine($"Total of a={a} and square of a= {total}");
            Console.ReadKey();
        }
    }
}
