using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLexicalAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lexical Anaylzer for finding keywords only
            string code =
                "class HelloWorld \n" +
                "method main () \n" +
                "print 'Hello'";
            string tempString = "";
            foreach (char c in code) {
                tempString = tempString + c;
                tempString = checkToken(tempString);
                if (c == ' ' || tempString=="\n") { tempString = ""; }
            }
        }

        private static string checkToken(string tempString)
        {
            switch (tempString)
            { 
                case "class":
                    Console.WriteLine("(class,Keyword)");
                    return "";
                    break;
                case "method":
Console.WriteLine("(method,Keyword)");
                    return "";
                    break;
                case "print":
                    Console.WriteLine("(print,Keyword)");
                    return "";
                    break;
                      
            }
            return tempString;
        }

    }
}
