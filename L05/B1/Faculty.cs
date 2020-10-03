using System;
class Faculty: Employee
{
    double officeHour;
    string rank;
    public void getRank(string r)
    {
        rank = r;
    }
    public void getOffice(double r)
    {
        officeHour = r;
    }
    public double setOffice()
    {
        return officeHour;
    }
    public string setRank()
    {
        return rank;
    }
    public double CalculateBonus()
    {
        return getSalary()*0.05+1000;
    }
    public int CalculateVacation()
    {
        if()
    }
    public override string ToString()
    {
        return base.ToString()+"\nOffice hours: "+officeHour+"\nRank: "+rank;
    }
}