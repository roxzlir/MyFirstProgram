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
            }
            while (no2 <= no1);
            //The loop will run if no1 is higher than 0 (the value of no2) and add +1 until it reaches the number in no1


        }
    }
}