using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        int seconds = _duration;
        while (seconds > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
            seconds -= 10;
        }
        DisplayEndingMessage();
    }
}
