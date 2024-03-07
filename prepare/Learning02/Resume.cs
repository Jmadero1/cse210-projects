using System;
using System.Collections.Generic;

public class Resume
{
    
    public string _personName;
    public List<Job> _jobs = new List<Job>(); 

  
    public void Display()
    {
        Console.WriteLine($"Nombre: {_personName}");
        foreach (Job job in _jobs)
        {
            job.Display(); 
        }
    }
}
