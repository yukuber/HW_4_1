using System;
using HW_4_1.interfaces;

namespace HW_4_1.classes;
public abstract class Parent<T>  
{
    public static Random rnd = new Random();

    protected abstract void Create();
    
    public abstract void Print();
}