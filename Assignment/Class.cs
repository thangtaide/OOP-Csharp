using System;
class Class
{
    string idClass;
    string description;
    string teacher;
    string time;
    string day;
    public string IDClass{
        get{return idClass;}
        set{idClass = value;}
    }
    public string Description{
        get{return description;}
        set{description = value;}
    }
    public string Teacher{
        get{return teacher;}
        set{teacher = value;}
    }
    public string Time{
        get{return time;}
        set{time = value;}
    }
    public string Day{
        get{return day;}
        set{day = value;}
    }
    public void display()
    {
        Console.WriteLine("| {0,-8}| {1,-24}| {2,-20}| {3,-16}| {4,-11}|"
        ,idClass,description,teacher,time,day);
    }
}