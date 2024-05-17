using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private readonly List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        ShowCountDown(5);
        List<string> items = new List<string>();
        int seconds = _duration;
        while (seconds > 0)
        {
            Console.Write("Enter an item: ");
            items.Add(Console.ReadLine());
            seconds -= 5;
        }
        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndingMessage();
    }
}
