namespace MyFirstProgram //Emil Nordin .NET23
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int no1 = 12;  //Creating a int variabel with value 12
            if (no1 >= 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else if (no1 < 10)
            {
                Console.WriteLine("Oj. Lågt tal!");
            }
            //Above here is the if and else code, this tells which text line that will be written from the value of int variabel
            
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hej, {name}");
            //Creating a string with the input text and then print the value from that string in writeline.

            int no2 = 0;
            do
            {
                Console.WriteLine(no2);
                no2++;
            } while (no2 <= no1);
            //If no1 are 0 or higher the loop will run until it reaches the number set in no1 before it breaks out from loop.


        }
    }
}