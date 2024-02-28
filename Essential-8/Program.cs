
namespace Essential8
{
    class Program
    {

        static void Main()
        {

            Array colors = Enum.GetValues(typeof(ConsoleColor));
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"{(int)colors.GetValue(i)} - {colors.GetValue(i)}");
            }
            Console.WriteLine("enter number from 0 to 15 to choose color");



            int color = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("write a sentence");

            string stroka = Console.ReadLine();

            bool colorExists = Enum.IsDefined(typeof(ConsoleColor), color);

            if (!colorExists)
            {
                Console.WriteLine("color doesn't exist");
            }
            else
            {
                Colors.Print(stroka, (ConsoleColor)color);
            }



        }
    }

    static class Colors
    {
        public static void Print(string stroka, ConsoleColor color)
        {
            if ((int)color == 0)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(stroka);
            }
            else 
            {
                Console.ForegroundColor = color;
                Console.WriteLine(stroka);
            }

        }
    }
}



