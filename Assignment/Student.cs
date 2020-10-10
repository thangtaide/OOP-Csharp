using System;
using System.Collections.Generic;
class Student
{
    string id;
    string name;
    string address;
    DateTime date;
    string idClass;
    public List<Scores> scr = new List<Scores>();
    public int count = 0;
    public string ID
    {
        get { return id; }
        set { id = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public string IDClass
    {
        get { return idClass; }
        set { idClass = value; }
    }
    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }
    public void display()
    {
        Console.WriteLine("| {0,-9}| {1,-21}| {2,-19}| {3,-10}| {4,-6}|"
        , id, name, address, date.ToShortDateString(), idClass);
    }
    public void displayScore(int index)
    {
        Console.WriteLine("| {0,-9}| {1,-21}| {2,-10}| {3,-5}| {4,-9}|"
        , idClass, name, scr[index].Subject, scr[index].Score, scr[index].Rate());
    }
}