using System;
using System.Collections.Generic;
class Student
{
    public Student()
    {
    }
    public Student(string _id, string _name, string _address, DateTime _birthday, string _idClass)
    {
        this._id = _id;
        this._name = _name;
        this._address = _address;
        this._birthday = _birthday;
        this._idClass = _idClass;
    }
    private string _id;
    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private string _address;
    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }
    private DateTime _birthday;
    public DateTime Birthday
    {
        get { return _birthday; }
        set { _birthday = value; }
    }
    private string _idClass;
    public string IdClass
    {
        get { return _idClass; }
        set { _idClass = value; }
    }
    private List<Subjects> _scr;
    public List<Subjects> Scr
    {
        get { return _scr; }
        set { _scr = value; }
    }
    
    public void display()
    {
        Console.WriteLine("| {0,-9}| {1,-21}| {2,-19}| {3,-10}| {4,-6}|"
        , _id, _name, _address, _birthday.ToShortDateString(), _idClass);
    }
    public void displayScore(int index)
    {
        Console.WriteLine("| {0,-9}| {1,-21}| {2,-10}| {3,-5}| {4,-9}|"
        , _idClass, _name, _scr[index].Subject, _scr[index].Score, _scr[index].Status());
    }
}