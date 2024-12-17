using System;
using Microsoft.VisualBasic;

namespace app
{
  class Program
  {
    static void Main(string[] args)
    { 
        
        DateTime now = DateTime.Now; 
        
       
       // TimeOnly time = TimeOnly.FromDateTime(now);
        var beforebreak = now;
        TimeSpan awayfromscreen = new TimeSpan(0,20,0);
       

        Console.WriteLine("Now " + now); 
        Console.WriteLine("Before break " + beforebreak);

        DateTime breaktime = beforebreak.Add(awayfromscreen);
        Console.WriteLine("Your break time is at: " + breaktime);
        Thread.Sleep(20*(60000));
       
        
        String CurrentTime = DateTime.Now.ToString("HH:mm");
        String Break = breaktime.ToString("HH:mm");
        Console.WriteLine(CurrentTime);
        Console.WriteLine(Break);
        
        if(Strings.Equals(CurrentTime , Break)){
            Console.WriteLine("Time for break! The time is  " + breaktime);
        }
        
        }
    }
}

