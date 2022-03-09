using ScreenSaver;

Timer myTimer = new Timer();
Image myImage = new Image();
Printer myPrinter = new Printer();
bool myBool = true;

ConsoleColor[] colors = new ConsoleColor[] { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.DarkGreen, ConsoleColor.DarkCyan, ConsoleColor.DarkRed };

Random rc = new Random();


for (int i = 0; i < 500; i++)
{
    while (myBool)
    {
        myTimer.TimerMethod(3000);
        myBool = false;
    }
    myPrinter.PrintNameToScreen(myImage, colors[rc.Next(colors.Length)], colors[rc.Next(colors.Length)]);
    myTimer.TimerMethod(50);
    myPrinter.PrintSecondNameToScreen(myImage, colors[rc.Next(colors.Length)], colors[rc.Next(colors.Length)]);
}

