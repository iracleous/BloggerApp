﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Patterns;

public class Singleton
{

    private static Singleton? instance;
    private Singleton() { }


    public static Singleton GetInstance ()
    { 
        if (instance == null)
            instance = new Singleton();
        return instance; 
    }

    public void DoWork()
    {
        Console.WriteLine("hello from the singleton");
    }
}
