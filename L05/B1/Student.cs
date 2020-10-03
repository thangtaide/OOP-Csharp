using System;
class Student: Person
{
    string enrolled;
    public Student()
    {

    }
    public Student(string n, string a, int p, string e, string enr)
    {
        setAddress(a);
		setPhone(p);
		setName(n);
		setEmail(e);
        enrolled = enr;
    }
    public void setEnrolled(string e)
    {
        enrolled = e;
    }
    public string getEnrolled()
    {
        return enrolled;
    }
    public override string ToString()
    {
        return base.ToString()+"Enrolled: "+enrolled;
    }
}