namespace MyFirstProgram //Emil Nordin .NET23
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int no1 = 12; //Skapar en variabel med siffran 3
            if (no1 >= 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else if (no1 < 10)
            {
                Console.WriteLine("Oj. Lågt tal!");
            }
            //Ovan är if och else satsen för vilken tex som ska skrivas beroende på vilket värde variabel får
            
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hej, {name}");

            int no2 = 0;
            do
            {
                Console.WriteLine(no2);
                no2++;
            } while (no2 <= no1);
            //Är no1 lika med 0 eller högre kommer loop köras tills det kommer upp till talet i no1.


        }
    }
}