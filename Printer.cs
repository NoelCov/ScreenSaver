namespace ScreenSaver
{
    public class Printer : IPrintToScreen
    {
        Random r = new Random();   
        public int GenerateRandom() => r.Next(100);
        public void PrintNameToScreen(Image image, ConsoleColor bgColor, ConsoleColor foreGroundColor)
        {
            Console.SetCursorPosition(r.Next(Console.WindowWidth), r.Next(Console.WindowHeight));
            Console.BackgroundColor = bgColor;
            Console.ForegroundColor = foreGroundColor;
            Console.WriteLine(image._name.Trim());
        }
        public void PrintSecondNameToScreen(Image image, ConsoleColor bgColor, ConsoleColor foreGroundColor)
        {
            Console.SetCursorPosition(r.Next(Console.WindowWidth), r.Next(Console.WindowHeight));
            Console.BackgroundColor = bgColor;
            Console.ForegroundColor = foreGroundColor;
            Console.WriteLine(image._secondName.Trim());
        }
    }
}
