//FCL
using System;

namespace FirstProject
{
    
    
   
    public class Program 
    {
        static void Main(string[] args)
        {
            // IsNullOrEmpty --> to check whether string has empty or null

            //string str = null;// nulll means nothing, no space , no "" , not empty
            string str = ""; //empty --> no space, it is not null
            
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("string is empty");
            }

            Console.WriteLine(str);

            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("name is reqired");
            }
            else
            {
                Console.WriteLine("Hello "+name);
            }
        }
      

    }
}

