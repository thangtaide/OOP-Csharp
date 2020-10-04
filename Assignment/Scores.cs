using System;
class Scores
{
    Student std;
    string subject;
    int score;
    public string ID{
        get{return std.ID;}
        set{std.ID = value;}
    }
    public string Subject{
        get{return subject;}
        set{subject = value;}
    }
    public int Score{
        get{return score;}
        set{score = value;}
    }
    public string Rate()
    {
        if(score >= 10) return "Đỗ";
        else return "Tạch";
    }
    public void display()
    {
        Console.WriteLine("| {0,-8}| {1,-20}| {2,-14}| {3,-12}| {4,-6}|",std.ID,std.Name,subject,score,Rate());
    }
}