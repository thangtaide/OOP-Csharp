using System;
using System.Collections.Generic;
class Class
{
    method m = new method();
    public Class()
    {
    }
    public Class(string _idClass, string _description, string _teacher, string _time, string _day)
    {
        this._idClass = _idClass;
        this._description = _description;
        this._teacher = _teacher;
        this._time = _time;
        this._day = _day;
    }
    private string _description;
    public string Description
    {
        get { return _description; }
        set { _description = m.ChuanHoa(value); }
    }
    private string _teacher;
    public string Teacher
    {
        get { return _teacher; }
        set { _teacher = value; }
    }
    private string _time;
    public string Time
    {
        get { return _time; }
        set { _time = value; }
    }
    private string _day;
    public string Day
    {
        get { return _day; }
        set { _day = value; }
    }
    private string _idClass;
    public string IdClass
    {
        get { return _idClass; }
        set { _idClass = value; }
    }
    public void display()
    {
        Console.WriteLine("| {0,-8}| {1,-24}| {2,-20}| {3,-16}| {4,-11}|"
        ,_idClass,_description,_teacher,_time,_day);
    }
}