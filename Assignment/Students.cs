using System;
class Student
{
    string id;
    string name;
    string address;
    DateTime date;
    string idClass;
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
    public void updateStudent()
    {

    }
    public void addStudent()
    {

    }
    public void display()
    {
        Console.WriteLine("| {0,-9}| {1,-20}| {2,-16}| {3,-12}| {4,-6}|", id, name, address, date.ToShortDateString(), idClass);
    }
}