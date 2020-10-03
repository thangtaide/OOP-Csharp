using System;
class Staff: Employee
{
    string title;
    public string getTitle()
    {
        return title;
    }
    public void setTitle(string t)
    {
        title = t;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}