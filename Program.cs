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

            while (no1 >= 0)
            {
                Console.WriteLine(no1);
                no1--;
            }
            //If no1 value is higher than 0 it will loop and subtract 1 from the number until it reaches 0


        }
    }
}