using System;
using Exceptions;
class Salary
{
    double salary;
    double bonus;
    public void press(double salary, double bonus)
    {
        if(salary < 60000)
        {
            throw (new LectureGetsLess("Lecture can't gets less 60000"));
        }
        else this.salary = salary;
        if(bonus > 10000)
        {
            throw (new BonusIsMore("Bonus can't more 10000"));
        }
        else this.bonus = bonus;
    }
    public override string ToString()
    {
        return "Your salary is "+salary+", your bonus is "+bonus;
    }
}