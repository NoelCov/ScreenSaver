using System.Threading;

public class Timer
{
    public void TimerMethod(int value)
    {
       Thread.Sleep(value);   
    }
}