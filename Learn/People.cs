using System;
class People
{
    public string name;
    public int age;
    public string address;


    public People()
    {
        Console.WriteLine("Hi! I'm a human!");
    }
    public void SayHello()
    {
        Console.WriteLine("Hi! My name is {0}", name);
    }

    public string ShowInfo()
    {
        return "My name is " + name + "\nI'm " + age;
    }
}