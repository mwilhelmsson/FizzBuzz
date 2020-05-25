using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FIZZ = 3;
            const int BUZZ = 5;

            for(int i = 1; i <= 100; i++){
                var output = "";

                if(i % FIZZ == 0)
                    output += "Fizz";
                if(i % BUZZ == 0)
                    output += "Buzz";
                
                if(output == "")
                    output = i.ToString();
                
                Console.WriteLine(output);
            }
        }
    }
}
